using GroupDocs.Conversion.Cloud.Sdk;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupDocs.Conversion.Cloud.Examples.Conversions
{
    // Get All Possible Conversions Formats
    class Get_All_Possible_Conversions
    {
        public static void Run()
        {
            var configuration = new Configuration
       {
           AppSid = Common.MyAppSid,
           AppKey = Common.MyAppKey
       };

            var apiInstance = new ConversionApi(configuration);

            try
            {
                var request = new GetAllPossibleConversionsRequest();

                // Get supported file formats
                var response = apiInstance.GetAllPossibleConversions(request);

                foreach (var entry in response.Conversions)
                {
                    Console.WriteLine(string.Format("{0}: {1}", entry.SourceFileType, string.Join(",", entry.PossibleConversions)));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling ConversionApi.GetAllPossibleConversions: " + e.Message);
            }
        }
    }
}