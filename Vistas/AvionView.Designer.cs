
namespace AerolineaGrupo4.Vistas
{
    partial class AvionView
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
            this.Cbx_SiglasAvion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbx_ModeloAvion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usuariosdatagriedviwe = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btu_Cancelar = new System.Windows.Forms.Button();
            this.Btu_Eliminar = new System.Windows.Forms.Button();
            this.Btu_Guardar = new System.Windows.Forms.Button();
            this.Btu_Modificar = new System.Windows.Forms.Button();
            this.Btu_Nuevo = new System.Windows.Forms.Button();
            this.Txt_CapacidadAvion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cbx_EstadoAvion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosdatagriedviwe)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cbx_SiglasAvion
            // 
            this.Cbx_SiglasAvion.FormattingEnabled = true;
            this.Cbx_SiglasAvion.Items.AddRange(new object[] {
            "HR-213",
            "HR-901",
            "TG-678",
            "YS-003",
            "HR-524"});
            this.Cbx_SiglasAvion.Location = new System.Drawing.Point(171, 249);
            this.Cbx_SiglasAvion.Margin = new System.Windows.Forms.Padding(4);
            this.Cbx_SiglasAvion.Name = "Cbx_SiglasAvion";
            this.Cbx_SiglasAvion.Size = new System.Drawing.Size(373, 21);
            this.Cbx_SiglasAvion.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 95;
            this.label2.Text = "Siglas del Avion:";
            // 
            // Cbx_ModeloAvion
            // 
            this.Cbx_ModeloAvion.FormattingEnabled = true;
            this.Cbx_ModeloAvion.Items.AddRange(new object[] {
            "ATR-72",
            "Airbus A330F",
            "Boeing 787",
            "A330-900neo",
            "Diamond DA42"});
            this.Cbx_ModeloAvion.Location = new System.Drawing.Point(173, 127);
            this.Cbx_ModeloAvion.Margin = new System.Windows.Forms.Padding(4);
            this.Cbx_ModeloAvion.Name = "Cbx_ModeloAvion";
            this.Cbx_ModeloAvion.Size = new System.Drawing.Size(373, 21);
            this.Cbx_ModeloAvion.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 93;
            this.label1.Text = "Modelo De Avion:";
            // 
            // usuariosdatagriedviwe
            // 
            this.usuariosdatagriedviwe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usuariosdatagriedviwe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosdatagriedviwe.Location = new System.Drawing.Point(2, 366);
            this.usuariosdatagriedviwe.Margin = new System.Windows.Forms.Padding(4);
            this.usuariosdatagriedviwe.Name = "usuariosdatagriedviwe";
            this.usuariosdatagriedviwe.RowHeadersWidth = 51;
            this.usuariosdatagriedviwe.Size = new System.Drawing.Size(760, 223);
            this.usuariosdatagriedviwe.TabIndex = 92;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btu_Cancelar);
            this.groupBox1.Controls.Add(this.Btu_Eliminar);
            this.groupBox1.Controls.Add(this.Btu_Guardar);
            this.groupBox1.Controls.Add(this.Btu_Modificar);
            this.groupBox1.Controls.Add(this.Btu_Nuevo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(116, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 68);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Btu_Cancelar
            // 
            this.Btu_Cancelar.Enabled = false;
            this.Btu_Cancelar.Location = new System.Drawing.Point(436, 16);
            this.Btu_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Btu_Cancelar.Name = "Btu_Cancelar";
            this.Btu_Cancelar.Size = new System.Drawing.Size(98, 38);
            this.Btu_Cancelar.TabIndex = 53;
            this.Btu_Cancelar.Text = "Cancelar";
            this.Btu_Cancelar.UseVisualStyleBackColor = true;
            this.Btu_Cancelar.Click += new System.EventHandler(this.Btu_Cancelar_Click);
            // 
            // Btu_Eliminar
            // 
            this.Btu_Eliminar.Location = new System.Drawing.Point(330, 16);
            this.Btu_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Btu_Eliminar.Name = "Btu_Eliminar";
            this.Btu_Eliminar.Size = new System.Drawing.Size(98, 38);
            this.Btu_Eliminar.TabIndex = 52;
            this.Btu_Eliminar.Text = "Eliminar";
            this.Btu_Eliminar.UseVisualStyleBackColor = true;
            // 
            // Btu_Guardar
            // 
            this.Btu_Guardar.Location = new System.Drawing.Point(224, 16);
            this.Btu_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btu_Guardar.Name = "Btu_Guardar";
            this.Btu_Guardar.Size = new System.Drawing.Size(98, 38);
            this.Btu_Guardar.TabIndex = 51;
            this.Btu_Guardar.Text = "Guardar";
            this.Btu_Guardar.UseVisualStyleBackColor = true;
            // 
            // Btu_Modificar
            // 
            this.Btu_Modificar.Location = new System.Drawing.Point(118, 16);
            this.Btu_Modificar.Margin = new System.Windows.Forms.Padding(4);
            this.Btu_Modificar.Name = "Btu_Modificar";
            this.Btu_Modificar.Size = new System.Drawing.Size(98, 38);
            this.Btu_Modificar.TabIndex = 50;
            this.Btu_Modificar.Text = "Modificar";
            this.Btu_Modificar.UseVisualStyleBackColor = true;
            // 
            // Btu_Nuevo
            // 
            this.Btu_Nuevo.Location = new System.Drawing.Point(12, 16);
            this.Btu_Nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.Btu_Nuevo.Name = "Btu_Nuevo";
            this.Btu_Nuevo.Size = new System.Drawing.Size(98, 38);
            this.Btu_Nuevo.TabIndex = 49;
            this.Btu_Nuevo.Text = "Nuevo";
            this.Btu_Nuevo.UseVisualStyleBackColor = true;
            // 
            // Txt_CapacidadAvion
            // 
            this.Txt_CapacidadAvion.Location = new System.Drawing.Point(171, 161);
            this.Txt_CapacidadAvion.Margin = new System.Windows.Forms.Padding(5);
            this.Txt_CapacidadAvion.Name = "Txt_CapacidadAvion";
            this.Txt_CapacidadAvion.Size = new System.Drawing.Size(116, 20);
            this.Txt_CapacidadAvion.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 89;
            this.label4.Text = "Capacidad del Avion:";
            // 
            // Cbx_EstadoAvion
            // 
            this.Cbx_EstadoAvion.FormattingEnabled = true;
            this.Cbx_EstadoAvion.Items.AddRange(new object[] {
            "Habilitado ",
            "Deshabilitado",
            "Suspendido",
            "En Espera",
            "Mantenimiento"});
            this.Cbx_EstadoAvion.Location = new System.Drawing.Point(171, 202);
            this.Cbx_EstadoAvion.Margin = new System.Windows.Forms.Padding(4);
            this.Cbx_EstadoAvion.Name = "Cbx_EstadoAvion";
            this.Cbx_EstadoAvion.Size = new System.Drawing.Size(373, 21);
            this.Cbx_EstadoAvion.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 87;
            this.label3.Text = "Estado del Avion:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 97;
            this.label5.Text = "ID Avion:";
            // 
            // Txt_Id
            // 
            this.Txt_Id.Location = new System.Drawing.Point(171, 90);
            this.Txt_Id.Margin = new System.Windows.Forms.Padding(5);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.ReadOnly = true;
            this.Txt_Id.Size = new System.Drawing.Size(116, 20);
            this.Txt_Id.TabIndex = 98;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Engravers MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(61, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(624, 34);
            this.label6.TabIndex = 99;
            this.label6.Text = "Especificaciones del Avion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AerolineaGrupo4.Properties.Resources.descuento;
            this.pictureBox1.Location = new System.Drawing.Point(623, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            // 
            // AvionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(766, 589);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_Id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cbx_SiglasAvion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cbx_ModeloAvion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuariosdatagriedviwe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Txt_CapacidadAvion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cbx_EstadoAvion);
            this.Controls.Add(this.label3);
            this.Name = "AvionView";
            this.Text = "AvionView";
            ((System.ComponentModel.ISupportInitialize)(this.usuariosdatagriedviwe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox Cbx_SiglasAvion;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox Cbx_ModeloAvion;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView usuariosdatagriedviwe;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button Btu_Cancelar;
        public System.Windows.Forms.Button Btu_Eliminar;
        public System.Windows.Forms.Button Btu_Guardar;
        public System.Windows.Forms.Button Btu_Modificar;
        public System.Windows.Forms.Button Btu_Nuevo;
        public System.Windows.Forms.TextBox Txt_CapacidadAvion;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox Cbx_EstadoAvion;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.TextBox Txt_Id;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}