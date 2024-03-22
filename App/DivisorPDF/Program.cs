using DevExpress.Pdf;
using DevExpress.XtraSpreadsheet.PrintLayoutEngine;
using DivisorPDF;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Crie uma instância do serviço
        var pdfService = new PdfService();

        // cria o caminho do arquivo de entrada e o diretório de saída
        try
        {
            var documento = @"C:\Abner\Estudos\Csharp\App\DUT - quebra.pdf";
            var pastaDeSaida = @"C:\Abner\Estudos\Csharp\App\pdf";
            string textoEntrada = "##QUEBRA##";


            var valida = 0; //validar se o texto foi encontrado
            int paginaTextoEntrada = -1; // Índice da página onde o texto de entrada é encontrado
            int paginaTextoSaida = -1; // Índice da página onde o texto de saída é encontrado
            //var PageContent = 0;

            using (PdfDocumentProcessor pdfDocumentProcessor = new PdfDocumentProcessor())
            {
                

                pdfDocumentProcessor.LoadDocument(documento);

                foreach (PdfPage page in pdfDocumentProcessor.Document.Pages)
                {
                    //Console.Write(PageContent);
                    //pesquisa o texto no documento PDF
                    var ResultadoPesquisa = pdfDocumentProcessor.FindText(textoEntrada);
                    if (ResultadoPesquisa.PageNumber > 0)
                    {
                        Console.WriteLine("Texto encontrado na página: " + ResultadoPesquisa.PageNumber);
                        valida += 1;
                    }
                    else
                    {
                        break;
                    }
                    //PageContent++;
                }
                if(valida == 0)
                {
                    throw new Exception("Texto não encontrado no documento PDF.");
                }
            }
            Console.WriteLine("Documento Dividido com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
