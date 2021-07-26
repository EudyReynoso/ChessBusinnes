using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingPress
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void Maximixar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            restaurar.Visible = true;
            Maximixar.Visible = false;
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            restaurar.Visible = false;
            Maximixar.Visible = true;
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            if(SideBar.Width == 229)
            {
                SideBar.Visible = false;
                SideBar.Width = 80;
                SideBarWrapeer.Width = 50;
                TransiVuelta.Show(SideBar);

            }
            else
            {
                SideBar.Visible = false;
                SideBar.Width = 229;
                SideBarWrapeer.Width = 200;
                TransIda.Show(SideBar);

            }
        }
    }
}
