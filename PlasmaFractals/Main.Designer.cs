namespace PlasmaFractals
{
    partial class Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.roughLimit = new System.Windows.Forms.TrackBar();
            this.intensityLimit = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roughLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intensityLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Render";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Roughness";
            // 
            // roughLimit
            // 
            this.roughLimit.Location = new System.Drawing.Point(79, 93);
            this.roughLimit.Maximum = 100;
            this.roughLimit.Name = "roughLimit";
            this.roughLimit.Size = new System.Drawing.Size(192, 45);
            this.roughLimit.TabIndex = 2;
            this.roughLimit.Value = 28;
            // 
            // intensityLimit
            // 
            this.intensityLimit.Location = new System.Drawing.Point(79, 144);
            this.intensityLimit.Maximum = 255;
            this.intensityLimit.Name = "intensityLimit";
            this.intensityLimit.Size = new System.Drawing.Size(192, 45);
            this.intensityLimit.TabIndex = 3;
            this.intensityLimit.Value = 255;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Intensity";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.intensityLimit);
            this.Controls.Add(this.roughLimit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.Text = "PlasmaFractals";
            ((System.ComponentModel.ISupportInitialize)(this.roughLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intensityLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar roughLimit;
        private System.Windows.Forms.TrackBar intensityLimit;
        private System.Windows.Forms.Label label2;
    }
}

