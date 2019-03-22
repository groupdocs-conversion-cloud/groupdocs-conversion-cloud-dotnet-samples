using System;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Client;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp
{
    // Convert to Slides with load and save options
    class Convert_To_Slides
    {
        public static void Run()
        {
            var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);

            var apiInstance = new ConversionApi(configuration);

            try
            {
                // convert settings
                var settings = new ConvertSettings
                {
                    Storage = Common.MyStorage,
                    FilePath = "conversions/sample.docx",
                    Format = "pptx",
                    LoadOptions = new DocxLoadOptions() { Password = "", HideWordTrackedChanges = true, DefaultFont = "Arial" },
                    ConvertOptions = new PptxConvertOptions() { FromPage = 1, PagesCount = 2, Zoom = 1 },
                    OutputPath = "converted/toslides"
                };

                // convert to specified format
                apiInstance.ConvertDocument(new ConvertDocumentRequest(settings));
                Console.WriteLine("Document conveted successfully.");
                Get_Files_List.Run("converted/toslides");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling ConversionApi: " + e.Message);
            }
        }
    }
}