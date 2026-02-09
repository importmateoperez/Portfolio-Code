#!/bin/bash

# Fix Windows line endings in this script automatically
sed -i 's/\r$//' "$0"

# Ensure the latest Terraform in ~/bin is used first
export PATH="$HOME/bin:$PATH"

# Remove old state metadata to prevent "ghost" errors
echo "Cleaning up old metadata..."
rm -rf .terraform/providers

# Terraform Workflow
echo "Starting Terraform Build..."

terraform init
terraform fmt
terraform validate

# Create the Plan 
echo "Generating Deployment Plan..."
terraform plan -out=main.tfplan

# To actually deploy, uncomment the line below
# terraform apply main.tfplan -auto-approve