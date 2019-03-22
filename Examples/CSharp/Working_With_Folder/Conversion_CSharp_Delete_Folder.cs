using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Client;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp
{
	// Delete Folder
	class Delete_Folder
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new FolderApi(configuration);

			try
			{
				var request = new DeleteFolderRequest("conversions/conversions1", Common.MyStorage, true);

				apiInstance.DeleteFolder(request);
				Console.WriteLine("Expected response type is Void: 'conversions/conversions1' folder deleted recusrsively.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling FolderApi: " + e.Message);
			}
		}
	}
}