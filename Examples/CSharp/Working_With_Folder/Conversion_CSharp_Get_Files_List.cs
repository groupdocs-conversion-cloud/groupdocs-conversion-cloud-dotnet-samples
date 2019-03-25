using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Client;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;
using System;
using GroupDocs.Conversion.Cloud.Sdk.Model;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp
{
    // Get Files List
    class Get_Files_List
    {
        public static void Run(string path)
        {
            var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
            var apiInstance = new FolderApi(configuration);

            try
            {
                var request = new GetFilesListRequest(path, Common.MyStorage);

                var response = apiInstance.GetFilesList(request);
                foreach (StorageFile storageFile in response.Value)
                {
                    Console.WriteLine("Expected response type is FilesList: " + storageFile.Path);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while calling FolderApi: " + e.Message);
            }
        }
    }
}