#!/bin/bash

# Get Hostname
HOSTNAME=$(hostname)

# Info Collection
UPTIME=$(uptime -p)
DISK=$(df -h / | tail -1 | awk '{print $5 " used (" $3 "/" $2 ")"}')
MEMORY=$(free -h | awk '/Mem:/ {print $3 " used of " $2}')
CPU=$(top -bn1 | grep "Cpu(s)" | awk '{print 100 - $8"% idle"}')

# Podman Container Status Section
CONTAINERS=("nextcloud-app-prod" "nextcloud-app-dev")
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

# Fedora Security Updates Section
SEC_UPDATES=$(dnf updateinfo list security --installed 2>/dev/null | grep -i "security" | wc -l)

# Total updates (excluding security) for context
REG_UPDATES=$(dnf check-update --quiet | grep -v "^$" | wc -l)

# Build Report
REPORT="
----------------------------------------------
DAILY STATUS REPORT: $HOSTNAME
Date: $(date)
----------------------------------------------

Uptime: $UPTIME
CPU Load: $CPU
Disk Usage: $DISK
Memory Usage: $MEMORY

[Container Status (Podman)]
$(echo -e "$CONTAINER_REPORT")

[System Vulnerabilities]
Critical Security Patches: $SEC_UPDATES
Other Software Updates: $REG_UPDATES

Note: Use 'sudo dnf upgrade --security' to apply only critical patches.
"

# Send Email
echo "$REPORT" | mail -s "Daily Report - $HOSTNAME" example@gmail.com