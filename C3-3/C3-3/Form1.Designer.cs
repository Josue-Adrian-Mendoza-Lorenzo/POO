namespace C3_3
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtInicial = new System.Windows.Forms.TextBox();
            this.cbElegir = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSecundario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDecripcion2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(393, 23);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "&Convertidor";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtInicial
            // 
            this.txtInicial.Location = new System.Drawing.Point(12, 26);
            this.txtInicial.Name = "txtInicial";
            this.txtInicial.Size = new System.Drawing.Size(121, 20);
            this.txtInicial.TabIndex = 1;
            // 
            // cbElegir
            // 
            this.cbElegir.FormattingEnabled = true;
            this.cbElegir.Items.AddRange(new object[] {
            "Temperatura",
            "Medidas",
            "Divisas"});
            this.cbElegir.Location = new System.Drawing.Point(266, 25);
            this.cbElegir.Name = "cbElegir";
            this.cbElegir.Size = new System.Drawing.Size(121, 21);
            this.cbElegir.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dato Inicial";
            // 
            // txtSecundario
            // 
            this.txtSecundario.Location = new System.Drawing.Point(139, 26);
            this.txtSecundario.Name = "txtSecundario";
            this.txtSecundario.Size = new System.Drawing.Size(121, 20);
            this.txtSecundario.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dato Secundario";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 78);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 13);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "0";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 65);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(45, 13);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Nota 2: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo de conversión:";
            // 
            // lblDecripcion2
            // 
            this.lblDecripcion2.AutoSize = true;
            this.lblDecripcion2.Location = new System.Drawing.Point(12, 52);
            this.lblDecripcion2.Name = "lblDecripcion2";
            this.lblDecripcion2.Size = new System.Drawing.Size(42, 13);
            this.lblDecripcion2.TabIndex = 9;
            this.lblDecripcion2.Text = "Nota 1:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 119);
            this.Controls.Add(this.lblDecripcion2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSecundario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbElegir);
            this.Controls.Add(this.txtInicial);
            this.Controls.Add(this.btnEnviar);
            this.Name = "Form1";
            this.Text = "Convertidor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtInicial;
        private System.Windows.Forms.ComboBox cbElegir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSecundario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDecripcion2;
    }
}

