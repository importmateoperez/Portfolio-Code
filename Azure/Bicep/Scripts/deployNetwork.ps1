# Variables
$subscriptionId = "e9567da1-99bc-41c0-8e86-f168bd848ac8"
$resourceGroup = "New_Test_Group"
$location = "westus2" 
$templateFile = "/main.bicep"
$parameterFile = "/Environments/Dev/dev.bicepparam"

# Login
az login

# Select subscription
az account set --subscription $subscriptionId

# Check if Resource Group exists
Write-Host "Checking if resource group '$resourceGroup' exists..."
$rgExists = az group exists --name $resourceGroup

if ($rgExists -eq 'false') {
    Write-Host "Resource group '$resourceGroup' not found. Creating it in '$location'..."
    az group create --name $resourceGroup --location $location
} else {
    Write-Host "Resource group '$resourceGroup' already exists."
}

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