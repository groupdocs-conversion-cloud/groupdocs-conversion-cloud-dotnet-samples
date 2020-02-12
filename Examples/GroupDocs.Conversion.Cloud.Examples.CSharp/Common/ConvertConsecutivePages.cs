using System;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp.Common
{
    /// <summary>
    /// This example demonstrates how to convert consecutive pages from word processing document into pdf document
    /// </summary>
    public class ConvertConsecutivePages
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
                    FilePath = "WordProcessing/four-pages.docx",
                    Format = "pdf",
                    ConvertOptions = new PdfConvertOptions
                    {
                        FromPage = 2, // Page number starts from 1
                        PagesCount = 2
                    },
                    OutputPath = "converted/two-pages.pdf"
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
