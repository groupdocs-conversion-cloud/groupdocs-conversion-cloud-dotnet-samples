using System;
using System.Linq;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp.Info
{
    /// <summary>
    /// This example demonstrates how to obtain all supported document conversions
    /// </summary>
    public class GetSupportedConversions
    {
		public static void Run()
		{
            var apiInstance = new InfoApi(Constants.GetConfig());

			try
			{
				// Get supported conversion types
				var response = apiInstance.GetSupportedConversionTypes(new GetSupportedConversionTypesRequest());

				foreach (var entry in response.Take(2))
				{
					Console.WriteLine($"{entry.SourceFormat}: {string.Join(",", entry.TargetFormats)}");
				}
                Console.WriteLine($"...");
            }
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling InfoApi: " + e.Message);
			}
		}
	}
}