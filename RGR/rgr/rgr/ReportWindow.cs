using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace rgr
{
    public partial class ReportWindow : Form
    {
        int printType;

        public ReportWindow(int selectedPrintType)
        {
            printType = selectedPrintType;
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportDocument reportDocument = new ReportDocument();
            string path = null;
            if (printType == 0)
            {
                path = "C:/Users/oleg/Documents/Visual Studio 2015/Projects/Database/rgr/rgr/PassangersList.rpt";
            }
            else if (printType == 1)
            {
                path = "C:/Users/oleg/Documents/Visual Studio 2015/Projects/Database/rgr/rgr/FlightInfo.rpt";
            }
            else if (printType == 2)
            {
                //path = 
            }
            reportDocument.Load(path);
            //reportDocument.
            crystalReportViewer1.ReportSource = reportDocument;
        }
    }
}
