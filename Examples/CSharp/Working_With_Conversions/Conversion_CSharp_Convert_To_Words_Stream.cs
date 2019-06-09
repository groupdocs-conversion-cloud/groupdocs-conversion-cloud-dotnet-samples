using System;
using System.Collections.Generic;
using System.IO;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Client;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp
{
	// Convert to Words with load and save options with output as iostream
	class Convert_To_Words_Stream
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
					FilePath = "conversions/sample.pdf",
					Format = "docx",
					LoadOptions = new PdfLoadOptions() { Password = "", HidePdfAnnotations = true, RemoveEmbeddedFiles = false, FlattenAllFields = true },
					ConvertOptions = new DocxConvertOptions() { FromPage = 1, PagesCount = 2, Zoom = 100, Dpi = 300 },
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