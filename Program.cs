using GroupDocs.Conversion.Cloud.Examples.Conversions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupDocs.Conversion.Cloud.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            // ***********************************************************
            //          GroupDocs.Conversion Cloud API Examples
            // ***********************************************************

            //TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud (free registration is required).
            Common.MyAppSid = "XXXX-XXXX-XXXX";
            Common.MyAppKey = "XXXXXXXXXX";

            // Uploading sample test files from local to default storage under folder 'conversions'
            Common.UploadSampleTestFiles();

            // Get All Possible Conversions Formats
            Get_All_Possible_Conversions.Run();
            // Get All Possible Conversions Formats For Provided Document
            Get_All_Possible_Conversions_For_Document.Run();
            // Get All Possible Conversions Formats For Provided Extension
            // Get_All_Possible_Conversions_For_Extension.Run();

            // Quick Convert to Any Desired Output Format and Get Output File Url
            Convert_To_Any_Format.Run();
            // Quick Convert to Any Desired Output Format and Get Output File Stream
            Convert_To_Any_Format_Stream.Run();

            // Convert to Cells and Get Output File Url
            Convert_To_Cells.Run();
            // Convert to Cells and Get Output File Stream
            Convert_To_Cells_Stream.Run();

            // Convert to Html and Get Output File Url
            Convert_To_Html.Run();
            // Convert to Html and Get Output File Stream
            Convert_To_Html_Stream.Run();

            // Convert to Image/s and Get Output File Url
            Convert_To_Images.Run();
            // Convert to Image/s and Get Output File Stream
            Convert_To_Images_Stream.Run();

            // Convert to PDF and Get Output File Url
            Convert_To_Pdf.Run();
            // Convert to PDF and Get Output File Stream
            Convert_To_Pdf_Stream.Run();
            // Convert to PDF with Options and Get Output File Url
            Convert_To_Pdf_CellsOptions.Run();
            // Convert to PDF as Grayscale and Get Output File Url
            Convert_To_Pdf_Grayscale.Run();
            // Convert to PDF as linearized and Get Output File Url
            Convert_To_Pdf_linearized.Run();
            // Convert to PDF Resource Optimization and Get Output File Url
            Convert_To_Pdf_ResourceOptimization.Run();
            // Convert to PDF to WordBookmarks and Get Output File Url
            Convert_To_Pdf_WordBookmarks.Run();

            // Convert to Slides and Get Output File Url
            Convert_To_Slides.Run();
            // Convert to Slides and Get Output File Stream
            Convert_To_Slides_Stream.Run();

            // Convert to Words and Get Output File Url
            Convert_To_Words.Run();
            // Convert to Words and Get Output File Stream
            Convert_To_Words_Stream.Run();
        }
    }
}
