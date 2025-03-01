
namespace AllWindowsForms
{
    partial class Assignment2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFont = new System.Windows.Forms.ComboBox();
            this.cmbFontSize = new System.Windows.Forms.ComboBox();
            this.cmbBackColor = new System.Windows.Forms.ComboBox();
            this.cmbFontColor = new System.Windows.Forms.ComboBox();
            this.rabBold = new System.Windows.Forms.RadioButton();
            this.rabItalic = new System.Windows.Forms.RadioButton();
            this.rabUnderline = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 61);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(696, 195);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter sample Text";
            // 
            // cmbFont
            // 
            this.cmbFont.FormattingEnabled = true;
            this.cmbFont.Location = new System.Drawing.Point(321, 278);
            this.cmbFont.Name = "cmbFont";
            this.cmbFont.Size = new System.Drawing.Size(156, 28);
            this.cmbFont.TabIndex = 2;
            this.cmbFont.Text = "Font Family";
            this.cmbFont.SelectedIndexChanged += new System.EventHandler(this.cmbFont_SelectedIndexChanged);
            // 
            // cmbFontSize
            // 
            this.cmbFontSize.FormattingEnabled = true;
            this.cmbFontSize.Location = new System.Drawing.Point(321, 328);
            this.cmbFontSize.Name = "cmbFontSize";
            this.cmbFontSize.Size = new System.Drawing.Size(156, 28);
            this.cmbFontSize.TabIndex = 3;
            this.cmbFontSize.Text = "Font Size";
            this.cmbFontSize.SelectedIndexChanged += new System.EventHandler(this.cmbFontSize_SelectedIndexChanged);
            // 
            // cmbBackColor
            // 
            this.cmbBackColor.FormattingEnabled = true;
            this.cmbBackColor.Location = new System.Drawing.Point(321, 428);
            this.cmbBackColor.Name = "cmbBackColor";
            this.cmbBackColor.Size = new System.Drawing.Size(156, 28);
            this.cmbBackColor.TabIndex = 4;
            this.cmbBackColor.Text = "Back Color";
            this.cmbBackColor.SelectedIndexChanged += new System.EventHandler(this.cmbBackColor_SelectedIndexChanged);
            // 
            // cmbFontColor
            // 
            this.cmbFontColor.FormattingEnabled = true;
            this.cmbFontColor.Location = new System.Drawing.Point(321, 378);
            this.cmbFontColor.Name = "cmbFontColor";
            this.cmbFontColor.Size = new System.Drawing.Size(156, 28);
            this.cmbFontColor.TabIndex = 5;
            this.cmbFontColor.Text = "Font Color";
            this.cmbFontColor.SelectedIndexChanged += new System.EventHandler(this.cmbFontColor_SelectedIndexChanged);
            // 
            // rabBold
            // 
            this.rabBold.AutoSize = true;
            this.rabBold.Location = new System.Drawing.Point(116, 499);
            this.rabBold.Name = "rabBold";
            this.rabBold.Size = new System.Drawing.Size(64, 24);
            this.rabBold.TabIndex = 6;
            this.rabBold.TabStop = true;
            this.rabBold.Text = "Bold";
            this.rabBold.UseVisualStyleBackColor = true;
            this.rabBold.CheckedChanged += new System.EventHandler(this.rabBold_CheckedChanged);
            // 
            // rabItalic
            // 
            this.rabItalic.AutoSize = true;
            this.rabItalic.Location = new System.Drawing.Point(336, 499);
            this.rabItalic.Name = "rabItalic";
            this.rabItalic.Size = new System.Drawing.Size(65, 24);
            this.rabItalic.TabIndex = 7;
            this.rabItalic.TabStop = true;
            this.rabItalic.Text = "Italic";
            this.rabItalic.UseVisualStyleBackColor = true;
            this.rabItalic.CheckedChanged += new System.EventHandler(this.rabItalic_CheckedChanged);
            // 
            // rabUnderline
            // 
            this.rabUnderline.AutoSize = true;
            this.rabUnderline.Location = new System.Drawing.Point(563, 499);
            this.rabUnderline.Name = "rabUnderline";
            this.rabUnderline.Size = new System.Drawing.Size(101, 24);
            this.rabUnderline.TabIndex = 8;
            this.rabUnderline.TabStop = true;
            this.rabUnderline.Text = "Underline";
            this.rabUnderline.UseVisualStyleBackColor = true;
            this.rabUnderline.CheckedChanged += new System.EventHandler(this.rabUnderline_CheckedChanged);
            // 
            // Assignment2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.rabUnderline);
            this.Controls.Add(this.rabItalic);
            this.Controls.Add(this.rabBold);
            this.Controls.Add(this.cmbFontColor);
            this.Controls.Add(this.cmbBackColor);
            this.Controls.Add(this.cmbFontSize);
            this.Controls.Add(this.cmbFont);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Assignment2";
            this.Text = "Assignment2";
            this.Load += new System.EventHandler(this.Assignment2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFont;
        private System.Windows.Forms.ComboBox cmbFontSize;
        private System.Windows.Forms.ComboBox cmbBackColor;
        private System.Windows.Forms.ComboBox cmbFontColor;
        private System.Windows.Forms.RadioButton rabBold;
        private System.Windows.Forms.RadioButton rabItalic;
        private System.Windows.Forms.RadioButton rabUnderline;
    }
}