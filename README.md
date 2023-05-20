# csharp-terraform-provider

This is an experimento of building a terraform provider with C#.

# Trying it

You must have terraform CLI installed!

Since I am in windows, I am publishing the code with this command
```
dotnet publish -r win-x64 -c release --self-contained -p:PublishSingleFile=true -o "$env:APPDATA\terraform.d\plugins\terraform.local\alberto\terraformprovider\1.0.0\windows_amd64"
```
More info about the terraform.d folder here https://developer.hashicorp.com/terraform/cli/config/config-file#provider-installation

Then with this tf file

```tf
resource "terraformprovider_file" "name" {
  path = "C:/temp/sample/ola.txt"
  content = "oi"
}
provider "terraformprovider" {
    file_header = "xpto"
}
terraform {
  required_providers {
    terraformprovider = {
      source = "terraform.local/alberto/terraformprovider"
      version = "1.0.0"
    }
  }
}
```

Run 
```
terraform init
terraform apply -auto-approve
```

Then you should see the results.
