using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Client;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;
using System;
using System.IO;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp
{
	// Upload File
	class Upload_File
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new FileApi(configuration);

			try
			{
				// Open file in IOStream from local/disc.
				var fileStream = File.Open("..\\..\\..\\Data\\conversions\\one-page.docx", FileMode.Open);

				var request = new UploadFileRequest("conversions/one-page1.docx", fileStream, Common.MyStorage);

				var response = apiInstance.UploadFile(request);
				Console.WriteLine("Expected response type is FilesUploadResult: " + response.Uploaded.Count.ToString());
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling FileApi: " + e.Message);
			}
		}
	}
}