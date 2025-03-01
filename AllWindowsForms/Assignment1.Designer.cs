
namespace AllWindowsForms
{
    partial class Assignment1
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
            this.slstItems = new System.Windows.Forms.ListBox();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sbtn = new System.Windows.Forms.Button();
            this.llbtn = new System.Windows.Forms.Button();
            this.lbtn = new System.Windows.Forms.Button();
            this.ssbtn = new System.Windows.Forms.Button();
            this.slstItemsCount = new System.Windows.Forms.Label();
            this.lstItemsCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // slstItems
            // 
            this.slstItems.FormattingEnabled = true;
            this.slstItems.ItemHeight = 20;
            this.slstItems.Location = new System.Drawing.Point(95, 75);
            this.slstItems.Margin = new System.Windows.Forms.Padding(4);
            this.slstItems.Name = "slstItems";
            this.slstItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.slstItems.Size = new System.Drawing.Size(292, 344);
            this.slstItems.TabIndex = 0;
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.ItemHeight = 20;
            this.lstItems.Location = new System.Drawing.Point(658, 75);
            this.lstItems.Margin = new System.Windows.Forms.Padding(4);
            this.lstItems.Name = "lstItems";
            this.lstItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstItems.Size = new System.Drawing.Size(292, 344);
            this.lstItems.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected Item(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(654, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "List of Items";
            // 
            // sbtn
            // 
            this.sbtn.Location = new System.Drawing.Point(497, 137);
            this.sbtn.Name = "sbtn";
            this.sbtn.Size = new System.Drawing.Size(59, 46);
            this.sbtn.TabIndex = 4;
            this.sbtn.Text = "<";
            this.sbtn.UseVisualStyleBackColor = true;
            this.sbtn.Click += new System.EventHandler(this.sbtn_Click);
            // 
            // llbtn
            // 
            this.llbtn.Location = new System.Drawing.Point(497, 326);
            this.llbtn.Name = "llbtn";
            this.llbtn.Size = new System.Drawing.Size(59, 46);
            this.llbtn.TabIndex = 5;
            this.llbtn.Text = ">>";
            this.llbtn.UseVisualStyleBackColor = true;
            this.llbtn.Click += new System.EventHandler(this.llbtn_Click);
            // 
            // lbtn
            // 
            this.lbtn.Location = new System.Drawing.Point(497, 263);
            this.lbtn.Name = "lbtn";
            this.lbtn.Size = new System.Drawing.Size(59, 46);
            this.lbtn.TabIndex = 6;
            this.lbtn.Text = ">";
            this.lbtn.UseVisualStyleBackColor = true;
            this.lbtn.Click += new System.EventHandler(this.lbtn_Click);
            // 
            // ssbtn
            // 
            this.ssbtn.Location = new System.Drawing.Point(497, 200);
            this.ssbtn.Name = "ssbtn";
            this.ssbtn.Size = new System.Drawing.Size(59, 46);
            this.ssbtn.TabIndex = 7;
            this.ssbtn.Text = "<<";
            this.ssbtn.UseVisualStyleBackColor = true;
            this.ssbtn.Click += new System.EventHandler(this.ssbtn_Click);
            // 
            // slstItemsCount
            // 
            this.slstItemsCount.AutoSize = true;
            this.slstItemsCount.Location = new System.Drawing.Point(91, 456);
            this.slstItemsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.slstItemsCount.Name = "slstItemsCount";
            this.slstItemsCount.Size = new System.Drawing.Size(0, 20);
            this.slstItemsCount.TabIndex = 8;
            // 
            // lstItemsCount
            // 
            this.lstItemsCount.AutoSize = true;
            this.lstItemsCount.Location = new System.Drawing.Point(663, 456);
            this.lstItemsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lstItemsCount.Name = "lstItemsCount";
            this.lstItemsCount.Size = new System.Drawing.Size(0, 20);
            this.lstItemsCount.TabIndex = 9;
            // 
            // Assignment1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 662);
            this.Controls.Add(this.lstItemsCount);
            this.Controls.Add(this.slstItemsCount);
            this.Controls.Add(this.ssbtn);
            this.Controls.Add(this.lbtn);
            this.Controls.Add(this.llbtn);
            this.Controls.Add(this.sbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.slstItems);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Assignment1";
            this.Text = "Assignment1";
            this.Load += new System.EventHandler(this.Assignment1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox slstItems;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sbtn;
        private System.Windows.Forms.Button llbtn;
        private System.Windows.Forms.Button lbtn;
        private System.Windows.Forms.Button ssbtn;
        private System.Windows.Forms.Label slstItemsCount;
        private System.Windows.Forms.Label lstItemsCount;
    }
}