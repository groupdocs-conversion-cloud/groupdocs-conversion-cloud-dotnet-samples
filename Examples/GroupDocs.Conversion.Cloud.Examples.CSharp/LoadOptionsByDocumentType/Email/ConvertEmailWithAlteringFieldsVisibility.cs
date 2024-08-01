using System;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp.LoadOptionsByDocumentType.Email
{
    /// <summary>
    /// This example demonstrates how to convert msg document into pdf document
    /// </summary>
    public class ConvertEmailWithAlteringFieldsVisibility
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
                    FilePath = "Email/sample.msg",
                    Format = "pdf",
                    LoadOptions = new EmailLoadOptions
                    {
                        DisplayHeader = false,
                        DisplayFromEmailAddress = false,
                        DisplayToEmailAddress = false,
                        DisplayCcEmailAddress = false,
                        DisplayBccEmailAddress = false
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
