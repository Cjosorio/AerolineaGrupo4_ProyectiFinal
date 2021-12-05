
namespace AerolineaGrupo4.Vistas
{
    partial class LoginView
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
            this.bttcancelar = new System.Windows.Forms.Button();
            this.bttaceptar = new System.Windows.Forms.Button();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttcancelar
            // 
            this.bttcancelar.Location = new System.Drawing.Point(276, 332);
            this.bttcancelar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bttcancelar.Name = "bttcancelar";
            this.bttcancelar.Size = new System.Drawing.Size(130, 36);
            this.bttcancelar.TabIndex = 17;
            this.bttcancelar.Text = "Cancelar";
            this.bttcancelar.UseVisualStyleBackColor = true;
            this.bttcancelar.Click += new System.EventHandler(this.bttcancelar_Click);
            // 
            // bttaceptar
            // 
            this.bttaceptar.Location = new System.Drawing.Point(104, 332);
            this.bttaceptar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bttaceptar.Name = "bttaceptar";
            this.bttaceptar.Size = new System.Drawing.Size(130, 36);
            this.bttaceptar.TabIndex = 16;
            this.bttaceptar.Text = "Aceptar";
            this.bttaceptar.UseVisualStyleBackColor = true;
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(180, 283);
            this.txtclave.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(201, 22);
            this.txtclave.TabIndex = 15;
            this.txtclave.Text = "1234";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(180, 220);
            this.txtemail.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(201, 22);
            this.txtemail.TabIndex = 14;
            this.txtemail.Text = "carlososorio@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Engravers MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(53, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(449, 34);
            this.label3.TabIndex = 18;
            this.label3.Text = "Honduran Airlines";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AerolineaGrupo4.Properties.Resources.piloto;
            this.pictureBox1.Location = new System.Drawing.Point(209, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(144, 407);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(237, 16);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Olvido la contraseña?, click aca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(248, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Sing in";
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 456);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttcancelar);
            this.Controls.Add(this.bttaceptar);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginView";
            this.Text = "LoginView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button bttcancelar;
        public System.Windows.Forms.Button bttaceptar;
        public System.Windows.Forms.TextBox txtclave;
        public System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
    }
}