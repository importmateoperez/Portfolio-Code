# Create the Resource Group first
$RG = "rg_prod_vm_lab"

# Deploy your Bicep file into that group
New-AzResourceGroup -Name $RG -Location northcentralus
Get-AzResourceGroupDeploymentWhatIfResult -ResourceGroupName $RG -TemplateFile ./VMs.bicep
# New-AzResourceGroupDeployment -ResourceGroupName exampleRG -TemplateFile ./VMs.bicep