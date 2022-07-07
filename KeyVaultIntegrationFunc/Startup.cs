using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Azure.Security.KeyVault.Certificates;
using Microsoft.Extensions.Azure;
using System;

[assembly: FunctionsStartup(typeof(KeyVaultIntegrationFunc.Startup))]
namespace KeyVaultIntegrationFunc
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddAzureClients(builder =>
            {
                builder.AddCertificateClient(new Uri("https://keyvaultintegrations-kv.vault.azure.net/"));
            });
        }
    }
}
