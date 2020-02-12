using System;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp.Convert
{
    /// <summary>
    /// This example demonstrates how to convert word processing document into spreadsheet document
    /// </summary>
    public class ConvertToSpreadsheet
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
                    Format = "xlsx",
                    ConvertOptions = new SpreadsheetConvertOptions()
                    {
                        FromPage = 2,
                        PagesCount = 1,
                        Zoom = 150
                    },
                    OutputPath = "converted"
                };

                // Convert to specified format
                var response = apiInstance.ConvertDocument(new ConvertDocumentRequest(settings));
                
                Console.WriteLine("Document converted successfully: ");
                Console.WriteLine(response[0].Url);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
