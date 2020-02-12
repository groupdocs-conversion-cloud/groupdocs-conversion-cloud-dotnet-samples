using System;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp.Convert
{
    /// <summary>
    /// This example demonstrates how to convert pdf document into word processing document
    /// </summary>
    public class ConvertToWordProcessing
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
                    FilePath = "Pdf/sample.pdf",
                    Format = "docx",
                    LoadOptions = new PdfLoadOptions { Password = "", HidePdfAnnotations = true, RemoveEmbeddedFiles = false, FlattenAllFields = true },
                    ConvertOptions = new DocxConvertOptions(),
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
