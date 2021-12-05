
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bttregresar = new System.Windows.Forms.Button();
            this.bttcontinuar = new System.Windows.Forms.Button();
            this.bttcancelar = new System.Windows.Forms.Button();
            this.bttfact = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtisv = new System.Windows.Forms.TextBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtidboletos = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.txtidpasajero = new System.Windows.Forms.TextBox();
            this.txtidboleto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtnomb = new System.Windows.Forms.TextBox();
            this.txtidusario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bttregresar);
            this.groupBox4.Controls.Add(this.bttcontinuar);
            this.groupBox4.Controls.Add(this.bttcancelar);
            this.groupBox4.Controls.Add(this.bttfact);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(587, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(209, 367);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Opciones";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // bttregresar
            // 
            this.bttregresar.Location = new System.Drawing.Point(43, 281);
            this.bttregresar.Name = "bttregresar";
            this.bttregresar.Size = new System.Drawing.Size(121, 66);
            this.bttregresar.TabIndex = 3;
            this.bttregresar.Text = "Regresar";
            this.bttregresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttregresar.UseVisualStyleBackColor = true;
            // 
            // bttcontinuar
            // 
            this.bttcontinuar.Location = new System.Drawing.Point(43, 195);
            this.bttcontinuar.Name = "bttcontinuar";
            this.bttcontinuar.Size = new System.Drawing.Size(121, 66);
            this.bttcontinuar.TabIndex = 2;
            this.bttcontinuar.Text = "Continuar";
            this.bttcontinuar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttcontinuar.UseVisualStyleBackColor = true;
            // 
            // bttcancelar
            // 
            this.bttcancelar.Location = new System.Drawing.Point(43, 112);
            this.bttcancelar.Name = "bttcancelar";
            this.bttcancelar.Size = new System.Drawing.Size(121, 66);
            this.bttcancelar.TabIndex = 1;
            this.bttcancelar.Text = "Cancelar";
            this.bttcancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttcancelar.UseVisualStyleBackColor = true;
            // 
            // bttfact
            // 
            this.bttfact.Location = new System.Drawing.Point(43, 30);
            this.bttfact.Name = "bttfact";
            this.bttfact.Size = new System.Drawing.Size(121, 66);
            this.bttfact.TabIndex = 0;
            this.bttfact.Text = "Nueva Factura";
            this.bttfact.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bttfact.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 380);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 222);
            this.dataGridView1.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txttotal);
            this.groupBox3.Controls.Add(this.txtisv);
            this.groupBox3.Controls.Add(this.txtsubtotal);
            this.groupBox3.Controls.Add(this.txtcant);
            this.groupBox3.Controls.Add(this.txtprecio);
            this.groupBox3.Controls.Add(this.txtdescripcion);
            this.groupBox3.Controls.Add(this.txtidboletos);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(2, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(579, 191);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos boletos";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(355, 137);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(114, 20);
            this.txttotal.TabIndex = 13;
            // 
            // txtisv
            // 
            this.txtisv.Location = new System.Drawing.Point(206, 137);
            this.txtisv.Name = "txtisv";
            this.txtisv.Size = new System.Drawing.Size(114, 20);
            this.txtisv.TabIndex = 12;
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(53, 137);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(114, 20);
            this.txtsubtotal.TabIndex = 11;
            // 
            // txtcant
            // 
            this.txtcant.Location = new System.Drawing.Point(460, 56);
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(46, 20);
            this.txtcant.TabIndex = 10;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(368, 56);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(49, 20);
            this.txtprecio.TabIndex = 9;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(150, 56);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(175, 20);
            this.txtdescripcion.TabIndex = 8;
            // 
            // txtidboletos
            // 
            this.txtidboletos.Location = new System.Drawing.Point(21, 56);
            this.txtidboletos.Name = "txtidboletos";
            this.txtidboletos.Size = new System.Drawing.Size(100, 20);
            this.txtidboletos.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(376, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "TOTAL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(231, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "ISV 15%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(79, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Sub Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(457, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(376, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Precio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Descripcion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtfecha);
            this.groupBox2.Controls.Add(this.txtidpasajero);
            this.groupBox2.Controls.Add(this.txtidboleto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(283, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 148);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Factura";
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(111, 103);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(121, 20);
            this.txtfecha.TabIndex = 13;
            // 
            // txtidpasajero
            // 
            this.txtidpasajero.Location = new System.Drawing.Point(111, 65);
            this.txtidpasajero.Name = "txtidpasajero";
            this.txtidpasajero.Size = new System.Drawing.Size(121, 20);
            this.txtidpasajero.TabIndex = 12;
            // 
            // txtidboleto
            // 
            this.txtidboleto.Location = new System.Drawing.Point(111, 27);
            this.txtidboleto.Name = "txtidboleto";
            this.txtidboleto.Size = new System.Drawing.Size(121, 20);
            this.txtidboleto.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Fecha emision";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID Pasajero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID Boleto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttelefono);
            this.groupBox1.Controls.Add(this.txtnomb);
            this.groupBox1.Controls.Add(this.txtidusario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 148);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de cliente";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(110, 103);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(121, 20);
            this.txttelefono.TabIndex = 10;
            // 
            // txtnomb
            // 
            this.txtnomb.Location = new System.Drawing.Point(110, 65);
            this.txtnomb.Name = "txtnomb";
            this.txtnomb.Size = new System.Drawing.Size(121, 20);
            this.txtnomb.TabIndex = 9;
            // 
            // txtidusario
            // 
            this.txtidusario.Location = new System.Drawing.Point(110, 27);
            this.txtidusario.Name = "txtidusario";
            this.txtidusario.Size = new System.Drawing.Size(121, 20);
            this.txtidusario.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Usuario";
            // 
            // FacturaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 603);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FacturaView";
            this.Text = "FacturaView";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bttregresar;
        private System.Windows.Forms.Button bttcontinuar;
        private System.Windows.Forms.Button bttcancelar;
        private System.Windows.Forms.Button bttfact;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtisv;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtidboletos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.TextBox txtidpasajero;
        private System.Windows.Forms.TextBox txtidboleto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtnomb;
        private System.Windows.Forms.TextBox txtidusario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}