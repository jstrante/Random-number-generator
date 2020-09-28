namespace Random_number_generator
{
    partial class Form1
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
            this.Redbulb = new System.Windows.Forms.PictureBox();
            this.Bluebulb = new System.Windows.Forms.PictureBox();
            this.Greenbulb = new System.Windows.Forms.PictureBox();
            this.SetColor = new System.Windows.Forms.Button();
            this.RedValue = new System.Windows.Forms.TextBox();
            this.BlueValue = new System.Windows.Forms.TextBox();
            this.GreenValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Redbulb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bluebulb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greenbulb)).BeginInit();
            this.SuspendLayout();
            // 
            // Redbulb
            // 
            this.Redbulb.Location = new System.Drawing.Point(81, 106);
            this.Redbulb.Name = "Redbulb";
            this.Redbulb.Size = new System.Drawing.Size(140, 140);
            this.Redbulb.TabIndex = 0;
            this.Redbulb.TabStop = false;
            // 
            // Bluebulb
            // 
            this.Bluebulb.Location = new System.Drawing.Point(252, 106);
            this.Bluebulb.Name = "Bluebulb";
            this.Bluebulb.Size = new System.Drawing.Size(140, 140);
            this.Bluebulb.TabIndex = 1;
            this.Bluebulb.TabStop = false;
            // 
            // Greenbulb
            // 
            this.Greenbulb.Location = new System.Drawing.Point(422, 106);
            this.Greenbulb.Name = "Greenbulb";
            this.Greenbulb.Size = new System.Drawing.Size(140, 140);
            this.Greenbulb.TabIndex = 2;
            this.Greenbulb.TabStop = false;
            // 
            // SetColor
            // 
            this.SetColor.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetColor.Location = new System.Drawing.Point(129, 279);
            this.SetColor.Name = "SetColor";
            this.SetColor.Size = new System.Drawing.Size(380, 78);
            this.SetColor.TabIndex = 3;
            this.SetColor.Text = "SetColorsButton";
            this.SetColor.UseVisualStyleBackColor = true;
            this.SetColor.Click += new System.EventHandler(this.SetColor_Click);
            // 
            // RedValue
            // 
            this.RedValue.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedValue.Location = new System.Drawing.Point(99, 71);
            this.RedValue.Name = "RedValue";
            this.RedValue.Size = new System.Drawing.Size(100, 29);
            this.RedValue.TabIndex = 4;
            this.RedValue.Text = "255";
            // 
            // BlueValue
            // 
            this.BlueValue.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueValue.Location = new System.Drawing.Point(274, 71);
            this.BlueValue.Name = "BlueValue";
            this.BlueValue.Size = new System.Drawing.Size(100, 29);
            this.BlueValue.TabIndex = 5;
            this.BlueValue.Text = "255";
            // 
            // GreenValue
            // 
            this.GreenValue.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenValue.Location = new System.Drawing.Point(443, 71);
            this.GreenValue.Name = "GreenValue";
            this.GreenValue.Size = new System.Drawing.Size(100, 29);
            this.GreenValue.TabIndex = 6;
            this.GreenValue.Text = "255";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 417);
            this.Controls.Add(this.GreenValue);
            this.Controls.Add(this.BlueValue);
            this.Controls.Add(this.RedValue);
            this.Controls.Add(this.SetColor);
            this.Controls.Add(this.Greenbulb);
            this.Controls.Add(this.Bluebulb);
            this.Controls.Add(this.Redbulb);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Redbulb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bluebulb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Greenbulb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Redbulb;
        private System.Windows.Forms.PictureBox Bluebulb;
        private System.Windows.Forms.PictureBox Greenbulb;
        private System.Windows.Forms.Button SetColor;
        private System.Windows.Forms.TextBox RedValue;
        private System.Windows.Forms.TextBox BlueValue;
        private System.Windows.Forms.TextBox GreenValue;
    }
}

