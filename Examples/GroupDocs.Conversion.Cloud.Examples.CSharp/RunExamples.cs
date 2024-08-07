﻿using System;
using GroupDocs.Conversion.Cloud.Examples.CSharp.Common;
using GroupDocs.Conversion.Cloud.Examples.CSharp.Convert;
using GroupDocs.Conversion.Cloud.Examples.CSharp.Info;
using GroupDocs.Conversion.Cloud.Examples.CSharp.LoadOptionsByDocumentType.Cad;
using GroupDocs.Conversion.Cloud.Examples.CSharp.LoadOptionsByDocumentType.Csv;
using GroupDocs.Conversion.Cloud.Examples.CSharp.LoadOptionsByDocumentType.Email;
using GroupDocs.Conversion.Cloud.Examples.CSharp.LoadOptionsByDocumentType.Html;
using GroupDocs.Conversion.Cloud.Examples.CSharp.LoadOptionsByDocumentType.Note;
using GroupDocs.Conversion.Cloud.Examples.CSharp.LoadOptionsByDocumentType.Pdf;
using GroupDocs.Conversion.Cloud.Examples.CSharp.LoadOptionsByDocumentType.Presentation;
using GroupDocs.Conversion.Cloud.Examples.CSharp.LoadOptionsByDocumentType.Spreadsheet;
using GroupDocs.Conversion.Cloud.Examples.CSharp.LoadOptionsByDocumentType.Txt;
using GroupDocs.Conversion.Cloud.Examples.CSharp.LoadOptionsByDocumentType.WordProcessing;

namespace GroupDocs.Conversion.Cloud.Examples.CSharp
{
	public class RunExamples
	{
		public static void Main(string[] args)
		{
            //// ***********************************************************
            ////          GroupDocs.Conversion Cloud API Examples
            //// ***********************************************************

            //TODO: Get your ClientId and ClientSecret at https://dashboard.groupdocs.cloud (free registration is required).
            Constants.MyClientId = "XXXX-XXXX-XXXX-XXXX";
            Constants.MyClientSecret = "XXXXXXXXXXXXXXXX";

            // Uploading sample test files from local disk to cloud storage
            Constants.UploadSampleTestFiles();


            #region Info API Examples
            GetSupportedConversions.Run();

            GetDocumentInformation.Run();
            #endregion

            #region License API Examples
            GetLicenseConsumption.Run();

            #endregion

            #region Document conversion examples with conversion options
            ConvertToPdf.Run();

            ConvertToPdfResponseBody.Run();

            ConvertToWordProcessing.Run();

            ConvertToHtml.Run();

            ConvertToImage.Run();

            ConvertToPresentation.Run();

            ConvertToSpreadsheet.Run();

            ConvertToPdfDirect.Run();

            ConvertToPdfDirectOptions.Run();
            #endregion

            #region Document conversion examples with common options
            AddWatermark.Run();

            ConvertConsecutivePages.Run();

            ConvertSpecificPages.Run();

            ConvertUsingCustomFont.Run();
            #endregion

            #region Document conversion examples with loading options
            ConvertCadAndSpecifyLoadOptions.Run();

            ConvertCsvByConvertingDateTimeAndNumericData.Run();

            ConvertCsvBySpecifyingDelimiter.Run();

            ConvertCsvBySpecifyingEncoding.Run();

            ConvertEmailWithAlteringFieldsVisibility.Run();

            ConvertEmailWithAttachments.Run();

            ConvertEmailWithTimezoneOffset.Run();

            ConvertEmailWithFieldLabels.Run();

            ConvertEmailWithOriginalDate.Run();

            ConvertHtmlWithPageNumbering.Run();

            ConvertNoteBySpecifyingFontSubstitution.Run();

            ConvertPdfAndFlattenAllFields.Run();

            ConvertPdfAndHideAnnotations.Run();

            ConvertPdfAndRemoveEmbeddedFiles.Run();

            ConvertPresentationByHidingComments.Run();

            ConvertPresentationBySpecifyingFontSubstitution.Run();

            ConvertPresentationWithHiddenSlidesIncluded.Run();

            ConvertSpreadsheetAndHideComments.Run();

            ConvertSpreadsheetByShowingGridLines.Run();

            ConvertSpreadsheetBySkippingEmptyRowsAndColumns.Run();

            ConvertSpreadsheetBySpecifyingFontsubstitution.Run();

            ConvertSpreadsheetBySpecifyingRange.Run();

            ConvertSpreadsheetWithHiddenSheetsIncluded.Run();

            ConvertTxtByControllingLeadingSpacesBehavior.Run();

            ConvertTxtByControllingTrailingSpacesBehavior.Run();

            ConvertTxtBySpecifyingEncoding.Run();

            ConvertWordProcessingByHidingComments.Run();

            ConvertWordProcessingByHidingTrackedChanges.Run();

            ConvertWordProcessingBySpecifyingFontSubstitution.Run();

            #endregion

            #region Async API Examples

            ConvertToPdfAsync.Run();
            
            ConvertToPdfDirectAsync.Run();
            
            #endregion

            Console.WriteLine("Completed!");
            Console.ReadKey();
        }
	}
}