#!/bin/bash
# Description: Full file-level backup for a web cluster (Configs, SSL, and Web Root)

# Configuration
# Directories to include in the backup
SOURCE_DIRS="/path/to/web/html /path/to/configs /etc/letsencrypt"
BACKUP_DIR="/path/to/your/backups"
DATE=$(date +"%Y-%m-%d")
BACKUP_FILE="$BACKUP_DIR/web-cluster_$DATE.tar.gz"
LOGFILE="/var/log/backup_web.log"
EMAIL="your-email@example.com"

# Preparation
mkdir -p "$BACKUP_DIR"
echo "--- Web Backup Started: $DATE ---" >> "$LOGFILE"

# Create Compressed Archive
ERROR_LOG=$(mktemp)
tar -cpzf "$BACKUP_FILE" $SOURCE_DIRS > /dev/null 2> "$ERROR_LOG"

# Check Result & Log Messages
if [ $? -eq 0 ]; then
    STATUS="✅ SUCCESS"
    SIZE=$(du -sh "$BACKUP_FILE" | awk '{print $1}')
    MESSAGE="Full backup of web files, configs, and SSL certs completed."
    
    # Retention Policy: Remove backups older than 7 days
    find "$BACKUP_DIR" -type f -name "*.tar.gz" -mtime +7 -delete
else
    STATUS="❌ FAILED"
    SIZE="0MB"
    MESSAGE="Tar encountered an error. Details: $(cat $ERROR_LOG)"
fi

rm -f "$ERROR_LOG"

# Storage Stats
TOTAL_STORAGE=$(du -sh "$BACKUP_DIR" | awk '{print $1}')
DISK_FREE=$(df -h "$BACKUP_DIR" | awk 'NR==2 {print $4}')

# Build & Send Report
read -r -d '' REPORT <<EOF
WEB CLUSTER BACKUP REPORT
----------------------------------------------
Status:          $STATUS
Date:            $DATE
Archive Size:    $SIZE
----------------------------------------------
STORAGE SUMMARY:
Total Backups:   $TOTAL_STORAGE
Disk Space Left: $DISK_FREE
----------------------------------------------
DETAILS:
$MESSAGE
----------------------------------------------
EOF

echo "[$DATE] $STATUS - $SIZE" >> "$LOGFILE"
echo "$REPORT" | mail -s "Web Backup Status: $STATUS ($DATE)" "$EMAIL"