using System;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp.Convert
{
    /// <summary>
    /// This example demonstrates how to convert word processing document into pdf document in response body
    /// </summary>
    public class ConvertToPdfResponseBody
    {
        public static void Run()
        {
            try
            {
                // Create necessary API instances
                var apiInstance = new ConvertApi(Constants.GetConfig());

                // Prepare convert settings
                var settings = new ConvertSettings
                {
                    StorageName = Constants.MyStorage,
                    FilePath = "WordProcessing/password-protected.docx",
                    Format = "pdf",
                    LoadOptions = new DocxLoadOptions { Password = "password" },
                    ConvertOptions = new PdfConvertOptions
                    {
                        CenterWindow = true,
                        CompressImages = false,
                        DisplayDocTitle = true,
                        Dpi = 1024,
                        FitWindow = false,
                        FromPage = 1,
                        Grayscale = false,
                        ImageQuality = 100,
                        Linearize = false,
                        MarginTop = 5,
                        MarginLeft = 5,
                        Password = "password",
                        UnembedFonts = true,
                        RemoveUnusedStreams = true,
                        RemoveUnusedObjects = true,
                        RemovePdfaCompliance = false,
                        PageSize = PdfConvertOptions.PageSizeEnum.A4
                    },
                    OutputPath = null // set OutputPath as null will result the output as document IOStream
                };

                // Convert to specified format
                var response = apiInstance.ConvertDocumentDownload(new ConvertDocumentRequest(settings));
                Console.WriteLine("Document converted successfully: " + response.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
