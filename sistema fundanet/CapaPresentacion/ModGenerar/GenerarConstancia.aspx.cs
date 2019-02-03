using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Sistema_Fundanet.CapaPresentacion.ModGenerar
{
    
    public partial class GenerarConstancia : System.Web.UI.Page
    {

        iTextSharp.text.pdf.BaseFont fuente;
        PdfContentByte cb;
        iTextSharp.text.pdf.PdfWriter pdfw;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

           /* Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("c:\\Test.pdf", FileMode.Create));
            doc.Open();
            Paragraph paragraph = new Paragraph("My first Line \n My Second Line ");
            doc.Add(paragraph);
            doc.Close();*/
           

           

            Response.ContentType = "application/pdf";
            Response.AppendHeader(
              "Content-Disposition",
              "attachment; filename=Constancia.pdf"
            );
            using (Document document = new Document())
            {
                pdfw = PdfWriter.GetInstance(document, Response.OutputStream);
                document.SetPageSize(iTextSharp.text.PageSize.A4.Rotate());
                document.Open();
                
                cb = pdfw.DirectContent;
                
               
                //////////////////////////////////////////////

                iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance("C:/Users/Pepe/Desktop/Fundanet/Sistema Fundanet/Sistema Fundanet/CapaPresentacion/Imagenes/FundanetBannersuperior.png");
                imagen.BorderWidth = 0;
                imagen.Alignment = Element.ALIGN_MIDDLE;
                float percentage = 0.0f;
                percentage = 150 / imagen.Width;
                imagen.ScalePercent(percentage * 350);
                document.Add(imagen);
                ////////////////////////////////////////////////

                /*
                iTextSharp.text.Image imagen2 = iTextSharp.text.Image.GetInstance("C:/Users/Pepe/Desktop/Fundanet/Sistema Fundanet/Sistema Fundanet/CapaPresentacion/Imagenes/Prueba.png");
                imagen2.Alignment = iTextSharp.text.Image.UNDERLYING;
                imagen.BorderWidth = 0;
                imagen.Alignment = Element.ALIGN_MIDDLE;
                float percentage2 = 0.0f;
              percentage = 150 / imagen.Width;
                imagen.ScalePercent(percentage2 * 2000);
                document.Add(imagen2);*/

                /////////////////////////////////////////////////////////////////////

                fuente = FontFactory.GetFont(FontFactory.HELVETICA, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.BOLD).BaseFont;
                 cb.SetFontAndSize(fuente, 16);
                cb.SetColorFill(iTextSharp.text.BaseColor.BLACK);
                document.Add(new Paragraph(" \n \n \n  \n  \n "));
                cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Certificado de Asistencia:", 420, 450, 0);
               

                //////////////////////////////////////////////////////////////////////////////////////////
                var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
                var phrase2 = new Phrase();
                phrase2.Add(new Chunk("Se otorga a: \n  \n"));
                phrase2.Add(new Chunk("Giuseppe Adamo \n  \n", boldFont));
                phrase2.Add(new Chunk("por haber asistido a la seccion \n \n "));
                phrase2.Add(new Chunk("#### \n  \n",boldFont));
                phrase2.Add(new Chunk("perteneciente al curso \n \n "));
                phrase2.Add(new Chunk("####### \n \n", boldFont));
                phrase2.Add(new Chunk("realizado en la Ciudad de Caracas y culminado en la fecha \n \n"));
                phrase2.Add(new Chunk("####### \n \n \n  ", boldFont));
                Paragraph parrafo = new Paragraph();
                parrafo.Alignment = Element.ALIGN_CENTER;
                parrafo.Add(phrase2);
                document.Add(parrafo);
                //////////////////////////////////////////////////////////////////////////////////////////
                
                var boldFont2 = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                var phrase3 = new Phrase();
                phrase3.Add(new Chunk("_________________________\n  ", boldFont2));
                phrase3.Add(new Chunk("Luis Molner \n  ", boldFont2));
                phrase3.Add(new Chunk("Director Academico \n ", boldFont2));
                Paragraph parrafo2 = new Paragraph();
                parrafo2.Alignment = Element.ALIGN_CENTER;
                parrafo2.Add(phrase3);
                document.Add(parrafo2);
              
                

                
            



                document.Close();
            }



        }
    }
}