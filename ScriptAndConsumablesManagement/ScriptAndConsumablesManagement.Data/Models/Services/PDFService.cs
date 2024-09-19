﻿using iText.Kernel.Pdf;
using iText.Layout.Properties;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Colors;
using iText.IO.Image;
using iText.Layout.Borders;
using System.Net.Http;
using System;
using ScriptAndConsumablesManagement.Data.Models.ViewModels;

namespace ScriptAndConsumablesManagement.Data.Models.Services
{
   public class PDFService
    {
        public byte[] GeneratePDF(ScriptDetailsViewModel ScriptDetailsViewModel)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                PdfWriter writer = new PdfWriter(stream);
                PdfDocument pdf = new PdfDocument(writer);
                iText.Layout.Document document = new Document(pdf);

                //gets current directory
                string baseDirectory = Directory.GetCurrentDirectory();

                //to wwwroot using current directory
                string wwwrootPath = Path.Combine(baseDirectory, "wwwroot");

                //logo from wwwroot
                string logoPath = Path.Combine(wwwrootPath, "peaky-blinders-logo(L).png");


                if (!File.Exists(logoPath))
                {
                    throw new FileNotFoundException($"Logo file not found at path: {logoPath}");
                }

                Image logo = new Image(ImageDataFactory.Create(logoPath));
                logo.ScaleAbsolute(75, 75); 
                logo.SetMarginTop(10);
                document.Add(logo);

                // Header
                document.Add(new Paragraph("Prescription")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(20)
                    .SetFontColor(ColorConstants.BLACK)
                    .SetBackgroundColor(ColorConstants.WHITE)
                    .SetBorder(new SolidBorder(ColorConstants.BLACK, 0.5f))
                    .SetMarginBottom(10));

                // Patient Information
                document.Add(new Paragraph("Patient Information:")
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontSize(20)
                    .SetFontColor(ColorConstants.BLACK));
                document.Add(new Paragraph($"Name: {ScriptDetailsViewModel.PatientName}")
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontSize(12));
                document.Add(new Paragraph($"Date: {ScriptDetailsViewModel.Date.ToString("yyyy-MM-dd")}")
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontSize(12));

                // Doctor Information
                document.Add(new Paragraph("Doctor Information:")
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontSize(20));
                document.Add(new Paragraph($"Name: {ScriptDetailsViewModel.FirstName}")
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontSize(12));

                // Medication and Dosage Stuff
                document.Add(new Paragraph("Medication Information:")
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontSize(20));
                document.Add(new Paragraph($"Medication: {ScriptDetailsViewModel.medicationName}")
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontSize(12));
                document.Add(new Paragraph($"Dosage: {ScriptDetailsViewModel.Dosage} mg")
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontSize(12));

                document.Close();

                return stream.ToArray();
            }
        }
    }
}
