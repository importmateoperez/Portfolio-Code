# Variable declarations
$resourceGroupName = 'New_Test_Group'
$subscriptionId = "e9567da1-99bc-41c0-8e86-f168bd848ac8"

#Login to Azure
az account set --subscription $subscriptionId

# Confirm resource group exists
az group show --name $resourceGroupName

# Confirm deletion
$confirmation = Read-Host "Type DELETE to remove $resourceGroupName"

if ($confirmation -eq "DELETE") {

    Write-Host "Deleting resource group $resourceGroupName..."

    az group delete `
        --name $resourceGroupName `
        --yes

    Write-Host "Deletion started."

}
else {
    Write-Host "Deletion cancelled."
}