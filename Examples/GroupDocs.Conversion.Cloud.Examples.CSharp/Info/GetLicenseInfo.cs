using System;
using GroupDocs.Conversion.Cloud.Sdk.Api;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp.Info
{
    /// <summary>
    /// This example demonstrates how to get metered license information
    /// </summary>
    public class GetLicenseInfo
    {
		public static void Run()
		{
            var apiInstance = new LicenseApi(Constants.GetConfig());

			try
			{
				var response = apiInstance.GetLicenseInfo();

                Console.WriteLine($"IsLicensed: {response.IsLicensed}");				
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling LicenseApi: " + e.Message);
			}
		}
	}
}
