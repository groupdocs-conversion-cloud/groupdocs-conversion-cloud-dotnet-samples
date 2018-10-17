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
    // Convert to Html and Get Output File Stream
    class Convert_To_Html_Stream
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
                // convert to HTML request
                var request = new ConvertToHtmlStreamRequest
                {
                    // convert to HTML Request
                    Request = new HtmlConversionRequest
                    {
                        // source file to convert
                        SourceFile = new ConversionFileInfo() { Folder = "conversions", Name = "sample.docx", Password = "" },
                        // HTML save options
                        Options = new HtmlSaveOptionsDto()
                    }
                };

                // convert to HTML
                var response = apiInstance.ConvertToHtmlStream(request);
                Console.WriteLine(response.Length.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling ConversionApi.ConvertToHtmlStream: " + e.Message);
            }
        }
    }
}