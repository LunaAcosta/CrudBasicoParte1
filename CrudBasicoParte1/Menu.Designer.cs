
namespace CrudBasicoParte1
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.catescris = new MetroFramework.Controls.MetroLabel();
            this.AgregarACatalogo = new MetroFramework.Controls.MetroLabel();
            this.Agregar = new MetroFramework.Controls.MetroButton();
            this.tabla = new MetroFramework.Controls.MetroTabControl();
            this.NuevoEscri = new MetroFramework.Controls.MetroTabPage();
            this.txtcate = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.txtmaterial = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgrega = new System.Windows.Forms.Button();
            this.txtEscri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbEscri = new System.Windows.Forms.Label();
            this.listEscrit = new MetroFramework.Controls.MetroTabPage();
            this.dgCatalogo = new MetroFramework.Controls.MetroGrid();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabla.SuspendLayout();
            this.NuevoEscri.SuspendLayout();
            this.listEscrit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCatalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // catescris
            // 
            this.catescris.AutoSize = true;
            this.catescris.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.catescris.Location = new System.Drawing.Point(34, 22);
            this.catescris.Name = "catescris";
            this.catescris.Size = new System.Drawing.Size(203, 19);
            this.catescris.TabIndex = 0;
            this.catescris.Text = "CATALOGOS DE ESCRITORIOS";
            // 
            // AgregarACatalogo
            // 
            this.AgregarACatalogo.AutoSize = true;
            this.AgregarACatalogo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AgregarACatalogo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.AgregarACatalogo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.AgregarACatalogo.Location = new System.Drawing.Point(243, 22);
            this.AgregarACatalogo.Name = "AgregarACatalogo";
            this.AgregarACatalogo.Size = new System.Drawing.Size(0, 0);
            this.AgregarACatalogo.TabIndex = 1;
            // 
            // Agregar
            // 
            this.Agregar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Agregar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Agregar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Agregar.ForeColor = System.Drawing.Color.Black;
            this.Agregar.Location = new System.Drawing.Point(243, 25);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(217, 23);
            this.Agregar.TabIndex = 2;
            this.Agregar.Text = "| Agregar Nuevo Escritorio Al Catalogo";
            this.Agregar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Agregar.UseSelectable = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // tabla
            // 
            this.tabla.Controls.Add(this.NuevoEscri);
            this.tabla.Controls.Add(this.listEscrit);
            this.tabla.Location = new System.Drawing.Point(34, 67);
            this.tabla.Name = "tabla";
            this.tabla.SelectedIndex = 0;
            this.tabla.Size = new System.Drawing.Size(797, 383);
            this.tabla.TabIndex = 3;
            this.tabla.UseSelectable = true;
            // 
            // NuevoEscri
            // 
            this.NuevoEscri.Controls.Add(this.txtcate);
            this.NuevoEscri.Controls.Add(this.txtcodigo);
            this.NuevoEscri.Controls.Add(this.txtcolor);
            this.NuevoEscri.Controls.Add(this.txtmaterial);
            this.NuevoEscri.Controls.Add(this.button1);
            this.NuevoEscri.Controls.Add(this.btnAgrega);
            this.NuevoEscri.Controls.Add(this.txtEscri);
            this.NuevoEscri.Controls.Add(this.label5);
            this.NuevoEscri.Controls.Add(this.label4);
            this.NuevoEscri.Controls.Add(this.label3);
            this.NuevoEscri.Controls.Add(this.label2);
            this.NuevoEscri.Controls.Add(this.lbEscri);
            this.NuevoEscri.HorizontalScrollbarBarColor = true;
            this.NuevoEscri.HorizontalScrollbarHighlightOnWheel = false;
            this.NuevoEscri.HorizontalScrollbarSize = 10;
            this.NuevoEscri.Location = new System.Drawing.Point(4, 38);
            this.NuevoEscri.Name = "NuevoEscri";
            this.NuevoEscri.Size = new System.Drawing.Size(789, 341);
            this.NuevoEscri.TabIndex = 0;
            this.NuevoEscri.Text = "Nuevo ";
            this.NuevoEscri.VerticalScrollbarBarColor = true;
            this.NuevoEscri.VerticalScrollbarHighlightOnWheel = false;
            this.NuevoEscri.VerticalScrollbarSize = 10;
            // 
            // txtcate
            // 
            this.txtcate.Location = new System.Drawing.Point(121, 83);
            this.txtcate.Name = "txtcate";
            this.txtcate.Size = new System.Drawing.Size(205, 20);
            this.txtcate.TabIndex = 19;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(121, 128);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(205, 20);
            this.txtcodigo.TabIndex = 18;
            // 
            // txtcolor
            // 
            this.txtcolor.Location = new System.Drawing.Point(121, 186);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(205, 20);
            this.txtcolor.TabIndex = 17;
            // 
            // txtmaterial
            // 
            this.txtmaterial.Location = new System.Drawing.Point(121, 246);
            this.txtmaterial.Name = "txtmaterial";
            this.txtmaterial.Size = new System.Drawing.Size(205, 20);
            this.txtmaterial.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.Location = new System.Drawing.Point(504, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgrega
            // 
            this.btnAgrega.BackColor = System.Drawing.Color.Green;
            this.btnAgrega.ForeColor = System.Drawing.Color.Transparent;
            this.btnAgrega.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgrega.Location = new System.Drawing.Point(347, 297);
            this.btnAgrega.Name = "btnAgrega";
            this.btnAgrega.Size = new System.Drawing.Size(75, 35);
            this.btnAgrega.TabIndex = 13;
            this.btnAgrega.Text = "Agregar";
            this.btnAgrega.UseVisualStyleBackColor = false;
            this.btnAgrega.Click += new System.EventHandler(this.btnAgrega_Click);
            // 
            // txtEscri
            // 
            this.txtEscri.Location = new System.Drawing.Point(121, 31);
            this.txtEscri.Name = "txtEscri";
            this.txtEscri.Size = new System.Drawing.Size(205, 20);
            this.txtEscri.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(43, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Materiales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(58, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(58, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(48, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categoria";
            // 
            // lbEscri
            // 
            this.lbEscri.AutoSize = true;
            this.lbEscri.BackColor = System.Drawing.Color.Transparent;
            this.lbEscri.ForeColor = System.Drawing.Color.Black;
            this.lbEscri.Location = new System.Drawing.Point(48, 31);
            this.lbEscri.Name = "lbEscri";
            this.lbEscri.Size = new System.Drawing.Size(50, 13);
            this.lbEscri.TabIndex = 2;
            this.lbEscri.Text = "Escritorio";
            // 
            // listEscrit
            // 
            this.listEscrit.Controls.Add(this.dgCatalogo);
            this.listEscrit.HorizontalScrollbarBarColor = true;
            this.listEscrit.HorizontalScrollbarHighlightOnWheel = false;
            this.listEscrit.HorizontalScrollbarSize = 10;
            this.listEscrit.Location = new System.Drawing.Point(4, 38);
            this.listEscrit.Name = "listEscrit";
            this.listEscrit.Size = new System.Drawing.Size(789, 341);
            this.listEscrit.TabIndex = 1;
            this.listEscrit.Text = "Lista De Escritorios";
            this.listEscrit.VerticalScrollbarBarColor = true;
            this.listEscrit.VerticalScrollbarHighlightOnWheel = false;
            this.listEscrit.VerticalScrollbarSize = 10;
            // 
            // dgCatalogo
            // 
            this.dgCatalogo.AllowUserToResizeRows = false;
            this.dgCatalogo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgCatalogo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgCatalogo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgCatalogo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCatalogo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCatalogo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgCatalogo.EnableHeadersVisualStyles = false;
            this.dgCatalogo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgCatalogo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgCatalogo.Location = new System.Drawing.Point(3, 16);
            this.dgCatalogo.Name = "dgCatalogo";
            this.dgCatalogo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCatalogo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgCatalogo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCatalogo.Size = new System.Drawing.Size(768, 322);
            this.dgCatalogo.TabIndex = 2;
            this.dgCatalogo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCatalogo_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(767, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(854, 519);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.AgregarACatalogo);
            this.Controls.Add(this.catescris);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tabla.ResumeLayout(false);
            this.NuevoEscri.ResumeLayout(false);
            this.NuevoEscri.PerformLayout();
            this.listEscrit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCatalogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private MetroFramework.Controls.MetroLabel catescris;
        private MetroFramework.Controls.MetroLabel AgregarACatalogo;
        private MetroFramework.Controls.MetroButton Agregar;
        private MetroFramework.Controls.MetroTabControl tabla;
        private MetroFramework.Controls.MetroTabPage NuevoEscri;
        private MetroFramework.Controls.MetroTabPage listEscrit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbEscri;
        private System.Windows.Forms.Button btnAgrega;
        private System.Windows.Forms.TextBox txtEscri;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcate;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.TextBox txtmaterial;
        private MetroFramework.Controls.MetroGrid dgCatalogo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}