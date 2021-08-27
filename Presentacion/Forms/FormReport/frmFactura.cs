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
using CapaEntidades;
using Microsoft.Reporting.WinForms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace Presentacion.Forms
{
    public partial class frmFactura : MaterialForm
    {
        public List<E_OrdenElementos> ordenElementosList = new List<E_OrdenElementos>();
        public List<E_Factura> facturas = new List<E_Factura>();
        public frmFactura()
        {
            InitializeComponent();
            
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", ordenElementosList));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", facturas));
            E_OrdenElementosBindingSource.DataSource = ordenElementosList;

            this.reportViewer1.RefreshReport();
        }
    }
}
