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
    // Get All Possible Conversions Formats For Provided Document
    class Get_All_Possible_Conversions_For_Document
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
                var request = new PossibleConversionsForDocumentRequest
                {
                    File = Convert_To_Cells_Stream.Run()
                };

                // Get supported file formats for specified document type
                var response = apiInstance.PossibleConversionsForDocument(request);

                Console.WriteLine(string.Format("{0}: {1}", response.SourceFileType, string.Join(",", response.PossibleConversions)));
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling ConversionApi.PossibleConversionsForDocument: " + e.Message);
            }
        }
    }
}