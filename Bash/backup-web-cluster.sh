#!/bin/bash

# 1. Configuration
SOURCE_DIRS="/opt/web-cluster /var/www/html /etc/letsencrypt"
BACKUP_DIR="/backups"
DATE=$(date +"%Y-%m-%d")
BACKUP_FILE="$BACKUP_DIR/web-cluster_$DATE.tar.gz"
LOGFILE="/var/log/backup.log"
EMAIL="mateoperez1080p@gmail.com"

# 2. Preparation
mkdir -p "$BACKUP_DIR"

# 3. Create Backup
# -p preserves permissions, -z is compression
tar -cpzf "$BACKUP_FILE" $SOURCE_DIRS > /dev/null 2>&1

# 4. Check Result & Notify
if [ $? -eq 0 ]; then
    SIZE=$(du -sh "$BACKUP_FILE" | awk '{print $1}')
    MESSAGE="✅ SUCCESS: Backup created at $BACKUP_FILE (Size: $SIZE)"
    # Cleanup: Keep only last 7 days of backups
    find "$BACKUP_DIR" -type f -name "*.tar.gz" -mtime +7 -delete
else
    MESSAGE="❌ FAILED: The backup for $DATE did not complete successfully!"
fi

# 5. Log and Email
echo "[$DATE] $MESSAGE" >> "$LOGFILE"
echo "$MESSAGE" | mail -s "Web-Cluster Backup Status ($DATE)" "$EMAIL"
