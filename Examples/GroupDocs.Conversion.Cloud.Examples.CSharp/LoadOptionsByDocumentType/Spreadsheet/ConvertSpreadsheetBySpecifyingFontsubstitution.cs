using System;
using System.Collections.Generic;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp.LoadOptionsByDocumentType.Spreadsheet
{
    /// <summary>
    /// This example demonstrates how to convert a spreadsheet document to pdf with advanced options
    /// </summary>
    public class ConvertSpreadsheetBySpecifyingFontsubstitution
    {
        public static void Run()
        {
            try
            {
                // Create necessary API instances
                var apiInstance = new ConvertApi(Constants.GetConfig());

                // Prepare convert settings
                var loadOptions = new SpreadsheetLoadOptions
                {
                    DefaultFont = "Helvetica",
                    FontSubstitutes = new Dictionary<string, string>
                    {
                        {"Tahoma", "Arial"}, {"Times New Roman", "Arial"}
                    },
                    OnePagePerSheet = true
                };

                var settings = new ConvertSettings
                {
                    StorageName = Constants.MyStorage,
                    FilePath = "Spreadsheet/sample.xlsx",
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