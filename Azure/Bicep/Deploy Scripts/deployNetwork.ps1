# Variables
$subscriptionId = "e9567da1-99bc-41c0-8e86-f168bd848ac8"
$resourceGroup = "New_Test_Group"
$templateFile = "../main.bicep"
$parameterFile = "../Environments/Dev/dev.bicepparam"

Write-Host "Template:"
Write-Host $templateFile

Write-Host "Parameters:"
Write-Host $parameterFile

Test-Path $templateFile
Test-Path $parameterFile

# Login
az login

# Select subscription
az account set --subscription $subscriptionId

# Validate
Write-Host "Validating deployment..."

az deployment group validate `
    --resource-group $resourceGroup `
    --template-file $templateFile `
    --parameters $parameterFile

# What-if
Write-Host "Checking changes..."

az deployment group what-if `
    --resource-group $resourceGroup `
    --template-file $templateFile `
    --parameters $parameterFile

# Deploy
Write-Host "Deploying..."

az deployment group create `
    --resource-group $resourceGroup `
    --template-file $templateFile `
    --parameters $parameterFile