namespace TestingPress
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.Hearder = new System.Windows.Forms.Panel();
            this.restaurar = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.Maximixar = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.PictureBox();
            this.SideBar = new System.Windows.Forms.Panel();
            this.SideBarWrapeer = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TransIda = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.TransiVuelta = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Hearder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximixar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).BeginInit();
            this.SideBar.SuspendLayout();
            this.SideBarWrapeer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hearder
            // 
            this.Hearder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Hearder.Controls.Add(this.restaurar);
            this.Hearder.Controls.Add(this.minimizar);
            this.Hearder.Controls.Add(this.cerrar);
            this.Hearder.Controls.Add(this.Maximixar);
            this.Hearder.Controls.Add(this.Menu);
            this.TransiVuelta.SetDecoration(this.Hearder, BunifuAnimatorNS.DecorationType.None);
            this.TransIda.SetDecoration(this.Hearder, BunifuAnimatorNS.DecorationType.None);
            this.Hearder.Dock = System.Windows.Forms.DockStyle.Top;
            this.Hearder.Location = new System.Drawing.Point(0, 0);
            this.Hearder.Name = "Hearder";
            this.Hearder.Size = new System.Drawing.Size(1164, 42);
            this.Hearder.TabIndex = 0;
            // 
            // restaurar
            // 
            this.restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TransIda.SetDecoration(this.restaurar, BunifuAnimatorNS.DecorationType.None);
            this.TransiVuelta.SetDecoration(this.restaurar, BunifuAnimatorNS.DecorationType.None);
            this.restaurar.Image = global::TestingPress.Properties.Resources.minized;
            this.restaurar.Location = new System.Drawing.Point(1078, 14);
            this.restaurar.Name = "restaurar";
            this.restaurar.Size = new System.Drawing.Size(30, 26);
            this.restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.restaurar.TabIndex = 4;
            this.restaurar.TabStop = false;
            this.restaurar.Visible = false;
            this.restaurar.Click += new System.EventHandler(this.restaurar_Click);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TransIda.SetDecoration(this.minimizar, BunifuAnimatorNS.DecorationType.None);
            this.TransiVuelta.SetDecoration(this.minimizar, BunifuAnimatorNS.DecorationType.None);
            this.minimizar.Image = global::TestingPress.Properties.Resources.minus_24px;
            this.minimizar.Location = new System.Drawing.Point(1040, 20);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(32, 21);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.minimizar.TabIndex = 3;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TransIda.SetDecoration(this.cerrar, BunifuAnimatorNS.DecorationType.None);
            this.TransiVuelta.SetDecoration(this.cerrar, BunifuAnimatorNS.DecorationType.None);
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(1114, 10);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(30, 30);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar.TabIndex = 2;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // Maximixar
            // 
            this.Maximixar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TransIda.SetDecoration(this.Maximixar, BunifuAnimatorNS.DecorationType.None);
            this.TransiVuelta.SetDecoration(this.Maximixar, BunifuAnimatorNS.DecorationType.None);
            this.Maximixar.Image = global::TestingPress.Properties.Resources.maximize_window_100px3;
            this.Maximixar.Location = new System.Drawing.Point(1078, 11);
            this.Maximixar.Name = "Maximixar";
            this.Maximixar.Size = new System.Drawing.Size(30, 30);
            this.Maximixar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Maximixar.TabIndex = 1;
            this.Maximixar.TabStop = false;
            this.Maximixar.Click += new System.EventHandler(this.Maximixar_Click);
            // 
            // Menu
            // 
            this.TransIda.SetDecoration(this.Menu, BunifuAnimatorNS.DecorationType.None);
            this.TransiVuelta.SetDecoration(this.Menu, BunifuAnimatorNS.DecorationType.None);
            this.Menu.Image = global::TestingPress.Properties.Resources.menu_50px;
            this.Menu.Location = new System.Drawing.Point(18, 6);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(30, 30);
            this.Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Menu.TabIndex = 0;
            this.Menu.TabStop = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SideBar.Controls.Add(this.SideBarWrapeer);
            this.SideBar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TransiVuelta.SetDecoration(this.SideBar, BunifuAnimatorNS.DecorationType.None);
            this.TransIda.SetDecoration(this.SideBar, BunifuAnimatorNS.DecorationType.None);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 42);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(229, 702);
            this.SideBar.TabIndex = 0;
            // 
            // SideBarWrapeer
            // 
            this.SideBarWrapeer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SideBarWrapeer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SideBarWrapeer.BackgroundImage")));
            this.SideBarWrapeer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SideBarWrapeer.Controls.Add(this.bunifuFlatButton1);
            this.TransiVuelta.SetDecoration(this.SideBarWrapeer, BunifuAnimatorNS.DecorationType.None);
            this.TransIda.SetDecoration(this.SideBarWrapeer, BunifuAnimatorNS.DecorationType.None);
            this.SideBarWrapeer.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SideBarWrapeer.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SideBarWrapeer.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SideBarWrapeer.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SideBarWrapeer.Location = new System.Drawing.Point(18, 6);
            this.SideBarWrapeer.Name = "SideBarWrapeer";
            this.SideBarWrapeer.Quality = 10;
            this.SideBarWrapeer.Size = new System.Drawing.Size(200, 699);
            this.SideBarWrapeer.TabIndex = 0;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "bunifuFlatButton1";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransIda.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.TransiVuelta.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(6, 21);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(194, 48);
            this.bunifuFlatButton1.TabIndex = 0;
            this.bunifuFlatButton1.Text = "bunifuFlatButton1";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TransiVuelta.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.TransIda.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(229, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(935, 702);
            this.panel3.TabIndex = 0;
            // 
            // TransIda
            // 
            this.TransIda.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.TransIda.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.TransIda.DefaultAnimation = animation1;
            // 
            // TransiVuelta
            // 
            this.TransiVuelta.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.TransiVuelta.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.TransiVuelta.DefaultAnimation = animation2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Hearder;
            this.bunifuDragControl1.Vertical = true;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 744);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.Hearder);
            this.TransiVuelta.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.TransIda.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Hearder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximixar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).EndInit();
            this.SideBar.ResumeLayout(false);
            this.SideBarWrapeer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Hearder;
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox Menu;
        private System.Windows.Forms.PictureBox Maximixar;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox restaurar;
        private Bunifu.Framework.UI.BunifuGradientPanel SideBarWrapeer;
        private BunifuAnimatorNS.BunifuTransition TransIda;
        private BunifuAnimatorNS.BunifuTransition TransiVuelta;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

