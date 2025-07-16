namespace XGCommLibDemo.ChildForm
{
    partial class IO_View
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IO_View));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnLamp01 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ledGreen_29x29.jpg");
            this.imageList1.Images.SetKeyName(1, "ledRed_29x29.jpg");
            // 
            // btnLamp01
            // 
            this.btnLamp01.Image = global::XGCommLibDemo.Properties.Resources.ledGreen_29x29;
            this.btnLamp01.Location = new System.Drawing.Point(44, 12);
            this.btnLamp01.Name = "btnLamp01";
            this.btnLamp01.Size = new System.Drawing.Size(29, 29);
            this.btnLamp01.TabIndex = 0;
            this.btnLamp01.UseVisualStyleBackColor = true;
            // 
            // IO_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 677);
            this.Controls.Add(this.btnLamp01);
            this.Name = "IO_View";
            this.Text = "IO_View";
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Button btnLamp01;
    }
}