#!/bin/bash

# Initialize Terraform
terraform init

# Format and Validate
terraform fmt      
terraform validate

# Create a Plan
terraform plan -out=main.tfplan

# Apply the file
#terraform apply main.tfplan