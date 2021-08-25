﻿using System;
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
using CapaModeloNegocio;
using CapaEntidades;

namespace Presentacion.Forms
{
    public partial class frmveentass : MaterialForm
    {
        public frmveentass()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.LightBlue100, Accent.LightBlue200,
                TextShade.WHITE);
        }

        
        private void CargaDelFormualrioVentas(object sender, EventArgs e)
        {
            DataProductos();
        }
        #region Cargar datos y buscar productos
        private void DataProductos()
        {
            N_Producto producto = new N_Producto();
            dataGridPorductVentas.DataSource = producto.ListadoProductos();
        }

        private void BuscarProducto(string valor)
        {
            N_Producto producto = new N_Producto();
            dataGridPorductVentas.DataSource = producto.BuscarProductoPorNombre(valor);
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            BuscarProducto(txtBuscarProducto.Text);
        }

        private void materialTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion


        decimal PrecioProducto;
        string NombreProducto;
        int contadorProductos = 0;
        decimal sub;
        int idProducto;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtCantidadProducto.Text) || dataGridPorductVentas.SelectedRows == null)
            {
                MaterialMessageBox.Show("Debe especidicar la cantidad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                idProducto = Convert.ToInt32(dataGridPorductVentas.SelectedRows[0].Cells[0].Value.ToString());
                NombreProducto = dataGridPorductVentas.SelectedRows[0].Cells[1].Value.ToString();
                PrecioProducto = Convert.ToDecimal(dataGridPorductVentas.SelectedRows[0].Cells[3].Value.ToString());
                decimal SubtotalColunm = Convert.ToInt32(txtCantidadProducto.Text) * PrecioProducto;

                DataGridViewRow gridViewRow = new DataGridViewRow();
                gridViewRow.CreateCells(dataGridDetallaFactura);

                gridViewRow.Cells[0].Value = NombreProducto;
                gridViewRow.Cells[1].Value = PrecioProducto;
                gridViewRow.Cells[2].Value = txtCantidadProducto.Text;
                gridViewRow.Cells[3].Value = SubtotalColunm;
                gridViewRow.Cells[4].Value = idProducto;

                dataGridDetallaFactura.Rows.Add(gridViewRow);
                contadorProductos++;
                LabelPorducto.Text = contadorProductos.ToString();

                sub = sub + SubtotalColunm;
                txtCantidadProducto.Clear();
                txtGeneralSubTotal.Text = sub.ToString("0.00");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            dataGridDetallaFactura.Rows.Clear();
            txtGeneralSubTotal.Clear();
            contadorProductos = 0;
            txtDescuentoNormal.Clear();
            txtCantidadProducto.Clear();
            PrecioProducto = 0;
            contadorProductos = 0;
            txtTotalAlPagar.Clear();
        }
        private void txtdDescuentoPorcentaje_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                double porcentaje = (Convert.ToDouble(txtdDescuentoPorcentaje.Text)) / 100;
                
                double PorcentajeRes = ((Convert.ToDouble(txtGeneralSubTotal.Text)) * porcentaje);

                double cantidad = Convert.ToDouble(txtGeneralSubTotal.Text) - PorcentajeRes;
                
                txtTotalAlPagar.Text = cantidad.ToString();
                txtDescuentoNormal.Text = PorcentajeRes.ToString();
            }
            catch (Exception ee)
            {
                MaterialMessageBox.Show(ee.Message);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow Rows in dataGridDetallaFactura.Rows)
            {
                E_OrdenElementos ordenElementos = new E_OrdenElementos
                {
                    Idproducto = Convert.ToInt32(Rows.Cells[4].Value.ToString()),
                    Cantidad = Convert.ToInt32(Rows.Cells[2].Value.ToString()),
                    IdOrden = 4,
                };

                N_InsertOrdenElementos ordenElementos1 = new N_InsertOrdenElementos();
                ordenElementos1.InsertarOrdenElmemtos(ordenElementos);
            }
        }
    } 
}
