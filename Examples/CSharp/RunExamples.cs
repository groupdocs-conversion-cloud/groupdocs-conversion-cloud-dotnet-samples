using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupDocs.Conversion.Cloud.Sdk.Model;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp
{
    class RunExamples
    {
        static void Main(string[] args)
        {
            //// ***********************************************************
            ////          GroupDocs.Conversion Cloud API Examples
            //// ***********************************************************

            //TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud (free registration is required).
            Common.MyAppSid = "XXXXX-XXXXX-XXXXX";
            Common.MyAppKey = "XXXXXXX";
            Common.MyStorage = "XXXXX";

            // Uploading sample test files from local to storage under folder 'conversions'
            //Common.UploadSampleTestFiles();

            //// ***********************************************************
            ///// ***** WORKING WITH STORAGE *****
            //// ***********************************************************

            // Is Storage Exist
            //Storage_Exist.Run();

            // Get Get Disc Usage
            //Get_Disc_Usage.Run();

            // Get File Versions
            //Get_File_Versions.Run();

            // Is Object Exists
            //Object_Exists.Run();


            //// ***********************************************************
            //// ***** WORKING WITH FOLDER *****
            //// ***********************************************************

            // Create Folder
            //Create_Folder.Run();

            // Copy Folder
            //Copy_Folder.Run();

            // Move Folder
            //Move_Folder.Run();

            // Delete Folder
            //Delete_Folder.Run();

            // Get Files List
            //Get_Files_List.Run("converted");


            //// ***********************************************************
            //// ***** WORKING WITH FILES *****
            //// ***********************************************************

            // Upload File
            //Upload_File.Run();

            // Copy File
            //Copy_File.Run();

            // Move File
            //Move_File.Run();

            // Delete File
            //Delete_File.Run();

            // Download_File
            //Download_File.Run();


            //// ***********************************************************
            //// ***** WORKING WITH SUPPORTED FORMATS *****
            //// ***********************************************************

            // Get All Supported Formats
            Get_All_Supported_Formats.Run();

            // Get All Supported Formats For Provided Document
            //Get_All_Possible_Conversions_For_Document.Run();

            // Get All Supported Formats For Provided Extension
            //Get_All_Possible_Conversions_For_Extension.Run();


            //// ***********************************************************
            //// ***** WORKING WITH CONVERSIONS *****
            //// ***********************************************************

            // Quick Convert to Any Desired Output Format
            //Convert_To_Any_Format.Run("jpg", new JpgConvertOptions());

            // Convert to Cells with load and save options
            //Convert_To_Cells.Run();

            // Convert to Html with load and save options
            //Convert_To_Html.Run();

            // Convert to image/s with load and save options
            //Convert_To_Images.Run();

            // Convert to PDF with load and save options
            //Convert_To_Pdf.Run();

            // Convert to Slides with load and save options
            //Convert_To_Slides.Run();

            // Convert to Words with load and save options
            //Convert_To_Words.Run();

            // Convert to Text with load and save options
            //Convert_To_Text.Run();
        }
    }
}
