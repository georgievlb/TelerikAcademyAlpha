using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace iTextSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document(PageSize.LETTER, 10, 10, 42, 35); //set the margins
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("Testpdf.pdf", FileMode.Create));
            doc.Open();//Open document to write
            //some content
            Paragraph paragraph = new Paragraph("Hello World, in a PDF");
            doc.Add(paragraph);
            doc.Close();

        }
    }
}
