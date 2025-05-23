using System;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp.LoadOptionsByDocumentType.Presentation
{
    /// <summary>
    /// This example demonstrates how to convert presentation document to pdf with advanced options
    /// </summary>
    public class ConvertPresentationByHidingComments
    {
        public static void Run()
        {
            try
            {
                // Create necessary API instances
                var apiInstance = new ConvertApi(Constants.GetConfig());

                // Prepare convert settings
                var loadOptions = new PresentationLoadOptions
                {
                    CommentsPosition = PresentationLoadOptions.CommentsPositionEnum.None
                };

                var settings = new ConvertSettings
                {
                    StorageName = Constants.MyStorage,
                    FilePath = "Presentation/with_notes.pptx",
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