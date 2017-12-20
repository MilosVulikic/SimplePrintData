using System;
using System.Collections.Generic;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using PDF = PdfSharp;
static class PrintDocument      // try to make them generic
{

    public static void ToTxt(IEnumerable<Account> accounts)
    {
        StreamWriter sw = null;
        sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\Data.txt", true);
        sw.WriteLine("Data from Accounts:");
        foreach (var acct in accounts)
        {
            sw.WriteLine("ID: {0}, Balance: {1}", acct.ID, acct.Balance);
        }
        sw.Flush();
        sw.Close();
    }

    public static void ToWord(IEnumerable<Account> accounts)
    {
        // Create app
        var wordApp = new Word.Application();
        wordApp.Visible = true;
        wordApp.WindowState = Word.WdWindowState.wdWindowStateNormal;

        // create doc
        Word.Document wordDocument = wordApp.Documents.Add();

        // add paragraph
        Word.Paragraph wordParagraph;
        wordParagraph = wordDocument.Paragraphs.Add();
        foreach (var acct in accounts)
        {
            wordParagraph.Range.Text = "ID: " + acct.ID.ToString() + "Balance: " + acct.Balance.ToString() + "\n";
        }

        //C:\Users\PC\AppData\Local\Temp
        //wordDocument.SaveAs2("C:\\Users\\PC\\AppData\\Local\\Temp\\myAppWordDocs\\firstAppData.docx");
        //wordDocument.SaveAs2("C: \\Users\\PC\\source\repos\\vjezbanje\\vjezbanje\\bin\\Debug\\WordData.docx");
        //wordDocument.SaveAs2(AppDomain.CurrentDomain.BaseDirectory + "\\WordData.docx");

        //wordDocument.Close();
        //wordApp.Quit();
    }

    public static void ToExcel(IEnumerable<Account> accounts)
    {
        var excelApp = new Excel.Application();
        excelApp.Visible = true;

        excelApp.Workbooks.Add();
        Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;
        workSheet.Cells[1, "A"] = "ID:";
        workSheet.Cells[1, "B"] = "Balance:";
        var row = 1;
        foreach (var acct in accounts)
        {
            row++;
            workSheet.Cells[row, "A"] = acct.ID;
            workSheet.Cells[row, "B"] = acct.Balance;
        }
        workSheet.Columns[1].AutoFit();
        workSheet.Columns[2].AutoFit();
        ((Excel.Range)workSheet.Columns[1]).AutoFit();
        ((Excel.Range)workSheet.Columns[2]).AutoFit();
        //workSheet.Range["A1:B3"].Copy();
    }

    public static void ToPDF(IEnumerable<Account> accounts)
    {

        var pdfDocument = new PDF.Pdf.PdfDocument();
        pdfDocument.Info.Title = "Account data";        // get it from outside
        var page = pdfDocument.AddPage();
        var gfx = PDF.Drawing.XGraphics.FromPdfPage(page);
        var font = new PDF.Drawing.XFont("Verdana", 14, PDF.Drawing.XFontStyle.BoldItalic);
        int yAxis = 40;
        foreach (var acct in accounts)
        {
            gfx.DrawString($"ID: {acct.ID}, Balance: {acct.Balance}", font, PDF.Drawing.XBrushes.Black, new PDF.Drawing.XRect(40, yAxis, 250, 40 + yAxis), PDF.Drawing.XStringFormats.TopLeft);    // fix it
            yAxis += 20;
        }
        const string filename = "Accounts.pdf";
        pdfDocument.Save(filename);
        System.Diagnostics.Process.Start(@AppDomain.CurrentDomain.BaseDirectory + "\\Accounts.pdf");
    }
}