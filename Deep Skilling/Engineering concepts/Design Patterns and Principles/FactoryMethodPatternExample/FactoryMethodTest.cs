using System;

namespace FactoryMethodPatternExample
{
    class FactoryMethodTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Factory Method Pattern Demonstration =====\n");

            DocumentFactory wordFactory = new WordDocumentFactory();
            Document word = wordFactory.CreateDocument();
            word.Open();

            DocumentFactory pdfFactory = new PdfDocumentFactory();
            Document pdf = pdfFactory.CreateDocument();
            pdf.Open();

            DocumentFactory excelFactory = new ExcelDocumentFactory();
            Document excel = excelFactory.CreateDocument();
            excel.Open();

            Console.WriteLine("\nAll document objects were created successfully using the Factory Method Pattern.");
        }
    }
}
