namespace CSharpPractice
{
    partial class idGeneration
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
            this.txtMonthYR = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.txtSequence = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMonthYR
            // 
            this.txtMonthYR.Location = new System.Drawing.Point(115, 46);
            this.txtMonthYR.Name = "txtMonthYR";
            this.txtMonthYR.Size = new System.Drawing.Size(137, 22);
            this.txtMonthYR.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Accounting",
            "Technical"});
            this.comboBox1.Location = new System.Drawing.Point(480, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(337, 46);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(137, 22);
            this.txtDept.TabIndex = 3;
            // 
            // txtSequence
            // 
            this.txtSequence.Location = new System.Drawing.Point(682, 46);
            this.txtSequence.Name = "txtSequence";
            this.txtSequence.Size = new System.Drawing.Size(137, 22);
            this.txtSequence.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(679, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sequence";
            // 
            // idGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 424);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSequence);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtMonthYR);
            this.Name = "idGeneration";
            this.Text = "idGeneration";
            this.Load += new System.EventHandler(this.idGeneration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMonthYR;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.TextBox txtSequence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}