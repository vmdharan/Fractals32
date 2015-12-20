namespace Fractals32
{
    partial class RenderOutput
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
            this.saveBitmapLabel = new System.Windows.Forms.Label();
            this.saveBMP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveBitmapLabel
            // 
            this.saveBitmapLabel.AutoSize = true;
            this.saveBitmapLabel.Location = new System.Drawing.Point(14, 520);
            this.saveBitmapLabel.Name = "saveBitmapLabel";
            this.saveBitmapLabel.Size = new System.Drawing.Size(70, 13);
            this.saveBitmapLabel.TabIndex = 0;
            this.saveBitmapLabel.Text = "Save to BMP";
            // 
            // saveBMP
            // 
            this.saveBMP.Location = new System.Drawing.Point(90, 515);
            this.saveBMP.Name = "saveBMP";
            this.saveBMP.Size = new System.Drawing.Size(75, 23);
            this.saveBMP.TabIndex = 1;
            this.saveBMP.Text = "Export";
            this.saveBMP.UseVisualStyleBackColor = true;
            this.saveBMP.Click += new System.EventHandler(this.saveBMP_Click);
            // 
            // RenderOutput
            // 
            this.ClientSize = new System.Drawing.Size(512, 541);
            this.Controls.Add(this.saveBMP);
            this.Controls.Add(this.saveBitmapLabel);
            this.Name = "RenderOutput";
            this.Load += new System.EventHandler(this.RenderOutput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saveBitmapLabel;
        private System.Windows.Forms.Button saveBMP;
    }
}