namespace proyectoAlacena
{
    partial class FormVerInventario
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
            this.dataGridViewInventario = new System.Windows.Forms.DataGridView();
            this.groupBoxBusqueda = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_salida = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_entrada = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_tipo_alimento = new System.Windows.Forms.TextBox();
            this.label_tipo = new System.Windows.Forms.Label();
            this.textBox_nombre_prodcuto = new System.Windows.Forms.TextBox();
            this.label_nombre = new System.Windows.Forms.Label();
            this.comboBox_filtro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventario)).BeginInit();
            this.groupBoxBusqueda.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewInventario
            // 
            this.dataGridViewInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventario.Location = new System.Drawing.Point(357, 81);
            this.dataGridViewInventario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewInventario.Name = "dataGridViewInventario";
            this.dataGridViewInventario.Size = new System.Drawing.Size(484, 347);
            this.dataGridViewInventario.TabIndex = 4;
            // 
            // groupBoxBusqueda
            // 
            this.groupBoxBusqueda.Controls.Add(this.label3);
            this.groupBoxBusqueda.Controls.Add(this.comboBox_filtro);
            this.groupBoxBusqueda.Controls.Add(this.dateTimePicker_salida);
            this.groupBoxBusqueda.Controls.Add(this.dateTimePicker_entrada);
            this.groupBoxBusqueda.Controls.Add(this.label1);
            this.groupBoxBusqueda.Controls.Add(this.label2);
            this.groupBoxBusqueda.Controls.Add(this.textBox_tipo_alimento);
            this.groupBoxBusqueda.Controls.Add(this.label_tipo);
            this.groupBoxBusqueda.Controls.Add(this.textBox_nombre_prodcuto);
            this.groupBoxBusqueda.Controls.Add(this.label_nombre);
            this.groupBoxBusqueda.Location = new System.Drawing.Point(4, 19);
            this.groupBoxBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxBusqueda.Name = "groupBoxBusqueda";
            this.groupBoxBusqueda.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxBusqueda.Size = new System.Drawing.Size(346, 409);
            this.groupBoxBusqueda.TabIndex = 5;
            this.groupBoxBusqueda.TabStop = false;
            this.groupBoxBusqueda.Text = "Búsqueda de productos";
            // 
            // dateTimePicker_salida
            // 
            this.dateTimePicker_salida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker_salida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_salida.Location = new System.Drawing.Point(167, 149);
            this.dateTimePicker_salida.Name = "dateTimePicker_salida";
            this.dateTimePicker_salida.Size = new System.Drawing.Size(154, 29);
            this.dateTimePicker_salida.TabIndex = 9;
            // 
            // dateTimePicker_entrada
            // 
            this.dateTimePicker_entrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_entrada.Location = new System.Drawing.Point(8, 149);
            this.dateTimePicker_entrada.Name = "dateTimePicker_entrada";
            this.dateTimePicker_entrada.Size = new System.Drawing.Size(153, 29);
            this.dateTimePicker_entrada.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha de entrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha de salida";
            // 
            // textBox_tipo_alimento
            // 
            this.textBox_tipo_alimento.Location = new System.Drawing.Point(167, 73);
            this.textBox_tipo_alimento.Name = "textBox_tipo_alimento";
            this.textBox_tipo_alimento.Size = new System.Drawing.Size(154, 29);
            this.textBox_tipo_alimento.TabIndex = 7;
            // 
            // label_tipo
            // 
            this.label_tipo.AutoSize = true;
            this.label_tipo.Location = new System.Drawing.Point(163, 49);
            this.label_tipo.Name = "label_tipo";
            this.label_tipo.Size = new System.Drawing.Size(99, 21);
            this.label_tipo.TabIndex = 6;
            this.label_tipo.Text = "Clasificación:";
            // 
            // textBox_nombre_prodcuto
            // 
            this.textBox_nombre_prodcuto.Location = new System.Drawing.Point(7, 73);
            this.textBox_nombre_prodcuto.Name = "textBox_nombre_prodcuto";
            this.textBox_nombre_prodcuto.Size = new System.Drawing.Size(154, 29);
            this.textBox_nombre_prodcuto.TabIndex = 1;
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(8, 49);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(71, 21);
            this.label_nombre.TabIndex = 0;
            this.label_nombre.Text = "Nombre:";
            // 
            // comboBox_filtro
            // 
            this.comboBox_filtro.FormattingEnabled = true;
            this.comboBox_filtro.Location = new System.Drawing.Point(167, 208);
            this.comboBox_filtro.Name = "comboBox_filtro";
            this.comboBox_filtro.Size = new System.Drawing.Size(154, 29);
            this.comboBox_filtro.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Filtrar por:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox2.Location = new System.Drawing.Point(357, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 60);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Códigos de colores:";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(344, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 30);
            this.button3.TabIndex = 0;
            this.button3.Text = "Pendiente";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.YellowGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(142, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 30);
            this.button2.TabIndex = 0;
            this.button2.Text = "Completado";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Verificado";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormVerInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(855, 452);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxBusqueda);
            this.Controls.Add(this.dataGridViewInventario);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormVerInventario";
            this.Text = "FormVerInventario";
            this.Load += new System.EventHandler(this.FormVerInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventario)).EndInit();
            this.groupBoxBusqueda.ResumeLayout(false);
            this.groupBoxBusqueda.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInventario;
        private System.Windows.Forms.GroupBox groupBoxBusqueda;
        private System.Windows.Forms.DateTimePicker dateTimePicker_salida;
        private System.Windows.Forms.DateTimePicker dateTimePicker_entrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_tipo_alimento;
        private System.Windows.Forms.Label label_tipo;
        private System.Windows.Forms.TextBox textBox_nombre_prodcuto;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_filtro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}