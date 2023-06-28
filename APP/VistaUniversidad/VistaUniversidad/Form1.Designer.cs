namespace VistaUniversidad
{
    partial class Form1
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
            this.btnguarda = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTId = new System.Windows.Forms.TextBox();
            this.TXTnombre = new System.Windows.Forms.TextBox();
            this.TXTapellido = new System.Windows.Forms.TextBox();
            this.TXTtelefono = new System.Windows.Forms.TextBox();
            this.TXTedad = new System.Windows.Forms.TextBox();
            this.dgwdatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnguarda
            // 
            this.btnguarda.Location = new System.Drawing.Point(387, 35);
            this.btnguarda.Name = "btnguarda";
            this.btnguarda.Size = new System.Drawing.Size(75, 23);
            this.btnguarda.TabIndex = 0;
            this.btnguarda.Text = "GUARDAR";
            this.btnguarda.UseVisualStyleBackColor = true;
            this.btnguarda.Click += new System.EventHandler(this.button1_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(387, 92);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 1;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(387, 146);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 2;
            this.btnmodificar.Text = "MODIFICAR";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(387, 194);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(75, 23);
            this.btnconsultar.TabIndex = 3;
            this.btnconsultar.Text = "CONSULTAR";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Identificación";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = " Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = " Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Edad";
            // 
            // TXTId
            // 
            this.TXTId.Location = new System.Drawing.Point(166, 32);
            this.TXTId.Name = "TXTId";
            this.TXTId.Size = new System.Drawing.Size(100, 20);
            this.TXTId.TabIndex = 9;
            // 
            // TXTnombre
            // 
            this.TXTnombre.Location = new System.Drawing.Point(166, 67);
            this.TXTnombre.Name = "TXTnombre";
            this.TXTnombre.Size = new System.Drawing.Size(100, 20);
            this.TXTnombre.TabIndex = 10;
            this.TXTnombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TXTapellido
            // 
            this.TXTapellido.Location = new System.Drawing.Point(166, 113);
            this.TXTapellido.Name = "TXTapellido";
            this.TXTapellido.Size = new System.Drawing.Size(100, 20);
            this.TXTapellido.TabIndex = 11;
            // 
            // TXTtelefono
            // 
            this.TXTtelefono.Location = new System.Drawing.Point(166, 156);
            this.TXTtelefono.Name = "TXTtelefono";
            this.TXTtelefono.Size = new System.Drawing.Size(100, 20);
            this.TXTtelefono.TabIndex = 12;
            // 
            // TXTedad
            // 
            this.TXTedad.Location = new System.Drawing.Point(166, 194);
            this.TXTedad.Name = "TXTedad";
            this.TXTedad.Size = new System.Drawing.Size(100, 20);
            this.TXTedad.TabIndex = 13;
            // 
            // dgwdatos
            // 
            this.dgwdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwdatos.Location = new System.Drawing.Point(23, 273);
            this.dgwdatos.Name = "dgwdatos";
            this.dgwdatos.Size = new System.Drawing.Size(719, 150);
            this.dgwdatos.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 454);
            this.Controls.Add(this.dgwdatos);
            this.Controls.Add(this.TXTedad);
            this.Controls.Add(this.TXTtelefono);
            this.Controls.Add(this.TXTapellido);
            this.Controls.Add(this.TXTnombre);
            this.Controls.Add(this.TXTId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguarda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwdatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnguarda;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTId;
        private System.Windows.Forms.TextBox TXTnombre;
        private System.Windows.Forms.TextBox TXTapellido;
        private System.Windows.Forms.TextBox TXTtelefono;
        private System.Windows.Forms.TextBox TXTedad;
        private System.Windows.Forms.DataGridView dgwdatos;
    }
}

