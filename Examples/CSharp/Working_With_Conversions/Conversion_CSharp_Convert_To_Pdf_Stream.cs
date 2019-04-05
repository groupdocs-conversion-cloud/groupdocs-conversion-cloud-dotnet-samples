using System;
using System.Collections.Generic;
using System.IO;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Client;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp
{
	// Convert to PDF with load and save options with output as iostream
	class Convert_To_Pdf_Stream
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
					OutputPath = null // set OutputPath as null will result the output as document IOStream
				};

				// convert to specified format
				Stream response = apiInstance.ConvertDocumentDownload(new ConvertDocumentRequest(settings));
				Console.WriteLine("Document conveted successfully: " + response.Length.ToString());
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception when calling ConversionApi: " + e.Message);
			}
		}
	}
}