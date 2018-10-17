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
    // Get All Possible Conversions Formats For Provided Extension
    class Get_All_Possible_Conversions_For_Extension
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
                var request = new GetPossibleConversionsForFileTypeRequest
                {
                    Extension = "docx"
                };

                // Get supported file formats for specified file extension
                var response = apiInstance.GetPossibleConversionsForFileType(request);


                Console.WriteLine(string.Format("{0}: {1}", response.SourceFileType, string.Join(",", response.PossibleConversions)));
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling ConversionApi.GetPossibleConversionsForFileType: " + e.Message);
            }
        }
    }
}