using GroupDocs.Conversion.Cloud.Sdk;
using GroupDocs.Conversion.Cloud.Sdk.Api;
using GroupDocs.Conversion.Cloud.Sdk.Model;
using GroupDocs.Conversion.Cloud.Sdk.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupDocs.Conversion.Cloud.Examples.Conversions
{
    // Convert to Words and Get Output File Stream
    class Convert_To_Words_Stream
    {
        public static void Run()
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
                // convert to Words request
                var request = new ConvertToWordsStreamRequest
                {
                    // convert to Words Request
                    Request = new WordsConversionRequest
                    {
                        // source file to convert
                        SourceFile = new ConversionFileInfo() { Folder = "conversions", Name = "sample.docx", Password = "" },
                        // Words save options
                        Options = new WordsSaveOptionsDto { ConvertFileType = WordsSaveOptionsDto.ConvertFileTypeEnum.Doc }
                    }
                };

                // convert to Words
                var response = apiInstance.ConvertToWordsStream(request);
                Console.WriteLine(response.Length.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception when calling ConversionApi.ConvertToWordsStream: " + e.Message);
            }
        }
    }
}