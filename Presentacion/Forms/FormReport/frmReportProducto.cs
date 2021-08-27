using System;
using MaterialSkin;
using MaterialSkin.Controls;
using CapaModeloNegocio.ReportClass;
using System.Windows.Forms;

namespace Presentacion.Forms.FormReport
{
    public partial class frmReportProducto : Form
    {
        public frmReportProducto()
        {
            InitializeComponent();
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.LightBlue100, Accent.LightBlue200,
            //    TextShade.WHITE);
        }

        private void frmReportProducto_Load(object sender, EventArgs e)
        {
            ReportProducto report = new ReportProducto();

            E_ProductoBindingSource.DataSource = report.obtenerListadoProductos();
            this.reportViewer1.RefreshReport();
        }
    }
}
