namespace TestAPI
{
    partial class frmTestAPI
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
            this.lbApiUrl = new System.Windows.Forms.Label();
            this.lbActionApi = new System.Windows.Forms.Label();
            this.lbFileUrl = new System.Windows.Forms.Label();
            this.btLauncher = new System.Windows.Forms.Button();
            this.txtApiUrl = new System.Windows.Forms.TextBox();
            this.txtActionApi = new System.Windows.Forms.TextBox();
            this.txtFileUrl = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbApiUrl
            // 
            this.lbApiUrl.AutoSize = true;
            this.lbApiUrl.Location = new System.Drawing.Point(6, 28);
            this.lbApiUrl.Name = "lbApiUrl";
            this.lbApiUrl.Size = new System.Drawing.Size(52, 13);
            this.lbApiUrl.TabIndex = 0;
            this.lbApiUrl.Text = "API URL:";
            // 
            // lbActionApi
            // 
            this.lbActionApi.AutoSize = true;
            this.lbActionApi.Location = new System.Drawing.Point(6, 67);
            this.lbActionApi.Name = "lbActionApi";
            this.lbActionApi.Size = new System.Drawing.Size(60, 13);
            this.lbActionApi.TabIndex = 1;
            this.lbActionApi.Text = "API Action:";
            // 
            // lbFileUrl
            // 
            this.lbFileUrl.AutoSize = true;
            this.lbFileUrl.Location = new System.Drawing.Point(6, 106);
            this.lbFileUrl.Name = "lbFileUrl";
            this.lbFileUrl.Size = new System.Drawing.Size(51, 13);
            this.lbFileUrl.TabIndex = 1;
            this.lbFileUrl.Text = "File URL:";
            // 
            // btLauncher
            // 
            this.btLauncher.Location = new System.Drawing.Point(104, 148);
            this.btLauncher.Name = "btLauncher";
            this.btLauncher.Size = new System.Drawing.Size(172, 67);
            this.btLauncher.TabIndex = 2;
            this.btLauncher.Text = "Launch";
            this.btLauncher.UseVisualStyleBackColor = true;
            this.btLauncher.Click += new System.EventHandler(this.btLauncher_Click);
            // 
            // txtApiUrl
            // 
            this.txtApiUrl.Location = new System.Drawing.Point(9, 44);
            this.txtApiUrl.Name = "txtApiUrl";
            this.txtApiUrl.Size = new System.Drawing.Size(350, 20);
            this.txtApiUrl.TabIndex = 3;
            this.txtApiUrl.Text = "http://localhost:55847/";
            // 
            // txtActionApi
            // 
            this.txtActionApi.Location = new System.Drawing.Point(9, 83);
            this.txtActionApi.Name = "txtActionApi";
            this.txtActionApi.Size = new System.Drawing.Size(350, 20);
            this.txtActionApi.TabIndex = 4;
            this.txtActionApi.Text = "API/UploadItinerary";
            // 
            // txtFileUrl
            // 
            this.txtFileUrl.Location = new System.Drawing.Point(9, 122);
            this.txtFileUrl.Name = "txtFileUrl";
            this.txtFileUrl.Size = new System.Drawing.Size(350, 20);
            this.txtFileUrl.TabIndex = 4;
            this.txtFileUrl.Text = "C:\\Users\\Linko\\Desktop\\Jepessen SISAC report.csv";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFileUrl);
            this.groupBox1.Controls.Add(this.txtActionApi);
            this.groupBox1.Controls.Add(this.txtApiUrl);
            this.groupBox1.Controls.Add(this.btLauncher);
            this.groupBox1.Controls.Add(this.lbFileUrl);
            this.groupBox1.Controls.Add(this.lbActionApi);
            this.groupBox1.Controls.Add(this.lbApiUrl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SISAC";
            // 
            // frmTestAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 247);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTestAPI";
            this.Text = "Test API";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbApiUrl;
        private System.Windows.Forms.Label lbActionApi;
        private System.Windows.Forms.Label lbFileUrl;
        private System.Windows.Forms.Button btLauncher;
        private System.Windows.Forms.TextBox txtApiUrl;
        private System.Windows.Forms.TextBox txtActionApi;
        private System.Windows.Forms.TextBox txtFileUrl;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

