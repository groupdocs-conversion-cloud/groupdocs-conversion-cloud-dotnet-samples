using System;
using System.Collections.Generic;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp.LoadOptionsByDocumentType.Note
{
    /// <summary>
    /// This example demonstrates how to convert one note document into pdf document
    /// </summary>
    public class ConvertNoteBySpecifyingFontSubstitution
    {
        public static void Run()
        {
            try
            {
                // Create necessary API instances
                var apiInstance = new ConvertApi(Constants.GetConfig());

                // Prepare convert settings
                var loadOptions = new OneLoadOptions
                {
                    FontSubstitutes = new Dictionary<string, string>
                    {
                        {"Tahoma", "Arial"}, {"Times New Roman", "Arial"}
                    }
                };

                var settings = new ConvertSettings
                {
                    StorageName = Constants.MyStorage,
                    FilePath = "Note/sample.one",
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
