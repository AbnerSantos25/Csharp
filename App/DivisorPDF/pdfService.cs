using DevExpress.Office.Utils;
using DevExpress.Pdf;
using System;
using DevExpress.Pdf;
using DevExpress.Office.Services;
using DevExpress.Pdf.Native;

namespace DivisorPDF
{
    public class PdfService
    {
        public void SplitPdf(string inputFilePath, string outputDirectory)
        {
            // Verifica se o diretório de saída existe, se não, cria
            if (!Directory.Exists(outputDirectory))
            {
                Directory.CreateDirectory(outputDirectory);
            }

            // Carrega o documento PDF
            using (var processor = new PdfDocumentProcessor())
            {
                processor.LoadDocument(inputFilePath);

                int pageCount = processor.Document.Pages.Count;

                for (int i = 1; i <= pageCount; i++)
                {
                    // Cria um novo documento PDF para cada página
                    using (var newProcessor = new PdfDocumentProcessor())
                    {
                        // Inicializa um novo documento
                        newProcessor.CreateEmptyDocument();
                        // Copia a página do documento original para o novo documento
                        newProcessor.Document.Pages.Add(processor.Document.Pages[i - 1]);

                        // Define o caminho de saída do novo arquivo PDF
                        string newFilePath = Path.Combine(outputDirectory, $"Page_{i}.pdf");

                        // Salva o novo documento no diretório de saída
                        newProcessor.SaveDocument(newFilePath);
                    }
                }
            }
        }

        string ExtractTextFromPDF(string filePath)
        {
            string documentText = "";
            try
            {
                using (PdfDocumentProcessor documentProcessor =
                new PdfDocumentProcessor())
                {
                    documentProcessor.LoadDocument(filePath);
                    documentText = documentProcessor.Text;
                }
            }
            catch { }
            return documentText;
        }

    }
}
