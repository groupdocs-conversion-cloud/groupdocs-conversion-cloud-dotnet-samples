using System;
using System.IO;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp.Convert
{
    /// <summary>
    /// This example demonstrates how to document without using cloud storage
    /// </summary>
    public class ConvertToPdfDirect
    {
        public static void Run()
        {
            try
            {
                // Create necessary API instances
                var apiInstance = new ConvertApi(Constants.GetConfig());

                // Prepare request
                var fileStream = File.Open("..\\..\\..\\Resources\\WordProcessing\\four-pages.docx", FileMode.Open);
                var request = new ConvertDocumentDirectRequest("pdf", fileStream);

                // Convert to specified format
                var response = apiInstance.ConvertDocumentDirect(request);
                Console.WriteLine("Document converted successfully: " + response.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
