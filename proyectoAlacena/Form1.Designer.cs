namespace proyectoAlacena
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this._panel_Menu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_consulta = new System.Windows.Forms.Button();
            this.button_registro = new System.Windows.Forms.Button();
            this.button_receta = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this._panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _panel_Menu
            // 
            this._panel_Menu.Controls.Add(this.button_receta);
            this._panel_Menu.Controls.Add(this.button_registro);
            this._panel_Menu.Controls.Add(this.button_consulta);
            this._panel_Menu.Location = new System.Drawing.Point(12, 9);
            this._panel_Menu.Name = "_panel_Menu";
            this._panel_Menu.Size = new System.Drawing.Size(344, 383);
            this._panel_Menu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(390, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 162);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de control\r\nde inventarios\r\nde alacena";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = global::proyectoAlacena.Properties.Resources.images1;
            this.pictureBox1.InitialImage = global::proyectoAlacena.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(417, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 160);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button_consulta
            // 
            this.button_consulta.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.button_consulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_consulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_consulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_consulta.Location = new System.Drawing.Point(18, 13);
            this.button_consulta.Name = "button_consulta";
            this.button_consulta.Size = new System.Drawing.Size(313, 65);
            this.button_consulta.TabIndex = 0;
            this.button_consulta.Text = "Consulta de inventario";
            this.button_consulta.UseVisualStyleBackColor = true;
            this.button_consulta.Click += new System.EventHandler(this.button_consulta_Click);
            // 
            // button_registro
            // 
            this.button_registro.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.button_registro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_registro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_registro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_registro.Location = new System.Drawing.Point(18, 97);
            this.button_registro.Name = "button_registro";
            this.button_registro.Size = new System.Drawing.Size(313, 65);
            this.button_registro.TabIndex = 1;
            this.button_registro.Text = "Registrar";
            this.button_registro.UseVisualStyleBackColor = true;
            // 
            // button_receta
            // 
            this.button_receta.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.button_receta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_receta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_receta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_receta.Location = new System.Drawing.Point(18, 185);
            this.button_receta.Name = "button_receta";
            this.button_receta.Size = new System.Drawing.Size(313, 65);
            this.button_receta.TabIndex = 2;
            this.button_receta.Text = "Receta";
            this.button_receta.UseVisualStyleBackColor = true;
            // 
            // button_home
            // 
            this.button_home.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_home.BackgroundImage")));
            this.button_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_home.FlatAppearance.BorderSize = 0;
            this.button_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.Location = new System.Drawing.Point(681, 12);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(61, 38);
            this.button_home.TabIndex = 13;
            this.button_home.UseVisualStyleBackColor = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(754, 432);
            this.Controls.Add(this.button_home);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._panel_Menu);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Sistema de control de inventarios de Alacena";
            this._panel_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel _panel_Menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_receta;
        private System.Windows.Forms.Button button_registro;
        private System.Windows.Forms.Button button_consulta;
        private System.Windows.Forms.Button button_home;
    }
}

