using DynamicsXrmClient;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DynamicsXrmClientSample
{
    class Program
    {
        async static Task Main(string[] args)
        {
            var client = await DynamicsXrmWebApiClient.ConnectAsync(
                new DynamicsXrmConnectionParams
                {
                    ServiceRootUri = "<service-root-uri>",
                    TenantId = "<tenant-id>",
                    ClientId = "<client-id>",
                    ClientSecret = "<client-secret>"
                });

            string whereEffortGreater8Hours = "?$filter=new_estimatedeffort_number gt 8";

            List<SalesOrder> orders = await client.RetrieveMultipleAsync<SalesOrder>(whereEffortGreater8Hours);
        }
    }
}
