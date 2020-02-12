using System;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp.Common
{
    /// <summary>
    /// This example demonstrates how to convert word processing document into pdf document with adding watermark
    /// </summary>
    public class AddWatermark
    {
        public static void Run()
        {
            try
            {
                // Create necessary API instances
                var apiInstance = new ConvertApi(Constants.GetConfig());

                // Prepare convert settings
                var watermark = new WatermarkOptions
                {
                    Text = "Sample watermark",
                    Color = "Red",
                    Width = 100,
                    Height = 100,
                    Background = true
                };

                var settings = new ConvertSettings
                {
                    StorageName = Constants.MyStorage,
                    FilePath = "WordProcessing/four-pages.docx",
                    Format = "pdf",
                    ConvertOptions = new PdfConvertOptions
                    {
                        WatermarkOptions = watermark
                    },
                    OutputPath = "converted"
                };

                // Convert to specified format
                var response = apiInstance.ConvertDocument(new ConvertDocumentRequest(settings));
                Console.WriteLine("Document converted successfully: " + response[0].Url);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
