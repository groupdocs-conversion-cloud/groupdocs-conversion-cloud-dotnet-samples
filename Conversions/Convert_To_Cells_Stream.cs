using GroupDocs.Conversion.Cloud.Sdk;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupDocs.Conversion.Cloud.Examples.Conversions
{
    // Convert to Cells and Get Output File Stream
    class Convert_To_Cells_Stream
    {
        public static Stream Run()
        {
            var configuration = new Configuration
       {
           AppSid = Common.MyAppSid,
           AppKey = Common.MyAppKey
       };

            // Initiate api instance
            var apiInstance = new ConversionApi(configuration);

            try
            {
                // convert to cells request
                var request = new ConvertToCellsStreamRequest
                {
                    // convert to cells Request
                    Request = new CellsConversionRequest
                    {
                        // source file to convert
                        SourceFile = new ConversionFileInfo() { Folder = "conversions", Name = "sample.docx", Password = "" },
                        // cells save options
                        Options = new CellsSaveOptionsDto()
                    }
                };

                // convert to cells
                var response = apiInstance.ConvertToCellsStream(request);
                Console.WriteLine(response.Length.ToString());
                return response;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling ConversionApi.ConvertToCellsStream: " + e.Message);
            }
            return null;
        }
    }
}