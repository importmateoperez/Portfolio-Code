#!/bin/bash

# Get Hostname
HOSTNAME=$(hostname)

# Info Collection
UPTIME=$(uptime -p)
DISK=$(df -h / | tail -1 | awk '{print $5 " used (" $3 "/" $2 ")"}')
MEMORY=$(free -h | awk '/Mem:/ {print $3 " used of " $2}')
CPU=$(top -bn1 | grep "Cpu(s)" | awk '{print 100 - $8"% idle"}')

# Docker Status Section
CONTAINERS=("apache-prod" "apache-dev")
DOCKER_REPORT=""

for CT in "${CONTAINERS[@]}"; do
    STATUS=$(docker inspect -f '{{.State.Status}}' "$CT" 2>/dev/null)
    if [ "$STATUS" == "running" ]; then
        DOCKER_REPORT+="$CT: ✅ RUNNING\n"
    elif [ -z "$STATUS" ]; then
        DOCKER_REPORT+="$CT: ❌ NOT FOUND\n"
    else
        DOCKER_REPORT+="$CT: ⚠️  OFFLINE ($STATUS)\n"
    fi
done

# Security Updates Section

SEC_UPDATES=$(apt-get -s upgrade | grep -iE "Inst.*security" | wc -l)

# Build Report
REPORT="
----------------------------------------------
SECURITY & STATUS REPORT: $HOSTNAME
Date: $(date)
----------------------------------------------

Uptime: $UPTIME
CPU Load: $CPU
Disk Usage: $DISK
Memory Usage: $MEMORY

[Web Server Containers (Apache2)]
$(echo -e "$DOCKER_REPORT")

[Vulnerability Management]
Pending Security Patches: $SEC_UPDATES
Note: This only counts patches from Debian Security mirrors.
"

# Send Email
echo "$REPORT" | mail -s "SECURITY REPORT - $HOSTNAME" example@gmail.com
echo "$REPORT" | mail -s "Daily Report - $HOSTNAME" example@gmail.com