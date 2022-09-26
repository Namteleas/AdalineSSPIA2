
namespace Adaline
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
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownError = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownLR = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEpocas = new System.Windows.Forms.NumericUpDown();
            this.buttonReg = new System.Windows.Forms.Button();
            this.buttonClas = new System.Windows.Forms.Button();
            this.buttonPesos = new System.Windows.Forms.Button();
            this.listBoxEntradas = new System.Windows.Forms.ListBox();
            this.labelW0 = new System.Windows.Forms.Label();
            this.labelW1 = new System.Windows.Forms.Label();
            this.labelW2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEpocas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCanvas
            // 
            this.pictureBoxCanvas.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCanvas.TabIndex = 0;
            this.pictureBoxCanvas.TabStop = false;
            this.pictureBoxCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCanvas_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDownError);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownLR);
            this.groupBox1.Controls.Add(this.numericUpDownEpocas);
            this.groupBox1.Controls.Add(this.buttonReg);
            this.groupBox1.Controls.Add(this.buttonClas);
            this.groupBox1.Controls.Add(this.buttonPesos);
            this.groupBox1.Location = new System.Drawing.Point(545, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 177);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Error";
            // 
            // numericUpDownError
            // 
            this.numericUpDownError.DecimalPlaces = 2;
            this.numericUpDownError.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownError.Location = new System.Drawing.Point(119, 139);
            this.numericUpDownError.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownError.Name = "numericUpDownError";
            this.numericUpDownError.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownError.TabIndex = 7;
            this.numericUpDownError.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "LR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "No. de Epocas";
            // 
            // numericUpDownLR
            // 
            this.numericUpDownLR.DecimalPlaces = 1;
            this.numericUpDownLR.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownLR.Location = new System.Drawing.Point(119, 112);
            this.numericUpDownLR.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLR.Name = "numericUpDownLR";
            this.numericUpDownLR.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownLR.TabIndex = 4;
            this.numericUpDownLR.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            this.numericUpDownLR.ValueChanged += new System.EventHandler(this.numericUpDownLR_ValueChanged);
            // 
            // numericUpDownEpocas
            // 
            this.numericUpDownEpocas.Location = new System.Drawing.Point(119, 86);
            this.numericUpDownEpocas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEpocas.Name = "numericUpDownEpocas";
            this.numericUpDownEpocas.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownEpocas.TabIndex = 3;
            this.numericUpDownEpocas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonReg
            // 
            this.buttonReg.Location = new System.Drawing.Point(119, 48);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(75, 23);
            this.buttonReg.TabIndex = 2;
            this.buttonReg.Text = "Regresión";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonReg_MouseClick);
            // 
            // buttonClas
            // 
            this.buttonClas.Location = new System.Drawing.Point(119, 19);
            this.buttonClas.Name = "buttonClas";
            this.buttonClas.Size = new System.Drawing.Size(75, 23);
            this.buttonClas.TabIndex = 1;
            this.buttonClas.Text = "Clasificación";
            this.buttonClas.UseVisualStyleBackColor = true;
            this.buttonClas.Click += new System.EventHandler(this.buttonClas_Click);
            // 
            // buttonPesos
            // 
            this.buttonPesos.Location = new System.Drawing.Point(16, 19);
            this.buttonPesos.Name = "buttonPesos";
            this.buttonPesos.Size = new System.Drawing.Size(75, 23);
            this.buttonPesos.TabIndex = 0;
            this.buttonPesos.Text = "Pesos";
            this.buttonPesos.UseVisualStyleBackColor = true;
            this.buttonPesos.Click += new System.EventHandler(this.buttonPesos_Click);
            // 
            // listBoxEntradas
            // 
            this.listBoxEntradas.FormattingEnabled = true;
            this.listBoxEntradas.Location = new System.Drawing.Point(545, 287);
            this.listBoxEntradas.Name = "listBoxEntradas";
            this.listBoxEntradas.Size = new System.Drawing.Size(209, 225);
            this.listBoxEntradas.TabIndex = 2;
            // 
            // labelW0
            // 
            this.labelW0.AutoSize = true;
            this.labelW0.Location = new System.Drawing.Point(590, 211);
            this.labelW0.MaximumSize = new System.Drawing.Size(150, 13);
            this.labelW0.Name = "labelW0";
            this.labelW0.Size = new System.Drawing.Size(24, 13);
            this.labelW0.TabIndex = 3;
            this.labelW0.Text = "W0";
            // 
            // labelW1
            // 
            this.labelW1.AutoSize = true;
            this.labelW1.Location = new System.Drawing.Point(590, 237);
            this.labelW1.MaximumSize = new System.Drawing.Size(150, 13);
            this.labelW1.Name = "labelW1";
            this.labelW1.Size = new System.Drawing.Size(24, 13);
            this.labelW1.TabIndex = 4;
            this.labelW1.Text = "W1";
            // 
            // labelW2
            // 
            this.labelW2.AutoSize = true;
            this.labelW2.Location = new System.Drawing.Point(590, 262);
            this.labelW2.MaximumSize = new System.Drawing.Size(150, 13);
            this.labelW2.Name = "labelW2";
            this.labelW2.Size = new System.Drawing.Size(24, 13);
            this.labelW2.TabIndex = 5;
            this.labelW2.Text = "W2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 525);
            this.Controls.Add(this.labelW2);
            this.Controls.Add(this.labelW1);
            this.Controls.Add(this.labelW0);
            this.Controls.Add(this.listBoxEntradas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxCanvas);
            this.Name = "Form1";
            this.Text = "Adaline";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEpocas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCanvas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownLR;
        private System.Windows.Forms.NumericUpDown numericUpDownEpocas;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Button buttonClas;
        private System.Windows.Forms.Button buttonPesos;
        private System.Windows.Forms.ListBox listBoxEntradas;
        private System.Windows.Forms.Label labelW0;
        private System.Windows.Forms.Label labelW1;
        private System.Windows.Forms.Label labelW2;
    }
}

