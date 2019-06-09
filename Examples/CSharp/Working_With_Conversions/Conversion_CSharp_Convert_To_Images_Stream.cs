using System;
using System.Collections.Generic;
using System.IO;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Client;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp
{
	// Convert to image/s with load and save options with output as iostream
	class Convert_To_Images_Stream
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);

			var apiInstance = new ConvertApi(configuration);

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
					OutputPath = null // set OutputPath as null will result the output as document IOStream
				};

				// convert to specified format
				Stream response = apiInstance.ConvertDocumentDownload(new ConvertDocumentRequest(settings));
				Console.WriteLine("Document conveted successfully: " + response.Length.ToString());
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception when calling ConvertApi: " + e.Message);
			}
		}
	}
}