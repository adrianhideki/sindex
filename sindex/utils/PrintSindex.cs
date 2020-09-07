using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
using sindx.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sindex.utils
{
    public static class DeviceInfoSindex
    {
        public const string landscape = @"<DeviceInfo>
                                           <OutputFormat>EMF</OutputFormat>
                                           <PageWidth>8.3in</PageWidth>
                                           <PageHeight>6.2in</PageHeight>
                                           <MarginTop>0.5in</MarginTop>
                                           <MarginLeft>0.5in</MarginLeft>
                                           <MarginRight>0.5in</MarginRight>
                                           <MarginBottom>0.5in</MarginBottom>
                                         </DeviceInfo>";
        public const string normal = @"<DeviceInfo>
                                         <OutputFormat>EMF</OutputFormat>
                                         <PageWidth>6.2in</PageWidth>
                                         <PageHeight>8.3in</PageHeight>
                                         <MarginTop>0.5in</MarginTop>
                                         <MarginLeft>0.5in</MarginLeft>
                                         <MarginRight>0.5in</MarginRight>
                                         <MarginBottom>0.5in</MarginBottom>
                                       </DeviceInfo>";
    }

    public static class PrintSindex
    {
        public static void PrintReportViewer(object ReportData, string DataSetName, string reportName, bool landScape, string deviceInfo)
        {
            //ReportDataSource rs = new ReportDataSource();
            //ReportViewer rv = new ReportViewer();

            //rs.Name = DataSetName;
            //rs.Value = ReportData;

            //rv.LocalReport.ReportEmbeddedResource = reportName;
            //rv.LocalReport.DataSources.Clear();
            //rv.LocalReport.DataSources.Add(rs);
            //rv.ZoomMode = ZoomMode.FullPage;
            //rv.SetDisplayMode(DisplayMode.Normal);

            LocalReport report = new LocalReport();
            report.ReportEmbeddedResource = reportName;
            report.DataSources.Add(new ReportDataSource(DataSetName, ReportData));
            report.PrintToPrinter(landScape, deviceInfo);

            //rv.RefreshReport();
            //rv.PageSetupDialog();
        }

        public static void PrintGrid(string title, string subtitle, string footer, DataGridView dgv)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = title;
            printer.SubTitle = subtitle;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = true;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = footer;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgv);
        }
}

    public static class PrintReport
    {

        private static int m_currentPageIndex;
        private static IList<Stream> m_streams;

        public static void PrintToPrinter(this LocalReport report, bool LandScape, string deviceInfo)
        {
            Export(report, LandScape, deviceInfo);
        }

        public static Stream CreateStream(string name,
          string fileNameExtension, Encoding encoding,
          string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        public static void Export(LocalReport report, bool LandScape, string device, bool print = true)
        {
                //<PageWidth>6.2in</PageWidth>
                //<PageHeight>8.3in</PageHeight>
            string deviceInfo =  device;
            Warning[] warnings;
            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream,
               out warnings);
            foreach (Stream stream in m_streams)
                stream.Position = 0;

            if (print)
            {
                Print(LandScape);
            }
        }


        // Handler for PrintPageEvents
        public static void PrintPage(object sender, PrintPageEventArgs ev)
        {

            Metafile pageImage = new
               Metafile(m_streams[m_currentPageIndex]);

            // Adjust rectangular area with printer margins.
            Rectangle adjustedRect = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                ev.PageBounds.Width,
                ev.PageBounds.Height);

            // Draw a white background for the report
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            // Draw the report content
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // Prepare for the next page. Make sure we haven't hit the end.
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }

        public static void Print(bool LandScape)
        {
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no stream to print.");

            PrintDocument printDoc = new PrintDocument();
            printDoc.DefaultPageSettings.Landscape = LandScape;

            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
        }

        public static void DisposePrint()
        {
            if (m_streams != null)
            {
                foreach (Stream stream in m_streams)
                    stream.Close();
                m_streams = null;
            }
        }
    }
}
