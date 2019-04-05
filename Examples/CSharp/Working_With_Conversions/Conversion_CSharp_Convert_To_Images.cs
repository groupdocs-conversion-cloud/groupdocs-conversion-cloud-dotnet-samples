using System;
using System.Collections.Generic;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Client;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp
{
    // Convert to image/s with load and save options
    class Convert_To_Images
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
                    StorageName = Common.MyStorage,
                    FilePath = "conversions/password-protected.docx",
                    Format = "jpeg",
                    LoadOptions = new DocxLoadOptions() { Password = "password" },
                    ConvertOptions = new JpegConvertOptions() { Grayscale = false, FromPage = 1, PagesCount = 1, Quality = 100, RotateAngle = 90, UsePdf = false },
                    OutputPath = "converted/tojpeg"
                };

				// convert to specified format
				List<StoredConvertedResult> response = apiInstance.ConvertDocument(new ConvertDocumentRequest(settings));
				Console.WriteLine("Document conveted successfully: " + response[0].Url);
			}
			catch (Exception e)
            {
                Console.WriteLine("Exception when calling ConversionApi: " + e.Message);
            }
        }
    }
}