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
    // Convert to PDF and Get Output File Stream
    class Convert_To_Pdf_Stream
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
                // convert to Pdf request
                var request = new ConvertToPdfStreamRequest
                {
                    // convert to Pdf Request
                    Request = new PdfConversionRequest
                    {
                        // source file to convert
                        SourceFile = new ConversionFileInfo() { Folder = "conversions", Name = "sample.docx", Password = "" },
                        // Pdf save options
                        Options = new PdfSaveOptionsDto()
                    }
                };

                // convert to Pdf
                var response = apiInstance.ConvertToPdfStream(request);
                Console.WriteLine(response.Length.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling ConversionApi.ConvertToPdfStream: " + e.Message);
            }
        }
    }
}