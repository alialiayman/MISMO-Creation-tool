namespace MismoCreator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dfsMismo = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dffHtmlEncode = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dffWrapInJsonObject = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dfsDocumentTypeId = new System.Windows.Forms.TextBox();
            this.dfsLoanId = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan Identifier";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(430, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(345, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Make Mismo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dfsMismo
            // 
            this.dfsMismo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dfsMismo.Location = new System.Drawing.Point(7, 166);
            this.dfsMismo.Multiline = true;
            this.dfsMismo.Name = "dfsMismo";
            this.dfsMismo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.dfsMismo.Size = new System.Drawing.Size(781, 244);
            this.dfsMismo.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsMessage
            // 
            this.tsMessage.Name = "tsMessage";
            this.tsMessage.Size = new System.Drawing.Size(785, 17);
            this.tsMessage.Spring = true;
            this.tsMessage.Text = "Ready...";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MismoCreator.Properties.Settings.Default, "PDFFileName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.linkLabel1.Location = new System.Drawing.Point(99, 87);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(80, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = global::MismoCreator.Properties.Settings.Default.PDFFileName;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Document Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "5056,1903";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MismoCreator.Properties.Resources.Mismo;
            this.pictureBox1.Location = new System.Drawing.Point(675, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // dffHtmlEncode
            // 
            this.dffHtmlEncode.AutoSize = true;
            this.dffHtmlEncode.Location = new System.Drawing.Point(430, 16);
            this.dffHtmlEncode.Name = "dffHtmlEncode";
            this.dffHtmlEncode.Size = new System.Drawing.Size(87, 17);
            this.dffHtmlEncode.TabIndex = 10;
            this.dffHtmlEncode.Text = "Html Encode";
            this.dffHtmlEncode.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dffWrapInJsonObject);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dfsDocumentTypeId);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.dffHtmlEncode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dfsLoanId);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 134);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customize";
            // 
            // dffWrapInJsonObject
            // 
            this.dffWrapInJsonObject.AutoSize = true;
            this.dffWrapInJsonObject.Location = new System.Drawing.Point(430, 39);
            this.dffWrapInJsonObject.Name = "dffWrapInJsonObject";
            this.dffWrapInJsonObject.Size = new System.Drawing.Size(122, 17);
            this.dffWrapInJsonObject.TabIndex = 12;
            this.dffWrapInJsonObject.Text = "Wrap in Json Object";
            this.dffWrapInJsonObject.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Embed PDF";
            // 
            // dfsDocumentTypeId
            // 
            this.dfsDocumentTypeId.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MismoCreator.Properties.Settings.Default, "DocumentType", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dfsDocumentTypeId.Location = new System.Drawing.Point(102, 53);
            this.dfsDocumentTypeId.Name = "dfsDocumentTypeId";
            this.dfsDocumentTypeId.Size = new System.Drawing.Size(127, 20);
            this.dfsDocumentTypeId.TabIndex = 7;
            this.dfsDocumentTypeId.Text = global::MismoCreator.Properties.Settings.Default.DocumentType;
            // 
            // dfsLoanId
            // 
            this.dfsLoanId.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MismoCreator.Properties.Settings.Default, "LoanId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dfsLoanId.Location = new System.Drawing.Point(102, 23);
            this.dfsLoanId.Name = "dfsLoanId";
            this.dfsLoanId.Size = new System.Drawing.Size(127, 20);
            this.dfsLoanId.TabIndex = 1;
            this.dfsLoanId.Text = global::MismoCreator.Properties.Settings.Default.LoanId;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dfsMismo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mismo Creator";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dfsLoanId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dfsMismo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsMessage;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox dfsDocumentTypeId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox dffHtmlEncode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox dffWrapInJsonObject;
    }
}

