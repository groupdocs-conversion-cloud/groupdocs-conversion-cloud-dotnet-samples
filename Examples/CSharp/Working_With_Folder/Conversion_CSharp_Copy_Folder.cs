using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Client;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp
{
	// Copy Folder
	class Copy_Folder
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new FolderApi(configuration);

			try
			{
				var request = new CopyFolderRequest("conversions", "conversions1", Common.MyStorage, Common.MyStorage);

				apiInstance.CopyFolder(request);
				Console.WriteLine("Expected response type is Void: 'conversions' folder copied as 'conversions1'.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling FolderApi: " + e.Message);
			}
		}
	}
}