#!/bin/bash

# Create the Resource Group first
az group create --name rg_prod_vm_lab --location westus3


# Test Deployment
az deployment group what-if --resource-group rg_prod_vm_lab --template-file VMs.bicep

# Deploy your Bicep file into that group
# az deployment group create --resource-group rg_prod_vm_lab --template-file VMs.bicep
