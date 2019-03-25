using System;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Client;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp
{
    // Convert to Cells with load and save options
    class Convert_To_Any_Format
    {
        public static void Run(string convertToFormat, ConvertOptions convertOptions)
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
                    Format = convertToFormat,
                    ConvertOptions = convertOptions,
                    OutputPath = "converted/" + convertToFormat
                };

                // convert to specified format
                apiInstance.ConvertDocument(new ConvertDocumentRequest(settings));
                Console.WriteLine("Document conveted successfully to: " + convertToFormat);
                Get_Files_List.Run("converted/" + convertToFormat);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling ConversionApi.QuickConvert: " + e.Message);
            }
        }
    }
}