using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureStorageEmulator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Test().Wait();
        }

        private static async Task Test()
        {
            CloudStorageAccount storageAccount = new CloudStorageAccount(
                new Microsoft.WindowsAzure.Storage.Auth.StorageCredentials("devstoreaccount1", "Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw=="),
                new Uri("http://127.0.0.1:10000"),
                new Uri("http://127.0.0.1:10001"),
                new Uri("http://127.0.0.1:10002"),
                new Uri("http://127.0.0.1:10003")
                );

            CloudTableClient tableClient = storageAccount.CreateCloudTableClient();
            // Retrieve a reference to the table.
            CloudTable table = tableClient.GetTableReference("people");
            try
            {
                //await table.CreateIfNotExistsAsync();
                await table.CreateIfNotExistsAsync();
            }
            catch (Exception e)
            {
                if (e.Message != "")
                {
                    int i = 0;
                }
            }
        }
    }
}
