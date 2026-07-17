# Variable declarations
$resourceGroupName = 'New_Test_Group'
$subscriptionId = "e9567da1-99bc-41c0-8e86-f168bd848ac8"

#Login to Azure
az account set --subscription $subscriptionId

$rgParams = @{
    Name = $resourceGroupName
    Force = $true
}

# Delete Entire Resource Group
Remove-AzResourceGroup @rgParams