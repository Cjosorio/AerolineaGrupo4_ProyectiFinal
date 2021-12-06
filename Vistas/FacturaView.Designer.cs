
namespace AerolineaGrupo4.Vistas
{
    partial class FacturaView
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
            this.DetalleDGrib = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TotalText = new System.Windows.Forms.TextBox();
            this.ISVText = new System.Windows.Forms.TextBox();
            this.SubText = new System.Windows.Forms.TextBox();
            this.CantText = new System.Windows.Forms.TextBox();
            this.PrecioText = new System.Windows.Forms.TextBox();
            this.DescText = new System.Windows.Forms.TextBox();
            this.IDText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IdPasajeroText = new System.Windows.Forms.TextBox();
            this.IdBoletoText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NClienteText = new System.Windows.Forms.TextBox();
            this.IdClienteText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttcancelar = new System.Windows.Forms.Button();
            this.btteliminar = new System.Windows.Forms.Button();
            this.bttguardar = new System.Windows.Forms.Button();
            this.bttmodificar = new System.Windows.Forms.Button();
            this.bttnuevo = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDGrib)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // DetalleDGrib
            // 
            this.DetalleDGrib.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetalleDGrib.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDGrib.Location = new System.Drawing.Point(3, 395);
            this.DetalleDGrib.Name = "DetalleDGrib";
            this.DetalleDGrib.Size = new System.Drawing.Size(778, 200);
            this.DetalleDGrib.TabIndex = 14;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bttcancelar);
            this.groupBox4.Controls.Add(this.bttnuevo);
            this.groupBox4.Controls.Add(this.btteliminar);
            this.groupBox4.Controls.Add(this.bttmodificar);
            this.groupBox4.Controls.Add(this.bttguardar);
            this.groupBox4.Location = new System.Drawing.Point(588, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(209, 367);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Opciones";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TotalText);
            this.groupBox3.Controls.Add(this.ISVText);
            this.groupBox3.Controls.Add(this.SubText);
            this.groupBox3.Controls.Add(this.CantText);
            this.groupBox3.Controls.Add(this.PrecioText);
            this.groupBox3.Controls.Add(this.DescText);
            this.groupBox3.Controls.Add(this.IDText);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(3, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(579, 191);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos boletos";
            // 
            // TotalText
            // 
            this.TotalText.Location = new System.Drawing.Point(355, 137);
            this.TotalText.Name = "TotalText";
            this.TotalText.Size = new System.Drawing.Size(114, 20);
            this.TotalText.TabIndex = 13;
            // 
            // ISVText
            // 
            this.ISVText.Location = new System.Drawing.Point(206, 137);
            this.ISVText.Name = "ISVText";
            this.ISVText.Size = new System.Drawing.Size(114, 20);
            this.ISVText.TabIndex = 12;
            // 
            // SubText
            // 
            this.SubText.Location = new System.Drawing.Point(53, 137);
            this.SubText.Name = "SubText";
            this.SubText.Size = new System.Drawing.Size(114, 20);
            this.SubText.TabIndex = 11;
            // 
            // CantText
            // 
            this.CantText.Location = new System.Drawing.Point(460, 56);
            this.CantText.Name = "CantText";
            this.CantText.Size = new System.Drawing.Size(46, 20);
            this.CantText.TabIndex = 10;
            // 
            // PrecioText
            // 
            this.PrecioText.Location = new System.Drawing.Point(368, 56);
            this.PrecioText.Name = "PrecioText";
            this.PrecioText.Size = new System.Drawing.Size(49, 20);
            this.PrecioText.TabIndex = 9;
            // 
            // DescText
            // 
            this.DescText.Location = new System.Drawing.Point(150, 56);
            this.DescText.Name = "DescText";
            this.DescText.Size = new System.Drawing.Size(175, 20);
            this.DescText.TabIndex = 8;
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(21, 56);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(100, 20);
            this.IDText.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(376, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "TOTAL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(231, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "ISV 15%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(79, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Sub Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(457, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(376, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Precio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Descripcion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IdPasajeroText);
            this.groupBox2.Controls.Add(this.IdBoletoText);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(304, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 161);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Factura";
            // 
            // IdPasajeroText
            // 
            this.IdPasajeroText.Location = new System.Drawing.Point(113, 94);
            this.IdPasajeroText.Name = "IdPasajeroText";
            this.IdPasajeroText.Size = new System.Drawing.Size(121, 20);
            this.IdPasajeroText.TabIndex = 12;
            // 
            // IdBoletoText
            // 
            this.IdBoletoText.Location = new System.Drawing.Point(113, 56);
            this.IdBoletoText.Name = "IdBoletoText";
            this.IdBoletoText.Size = new System.Drawing.Size(121, 20);
            this.IdBoletoText.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID Pasajero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID Boleto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NClienteText);
            this.groupBox1.Controls.Add(this.IdClienteText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 161);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de cliente";
            // 
            // NClienteText
            // 
            this.NClienteText.Location = new System.Drawing.Point(112, 83);
            this.NClienteText.Name = "NClienteText";
            this.NClienteText.Size = new System.Drawing.Size(121, 20);
            this.NClienteText.TabIndex = 9;
            // 
            // IdClienteText
            // 
            this.IdClienteText.Location = new System.Drawing.Point(112, 45);
            this.IdClienteText.Name = "IdClienteText";
            this.IdClienteText.Size = new System.Drawing.Size(121, 20);
            this.IdClienteText.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Usuario";
            // 
            // bttcancelar
            // 
            this.bttcancelar.Enabled = false;
            this.bttcancelar.Location = new System.Drawing.Point(51, 276);
            this.bttcancelar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bttcancelar.Name = "bttcancelar";
            this.bttcancelar.Size = new System.Drawing.Size(82, 40);
            this.bttcancelar.TabIndex = 33;
            this.bttcancelar.Text = "Cancelar";
            this.bttcancelar.UseVisualStyleBackColor = true;
            // 
            // btteliminar
            // 
            this.btteliminar.Location = new System.Drawing.Point(51, 214);
            this.btteliminar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btteliminar.Name = "btteliminar";
            this.btteliminar.Size = new System.Drawing.Size(82, 40);
            this.btteliminar.TabIndex = 32;
            this.btteliminar.Text = "Eliminar";
            this.btteliminar.UseVisualStyleBackColor = true;
            // 
            // bttguardar
            // 
            this.bttguardar.Enabled = false;
            this.bttguardar.Location = new System.Drawing.Point(51, 145);
            this.bttguardar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bttguardar.Name = "bttguardar";
            this.bttguardar.Size = new System.Drawing.Size(82, 40);
            this.bttguardar.TabIndex = 31;
            this.bttguardar.Text = "Guardar";
            this.bttguardar.UseVisualStyleBackColor = true;
            // 
            // bttmodificar
            // 
            this.bttmodificar.Location = new System.Drawing.Point(51, 83);
            this.bttmodificar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bttmodificar.Name = "bttmodificar";
            this.bttmodificar.Size = new System.Drawing.Size(82, 40);
            this.bttmodificar.TabIndex = 30;
            this.bttmodificar.Text = "Modificar";
            this.bttmodificar.UseVisualStyleBackColor = true;
            // 
            // bttnuevo
            // 
            this.bttnuevo.Location = new System.Drawing.Point(51, 30);
            this.bttnuevo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bttnuevo.Name = "bttnuevo";
            this.bttnuevo.Size = new System.Drawing.Size(82, 40);
            this.bttnuevo.TabIndex = 29;
            this.bttnuevo.Text = "Nuevo";
            this.bttnuevo.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FacturaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 603);
            this.Controls.Add(this.DetalleDGrib);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FacturaView";
            this.Text = "FacturaView";
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDGrib)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DetalleDGrib;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox TotalText;
        public System.Windows.Forms.TextBox ISVText;
        public System.Windows.Forms.TextBox SubText;
        public System.Windows.Forms.TextBox CantText;
        public System.Windows.Forms.TextBox PrecioText;
        public System.Windows.Forms.TextBox DescText;
        public System.Windows.Forms.TextBox IDText;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox IdPasajeroText;
        public System.Windows.Forms.TextBox IdBoletoText;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox NClienteText;
        public System.Windows.Forms.TextBox IdClienteText;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button bttcancelar;
        public System.Windows.Forms.Button bttnuevo;
        public System.Windows.Forms.Button btteliminar;
        public System.Windows.Forms.Button bttmodificar;
        public System.Windows.Forms.Button bttguardar;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}