using System;
using System.Threading;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp.Convert
{
    /// <summary>
    /// This example demonstrates how to convert word processing document into pdf document asyncronously
    /// </summary>
    public class ConvertToPdfAsync
    {
        public static void Run()
        {
            try
            {
                // Create necessary API instances
                var apiInstance = new AsyncApi(Constants.GetConfig());

                // Prepare convert settings
                var settings = new ConvertSettings
                {
                    StorageName = Constants.MyStorage,
                    FilePath = "WordProcessing/password-protected.docx",
                    Format = "pdf",
                    LoadOptions = new WordProcessingLoadOptions { Password = "password" },
                    ConvertOptions = new PdfConvertOptions
                    {
                        CenterWindow = true,
                        CompressImages = false,
                        DisplayDocTitle = true,
                        Dpi = 1024,
                        FitWindow = false,
                        FromPage = 1,
                        Grayscale = false,
                        ImageQuality = 100,
                        Linearize = false,
                        MarginTop = 5,
                        MarginLeft = 5,
                        Password = "password",
                        UnembedFonts = true,
                        RemoveUnusedStreams = true,
                        RemoveUnusedObjects = true,
                        RemovePdfaCompliance = false
                    },
                    OutputPath = "converted"
                };

                
                // Convert to specified format
                var operationId = apiInstance.StartConvertAndSave(new StartConvertAndSaveRequest(settings));
                
                Console.WriteLine("Operation ID: " + operationId);

                while (true) {
                    Thread.Sleep(1000);
                    var result = apiInstance.GetOperationStatus(new GetOperationStatusRequest(operationId));
                    if (result.Status == OperationResult.StatusEnum.Finished)
                    {
                        Console.WriteLine("Document converted successfully: " + result.Result[0].Url);
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
