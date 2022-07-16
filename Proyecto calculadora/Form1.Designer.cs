namespace Proyecto_calculadora
{
    partial class Form1 : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btncoma = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.btndivision = new System.Windows.Forms.Button();
            this.btnmultiplicacion = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnporcentaje = new System.Windows.Forms.Button();
            this.btnlimpieza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDisplay
            // 
            this.tbDisplay.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbDisplay.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tbDisplay.Cursor = System.Windows.Forms.Cursors.No;
            this.tbDisplay.Font = new System.Drawing.Font("ROBO", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDisplay.ForeColor = System.Drawing.Color.Blue;
            this.tbDisplay.Location = new System.Drawing.Point(51, 46);
            this.tbDisplay.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbDisplay.Size = new System.Drawing.Size(399, 57);
            this.tbDisplay.TabIndex = 0;
            this.tbDisplay.TextChanged += new System.EventHandler(this.tbDisplay_TextChanged);
            // 
            // btn7
            // 
            this.btn7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn7.BackgroundImage")));
            this.btn7.Location = new System.Drawing.Point(51, 104);
            this.btn7.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(80, 43);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn8.BackgroundImage")));
            this.btn8.Location = new System.Drawing.Point(131, 104);
            this.btn8.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(80, 43);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn9.BackgroundImage")));
            this.btn9.Location = new System.Drawing.Point(211, 104);
            this.btn9.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(80, 43);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn4
            // 
            this.btn4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn4.BackgroundImage")));
            this.btn4.Location = new System.Drawing.Point(51, 147);
            this.btn4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(80, 43);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn5.BackgroundImage")));
            this.btn5.Location = new System.Drawing.Point(131, 147);
            this.btn5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(80, 43);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn6.BackgroundImage")));
            this.btn6.Location = new System.Drawing.Point(211, 147);
            this.btn6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(80, 43);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn1
            // 
            this.btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1.BackgroundImage")));
            this.btn1.Location = new System.Drawing.Point(51, 189);
            this.btn1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(80, 43);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn2.BackgroundImage")));
            this.btn2.Location = new System.Drawing.Point(131, 189);
            this.btn2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(80, 43);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn3.BackgroundImage")));
            this.btn3.Location = new System.Drawing.Point(211, 189);
            this.btn3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(80, 43);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btncoma
            // 
            this.btncoma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncoma.BackgroundImage")));
            this.btncoma.Font = new System.Drawing.Font("Days", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncoma.Location = new System.Drawing.Point(51, 232);
            this.btncoma.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btncoma.Name = "btncoma";
            this.btncoma.Size = new System.Drawing.Size(80, 43);
            this.btncoma.TabIndex = 10;
            this.btncoma.Text = ".";
            this.btncoma.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn0.BackgroundImage")));
            this.btn0.Location = new System.Drawing.Point(131, 232);
            this.btn0.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(80, 43);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnigual
            // 
            this.btnigual.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnigual.BackgroundImage")));
            this.btnigual.Location = new System.Drawing.Point(211, 232);
            this.btnigual.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(80, 43);
            this.btnigual.TabIndex = 12;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = true;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // btndivision
            // 
            this.btndivision.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndivision.BackgroundImage")));
            this.btndivision.Location = new System.Drawing.Point(291, 104);
            this.btndivision.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(80, 43);
            this.btndivision.TabIndex = 13;
            this.btndivision.Text = "/";
            this.btndivision.UseVisualStyleBackColor = true;
            // 
            // btnmultiplicacion
            // 
            this.btnmultiplicacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmultiplicacion.BackgroundImage")));
            this.btnmultiplicacion.Font = new System.Drawing.Font("ROBO", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiplicacion.Location = new System.Drawing.Point(291, 147);
            this.btnmultiplicacion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnmultiplicacion.Name = "btnmultiplicacion";
            this.btnmultiplicacion.Size = new System.Drawing.Size(80, 43);
            this.btnmultiplicacion.TabIndex = 14;
            this.btnmultiplicacion.Text = "*";
            this.btnmultiplicacion.UseVisualStyleBackColor = true;
            // 
            // btnresta
            // 
            this.btnresta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnresta.BackgroundImage")));
            this.btnresta.Location = new System.Drawing.Point(291, 189);
            this.btnresta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(80, 43);
            this.btnresta.TabIndex = 15;
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = true;
            // 
            // btnsuma
            // 
            this.btnsuma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsuma.BackgroundImage")));
            this.btnsuma.Font = new System.Drawing.Font("ROBO", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuma.Location = new System.Drawing.Point(291, 232);
            this.btnsuma.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(80, 43);
            this.btnsuma.TabIndex = 16;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            // 
            // btnporcentaje
            // 
            this.btnporcentaje.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnporcentaje.BackgroundImage")));
            this.btnporcentaje.Font = new System.Drawing.Font("ROBO", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnporcentaje.Location = new System.Drawing.Point(370, 104);
            this.btnporcentaje.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnporcentaje.Name = "btnporcentaje";
            this.btnporcentaje.Size = new System.Drawing.Size(80, 43);
            this.btnporcentaje.TabIndex = 17;
            this.btnporcentaje.Text = "%";
            this.btnporcentaje.UseVisualStyleBackColor = true;
            // 
            // btnlimpieza
            // 
            this.btnlimpieza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlimpieza.BackgroundImage")));
            this.btnlimpieza.Font = new System.Drawing.Font("ROBO", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpieza.Location = new System.Drawing.Point(371, 147);
            this.btnlimpieza.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnlimpieza.Name = "btnlimpieza";
            this.btnlimpieza.Size = new System.Drawing.Size(79, 128);
            this.btnlimpieza.TabIndex = 18;
            this.btnlimpieza.Text = "C";
            this.btnlimpieza.UseVisualStyleBackColor = true;
            this.btnlimpieza.Click += new System.EventHandler(this.button17_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(517, 321);
            this.Controls.Add(this.btnlimpieza);
            this.Controls.Add(this.btnporcentaje);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btnmultiplicacion);
            this.Controls.Add(this.btndivision);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btncoma);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.tbDisplay);
            this.Font = new System.Drawing.Font("ROBO", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btncoma;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.Button btndivision;
        private System.Windows.Forms.Button btnmultiplicacion;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnporcentaje;
        private System.Windows.Forms.Button btnlimpieza;
    }
}

