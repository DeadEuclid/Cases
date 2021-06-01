//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using iText;
//using System.IO;
//using iText.Kernel.Pdf;
//using iText.Layout;
//using iText.Layout.Properties;
//using iText.Layout.Element;
//using iText.IO.Font.Constants;
//using iText.Kernel.Font;
//using iText.IO.Font;
//using System.Globalization;
//using System.Diagnostics;
//using Viewer;

//namespace Cases
//{
    
//public class Printer
//{
//    public Printer(DataGridView dg)
//    {
//        InfoGrid = dg;
//    }
//    public DataGridView InfoGrid { get; set; }

//    public void PrintSales(string PeriodStart, string Periodend)
//    {
//        FileInfo file = new FileInfo($"Отчёт о продаже билетов c {PeriodStart} по {Periodend}.pdf");
//        file.Directory.Create();
//        PdfWriter writer = new PdfWriter($"Отчёт о продаже билетов c {PeriodStart} по {Periodend}.pdf");
//        //Initialize PDF document
//        PdfDocument pdf = new PdfDocument(writer);
//        // Initialize document
//        Document document = new Document(pdf);
//        // Create a PdfFont
//        PdfFont russian = PdfFontFactory.CreateFont(
//            "FreeSans.ttf", "CP1251", true);
//        //Add paragraph to the document
//        Paragraph p = new Paragraph("ОТЧЁТ\n").
//            Add($"продажа билетов c {PeriodStart} по {Periodend}").
//            SetFont(russian).SetFontSize(14).SetTextAlignment(TextAlignment.CENTER);
//        Table table = GetTable(russian);
//        document.Add(p);
//        document.Add(table);
//        //Close document
//        document.Close();
//        if (File.Exists(file.Name))
//            Process.Start(file.Name);
//    }
//    public void PrintDemand(string PeriodStart, string Periodend)
//    {
//        FileInfo file = new FileInfo($"Отчёт о востребованности маршрутов c {PeriodStart} по {Periodend}.pdf");
//        file.Directory.Create();
//        PdfWriter writer = new PdfWriter($"Отчёт о востребованности маршрутов c {PeriodStart} по {Periodend}.pdf");
//        //Initialize PDF document
//        PdfDocument pdf = new PdfDocument(writer);
//        // Initialize document
//        Document document = new Document(pdf);
//        // Create a PdfFont
//        PdfFont russian = PdfFontFactory.CreateFont(
//            "FreeSans.ttf", "CP1251", true);
//        //Add paragraph to the document
//        Paragraph p = new Paragraph("ОТЧЁТ\n").
//            Add($"востребованность маршрутов c {PeriodStart} по {Periodend}").
//            SetFont(russian).SetFontSize(14).SetTextAlignment(TextAlignment.CENTER);
//        Table table = GetTable(russian);
//        document.Add(p);
//        document.Add(table);
//        //Close document
//        document.Close();
//        if (File.Exists(file.Name))
//            Process.Start(file.Name);
//    }
//    public void PrintTicket(Ticket ticket)
//    {

//        FileInfo file = new FileInfo($"Билет № {ticket.Id}.pdf");
//        file.Directory.Create();
//        PdfWriter writer = new PdfWriter($"Билет № {ticket.Id}.pdf");
//        //Initialize PDF document
//        PdfDocument pdf = new PdfDocument(writer);
//        // Initialize document
//        Document document = new Document(pdf);
//        // Create a PdfFont
//        PdfFont russian = PdfFontFactory.CreateFont(
//            "FreeSans.ttf", "CP1251", true);
//        //Add paragraph to the document
//        Paragraph p = new Paragraph("БИЛЕТ\n");
//        Table table = GetTicketTable(russian,ticket);
//        document.Add(p);
//        document.Add(table);
//        //Close document
//        document.Close();
//        if (File.Exists(file.Name))
//            Process.Start(file.Name);
//    }
//    private Table GetTable(PdfFont russian, Ticket ticket)
//    {
//        Table table = new Table(14).UseAllAvailableWidth();
//        table.AddHeaderCell(new Cell().Add(new Paragraph("№ билета").SetFont(russian).SetFontSize(12)));
//        table.AddHeaderCell(new Cell().Add(new Paragraph($"{ticket.Id}").SetFont(russian).SetFontSize(12)));
//        table.AddCell(new Paragraph("Время отбытия")).SetFont(russian).SetFontSize(12);
//        table.AddCell(new Paragraph($"{ticket.DepartureTime}")).SetFont(russian).SetFontSize(12);
//        table.AddCell(new Paragraph("Маршрут")).SetFont(russian).SetFontSize(12);
//        table.AddCell(new Paragraph($"{ticket.Route}")).SetFont(russian).SetFontSize(12);
//        table.AddCell(new Paragraph("Станция отбытия")).SetFont(russian).SetFontSize(12);
//        table.AddCell(new Paragraph($"{ticket.Departure}")).SetFont(russian).SetFontSize(12);
//        table.AddCell(new Paragraph("Станция прибытия")).SetFont(russian).SetFontSize(12);
//        table.AddCell(new Paragraph($"{ticket.Destination}")).SetFont(russian).SetFontSize(12);
//        table.AddCell(new Paragraph("Номер поезда")).SetFont(russian).SetFontSize(12);
//        table.AddCell(new Paragraph($"{ticket.TrainId}")).SetFont(russian).SetFontSize(12);
//        table.AddCell(new Paragraph("Вагон")).SetFont(russian).SetFontSize(12);
//        table.AddCell(new Paragraph($"{ticket.Wagon.Number}")).SetFont(russian).SetFontSize(12);
//        table.AddCell(new Paragraph("Номер места")).SetFont(russian).SetFontSize(12);
//        table.AddCell(new Paragraph($"{ticket.PalesNum}")).SetFont(russian).SetFontSize(12);
//        table.AddCell(new Paragraph("ФИО")).SetFont(russian).SetFontSize(12);
//        table.AddCell(new Paragraph($"{ticket.LastName} {ticket.FirstName} {ticket.MiddleName}")).SetFont(russian).SetFontSize(12);
//        table.AddCell(new Paragraph("Паспорт")).SetFont(russian).SetFontSize(12);
//        table.AddCell(new Paragraph($"{ticket.PassportSeries} {ticket.PassportNum}")).SetFont(russian).SetFontSize(12);
//        table.AddCell(new Paragraph("Тип льготы")).SetFont(russian).SetFontSize(12);
//        table.AddCell(new Paragraph($"{ticket.ExemType}")).SetFont(russian).SetFontSize(12);
//        table.AddCell(new Paragraph("Цена")).SetFont(russian).SetFontSize(12);
//        table.AddCell(new Paragraph($"{ticket.Price}")).SetFont(russian).SetFontSize(12);
//        return table;
//    }

//    private Table GetTicketTable(PdfFont russian, Ticket ticket)
//    {
//        Table table = new Table(14).UseAllAvailableWidth();
//        for (int i = 0; i < InfoGrid.Columns.Count; i++)//мб роу каунт -1, но ты проверь
//        {
//            table.AddHeaderCell(new Cell().Add(new Paragraph(InfoGrid.Columns[i].HeaderText).
//                SetFont(russian).SetFontSize(12)));
//        }
//        foreach (DataGridViewRow i in InfoGrid.Rows)
//        {
//            for (int j = 0; j < i.Cells.Count; j++)//мб роу каунт -1, но ты проверь
//            {
//                table.AddCell(new Paragraph(i.Cells[j].Value.ToString())).SetFont(russian).SetFontSize(12);
//            }

//        }
//        return table;
//    }
//}

//}


