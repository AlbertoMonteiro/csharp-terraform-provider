using Microsoft.Extensions.DependencyInjection;
using TerraformPluginDotNet;
using TerraformPluginDotNet.ResourceProvider;
using TerraformProvider;

await TerraformPluginHost.RunAsync(args, "terraform.local/alberto/terraformprovider", (services, registry) =>
{
    services.AddSingleton<SampleConfigurator>();
    services.AddTerraformProviderConfigurator<Configuration, SampleConfigurator>();
    services.AddSingleton<IResourceProvider<SampleFileResource>, SampleFileResourceProvider>();
    registry.RegisterResource<SampleFileResource>("terraformprovider_file");
});