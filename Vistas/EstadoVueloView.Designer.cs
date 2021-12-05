
namespace AerolineaGrupo4.Vistas
{
    partial class EstadoVueloView
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbcancelado = new System.Windows.Forms.CheckBox();
            this.chbretrasado = new System.Windows.Forms.CheckBox();
            this.chbdisponible = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttcancelar = new System.Windows.Forms.Button();
            this.btteliminar = new System.Windows.Forms.Button();
            this.bttguardar = new System.Windows.Forms.Button();
            this.bttmodificar = new System.Windows.Forms.Button();
            this.bttnuevo = new System.Windows.Forms.Button();
            this.usuariosdatagriedviwe = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosdatagriedviwe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbcancelado);
            this.groupBox2.Controls.Add(this.chbretrasado);
            this.groupBox2.Controls.Add(this.chbdisponible);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(523, 61);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado de vuelo";
            // 
            // chbcancelado
            // 
            this.chbcancelado.AutoSize = true;
            this.chbcancelado.Location = new System.Drawing.Point(376, 34);
            this.chbcancelado.Margin = new System.Windows.Forms.Padding(4);
            this.chbcancelado.Name = "chbcancelado";
            this.chbcancelado.Size = new System.Drawing.Size(102, 20);
            this.chbcancelado.TabIndex = 40;
            this.chbcancelado.Text = "Cancelado";
            this.chbcancelado.UseVisualStyleBackColor = true;
            // 
            // chbretrasado
            // 
            this.chbretrasado.AutoSize = true;
            this.chbretrasado.Location = new System.Drawing.Point(191, 34);
            this.chbretrasado.Margin = new System.Windows.Forms.Padding(4);
            this.chbretrasado.Name = "chbretrasado";
            this.chbretrasado.Size = new System.Drawing.Size(100, 20);
            this.chbretrasado.TabIndex = 39;
            this.chbretrasado.Text = "Retrasado";
            this.chbretrasado.UseVisualStyleBackColor = true;
            // 
            // chbdisponible
            // 
            this.chbdisponible.AutoSize = true;
            this.chbdisponible.Location = new System.Drawing.Point(4, 34);
            this.chbdisponible.Margin = new System.Windows.Forms.Padding(4);
            this.chbdisponible.Name = "chbdisponible";
            this.chbdisponible.Size = new System.Drawing.Size(102, 20);
            this.chbdisponible.TabIndex = 38;
            this.chbdisponible.Text = "Disponible";
            this.chbdisponible.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttcancelar);
            this.groupBox1.Controls.Add(this.btteliminar);
            this.groupBox1.Controls.Add(this.bttguardar);
            this.groupBox1.Controls.Add(this.bttmodificar);
            this.groupBox1.Controls.Add(this.bttnuevo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(119, 209);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(562, 75);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // bttcancelar
            // 
            this.bttcancelar.Enabled = false;
            this.bttcancelar.Location = new System.Drawing.Point(414, 23);
            this.bttcancelar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bttcancelar.Name = "bttcancelar";
            this.bttcancelar.Size = new System.Drawing.Size(82, 40);
            this.bttcancelar.TabIndex = 28;
            this.bttcancelar.Text = "Cancelar";
            this.bttcancelar.UseVisualStyleBackColor = true;
            this.bttcancelar.Click += new System.EventHandler(this.bttcancelar_Click);
            // 
            // btteliminar
            // 
            this.btteliminar.Location = new System.Drawing.Point(328, 23);
            this.btteliminar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btteliminar.Name = "btteliminar";
            this.btteliminar.Size = new System.Drawing.Size(82, 40);
            this.btteliminar.TabIndex = 27;
            this.btteliminar.Text = "Eliminar";
            this.btteliminar.UseVisualStyleBackColor = true;
            // 
            // bttguardar
            // 
            this.bttguardar.Enabled = false;
            this.bttguardar.Location = new System.Drawing.Point(230, 23);
            this.bttguardar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bttguardar.Name = "bttguardar";
            this.bttguardar.Size = new System.Drawing.Size(82, 40);
            this.bttguardar.TabIndex = 26;
            this.bttguardar.Text = "Guardar";
            this.bttguardar.UseVisualStyleBackColor = true;
            // 
            // bttmodificar
            // 
            this.bttmodificar.Location = new System.Drawing.Point(141, 23);
            this.bttmodificar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bttmodificar.Name = "bttmodificar";
            this.bttmodificar.Size = new System.Drawing.Size(82, 40);
            this.bttmodificar.TabIndex = 25;
            this.bttmodificar.Text = "Modificar";
            this.bttmodificar.UseVisualStyleBackColor = true;
            // 
            // bttnuevo
            // 
            this.bttnuevo.Location = new System.Drawing.Point(53, 23);
            this.bttnuevo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bttnuevo.Name = "bttnuevo";
            this.bttnuevo.Size = new System.Drawing.Size(82, 40);
            this.bttnuevo.TabIndex = 24;
            this.bttnuevo.Text = "Nuevo";
            this.bttnuevo.UseVisualStyleBackColor = true;
            // 
            // usuariosdatagriedviwe
            // 
            this.usuariosdatagriedviwe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usuariosdatagriedviwe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosdatagriedviwe.Location = new System.Drawing.Point(2, 292);
            this.usuariosdatagriedviwe.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.usuariosdatagriedviwe.Name = "usuariosdatagriedviwe";
            this.usuariosdatagriedviwe.Size = new System.Drawing.Size(797, 253);
            this.usuariosdatagriedviwe.TabIndex = 47;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(172, 98);
            this.txtid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(216, 22);
            this.txtid.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "ID Estado de Vuelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Engravers MT", 21.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(163, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 34);
            this.label2.TabIndex = 50;
            this.label2.Text = "Estado de Vuelo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AerolineaGrupo4.Properties.Resources.control_de_torre;
            this.pictureBox1.Location = new System.Drawing.Point(618, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // EstadoVueloView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.usuariosdatagriedviwe);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Name = "EstadoVueloView";
            this.Text = "EstadoVueloView";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosdatagriedviwe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.CheckBox chbcancelado;
        public System.Windows.Forms.CheckBox chbretrasado;
        public System.Windows.Forms.CheckBox chbdisponible;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button bttcancelar;
        public System.Windows.Forms.Button btteliminar;
        public System.Windows.Forms.Button bttguardar;
        public System.Windows.Forms.Button bttmodificar;
        public System.Windows.Forms.Button bttnuevo;
        public System.Windows.Forms.DataGridView usuariosdatagriedviwe;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}