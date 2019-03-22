using System;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Client;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp
{
    // Convert to PDF with load and save options
    class Convert_To_Pdf
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
                    Format = "pdf",
                    LoadOptions = new DocxLoadOptions() { Password = "password" },
                    ConvertOptions = new PdfConvertOptions()
                    {
                        BookmarksOutlineLevel = 1,
                        CenterWindow = true,
                        CompressImages = false,
                        DisplayDocTitle = true,
                        Dpi = 1024,
                        ExpandedOutlineLevels = 1,
                        FitWindow = false,
                        FromPage = 1,
                        Grayscale = false,
                        HeadingsOutlineLevels = 1,
                        ImageQuality = 100,
                        Linearize = false,
                        MarginTop = 5,
                        MarginLeft = 5,
                        Password = "password",
                        UnembedFonts = true,
                        RemoveUnusedStreams = true,
                        RemoveUnusedObjects = true,
                        RemovePdfaCompliance = false,
                        Height = 1024
                    },
                    OutputPath = "converted/topdf"
                };

                // convert to specified format
                apiInstance.ConvertDocument(new ConvertDocumentRequest(settings));
                Console.WriteLine("Document conveted successfully.");
                Get_Files_List.Run("converted/topdf");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling ConversionApi: " + e.Message);
            }
        }
    }
}