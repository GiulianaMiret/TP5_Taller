namespace Punto08
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obtenerTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obtenerPorCódigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obtenerOrdenadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCódigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreYCódigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCorreoElectronicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "&Archivo";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.cerrarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.obtenerTodosToolStripMenuItem,
            this.obtenerPorCódigoToolStripMenuItem,
            this.obtenerOrdenadosToolStripMenuItem,
            this.cerrarToolStripMenuItem1});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.archivoToolStripMenuItem.Text = "Usuario";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.nuevoToolStripMenuItem.Text = "&Agregar";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cerrarToolStripMenuItem.Text = "&Actualizar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.eliminarToolStripMenuItem.Text = "&Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // obtenerTodosToolStripMenuItem
            // 
            this.obtenerTodosToolStripMenuItem.Name = "obtenerTodosToolStripMenuItem";
            this.obtenerTodosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.obtenerTodosToolStripMenuItem.Text = "&Obtener todos";
            this.obtenerTodosToolStripMenuItem.Click += new System.EventHandler(this.obtenerTodosToolStripMenuItem_Click);
            // 
            // obtenerPorCódigoToolStripMenuItem
            // 
            this.obtenerPorCódigoToolStripMenuItem.Name = "obtenerPorCódigoToolStripMenuItem";
            this.obtenerPorCódigoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.obtenerPorCódigoToolStripMenuItem.Text = "&Obtener por código";
            this.obtenerPorCódigoToolStripMenuItem.Click += new System.EventHandler(this.obtenerPorCódigoToolStripMenuItem_Click);
            // 
            // obtenerOrdenadosToolStripMenuItem
            // 
            this.obtenerOrdenadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porCódigoToolStripMenuItem,
            this.porNombreToolStripMenuItem,
            this.porNombreYCódigoToolStripMenuItem,
            this.porCorreoElectronicoToolStripMenuItem});
            this.obtenerOrdenadosToolStripMenuItem.Name = "obtenerOrdenadosToolStripMenuItem";
            this.obtenerOrdenadosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.obtenerOrdenadosToolStripMenuItem.Text = "&Obtener ordenados";
            this.obtenerOrdenadosToolStripMenuItem.Click += new System.EventHandler(this.obtenerOrdenadosToolStripMenuItem_Click);
            // 
            // porCódigoToolStripMenuItem
            // 
            this.porCódigoToolStripMenuItem.Name = "porCódigoToolStripMenuItem";
            this.porCódigoToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.porCódigoToolStripMenuItem.Text = "Por código";
            this.porCódigoToolStripMenuItem.Click += new System.EventHandler(this.porCódigoToolStripMenuItem_Click);
            // 
            // porNombreToolStripMenuItem
            // 
            this.porNombreToolStripMenuItem.Name = "porNombreToolStripMenuItem";
            this.porNombreToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.porNombreToolStripMenuItem.Text = "Por nombre";
            this.porNombreToolStripMenuItem.Click += new System.EventHandler(this.porNombreToolStripMenuItem_Click);
            // 
            // porNombreYCódigoToolStripMenuItem
            // 
            this.porNombreYCódigoToolStripMenuItem.Name = "porNombreYCódigoToolStripMenuItem";
            this.porNombreYCódigoToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.porNombreYCódigoToolStripMenuItem.Text = "Por nombre y código";
            this.porNombreYCódigoToolStripMenuItem.Click += new System.EventHandler(this.porNombreYCódigoToolStripMenuItem_Click);
            // 
            // porCorreoElectronicoToolStripMenuItem
            // 
            this.porCorreoElectronicoToolStripMenuItem.Name = "porCorreoElectronicoToolStripMenuItem";
            this.porCorreoElectronicoToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.porCorreoElectronicoToolStripMenuItem.Text = "Por correo electronico";
            this.porCorreoElectronicoToolStripMenuItem.Click += new System.EventHandler(this.porCorreoElectronicoToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem1
            // 
            this.cerrarToolStripMenuItem1.Name = "cerrarToolStripMenuItem1";
            this.cerrarToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.cerrarToolStripMenuItem1.Text = "&Cerrar";
            this.cerrarToolStripMenuItem1.Click += new System.EventHandler(this.cerrarToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obtenerTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obtenerPorCódigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obtenerOrdenadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCódigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porNombreYCódigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCorreoElectronicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem1;
    }
}

