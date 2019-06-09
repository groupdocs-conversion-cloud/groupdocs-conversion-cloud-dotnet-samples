using System;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Client;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp
{
	// Get Document Information / Docuement Metada
	class Get_Document_Information
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);

			var apiInstance = new InfoApi(configuration);

			try
			{
				// get document info/metadata request
				var request = new GetDocumentMetadataRequest
				{
					StorageName = Common.MyStorage,
					FilePath = "conversions/password-protected.docx"
				};

				// Execute api method to get response.
				var response = apiInstance.GetDocumentMetadata(request);
				Console.WriteLine("Expected response type is DocumentMetadata: " + response.ToString());
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception when calling InfoApi: " + e.Message);
			}
		}
	}
}