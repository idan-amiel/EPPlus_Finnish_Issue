using System.Globalization;
using OfficeOpenXml;

var pathToExcel = Path.Combine(Directory.GetCurrentDirectory(), "Finnish_issue.xlsx");
var x = File.Exists(pathToExcel);
ExcelPackage.LicenseContext = LicenseContext.Commercial;
CultureInfo ci = new CultureInfo("fi-FI");
Thread.CurrentThread.CurrentCulture = ci;
Thread.CurrentThread.CurrentUICulture = ci;
using var excelPackage = new ExcelPackage(pathToExcel);
{
    var workbook = excelPackage.Workbook;
    var sheet = workbook.Worksheets.FirstOrDefault();
    var value = sheet.Cells[1, 2].Text;
    Console.WriteLine(value);
    Console.ReadLine();
}