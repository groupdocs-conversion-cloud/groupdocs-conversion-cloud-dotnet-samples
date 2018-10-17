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
    // Convert to Image/s and Get Output File Stream
    class Convert_To_Images_Stream
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
                // convert to Image request
                var request = new ConvertToImageStreamRequest
                {
                    // convert to Image Request
                    Request = new ImageConversionRequest
                    {
                        // source file to convert
                        SourceFile = new ConversionFileInfo() { Folder = "conversions", Name = "sample-one-page.docx", Password = "" },
                        // Image save options
                        Options = new ImageSaveOptionsDto()
                    }
                };

                // convert to Image
                var response = apiInstance.ConvertToImageStream(request);
                Console.WriteLine(response.Length.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling ConversionApi.ConvertToImageStream: " + e.Message);
            }
        }
    }
}