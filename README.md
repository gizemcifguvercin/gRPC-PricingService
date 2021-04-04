# gRPC Pricing Service

Enable proto extension for vscode
vscode-proto3

1-Add Grpc package
(grpc.AspNetCore/2.32.0)

dotnet add package Grpc.AspNetCore --version 2.32.0

2-Protos
 Create proto (Request, Response, Rpc Service)

3-Build Project
  dotnet build

4-Services
  Create Service and Impl from proto base

5-appsettings enable http 2
  "Kestrel": {
    "EndpointDefaults": {
      "Protocols": "Http2"
    }

6- Add gRPC service on UseEndpoints
endpoints.MapGrpcService<PricingService>();

# gRP Client

Add proto file

dotnet add package Grpc.Net.Client --version 2.36.0

dotnet add package Google.Protobuf --version 3.15.7

dotnet add package Grpc.Tools --version 2.37.0-pre1

# Project Structure

<img src="https://i.ibb.co/48f02PX/Screen-Shot-2021-04-04-at-17-14-16.png"/>

# BloomRPC For Calling Service

<img src="https://i.ibb.co/bW48Ggz/Screen-Shot-2021-04-04-at-16-23-26.png"/>

# Client App For Calling Service

<img src="https://i.ibb.co/0nHJgC6/Screen-Shot-2021-04-04-at-17-08-37.png"/>
