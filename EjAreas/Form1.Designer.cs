
namespace EjAreas
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
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.labelBase = new System.Windows.Forms.Label();
            this.labelAltura = new System.Windows.Forms.Label();
            this.labelRadio = new System.Windows.Forms.Label();
            this.rbntRectangulo = new System.Windows.Forms.RadioButton();
            this.rbtnTriangulo = new System.Windows.Forms.RadioButton();
            this.rbtnCirculo = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.labelArea = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(219, 84);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 0;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(219, 150);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 1;
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(219, 217);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 20);
            this.txtRadio.TabIndex = 2;
            // 
            // labelBase
            // 
            this.labelBase.AutoSize = true;
            this.labelBase.Location = new System.Drawing.Point(76, 84);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(31, 13);
            this.labelBase.TabIndex = 3;
            this.labelBase.Text = "Base";
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Location = new System.Drawing.Point(79, 162);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(34, 13);
            this.labelAltura.TabIndex = 4;
            this.labelAltura.Text = "Altura";
            // 
            // labelRadio
            // 
            this.labelRadio.AutoSize = true;
            this.labelRadio.Location = new System.Drawing.Point(75, 223);
            this.labelRadio.Name = "labelRadio";
            this.labelRadio.Size = new System.Drawing.Size(35, 13);
            this.labelRadio.TabIndex = 5;
            this.labelRadio.Text = "Radio";
            // 
            // rbntRectangulo
            // 
            this.rbntRectangulo.AutoSize = true;
            this.rbntRectangulo.Location = new System.Drawing.Point(633, 79);
            this.rbntRectangulo.Name = "rbntRectangulo";
            this.rbntRectangulo.Size = new System.Drawing.Size(80, 17);
            this.rbntRectangulo.TabIndex = 6;
            this.rbntRectangulo.TabStop = true;
            this.rbntRectangulo.Text = "Rectángulo";
            this.rbntRectangulo.UseVisualStyleBackColor = true;
            this.rbntRectangulo.CheckedChanged += new System.EventHandler(this.rbntRectangulo_CheckedChanged);
            // 
            // rbtnTriangulo
            // 
            this.rbtnTriangulo.AutoSize = true;
            this.rbtnTriangulo.Location = new System.Drawing.Point(633, 130);
            this.rbtnTriangulo.Name = "rbtnTriangulo";
            this.rbtnTriangulo.Size = new System.Drawing.Size(69, 17);
            this.rbtnTriangulo.TabIndex = 7;
            this.rbtnTriangulo.TabStop = true;
            this.rbtnTriangulo.Text = "Triángulo";
            this.rbtnTriangulo.UseVisualStyleBackColor = true;
            this.rbtnTriangulo.CheckedChanged += new System.EventHandler(this.rbtnTriangulo_CheckedChanged);
            // 
            // rbtnCirculo
            // 
            this.rbtnCirculo.AutoSize = true;
            this.rbtnCirculo.Location = new System.Drawing.Point(633, 191);
            this.rbtnCirculo.Name = "rbtnCirculo";
            this.rbtnCirculo.Size = new System.Drawing.Size(57, 17);
            this.rbtnCirculo.TabIndex = 8;
            this.rbtnCirculo.TabStop = true;
            this.rbtnCirculo.Text = "Circulo";
            this.rbtnCirculo.UseVisualStyleBackColor = true;
            this.rbtnCirculo.CheckedChanged += new System.EventHandler(this.rbtnCirculo_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(633, 347);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(78, 347);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(29, 13);
            this.labelArea.TabIndex = 10;
            this.labelArea.Text = "Área";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(219, 347);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rbtnCirculo);
            this.Controls.Add(this.rbtnTriangulo);
            this.Controls.Add(this.rbntRectangulo);
            this.Controls.Add(this.labelRadio);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.labelBase);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Label labelBase;
        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.Label labelRadio;
        private System.Windows.Forms.RadioButton rbntRectangulo;
        private System.Windows.Forms.RadioButton rbtnTriangulo;
        private System.Windows.Forms.RadioButton rbtnCirculo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.TextBox txtArea;
    }
}

