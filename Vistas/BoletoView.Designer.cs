
namespace AerolineaGrupo4.Vistas
{
    partial class BoletoView
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
            this.BoletosdataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttcancelar = new System.Windows.Forms.Button();
            this.btteliminar = new System.Windows.Forms.Button();
            this.bttguardar = new System.Windows.Forms.Button();
            this.bttmodificar = new System.Windows.Forms.Button();
            this.bttnuevo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.AsientocomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ClasecomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.IDPsajerotextBox = new System.Windows.Forms.TextBox();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BoletosdataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BoletosdataGridView
            // 
            this.BoletosdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoletosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BoletosdataGridView.Location = new System.Drawing.Point(1, 379);
            this.BoletosdataGridView.Name = "BoletosdataGridView";
            this.BoletosdataGridView.Size = new System.Drawing.Size(797, 198);
            this.BoletosdataGridView.TabIndex = 57;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttcancelar);
            this.groupBox1.Controls.Add(this.btteliminar);
            this.groupBox1.Controls.Add(this.bttguardar);
            this.groupBox1.Controls.Add(this.bttmodificar);
            this.groupBox1.Controls.Add(this.bttnuevo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(165, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 86);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            // 
            // bttcancelar
            // 
            this.bttcancelar.Location = new System.Drawing.Point(416, 28);
            this.bttcancelar.Name = "bttcancelar";
            this.bttcancelar.Size = new System.Drawing.Size(84, 32);
            this.bttcancelar.TabIndex = 4;
            this.bttcancelar.Text = "Cancelar";
            this.bttcancelar.UseVisualStyleBackColor = true;
            this.bttcancelar.Click += new System.EventHandler(this.bttcancelar_Click);
            // 
            // btteliminar
            // 
            this.btteliminar.Location = new System.Drawing.Point(317, 28);
            this.btteliminar.Name = "btteliminar";
            this.btteliminar.Size = new System.Drawing.Size(84, 32);
            this.btteliminar.TabIndex = 3;
            this.btteliminar.Text = "Eliminar";
            this.btteliminar.UseVisualStyleBackColor = true;
            // 
            // bttguardar
            // 
            this.bttguardar.Location = new System.Drawing.Point(218, 28);
            this.bttguardar.Name = "bttguardar";
            this.bttguardar.Size = new System.Drawing.Size(84, 32);
            this.bttguardar.TabIndex = 2;
            this.bttguardar.Text = "Guardar";
            this.bttguardar.UseVisualStyleBackColor = true;
            // 
            // bttmodificar
            // 
            this.bttmodificar.Location = new System.Drawing.Point(118, 28);
            this.bttmodificar.Name = "bttmodificar";
            this.bttmodificar.Size = new System.Drawing.Size(84, 32);
            this.bttmodificar.TabIndex = 1;
            this.bttmodificar.Text = "Modificar";
            this.bttmodificar.UseVisualStyleBackColor = true;
            // 
            // bttnuevo
            // 
            this.bttnuevo.Location = new System.Drawing.Point(28, 28);
            this.bttnuevo.Name = "bttnuevo";
            this.bttnuevo.Size = new System.Drawing.Size(84, 32);
            this.bttnuevo.TabIndex = 0;
            this.bttnuevo.Text = "Nuevo";
            this.bttnuevo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(416, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "Asiento:";
            // 
            // AsientocomboBox
            // 
            this.AsientocomboBox.FormattingEnabled = true;
            this.AsientocomboBox.Items.AddRange(new object[] {
            "Ventana",
            "Pasillo"});
            this.AsientocomboBox.Location = new System.Drawing.Point(482, 189);
            this.AsientocomboBox.Name = "AsientocomboBox";
            this.AsientocomboBox.Size = new System.Drawing.Size(244, 21);
            this.AsientocomboBox.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(421, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 52;
            this.label5.Text = "Precio:";
            // 
            // ClasecomboBox
            // 
            this.ClasecomboBox.FormattingEnabled = true;
            this.ClasecomboBox.Items.AddRange(new object[] {
            "Clase Turista",
            "Clase Economica",
            "Business Class",
            "Primera Clase"});
            this.ClasecomboBox.Location = new System.Drawing.Point(482, 143);
            this.ClasecomboBox.Name = "ClasecomboBox";
            this.ClasecomboBox.Size = new System.Drawing.Size(244, 21);
            this.ClasecomboBox.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(425, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Clase:";
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(482, 236);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(244, 20);
            this.PreciotextBox.TabIndex = 49;
            // 
            // IDPsajerotextBox
            // 
            this.IDPsajerotextBox.Location = new System.Drawing.Point(138, 189);
            this.IDPsajerotextBox.Name = "IDPsajerotextBox";
            this.IDPsajerotextBox.Size = new System.Drawing.Size(244, 20);
            this.IDPsajerotextBox.TabIndex = 48;
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(138, 139);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.ReadOnly = true;
            this.IDtextBox.Size = new System.Drawing.Size(244, 20);
            this.IDtextBox.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Fecha Vuelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "ID Pasajero:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "ID Boletos:";
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(138, 229);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(244, 20);
            this.txtfecha.TabIndex = 58;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Engravers MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(198, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(368, 34);
            this.label7.TabIndex = 59;
            this.label7.Text = "Boletos Aereos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AerolineaGrupo4.Properties.Resources.plane_tickets__1_;
            this.pictureBox1.Location = new System.Drawing.Point(645, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // BoletoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.BoletosdataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AsientocomboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ClasecomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.IDPsajerotextBox);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BoletoView";
            this.Text = "BoletoView";
            this.Load += new System.EventHandler(this.BoletoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BoletosdataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView BoletosdataGridView;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox AsientocomboBox;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox ClasecomboBox;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox PreciotextBox;
        public System.Windows.Forms.TextBox IDPsajerotextBox;
        public System.Windows.Forms.TextBox IDtextBox;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtfecha;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.Button bttcancelar;
        public System.Windows.Forms.Button btteliminar;
        public System.Windows.Forms.Button bttguardar;
        public System.Windows.Forms.Button bttmodificar;
        public System.Windows.Forms.Button bttnuevo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}