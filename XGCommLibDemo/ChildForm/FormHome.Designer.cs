namespace XGCommLibDemo.ChildForm
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
            this.txtPlcManualBtNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlcIONo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPlcManualBtNo
            // 
            this.txtPlcManualBtNo.Font = new System.Drawing.Font("굴림", 18F);
            this.txtPlcManualBtNo.Location = new System.Drawing.Point(202, 12);
            this.txtPlcManualBtNo.Name = "txtPlcManualBtNo";
            this.txtPlcManualBtNo.Size = new System.Drawing.Size(156, 35);
            this.txtPlcManualBtNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F);
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "수동버튼 수량 :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 18F);
            this.label2.Location = new System.Drawing.Point(45, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "IO램프 수량 :";
            // 
            // txtPlcIONo
            // 
            this.txtPlcIONo.Font = new System.Drawing.Font("굴림", 18F);
            this.txtPlcIONo.Location = new System.Drawing.Point(202, 53);
            this.txtPlcIONo.Name = "txtPlcIONo";
            this.txtPlcIONo.Size = new System.Drawing.Size(156, 35);
            this.txtPlcIONo.TabIndex = 2;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 677);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlcIONo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlcManualBtNo);
            this.Name = "FormHome";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtPlcManualBtNo;
        public System.Windows.Forms.TextBox txtPlcIONo;
    }
}