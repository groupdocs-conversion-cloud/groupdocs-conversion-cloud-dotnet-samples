using System;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Client;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp
{
    // Get All Supported Formats
    class Get_All_Supported_Formats
    {
        public static void Run()
        {
            var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);

            var apiInstance = new ConversionApi(configuration);

            try
            {
                // Get supported file formats
                var response = apiInstance.GetSupportedConversionTypes(new GetSupportedConversionTypesRequest());

                foreach (var entry in response)
                {
                    foreach (var formats in entry.TargetFormats)
                    {
                        Console.WriteLine(string.Format("{0} TO {1}", entry.SourceFormat, string.Join(",", formats)));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while calling ConversionApi: " + e.Message);
            }
        }
    }
}