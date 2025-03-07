# Azure.Communication.CallAutomation

From Folder that contains autorest.md, Run `dotnet msbuild /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

```yaml
model-namespace: false
tag: package-2024-11-15-preview

require:
    - https://github.com/DominikMe/azure-rest-api-specs/blob/f59f8a213d7138c3a5d30aedd41fe29fd5d52dbb/specification/communication/data-plane/CallAutomation/readme.md


title: Azure Communication Services

generation1-convenience-client: true
```
