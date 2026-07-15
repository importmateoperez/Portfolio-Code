@description('The name of your Virtual Machine.')
param vmName string

@description('Username for the Virtual Machine.')
param adminUsername string

@description('SSH Key or password for the Virtual Machine. SSH key is recommended.')
@secure()
param adminPasswordOrKey string

@description('Unique DNS Name for the Public IP used to access the Virtual Machine.')
param dnsLabelPrefix string = toLower('${vmName}-${uniqueString(resourceGroup().id)}')

@description('Location for all resources.')
param location string

@description('The size of the VM')
param vmSize string

@description('Name of the subnetID')
param subnetID string

output adminUsername string = adminUsername
