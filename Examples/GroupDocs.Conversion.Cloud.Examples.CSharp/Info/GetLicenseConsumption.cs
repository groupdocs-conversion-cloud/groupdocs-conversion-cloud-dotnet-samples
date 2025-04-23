using System;
using GroupDocs.Conversion.Cloud.Sdk.Api;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp.Info
{
    /// <summary>
    /// This example demonstrates how to get metered license consumption information
    /// </summary>
    public class GetLicenseConsumption
	{
		public static void Run()
		{
            var apiInstance = new LicenseApi(Constants.GetConfig());

			try
			{
				var response = apiInstance.GetConsumptionCredit();

                Console.WriteLine($"Credits (for self-hosted version): {response.Credit}");
				Console.WriteLine($"Quantity (for self-hosted version): {response.Quantity}");
                Console.WriteLine($"BilledApiCalls (for cloud version): {response.BilledApiCalls}");
            }
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling LicenseApi: " + e.Message);
			}
		}
	}
}