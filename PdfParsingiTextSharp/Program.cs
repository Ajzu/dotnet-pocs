using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using iTextSharp.text;

namespace PdfParsingiTextSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ExtractTextFromPdf(@"C:\Source Code\AMAT Calendar 2019.pdf")); //working file
            //Console.WriteLine(ExtractTextFromPdf(@"C:\Source Code\NAD-exam-1.pdf"));//working file
            //Console.WriteLine(ExtractTextFromPdf(@"C:\Source Code\Arjun Singh CV 2019 Rest API.pdf"));//working file
            Console.WriteLine(ExtractTextFromPdf(@"C:\Source Code\29-MAR-2019.pdf"));//working file

            Console.ReadLine();
        }

        public static string ExtractTextFromPdf(string path)
        {
            using (PdfReader reader = new PdfReader(path))
            {
                StringBuilder text = new StringBuilder();

                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }

                return text.ToString();
            }
        }
    }
}
