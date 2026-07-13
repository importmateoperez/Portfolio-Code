#!/bin/bash
# Description: Daily system health and security report for Debian-based servers

# Configuration
EMAIL="your-email@example.com"
HOSTNAME=$(hostname)

# Refresh package lists for accurate update reporting
sudo apt-get update -qq

# System Metrics Collection
UPTIME=$(uptime -p)
DISK=$(df -h / | awk 'NR==2 {print $5 " used (" $3 "/" $2 ")"}')
MEMORY=$(free -h | awk '/Mem:/ {print $3 " used of " $2}')
CPU=$(top -bn1 | grep "Cpu(s)" | awk '{print 100 - $8"% idle"}')

# Docker Container Status
if systemctl is-active --quiet docker; then
    CONTAINERS=("container-1" "container-2")
    DOCKER_REPORT=""
    for CT in "${CONTAINERS[@]}"; do
        STATUS=$(docker inspect -f '{{.State.Status}}' "$CT" 2>/dev/null)
        if [ "$STATUS" == "running" ]; then
            DOCKER_REPORT+="$CT: ✅ RUNNING\n"
        elif [ -z "$STATUS" ]; then
            DOCKER_REPORT+="$CT: ❌ NOT FOUND\n"
        else
            DOCKER_REPORT+="$CT: ⚠️  STOPPED ($STATUS)\n"
        fi
    done
else
    DOCKER_REPORT="❌ ERROR: Docker Service is not running!"
fi

# Security & Update Status
SEC_UPDATES=$(apt-get -s upgrade | grep -iE "security|vulnerability" | grep -c "Inst")
REG_UPDATES=$(apt-get -s upgrade | grep -c "Inst")

# Debian-Specific Reboot Check
if [ -f /var/run/reboot-required ]; then
    REBOOT_STATUS="⚠️  REBOOT REQUIRED (Kernel/Library updates pending)"
else
    REBOOT_STATUS="✅ System up to date"
fi

# Build Final Report
read -r -d '' REPORT <<EOF
----------------------------------------------
DEBIAN SYSTEM STATUS: $HOSTNAME
Date: $(date)
----------------------------------------------

Uptime:       $UPTIME
CPU Load:     $CPU
Disk Usage:   $DISK
Memory Usage: $MEMORY

[Server Health]
Status:       $REBOOT_STATUS

[Container Status (Docker)]
$(echo -e "$DOCKER_REPORT")

[Update Management]
Pending Security Patches: $SEC_UPDATES
Total Updates Available:  $REG_UPDATES
----------------------------------------------
EOF

echo "$REPORT" | mail -s "Daily Status Report: $HOSTNAME" "$EMAIL"