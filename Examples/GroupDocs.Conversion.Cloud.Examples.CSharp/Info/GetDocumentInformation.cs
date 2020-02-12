using System;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp.Info
{
    /// <summary>
    /// This example demonstrates how to get document information
    /// </summary>
    public class GetDocumentInformation
    {
        public static void Run()
        {
            var apiInstance = new InfoApi(Constants.GetConfig());

            try
            {
                var request = new GetDocumentMetadataRequest("WordProcessing/four-pages.docx", Constants.MyStorage);

                var response = apiInstance.GetDocumentMetadata(request);
                Console.WriteLine("InfoResult.Pages.Count: " + response.PageCount);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while calling InfoApi: " + e.Message);
            }
        }
    }
}