@description('Name of the Vnet')
param vnetName string

@description('Vnet address space')
param addressPrefix string

@description('Vnet location')
param location string

@description('Name of the subnet')
param subnetName string   

@description('Subnet address space')
param subnetPrefix string

resource virtualNetwork 'Microsoft.Network/virtualNetworks@2025-07-01' = {
  name: vnetName
  location: location

  properties: {
    addressSpace: {
      addressPrefixes: [ addressPrefix
      ]
    
    }
  
  subnets: [
    {
      name: subnetName

      properties: {
        addressPrefix: subnetPrefix
      }
    }
  ]

  }

}

output vnetId string = virtualNetwork.id
