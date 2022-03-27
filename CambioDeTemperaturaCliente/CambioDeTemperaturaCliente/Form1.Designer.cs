namespace CambioDeTemperaturaCliente
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
            this.Temperatura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CelToFaren = new System.Windows.Forms.RadioButton();
            this.FarengtoCel = new System.Windows.Forms.RadioButton();
            this.DesconectarBtn = new System.Windows.Forms.Button();
            this.ConectarBtn = new System.Windows.Forms.Button();
            this.ConvertirBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Temperatura
            // 
            this.Temperatura.Location = new System.Drawing.Point(48, 73);
            this.Temperatura.Name = "Temperatura";
            this.Temperatura.Size = new System.Drawing.Size(198, 26);
            this.Temperatura.TabIndex = 0;
            this.Temperatura.TextChanged += new System.EventHandler(this.Temperatura_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temperatura:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CelToFaren
            // 
            this.CelToFaren.AutoSize = true;
            this.CelToFaren.Location = new System.Drawing.Point(379, 39);
            this.CelToFaren.Name = "CelToFaren";
            this.CelToFaren.Size = new System.Drawing.Size(267, 24);
            this.CelToFaren.TabIndex = 3;
            this.CelToFaren.TabStop = true;
            this.CelToFaren.Text = "Convertir de Celsius a Farenheits";
            this.CelToFaren.UseVisualStyleBackColor = true;
            this.CelToFaren.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // FarengtoCel
            // 
            this.FarengtoCel.AutoSize = true;
            this.FarengtoCel.Location = new System.Drawing.Point(379, 84);
            this.FarengtoCel.Name = "FarengtoCel";
            this.FarengtoCel.Size = new System.Drawing.Size(267, 24);
            this.FarengtoCel.TabIndex = 4;
            this.FarengtoCel.TabStop = true;
            this.FarengtoCel.Text = "Convertir de Farenheits a Celsius";
            this.FarengtoCel.UseVisualStyleBackColor = true;
            this.FarengtoCel.CheckedChanged += new System.EventHandler(this.CF_CheckedChanged);
            // 
            // DesconectarBtn
            // 
            this.DesconectarBtn.Location = new System.Drawing.Point(170, 116);
            this.DesconectarBtn.Name = "DesconectarBtn";
            this.DesconectarBtn.Size = new System.Drawing.Size(116, 60);
            this.DesconectarBtn.TabIndex = 5;
            this.DesconectarBtn.Text = "Desconectar";
            this.DesconectarBtn.UseVisualStyleBackColor = true;
            this.DesconectarBtn.Click += new System.EventHandler(this.DesconectarBtn_Click);
            // 
            // ConectarBtn
            // 
            this.ConectarBtn.Location = new System.Drawing.Point(48, 117);
            this.ConectarBtn.Name = "ConectarBtn";
            this.ConectarBtn.Size = new System.Drawing.Size(116, 60);
            this.ConectarBtn.TabIndex = 6;
            this.ConectarBtn.Text = "Conectar";
            this.ConectarBtn.UseVisualStyleBackColor = true;
            this.ConectarBtn.Click += new System.EventHandler(this.ConectarBtn_Click);
            // 
            // ConvertirBtn
            // 
            this.ConvertirBtn.Location = new System.Drawing.Point(379, 132);
            this.ConvertirBtn.Name = "ConvertirBtn";
            this.ConvertirBtn.Size = new System.Drawing.Size(267, 44);
            this.ConvertirBtn.TabIndex = 7;
            this.ConvertirBtn.Text = "Convertir";
            this.ConvertirBtn.UseVisualStyleBackColor = true;
            this.ConvertirBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 189);
            this.Controls.Add(this.ConvertirBtn);
            this.Controls.Add(this.ConectarBtn);
            this.Controls.Add(this.DesconectarBtn);
            this.Controls.Add(this.FarengtoCel);
            this.Controls.Add(this.CelToFaren);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Temperatura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Temperatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton CelToFaren;
        private System.Windows.Forms.RadioButton FarengtoCel;
        private System.Windows.Forms.Button DesconectarBtn;
        private System.Windows.Forms.Button ConectarBtn;
        private System.Windows.Forms.Button ConvertirBtn;
    }
}

