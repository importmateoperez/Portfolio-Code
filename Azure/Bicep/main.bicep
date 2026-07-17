@description('Deployment location')
param location string = resourceGroup().location

@description('Virtual network name')
param vnetName string

@description('Address space')
param addressPrefix string

@description('Virtual network name')
param subnetName string

@description('Address space')
param subnetPrefix string

module network './Modules/Networks/networks.bicep' = {
  name: 'networkDeployment'

  params: {
    location: location
    vnetName: vnetName
    addressPrefix: addressPrefix
    subnetName: subnetName
    subnetPrefix: subnetPrefix
  }

}

output vnetId string = network.outputs.vnetId
