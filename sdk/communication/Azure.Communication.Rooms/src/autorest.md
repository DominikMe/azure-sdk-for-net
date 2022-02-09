# Azure SDK Code Generation for Data Plane

Run `dotnet msbuild /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
input-file:
- https://raw.githubusercontent.com/wangrui-msft/azure-rest-api-specs/7ae90e461058f311d1454398789ce1230220f695/specification/communication/data-plane/Rooms/preview/2021-04-07-preview1/communicationservicesrooms.json
model-namespace: false
payload-flattening-threshold: 10
```
