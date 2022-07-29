using DGVPrinterHelper;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IspisPDF
{
    public static class Ispis
    {
        public static void IspisiTablicu(DataGridView dgv)
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "Izvješće o računima";
            printer.SubTitle = String.Format("Datum: {0}", DateTime.Now);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.SubTitleSpacing = 15;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "PharmaCare";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgv);
        }
    }
}
