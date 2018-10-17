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
    class Convert_To_Pdf_linearized
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
                var request = new ConvertToPdfRequest
                {
                    OutPath = "conversions/linearizedPDF",
                    // convert to Pdf settings
                    Request = new PdfConversionRequest
                    {
                        // source file to convert
                        SourceFile = new ConversionFileInfo() { Folder = "conversions", Name = "sample-one-page.docx", Password = "" },
                        // Pdf save options
                        Options = new PdfSaveOptionsDto() { ConvertFileType = GroupDocs.Conversion.Cloud.Sdk.Model.PdfSaveOptionsDto.ConvertFileTypeEnum.Pdf, PdfOptions = new PdfOptionsDto() { Linearize = true } }
                    }
                };

                // convert to Pdf
                var response = apiInstance.ConvertToPdf(request);
                Console.WriteLine(response.Href.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling ConversionApi: " + e.Message);
            }
        }
    }
}