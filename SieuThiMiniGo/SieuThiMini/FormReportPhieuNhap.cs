using Microsoft.Reporting.WinForms;
using SieuThiMini.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SieuThiMini
{
    public partial class FormReportPhieuNhap : Form
    {
        public FormReportPhieuNhap()
        {
            InitializeComponent();
        }

        private void FormReportPhieuNhap_Load(object sender, EventArgs e)
        {

            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "SieuThiMini.Report4.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                reportDataSource.Value = PhieuNhapBUS.layToanBoDanhSach();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
