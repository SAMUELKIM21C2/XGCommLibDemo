namespace XGCommLibDemo.ChildForm
{
    partial class MAIN
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
            this.txtPlcDelayData = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPlcDelayData
            // 
            this.txtPlcDelayData.Location = new System.Drawing.Point(68, 46);
            this.txtPlcDelayData.Name = "txtPlcDelayData";
            this.txtPlcDelayData.Size = new System.Drawing.Size(194, 21);
            this.txtPlcDelayData.TabIndex = 0;
            this.txtPlcDelayData.TextChanged += new System.EventHandler(this.txtPlcDelayData_TextChanged);
            this.txtPlcDelayData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlcDelayData_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 677);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtPlcDelayData);
            this.Name = "MAIN";
            this.Text = "MAIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlcDelayData;
        private System.Windows.Forms.TextBox textBox1;
    }
}