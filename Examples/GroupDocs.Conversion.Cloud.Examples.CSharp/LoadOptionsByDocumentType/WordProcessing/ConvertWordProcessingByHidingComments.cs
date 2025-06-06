using System;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp.LoadOptionsByDocumentType.WordProcessing
{
    /// <summary>
    /// This example demonstrates how to convert a word-processing document to pdf with advanced options
    /// </summary>
    public class ConvertWordProcessingByHidingComments
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
                    CommentDisplayMode = WordProcessingLoadOptions.CommentDisplayModeEnum.Hidden
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