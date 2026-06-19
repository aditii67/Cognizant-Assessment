public class FactoryMethodTest {

    public static void main(String[] args) {

        System.out.println("===== Factory Method Pattern Demonstration =====\n");

        DocumentFactory wordFactory = new WordDocumentFactory();
        Document word = wordFactory.createDocument();
        word.open();

        DocumentFactory pdfFactory = new PdfDocumentFactory();
        Document pdf = pdfFactory.createDocument();
        pdf.open();

        DocumentFactory excelFactory = new ExcelDocumentFactory();
        Document excel = excelFactory.createDocument();
        excel.open();

        System.out.println("\nAll document objects were created successfully using the Factory Method Pattern.");
    }
}