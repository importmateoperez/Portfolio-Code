# Login only if needed
az login

# Select subscription
az account set --subscription "e9567da1-99bc-41c0-8e86-f168bd848ac8"

# Validation
az deployment group validate \
    --resource-group "New_Test_Group" \
    --template-file "../main.bicep" \
    --parameters "../environments/dev/dev.bicepparam"

# Preview
az deployment group what-if \
    --resource-group "New_Test_Group" \
    --template-file "../main.bicep" \
    --parameters "../environments/dev/dev.bicepparam"

# Deploy
az deployment group create \
    --resource-group New_Test_Group \
    --template-file ../main.bicep \
    --parameters ../environments/dev/dev.bicepparam