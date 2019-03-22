using System;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Client;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp
{
    // Convert to Html and Get Output File Url
    class Convert_To_Html
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
                    FilePath = "conversions/password-protected.docx",
                    Format = "html",
                    LoadOptions = new DocxLoadOptions() { Password = "password" },
                    ConvertOptions = new HtmlConvertOptions() { FixedLayout = true, UsePdf = true },
                    OutputPath = "converted/tohtml"
                };

                // convert to specified format
                apiInstance.ConvertDocument(new ConvertDocumentRequest(settings));
                Console.WriteLine("Document conveted successfully.");
                Get_Files_List.Run("converted/tohtml");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling ConversionApi: " + e.Message);
            }
        }
    }
}