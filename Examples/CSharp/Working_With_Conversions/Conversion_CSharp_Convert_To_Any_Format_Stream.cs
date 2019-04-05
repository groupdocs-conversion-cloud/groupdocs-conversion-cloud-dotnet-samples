using System;
using System.Collections.Generic;
using System.IO;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Client;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp
{
	// Quick Convert to Any Desired Output Format with output as iostream
	class Convert_To_Any_Format_Stream
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
					StorageName = Common.MyStorage,
					FilePath = "conversions/sample.docx",
					Format = convertToFormat,
					ConvertOptions = convertOptions,
					OutputPath = null // set OutputPath as null will result the output as document IOStream
				};

				// convert to specified format
				Stream response = apiInstance.ConvertDocumentDownload(new ConvertDocumentRequest(settings));
				Console.WriteLine("Document converted successfully: " + response.Length.ToString());
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception when calling ConversionApi.QuickConvert: " + e.Message);
			}
		}
	}
}