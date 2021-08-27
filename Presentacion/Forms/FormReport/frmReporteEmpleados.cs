using System;
using MaterialSkin;
using MaterialSkin.Controls;
using CapaEntidades;
using CapaModeloNegocio.ReportClass;

namespace Presentacion.Forms.FormReport
{
    public partial class frmReporteEmpleados : MaterialForm
    {
        public frmReporteEmpleados()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.LightBlue100, Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void frmReporteEmpleados_Load(object sender, EventArgs e)
        {
            ReportEmpleados reportEmpleados = new ReportEmpleados();
            E_EmpleadoBindingSource.DataSource = reportEmpleados.obtenerListadoEmpleados();
            this.reportViewer1.RefreshReport();
        }
    }
}
