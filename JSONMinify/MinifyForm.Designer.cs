namespace JSONMinify
{
    partial class MinifyForm
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
            this.txtboxFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnMinify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxFile
            // 
            this.txtboxFile.Location = new System.Drawing.Point(12, 32);
            this.txtboxFile.Name = "txtboxFile";
            this.txtboxFile.Size = new System.Drawing.Size(179, 20);
            this.txtboxFile.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(197, 29);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnMinify
            // 
            this.btnMinify.Location = new System.Drawing.Point(101, 74);
            this.btnMinify.Name = "btnMinify";
            this.btnMinify.Size = new System.Drawing.Size(75, 23);
            this.btnMinify.TabIndex = 2;
            this.btnMinify.Text = "Minify";
            this.btnMinify.UseVisualStyleBackColor = true;
            this.btnMinify.Click += new System.EventHandler(this.btnMinify_Click);
            // 
            // MinifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 109);
            this.Controls.Add(this.btnMinify);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtboxFile);
            this.Name = "MinifyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JSONMinify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnMinify;
    }
}

