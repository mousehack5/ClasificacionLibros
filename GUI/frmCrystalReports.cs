using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace ClasificacionLibros.GUI
{
    public partial class frmCrystalReports : Form
    {
        //private DataTable dtReporte; //Chekar si lo lleva

        public frmCrystalReports()
        {
            InitializeComponent();
        }

        public frmCrystalReports(DataTable dt)
        {
            InitializeComponent();
            ImprimeReporte(dt);
            // TODO: Complete member initialization
            //this.dtReporte = dtReporte;
        }

        //Método que permite ubicar la dirección o ruta donde se encuentra 
        //el archivo del reporte actual desde el proyecto
        public void ImprimeReporte(DataTable dt)
        {

            ReportDocument reporte = new ReportDocument();
            string ruta = Application.StartupPath;
            string Path = ruta.Substring(0, ruta.Length - 9);
            reporte.Load(Path + "Reportes\\CrystalReport1.rpt");
            reporte.DataSourceConnections.Clear();
            reporte.SetDataSource(dt);
            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}