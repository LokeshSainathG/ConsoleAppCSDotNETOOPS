
namespace AllWindowsForms
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.chkMonitor = new System.Windows.Forms.CheckBox();
            this.chkPrinter = new System.Windows.Forms.CheckBox();
            this.chkSpeakers = new System.Windows.Forms.CheckBox();
            this.chkHeadSet = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rabFull = new System.Windows.Forms.RadioButton();
            this.rabInstallments = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Item(s)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chkMonitor
            // 
            this.chkMonitor.AutoSize = true;
            this.chkMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMonitor.Location = new System.Drawing.Point(67, 90);
            this.chkMonitor.Name = "chkMonitor";
            this.chkMonitor.Size = new System.Drawing.Size(87, 24);
            this.chkMonitor.TabIndex = 1;
            this.chkMonitor.Text = "Monitor";
            this.chkMonitor.UseVisualStyleBackColor = true;
            // 
            // chkPrinter
            // 
            this.chkPrinter.AutoSize = true;
            this.chkPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrinter.Location = new System.Drawing.Point(67, 138);
            this.chkPrinter.Name = "chkPrinter";
            this.chkPrinter.Size = new System.Drawing.Size(81, 24);
            this.chkPrinter.TabIndex = 2;
            this.chkPrinter.Text = "Printer";
            this.chkPrinter.UseVisualStyleBackColor = true;
            // 
            // chkSpeakers
            // 
            this.chkSpeakers.AutoSize = true;
            this.chkSpeakers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSpeakers.Location = new System.Drawing.Point(67, 186);
            this.chkSpeakers.Name = "chkSpeakers";
            this.chkSpeakers.Size = new System.Drawing.Size(101, 24);
            this.chkSpeakers.TabIndex = 3;
            this.chkSpeakers.Text = "Speakers";
            this.chkSpeakers.UseVisualStyleBackColor = true;
            // 
            // chkHeadSet
            // 
            this.chkHeadSet.AutoSize = true;
            this.chkHeadSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHeadSet.Location = new System.Drawing.Point(67, 234);
            this.chkHeadSet.Name = "chkHeadSet";
            this.chkHeadSet.Size = new System.Drawing.Size(96, 24);
            this.chkHeadSet.TabIndex = 4;
            this.chkHeadSet.Text = "HeadSet";
            this.chkHeadSet.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Mode of Pament";
            // 
            // rabFull
            // 
            this.rabFull.AutoSize = true;
            this.rabFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabFull.Location = new System.Drawing.Point(445, 103);
            this.rabFull.Name = "rabFull";
            this.rabFull.Size = new System.Drawing.Size(127, 24);
            this.rabFull.TabIndex = 6;
            this.rabFull.TabStop = true;
            this.rabFull.Text = "Full Payment";
            this.rabFull.UseVisualStyleBackColor = true;
            // 
            // rabInstallments
            // 
            this.rabInstallments.AutoSize = true;
            this.rabInstallments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabInstallments.Location = new System.Drawing.Point(445, 153);
            this.rabInstallments.Name = "rabInstallments";
            this.rabInstallments.Size = new System.Drawing.Size(120, 24);
            this.rabInstallments.TabIndex = 7;
            this.rabInstallments.TabStop = true;
            this.rabInstallments.Text = "Installments";
            this.rabInstallments.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(445, 203);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 38);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 348);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rabInstallments);
            this.Controls.Add(this.rabFull);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkHeadSet);
            this.Controls.Add(this.chkSpeakers);
            this.Controls.Add(this.chkPrinter);
            this.Controls.Add(this.chkMonitor);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkMonitor;
        private System.Windows.Forms.CheckBox chkPrinter;
        private System.Windows.Forms.CheckBox chkSpeakers;
        private System.Windows.Forms.CheckBox chkHeadSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rabFull;
        private System.Windows.Forms.RadioButton rabInstallments;
        private System.Windows.Forms.Button btnCalculate;
    }
}