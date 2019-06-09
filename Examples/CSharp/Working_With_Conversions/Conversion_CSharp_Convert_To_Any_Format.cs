using System;
using System.Collections.Generic;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Client;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp
{
	// Quick Convert to Any Desired Output Format
	class Convert_To_Any_Format
	{
		public static void Run(string convertToFormat, ConvertOptions convertOptions)
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);

			var apiInstance = new ConvertApi(configuration);

			try
			{
				// convert settings
				var settings = new ConvertSettings
				{
					StorageName = Common.MyStorage,
					FilePath = "conversions/sample.docx",
					Format = convertToFormat,
					ConvertOptions = convertOptions,
					OutputPath = "converted/" + convertToFormat
				};

				// convert to specified format
				List<StoredConvertedResult> response = apiInstance.ConvertDocument(new ConvertDocumentRequest(settings));
				Console.WriteLine("Document converted successfully: " + response[0].Url);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception when calling ConvertApi.QuickConvert: " + e.Message);
			}
		}
	}
}