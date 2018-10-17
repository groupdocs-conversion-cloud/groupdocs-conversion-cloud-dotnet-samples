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
    // Convert to Slides and Get Output File Url
    class Convert_To_Slides
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
                // convert to Slides request
                var request = new ConvertToSlidesRequest
                {
                    // convert to Slides Request
                    Request = new SlidesConversionRequest
                    {
                        // source file to convert
                        SourceFile = new ConversionFileInfo() { Folder = "conversions", Name = "sample.docx", Password = "" },
                        // Slides save options
                        Options = new SlidesSaveOptionsDto()
                    }
                };

                // convert to Slides
                var response = apiInstance.ConvertToSlides(request);
                Console.WriteLine(response.Href.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling ConversionApi.ConvertToSlides: " + e.Message);
            }
        }
    }
}