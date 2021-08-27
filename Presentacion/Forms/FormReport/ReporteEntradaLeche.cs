using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaModeloNegocio.ReportClass;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Presentacion.Forms
{
    public partial class ReporteVEntas : MaterialForm
    {
        public ReporteVEntas()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.LightBlue100, Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void ReporteVEntas_Load(object sender, EventArgs e)
        {
            ListaEntradasBindingSource.DataSource = new ReporEntradas().ObtenerListado();
            this.reportViewer1.RefreshReport();
        }
    }
}
