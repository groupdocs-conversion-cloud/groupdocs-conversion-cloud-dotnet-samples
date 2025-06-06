using System;
using System.Collections.Generic;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp.LoadOptionsByDocumentType.WordProcessing
{
    /// <summary>
    /// This example demonstrates how to convert a word-processing document to pdf with advanced options
    /// </summary>
    public class ConvertWordProcessingBySpecifyingFontSubstitution
    {
        public static void Run()
        {
            try
            {
                // Create necessary API instances
                var apiInstance = new ConvertApi(Constants.GetConfig());

                // Prepare convert settings
                var loadOptions = new WordProcessingLoadOptions
                {
                    FontNameSubstitutionEnabled = true,
                    DefaultFont = "Helvetica",
                    FontSubstitutes = new Dictionary<string, string>
                    {
                        {"Tahoma", "Arial"}, {"Times New Roman", "Arial"}
                    }
                };

                var settings = new ConvertSettings
                {
                    StorageName = Constants.MyStorage,
                    FilePath = "WordProcessing/with_tracked_changes.docx",
                    Format = "pdf",
                    LoadOptions = loadOptions,
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