using System;
using System.Collections.Generic;
using System.ComponentModel;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Windows.Forms;
using CapaModeloNegocio.ReportClass;

namespace Presentacion.Forms.FormReport
{
    public partial class frmReportSuplidores : MaterialForm
    {
        public frmReportSuplidores()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme
                (Primary.Blue400, Primary.Blue500, Primary.LightBlue100, Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void frmReportSuplidores_Load(object sender, EventArgs e)
        {
            ReportSuplidores reportSuplidores = new ReportSuplidores();
            E_SuplidorBindingSource.DataSource = reportSuplidores.obtenerListadoSuplidores();
            this.reportViewer1.RefreshReport();
        }
    }
}
