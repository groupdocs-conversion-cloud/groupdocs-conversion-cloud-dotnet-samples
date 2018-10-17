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
    // Quick Convert to Any Desired Output Format and Get Output File Stream
    class Convert_To_Any_Format_Stream
    {
        public static void Run()
        {
            var configuration = new Configuration
    {
        AppSid = Common.MyAppSid,
        AppKey = Common.MyAppKey
    };

            // Initiate api instance
            var apiInstance = new ConversionApi(configuration);

            try
            {
                // convert to any format (quick convert) request
                var request = new QuickConvertToStreamRequest
                {
                    // convert to cells request
                    Request = new QuickConversionRequest
                    {
                        // source file to convert
                        SourceFile = new ConversionFileInfo() { Folder = "conversions", Name = "sample.pdf", Password = "" },
                        // quick convert format
                        Format = "doc"
                    }
                };

                // convert to specified format
                var response = apiInstance.QuickConvertToStream(request);
                Console.WriteLine(response.Length.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling ConversionApi.QuickConvertToStream: " + e.Message);
            }
        }
    }
}