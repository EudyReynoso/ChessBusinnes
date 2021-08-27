using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using CapaModeloNegocio.ReportVentasClass;

namespace Presentacion.Forms.FormReport
{
    public partial class frmReportVentas : MaterialForm
    {
        public frmReportVentas()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.LightBlue100, Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void frmReportVentas_Load(object sender, EventArgs e)
        {
            ReportVentas reportVentas = new ReportVentas();
            E_VentasReportBindingSource.DataSource = reportVentas.ListadoVentas();
            this.reportViewer1.RefreshReport();
        }
    }
}
