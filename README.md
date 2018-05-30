# PInvokeNetCore
Simple examle of using PInovoke in .Net Core
## Building C++ part
Go to cpp folder and execute make
## Building C# part
Download .NET Core SDK

[Linux](https://www.microsoft.com/net/download/linux-package-manager/ubuntu18-04/sdk-current)

[macOS](https://www.microsoft.com/net/download/macos)

And then run (ubuntu example)

`dotnet build --runtime ubuntu.16.04-x64 -c Release`
## Running binary
Go to Release folder and copy C++ library object there and then run the binary
