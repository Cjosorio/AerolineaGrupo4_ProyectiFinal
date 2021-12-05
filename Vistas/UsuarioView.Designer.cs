
namespace AerolineaGrupo4.Vistas
{
    partial class UsuarioView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttcancelar = new System.Windows.Forms.Button();
            this.btteliminar = new System.Windows.Forms.Button();
            this.bttguardar = new System.Windows.Forms.Button();
            this.bttmodificar = new System.Windows.Forms.Button();
            this.bttnuevo = new System.Windows.Forms.Button();
            this.usuariosdatagriedviwe = new System.Windows.Forms.DataGridView();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtnomb = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosdatagriedviwe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttcancelar);
            this.groupBox1.Controls.Add(this.btteliminar);
            this.groupBox1.Controls.Add(this.bttguardar);
            this.groupBox1.Controls.Add(this.bttmodificar);
            this.groupBox1.Controls.Add(this.bttnuevo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(83, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 71);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            // 
            // bttcancelar
            // 
            this.bttcancelar.Enabled = false;
            this.bttcancelar.Location = new System.Drawing.Point(403, 20);
            this.bttcancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttcancelar.Name = "bttcancelar";
            this.bttcancelar.Size = new System.Drawing.Size(90, 42);
            this.bttcancelar.TabIndex = 28;
            this.bttcancelar.Text = "Cancelar";
            this.bttcancelar.UseVisualStyleBackColor = true;
            this.bttcancelar.Click += new System.EventHandler(this.bttcancelar_Click);
            // 
            // btteliminar
            // 
            this.btteliminar.Location = new System.Drawing.Point(305, 20);
            this.btteliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btteliminar.Name = "btteliminar";
            this.btteliminar.Size = new System.Drawing.Size(90, 42);
            this.btteliminar.TabIndex = 27;
            this.btteliminar.Text = "Eliminar";
            this.btteliminar.UseVisualStyleBackColor = true;
            // 
            // bttguardar
            // 
            this.bttguardar.Enabled = false;
            this.bttguardar.Location = new System.Drawing.Point(207, 20);
            this.bttguardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttguardar.Name = "bttguardar";
            this.bttguardar.Size = new System.Drawing.Size(90, 42);
            this.bttguardar.TabIndex = 26;
            this.bttguardar.Text = "Guardar";
            this.bttguardar.UseVisualStyleBackColor = true;
            // 
            // bttmodificar
            // 
            this.bttmodificar.Location = new System.Drawing.Point(109, 20);
            this.bttmodificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttmodificar.Name = "bttmodificar";
            this.bttmodificar.Size = new System.Drawing.Size(90, 42);
            this.bttmodificar.TabIndex = 25;
            this.bttmodificar.Text = "Modificar";
            this.bttmodificar.UseVisualStyleBackColor = true;
            // 
            // bttnuevo
            // 
            this.bttnuevo.Location = new System.Drawing.Point(11, 20);
            this.bttnuevo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttnuevo.Name = "bttnuevo";
            this.bttnuevo.Size = new System.Drawing.Size(90, 42);
            this.bttnuevo.TabIndex = 24;
            this.bttnuevo.Text = "Nuevo";
            this.bttnuevo.UseVisualStyleBackColor = true;
            // 
            // usuariosdatagriedviwe
            // 
            this.usuariosdatagriedviwe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usuariosdatagriedviwe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosdatagriedviwe.Location = new System.Drawing.Point(2, 324);
            this.usuariosdatagriedviwe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.usuariosdatagriedviwe.Name = "usuariosdatagriedviwe";
            this.usuariosdatagriedviwe.Size = new System.Drawing.Size(658, 207);
            this.usuariosdatagriedviwe.TabIndex = 63;
            // 
            // txtclave
            // 
            this.txtclave.Enabled = false;
            this.txtclave.Location = new System.Drawing.Point(135, 221);
            this.txtclave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(200, 20);
            this.txtclave.TabIndex = 61;
            // 
            // txtemail
            // 
            this.txtemail.Enabled = false;
            this.txtemail.Location = new System.Drawing.Point(135, 176);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(200, 20);
            this.txtemail.TabIndex = 60;
            // 
            // txtnomb
            // 
            this.txtnomb.Enabled = false;
            this.txtnomb.Location = new System.Drawing.Point(135, 131);
            this.txtnomb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtnomb.Name = "txtnomb";
            this.txtnomb.Size = new System.Drawing.Size(200, 20);
            this.txtnomb.TabIndex = 59;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(135, 85);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(115, 20);
            this.txtid.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "Clave:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "ID Usuarios";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Engravers MT", 21.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(186, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 34);
            this.label5.TabIndex = 65;
            this.label5.Text = "Usuarios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AerolineaGrupo4.Properties.Resources.hombre__1_;
            this.pictureBox1.Location = new System.Drawing.Point(463, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // UsuarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(662, 533);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.usuariosdatagriedviwe);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtnomb);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UsuarioView";
            this.Text = "UsuarioView";
            this.Load += new System.EventHandler(this.UsuarioView_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosdatagriedviwe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button bttcancelar;
        public System.Windows.Forms.Button btteliminar;
        public System.Windows.Forms.Button bttguardar;
        public System.Windows.Forms.Button bttmodificar;
        public System.Windows.Forms.Button bttnuevo;
        public System.Windows.Forms.DataGridView usuariosdatagriedviwe;
        public System.Windows.Forms.TextBox txtclave;
        public System.Windows.Forms.TextBox txtemail;
        public System.Windows.Forms.TextBox txtnomb;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}