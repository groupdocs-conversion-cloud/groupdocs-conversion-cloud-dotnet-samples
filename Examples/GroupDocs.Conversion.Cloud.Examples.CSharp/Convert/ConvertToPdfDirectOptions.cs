using System;
using System.IO;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp.Convert
{
    /// <summary>
    /// This example demonstrates how to document without using cloud storage
    /// and with options
    /// </summary>
    public class ConvertToPdfDirectOptions
    {
        public static void Run()
        {
            try
            {
                // Create necessary API instances
                var apiInstance = new ConvertApi(Constants.GetConfig());

                // Prepare request
                var fileStream = File.Open("..\\..\\..\\..\\Resources\\WordProcessing\\password-protected.docx", FileMode.Open);
                var loadOptions = new WordProcessingLoadOptions();
                loadOptions.Format = "docx";
                loadOptions.Password = "password";
                var request = new ConvertDocumentDirectRequest("pdf", fileStream, null, null, loadOptions);

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
