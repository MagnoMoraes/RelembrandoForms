namespace WindowsFormsApp1
{
    partial class FormHome
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.buttonPlusExponential = new System.Windows.Forms.Button();
            this.buttonFull = new System.Windows.Forms.Button();
            this.buttonDerivative = new System.Windows.Forms.Button();
            this.buttonPlusMultiplicationExponential = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Location = new System.Drawing.Point(333, 395);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(141, 43);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Sair";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Times New Roman", 30F);
            this.title.Location = new System.Drawing.Point(182, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(460, 46);
            this.title.TabIndex = 2;
            this.title.Text = "Matemática Computacional";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonPlusExponential
            // 
            this.buttonPlusExponential.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlusExponential.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonPlusExponential.Location = new System.Drawing.Point(190, 120);
            this.buttonPlusExponential.Name = "buttonPlusExponential";
            this.buttonPlusExponential.Size = new System.Drawing.Size(152, 43);
            this.buttonPlusExponential.TabIndex = 3;
            this.buttonPlusExponential.Text = "(X + Y) ^ Z";
            this.buttonPlusExponential.UseVisualStyleBackColor = true;
            this.buttonPlusExponential.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonFull
            // 
            this.buttonFull.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFull.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonFull.Location = new System.Drawing.Point(472, 273);
            this.buttonFull.Name = "buttonFull";
            this.buttonFull.Size = new System.Drawing.Size(152, 43);
            this.buttonFull.TabIndex = 4;
            this.buttonFull.Text = "Integral de Y em X";
            this.buttonFull.UseVisualStyleBackColor = true;
            // 
            // buttonDerivative
            // 
            this.buttonDerivative.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDerivative.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonDerivative.Location = new System.Drawing.Point(472, 120);
            this.buttonDerivative.Name = "buttonDerivative";
            this.buttonDerivative.Size = new System.Drawing.Size(152, 43);
            this.buttonDerivative.TabIndex = 5;
            this.buttonDerivative.Text = "Derivada de Y em X";
            this.buttonDerivative.UseVisualStyleBackColor = true;
            // 
            // buttonPlusMultiplicationExponential
            // 
            this.buttonPlusMultiplicationExponential.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlusMultiplicationExponential.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonPlusMultiplicationExponential.Location = new System.Drawing.Point(190, 273);
            this.buttonPlusMultiplicationExponential.Name = "buttonPlusMultiplicationExponential";
            this.buttonPlusMultiplicationExponential.Size = new System.Drawing.Size(152, 43);
            this.buttonPlusMultiplicationExponential.TabIndex = 6;
            this.buttonPlusMultiplicationExponential.Text = "TXZ + TZ^2";
            this.buttonPlusMultiplicationExponential.UseVisualStyleBackColor = true;
            this.buttonPlusMultiplicationExponential.Click += new System.EventHandler(this.buttonPlusMultiplicationExponential_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.ControlBox = false;
            this.Controls.Add(this.buttonPlusMultiplicationExponential);
            this.Controls.Add(this.buttonDerivative);
            this.Controls.Add(this.buttonFull);
            this.Controls.Add(this.buttonPlusExponential);
            this.Controls.Add(this.title);
            this.Controls.Add(this.buttonExit);
            this.MaximumSize = new System.Drawing.Size(820, 500);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "FormHome";
            this.ShowIcon = false;
            this.Text = "Relembrando Forms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button buttonPlusExponential;
        private System.Windows.Forms.Button buttonFull;
        private System.Windows.Forms.Button buttonDerivative;
        private System.Windows.Forms.Button buttonPlusMultiplicationExponential;
    }
}

