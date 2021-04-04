# Grpc Pricing Service

Enable proto extension for vscode
vscode-proto3

1-Add Grpc package
(grpc.AspNetCore/2.32.0)

dotnet add package Grpc.AspNetCore --version 2.32.0

2-Protos
 Create proto (Request, Response, Rpc Service)

3-Build Project
  dotnet build

3-Services
  Create Service and Impl from proto base

4-appsettings enable http 2
  "Kestrel": {
    "EndpointDefaults": {
      "Protocols": "Http2"
    }

5- Add grpc service on UseEndpoints
endpoints.MapGrpcService<PricingService>();

#Grpc.Client
Add proto file
dotnet add package Grpc.Net.Client --version 2.36.0
dotnet add package Google.Protobuf --version 3.15.7
dotnet add package Grpc.Tools --version 2.37.0-pre1