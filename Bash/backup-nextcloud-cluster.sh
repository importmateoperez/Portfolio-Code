#!/bin/bash

# Configuration
BACKUP_DIR="/backups"
DATE=$(date +"%Y-%m-%d")
LOGFILE="/var/log/backup.log"
EMAIL="example@gmail.com"
DB_CONTAINERS=("nextcloud-db-prod" "nextcloud-db-dev")

# Preparation
mkdir -p "$BACKUP_DIR"
echo "--- Backup Started: $DATE ---" >> "$LOGFILE"

# Database Dump Loop
for CT in "${DB_CONTAINERS[@]}"; do
    echo "Exporting database for $CT..." >> "$LOGFILE"
    sudo podman exec $CT sh -c "mysqldump -u nextcloud -p\$(cat /nice/path/file) --all-databases" > "$BACKUP_DIR/${CT}_db_$DATE.sql"
    
    if [ ${PIPESTATUS[0]} -eq 0 ]; then
        echo "✅ $CT: SQL Export Successful" >> "$LOGFILE"
    else
        echo "❌ $CT: SQL Export FAILED" >> "$LOGFILE"
    fi
done

# Physical File Backup (Volumes)
echo "Compressing files and databases..." >> "$LOGFILE"
tar -cpzf "$BACKUP_DIR/nextcloud_full_cluster_$DATE.tar.gz" /var/lib/containers/storage/volumes/ "$BACKUP_DIR"/*.sql > /dev/null 2>&1

if [ $? -eq 0 ]; then
    CURRENT_SIZE=$(du -sh "$BACKUP_DIR/nextcloud_full_cluster_$DATE.tar.gz" | awk '{print $1}')
    RESULT_MSG="✅ Backup Success: $CURRENT_SIZE"
else
    RESULT_MSG="❌ Backup FAILED during compression"
fi

# Cleanup & Disk Usage Summary
rm -f "$BACKUP_DIR"/*.sql
find "$BACKUP_DIR" -type f -name "*.tar.gz" -mtime +7 -delete

# Get total storage used by all backups combined
TOTAL_BACKUP_STORAGE=$(du -sh "$BACKUP_DIR" | awk '{print $1}')
DISK_FREE=$(df -h "$BACKUP_DIR" | awk 'NR==2 {print $4}')

# 6. Final Report and Email
FINAL_REPORT="Status: $RESULT_MSG
Total Backup Storage Used: $TOTAL_BACKUP_STORAGE
Storage Remaining on Drive: $DISK_FREE"

# Log it
echo -e "[$DATE]\n$FINAL_REPORT" >> "$LOGFILE"

# Send it
echo -e "$FINAL_REPORT" | mail -s "Nextcloud Backup Summary - $DATE" "$EMAIL"