#!/bin/bash
# Description: Automated backup for a Nextcloud cluster using Podman and MariaDB/MySQL

# Configuration
BACKUP_DIR="/path/to/your/backups"
DATE=$(date +"%Y-%m-%d")
LOGFILE="/var/log/backup_nextcloud.log"
EMAIL="your-email@example.com"

# Podman Secret name used for DB root password
DB_SECRET_NAME="your_db_secret_name" 

# List of database containers to back up
DB_CONTAINERS=("db-container-1" "db-container-2")

# Preparation
mkdir -p "$BACKUP_DIR"
echo "--- Backup Started: $DATE ---" >> "$LOGFILE"

# Database Dump Loop
DB_ERROR=0
for CT in "${DB_CONTAINERS[@]}"; do
    echo "Exporting database for $CT..." >> "$LOGFILE"
    
    # Securely executes mysqldump inside the container using a Podman secret
    sudo podman exec $CT sh -c "mysqldump -u root -p\$(cat /run/secrets/$DB_SECRET_NAME) --all-databases" > "$BACKUP_DIR/${CT}_db_$DATE.sql"
    
    if [ ${PIPESTATUS[0]} -eq 0 ]; then
        echo "✅ $CT: SQL Export Successful" >> "$LOGFILE"
    else
        echo "❌ $CT: SQL Export FAILED" >> "$LOGFILE"
        DB_ERROR=1
    fi
done

# Physical File Compression
# Backs up local container volumes and the fresh SQL dumps
tar -cpzf "$BACKUP_DIR/nextcloud_full_cluster_$DATE.tar.gz" /path/to/container/storage/volumes/ "$BACKUP_DIR"/*.sql > /dev/null 2>&1

# Success Verification
if [ $? -eq 0 ] && [ $DB_ERROR -eq 0 ]; then
    RESULT_MSG="✅ SUCCESS"
    CURRENT_SIZE=$(du -sh "$BACKUP_DIR/nextcloud_full_cluster_$DATE.tar.gz" | awk '{print $1}')
else
    RESULT_MSG="❌ FAILED"
    CURRENT_SIZE="0MB"
fi

# Cleanup & Storage Reporting
rm -f "$BACKUP_DIR"/*.sql
find "$BACKUP_DIR" -type f -name "*.tar.gz" -mtime +7 -delete
TOTAL_STORAGE=$(du -sh "$BACKUP_DIR" | awk '{print $1}')
DISK_FREE=$(df -h "$BACKUP_DIR" | awk 'NR==2 {print $4}')

# Build & Send Formatted Report
read -r -d '' FINAL_REPORT <<EOF
NEXTCLOUD CLUSTER BACKUP REPORT
----------------------------------------------
Overall Status:      $RESULT_MSG
Backup Date:         $DATE
Archive Size:        $CURRENT_SIZE
----------------------------------------------
STORAGE SUMMARY
Total Backups Size:  $TOTAL_STORAGE
Disk Space Left:     $DISK_FREE
----------------------------------------------
EOF

echo -e "$FINAL_REPORT" >> "$LOGFILE"
echo -e "$FINAL_REPORT" | mail -s "Nextcloud Backup Status: $RESULT_MSG ($DATE)" "$EMAIL"