using System;
using System.IO;
using System.Threading;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp.Convert
{
    /// <summary>
    /// This example demonstrates how to convert word processing document into pdf document asyncronously
    /// </summary>
    public class ConvertToPdfDirectAsync
    {
        public static void Run()
        {
            try
            {
                // Create necessary API instances
                var apiInstance = new AsyncApi(Constants.GetConfig());

                var fileStream = File.Open("..\\..\\..\\..\\Resources\\WordProcessing\\four-pages.docx", FileMode.Open);
                var request = new StartConvertRequest("pdf", fileStream);

                // Convert to specified format
                var operationId = apiInstance.StartConvert(request);
                
                Console.WriteLine("Operation ID: " + operationId);

                while (true) {
                    Thread.Sleep(1000);
                    var result = apiInstance.GetOperationStatus(new GetOperationStatusRequest(operationId));
                    if (result.Status == OperationResult.StatusEnum.Finished)
                    {
                        var response = apiInstance.GetOperationResult(new GetOperationResultRequest(operationId));
                        Console.WriteLine("Document converted successfully: " + response.Length);
                        break;
                    }
                    else if (result.Status == OperationResult.StatusEnum.Failed) {
                        Console.WriteLine("Document converted failed: " + result.Error);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Operation status: " + result.Status);
                    }
                }                
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
