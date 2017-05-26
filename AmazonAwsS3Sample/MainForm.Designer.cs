namespace Enginesoft.AmazonAwsS3Sample
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtSecretAccessKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccessKeyId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtBucketName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtServerFolder = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.nupMaxItems = new System.Windows.Forms.NumericUpDown();
            this.btnList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupMaxItems)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRegion);
            this.groupBox1.Controls.Add(this.txtSecretAccessKey);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAccessKeyId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aws Credentials";
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(122, 97);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(289, 20);
            this.txtRegion.TabIndex = 1;
            // 
            // txtSecretAccessKey
            // 
            this.txtSecretAccessKey.Location = new System.Drawing.Point(122, 64);
            this.txtSecretAccessKey.Name = "txtSecretAccessKey";
            this.txtSecretAccessKey.Size = new System.Drawing.Size(289, 20);
            this.txtSecretAccessKey.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Region";
            // 
            // txtAccessKeyId
            // 
            this.txtAccessKeyId.Location = new System.Drawing.Point(122, 29);
            this.txtAccessKeyId.Name = "txtAccessKeyId";
            this.txtAccessKeyId.Size = new System.Drawing.Size(289, 20);
            this.txtAccessKeyId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Secret Access Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Access Key ID";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(15, 157);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(545, 304);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnList);
            this.tabPage1.Controls.Add(this.nupMaxItems);
            this.tabPage1.Controls.Add(this.lstItems);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtServerFolder);
            this.tabPage1.Controls.Add(this.txtBucketName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(537, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtBucketName
            // 
            this.txtBucketName.Location = new System.Drawing.Point(102, 15);
            this.txtBucketName.Name = "txtBucketName";
            this.txtBucketName.Size = new System.Drawing.Size(302, 20);
            this.txtBucketName.TabIndex = 0;
            this.txtBucketName.Text = "cdntest01";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bucket Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Server Folder";
            // 
            // txtServerFolder
            // 
            this.txtServerFolder.Location = new System.Drawing.Point(102, 47);
            this.txtServerFolder.Name = "txtServerFolder";
            this.txtServerFolder.Size = new System.Drawing.Size(302, 20);
            this.txtServerFolder.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Max Items";
            // 
            // lstItems
            // 
            this.lstItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(15, 118);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(389, 147);
            this.lstItems.TabIndex = 2;
            // 
            // nupMaxItems
            // 
            this.nupMaxItems.Location = new System.Drawing.Point(102, 80);
            this.nupMaxItems.Name = "nupMaxItems";
            this.nupMaxItems.Size = new System.Drawing.Size(60, 20);
            this.nupMaxItems.TabIndex = 3;
            this.nupMaxItems.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(421, 45);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 4;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 473);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Amazon Aws S3 Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupMaxItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSecretAccessKey;
        private System.Windows.Forms.TextBox txtAccessKeyId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBucketName;
        private System.Windows.Forms.TextBox txtServerFolder;
        private System.Windows.Forms.NumericUpDown nupMaxItems;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnList;
    }
}

