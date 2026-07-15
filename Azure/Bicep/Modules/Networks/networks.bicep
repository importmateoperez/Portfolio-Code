@description('Name of the Vnet')
param vnetName string

@description('Vnet address space')
param addressPrefix string

@description('Vnet location')
param location string

resource virtualNetwork 'Microsoft.Network/virtualNetworks@2025-07-01' = {
  name: vnetName
  location: location

  properties: {
    addressSpace: {
      addressPrefixes: [

      ]
    
    }
  
  }

}

output vnetId string = virtualNetwork.id
