#!/bin/bash
# Description: Daily system health and security report for Fedora-based servers

# Configuration
EMAIL="your-email@example.com"
HOSTNAME=$(hostname)

# System Metrics Collection
UPTIME=$(uptime -p)
DISK=$(df -h / | awk 'NR==2 {print $5 " used (" $3 "/" $2 ")"}')
MEMORY=$(free -h | awk '/Mem:/ {print $3 " used of " $2}')
CPU=$(top -bn1 | grep "Cpu(s)" | awk '{print 100 - $8"% idle"}')

# Podman Container Status
CONTAINERS=("app-container-1" "app-container-2")
CONTAINER_REPORT=""

for CT in "${CONTAINERS[@]}"; do
    STATUS=$(sudo podman inspect -f '{{.State.Status}}' "$CT" 2>/dev/null)
    
    if [ "$STATUS" == "running" ]; then
        CONTAINER_REPORT+="$CT: ✅ RUNNING\n"
    elif [ -z "$STATUS" ]; then
        CONTAINER_REPORT+="$CT: ❌ NOT FOUND\n"
    else
        CONTAINER_REPORT+="$CT: ⚠️  STOPPED ($STATUS)\n"
    fi
done

# Security & Update Status
SEC_UPDATES=$(dnf updateinfo list security --available 2>/dev/null | grep -i "security" | wc -l)
REG_UPDATES=$(dnf check-update --quiet 2>/dev/null | grep -v "^$" | wc -l)

# Build Final Report
read -r -d '' REPORT <<EOF
----------------------------------------------
FEDORA SYSTEM STATUS: $HOSTNAME
Date: $(date)
----------------------------------------------

Uptime:       $UPTIME
CPU Load:     $CPU
Disk Usage:   $DISK
Memory Usage: $MEMORY

[Container Status (Podman)]
$(echo -e "$CONTAINER_REPORT")

[System Vulnerabilities]
Critical Security Patches: $SEC_UPDATES
Other Software Updates:    $REG_UPDATES
----------------------------------------------
EOF

echo "$REPORT" | mail -s "Daily Status Report: $HOSTNAME" "$EMAIL"