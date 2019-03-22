using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Client;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp
{
	// Is Storage Exist
	class Storage_Exist
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new StorageApi(configuration);

			try
			{
				var request = new StorageExistsRequest(Common.MyStorage);

				var response = apiInstance.StorageExists(request);
				Console.WriteLine("Expected response type is StorageExist: " + response.Exists.Value.ToString());
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling StorageApi: " + e.Message);
			}
		}
	}
}