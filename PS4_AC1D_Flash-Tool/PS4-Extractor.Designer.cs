namespace PS4AC1DFlashTool
{
    partial class ExtractorDev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtractorDev));
            this.textOpen = new System.Windows.Forms.TextBox();
            this.textSave = new System.Windows.Forms.TextBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExtractNow = new System.Windows.Forms.Button();
            this.openPS4DMP = new System.Windows.Forms.OpenFileDialog();
            this.saveFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.checkDump = new System.Windows.Forms.CheckBox();
            this.checkFolder = new System.Windows.Forms.CheckBox();
            this.groupExDump = new System.Windows.Forms.GroupBox();
            this.buttonCleardmp = new System.Windows.Forms.Button();
            this.groupCI = new System.Windows.Forms.GroupBox();
            this.labelSHA1 = new System.Windows.Forms.Label();
            this.labelFWV = new System.Windows.Forms.Label();
            this.textSHA1 = new System.Windows.Forms.TextBox();
            this.textFWV = new System.Windows.Forms.TextBox();
            this.labelSKU = new System.Windows.Forms.Label();
            this.textSKU = new System.Windows.Forms.TextBox();
            this.labelMAC = new System.Windows.Forms.Label();
            this.labelCS = new System.Windows.Forms.Label();
            this.textCID = new System.Windows.Forms.TextBox();
            this.textMAC = new System.Windows.Forms.TextBox();
            this.groupSLB2 = new System.Windows.Forms.GroupBox();
            this.buttonClearslb = new System.Windows.Forms.Button();
            this.SLB2I = new System.Windows.Forms.GroupBox();
            this.label1SHAslb = new System.Windows.Forms.Label();
            this.textSHAslb = new System.Windows.Forms.TextBox();
            this.textSLBFilecount = new System.Windows.Forms.TextBox();
            this.labelFC = new System.Windows.Forms.Label();
            this.labelV = new System.Windows.Forms.Label();
            this.textSLBVersion = new System.Windows.Forms.TextBox();
            this.checkOFSLB2 = new System.Windows.Forms.CheckBox();
            this.checkDSLB2 = new System.Windows.Forms.CheckBox();
            this.buttonOSLB2 = new System.Windows.Forms.Button();
            this.buttonSSLB2 = new System.Windows.Forms.Button();
            this.textSSLB2 = new System.Windows.Forms.TextBox();
            this.textOSLB2 = new System.Windows.Forms.TextBox();
            this.openSLB2 = new System.Windows.Forms.OpenFileDialog();
            this.groupExDump.SuspendLayout();
            this.groupCI.SuspendLayout();
            this.groupSLB2.SuspendLayout();
            this.SLB2I.SuspendLayout();
            this.SuspendLayout();
            // 
            // textOpen
            // 
            this.textOpen.Location = new System.Drawing.Point(6, 19);
            this.textOpen.Name = "textOpen";
            this.textOpen.ReadOnly = true;
            this.textOpen.Size = new System.Drawing.Size(405, 20);
            this.textOpen.TabIndex = 0;
            this.textOpen.Text = "Select PS4 NOR Dump 2 Extract...";
            this.textOpen.TextChanged += new System.EventHandler(this.textOpen_TextChanged);
            // 
            // textSave
            // 
            this.textSave.Location = new System.Drawing.Point(6, 47);
            this.textSave.Name = "textSave";
            this.textSave.ReadOnly = true;
            this.textSave.Size = new System.Drawing.Size(405, 20);
            this.textSave.TabIndex = 1;
            this.textSave.Text = "Select the Folder 2 save files in...";
            this.textSave.TextChanged += new System.EventHandler(this.textSave_TextChanged);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpen.Location = new System.Drawing.Point(417, 17);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 3;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(417, 45);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExtractNow
            // 
            this.buttonExtractNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExtractNow.Location = new System.Drawing.Point(13, 383);
            this.buttonExtractNow.Name = "buttonExtractNow";
            this.buttonExtractNow.Size = new System.Drawing.Size(499, 48);
            this.buttonExtractNow.TabIndex = 5;
            this.buttonExtractNow.Text = "Extract Now!";
            this.buttonExtractNow.UseVisualStyleBackColor = true;
            this.buttonExtractNow.Click += new System.EventHandler(this.buttonExtractNow_Click);
            // 
            // openPS4DMP
            // 
            this.openPS4DMP.FileName = "PS4NORDump";
            this.openPS4DMP.Filter = "|*.BIN";
            this.openPS4DMP.Title = "Select PS4 NOR Dump";
            // 
            // checkDump
            // 
            this.checkDump.AutoSize = true;
            this.checkDump.Location = new System.Drawing.Point(380, 101);
            this.checkDump.Name = "checkDump";
            this.checkDump.Size = new System.Drawing.Size(88, 17);
            this.checkDump.TabIndex = 7;
            this.checkDump.Text = "Delete Dump";
            this.checkDump.UseVisualStyleBackColor = true;
            // 
            // checkFolder
            // 
            this.checkFolder.AutoSize = true;
            this.checkFolder.Location = new System.Drawing.Point(380, 124);
            this.checkFolder.Name = "checkFolder";
            this.checkFolder.Size = new System.Drawing.Size(106, 17);
            this.checkFolder.TabIndex = 8;
            this.checkFolder.Text = "Overwritte Folder";
            this.checkFolder.UseVisualStyleBackColor = true;
            // 
            // groupExDump
            // 
            this.groupExDump.Controls.Add(this.buttonCleardmp);
            this.groupExDump.Controls.Add(this.groupCI);
            this.groupExDump.Controls.Add(this.textOpen);
            this.groupExDump.Controls.Add(this.checkFolder);
            this.groupExDump.Controls.Add(this.textSave);
            this.groupExDump.Controls.Add(this.checkDump);
            this.groupExDump.Controls.Add(this.buttonOpen);
            this.groupExDump.Controls.Add(this.buttonSave);
            this.groupExDump.Location = new System.Drawing.Point(13, 12);
            this.groupExDump.Name = "groupExDump";
            this.groupExDump.Size = new System.Drawing.Size(499, 208);
            this.groupExDump.TabIndex = 9;
            this.groupExDump.TabStop = false;
            this.groupExDump.Text = "NOR Dump";
            // 
            // buttonCleardmp
            // 
            this.buttonCleardmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCleardmp.Location = new System.Drawing.Point(380, 74);
            this.buttonCleardmp.Name = "buttonCleardmp";
            this.buttonCleardmp.Size = new System.Drawing.Size(113, 23);
            this.buttonCleardmp.TabIndex = 11;
            this.buttonCleardmp.Text = "Clear";
            this.buttonCleardmp.UseVisualStyleBackColor = true;
            this.buttonCleardmp.Click += new System.EventHandler(this.buttonCleardmp_Click);
            // 
            // groupCI
            // 
            this.groupCI.Controls.Add(this.labelSHA1);
            this.groupCI.Controls.Add(this.labelFWV);
            this.groupCI.Controls.Add(this.textSHA1);
            this.groupCI.Controls.Add(this.textFWV);
            this.groupCI.Controls.Add(this.labelSKU);
            this.groupCI.Controls.Add(this.textSKU);
            this.groupCI.Controls.Add(this.labelMAC);
            this.groupCI.Controls.Add(this.labelCS);
            this.groupCI.Controls.Add(this.textCID);
            this.groupCI.Controls.Add(this.textMAC);
            this.groupCI.Location = new System.Drawing.Point(6, 71);
            this.groupCI.Name = "groupCI";
            this.groupCI.Size = new System.Drawing.Size(368, 130);
            this.groupCI.TabIndex = 19;
            this.groupCI.TabStop = false;
            this.groupCI.Text = "Console Information";
            // 
            // labelSHA1
            // 
            this.labelSHA1.AutoSize = true;
            this.labelSHA1.Location = new System.Drawing.Point(278, 103);
            this.labelSHA1.Name = "labelSHA1";
            this.labelSHA1.Size = new System.Drawing.Size(35, 13);
            this.labelSHA1.TabIndex = 25;
            this.labelSHA1.Text = "SHA1";
            // 
            // labelFWV
            // 
            this.labelFWV.AutoSize = true;
            this.labelFWV.Location = new System.Drawing.Point(71, 24);
            this.labelFWV.Name = "labelFWV";
            this.labelFWV.Size = new System.Drawing.Size(90, 13);
            this.labelFWV.TabIndex = 23;
            this.labelFWV.Text = "FirmWare Version";
            // 
            // textSHA1
            // 
            this.textSHA1.Location = new System.Drawing.Point(6, 100);
            this.textSHA1.Name = "textSHA1";
            this.textSHA1.ReadOnly = true;
            this.textSHA1.Size = new System.Drawing.Size(267, 20);
            this.textSHA1.TabIndex = 24;
            // 
            // textFWV
            // 
            this.textFWV.Location = new System.Drawing.Point(6, 21);
            this.textFWV.Name = "textFWV";
            this.textFWV.ReadOnly = true;
            this.textFWV.Size = new System.Drawing.Size(60, 20);
            this.textFWV.TabIndex = 22;
            // 
            // labelSKU
            // 
            this.labelSKU.AutoSize = true;
            this.labelSKU.Location = new System.Drawing.Point(303, 76);
            this.labelSKU.Name = "labelSKU";
            this.labelSKU.Size = new System.Drawing.Size(61, 13);
            this.labelSKU.TabIndex = 20;
            this.labelSKU.Text = "SKU Model";
            // 
            // textSKU
            // 
            this.textSKU.Location = new System.Drawing.Point(203, 73);
            this.textSKU.Name = "textSKU";
            this.textSKU.ReadOnly = true;
            this.textSKU.Size = new System.Drawing.Size(95, 20);
            this.textSKU.TabIndex = 21;
            // 
            // labelMAC
            // 
            this.labelMAC.AutoSize = true;
            this.labelMAC.Location = new System.Drawing.Point(111, 50);
            this.labelMAC.Name = "labelMAC";
            this.labelMAC.Size = new System.Drawing.Size(71, 13);
            this.labelMAC.TabIndex = 19;
            this.labelMAC.Text = "MAC Address";
            // 
            // labelCS
            // 
            this.labelCS.AutoSize = true;
            this.labelCS.Location = new System.Drawing.Point(125, 76);
            this.labelCS.Name = "labelCS";
            this.labelCS.Size = new System.Drawing.Size(74, 13);
            this.labelCS.TabIndex = 18;
            this.labelCS.Text = "Console Serial";
            // 
            // textCID
            // 
            this.textCID.Location = new System.Drawing.Point(6, 73);
            this.textCID.Name = "textCID";
            this.textCID.ReadOnly = true;
            this.textCID.Size = new System.Drawing.Size(115, 20);
            this.textCID.TabIndex = 17;
            // 
            // textMAC
            // 
            this.textMAC.Location = new System.Drawing.Point(6, 47);
            this.textMAC.Name = "textMAC";
            this.textMAC.ReadOnly = true;
            this.textMAC.Size = new System.Drawing.Size(100, 20);
            this.textMAC.TabIndex = 16;
            // 
            // groupSLB2
            // 
            this.groupSLB2.Controls.Add(this.buttonClearslb);
            this.groupSLB2.Controls.Add(this.SLB2I);
            this.groupSLB2.Controls.Add(this.checkOFSLB2);
            this.groupSLB2.Controls.Add(this.checkDSLB2);
            this.groupSLB2.Controls.Add(this.buttonOSLB2);
            this.groupSLB2.Controls.Add(this.buttonSSLB2);
            this.groupSLB2.Controls.Add(this.textSSLB2);
            this.groupSLB2.Controls.Add(this.textOSLB2);
            this.groupSLB2.Location = new System.Drawing.Point(13, 225);
            this.groupSLB2.Name = "groupSLB2";
            this.groupSLB2.Size = new System.Drawing.Size(499, 152);
            this.groupSLB2.TabIndex = 10;
            this.groupSLB2.TabStop = false;
            this.groupSLB2.Text = "SLB2 Container";
            // 
            // buttonClearslb
            // 
            this.buttonClearslb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearslb.Location = new System.Drawing.Point(380, 75);
            this.buttonClearslb.Name = "buttonClearslb";
            this.buttonClearslb.Size = new System.Drawing.Size(111, 23);
            this.buttonClearslb.TabIndex = 20;
            this.buttonClearslb.Text = "Clear";
            this.buttonClearslb.UseVisualStyleBackColor = true;
            this.buttonClearslb.Click += new System.EventHandler(this.buttonClearslb_Click);
            // 
            // SLB2I
            // 
            this.SLB2I.Controls.Add(this.label1SHAslb);
            this.SLB2I.Controls.Add(this.textSHAslb);
            this.SLB2I.Controls.Add(this.textSLBFilecount);
            this.SLB2I.Controls.Add(this.labelFC);
            this.SLB2I.Controls.Add(this.labelV);
            this.SLB2I.Controls.Add(this.textSLBVersion);
            this.SLB2I.Location = new System.Drawing.Point(6, 73);
            this.SLB2I.Name = "SLB2I";
            this.SLB2I.Size = new System.Drawing.Size(368, 71);
            this.SLB2I.TabIndex = 11;
            this.SLB2I.TabStop = false;
            this.SLB2I.Text = "SLB2 Information";
            // 
            // label1SHAslb
            // 
            this.label1SHAslb.AutoSize = true;
            this.label1SHAslb.Location = new System.Drawing.Point(279, 48);
            this.label1SHAslb.Name = "label1SHAslb";
            this.label1SHAslb.Size = new System.Drawing.Size(35, 13);
            this.label1SHAslb.TabIndex = 30;
            this.label1SHAslb.Text = "SHA1";
            // 
            // textSHAslb
            // 
            this.textSHAslb.Location = new System.Drawing.Point(6, 45);
            this.textSHAslb.Name = "textSHAslb";
            this.textSHAslb.ReadOnly = true;
            this.textSHAslb.Size = new System.Drawing.Size(267, 20);
            this.textSHAslb.TabIndex = 11;
            // 
            // textSLBFilecount
            // 
            this.textSLBFilecount.Location = new System.Drawing.Point(85, 19);
            this.textSLBFilecount.Name = "textSLBFilecount";
            this.textSLBFilecount.ReadOnly = true;
            this.textSLBFilecount.Size = new System.Drawing.Size(21, 20);
            this.textSLBFilecount.TabIndex = 29;
            // 
            // labelFC
            // 
            this.labelFC.AutoSize = true;
            this.labelFC.Location = new System.Drawing.Point(108, 22);
            this.labelFC.Name = "labelFC";
            this.labelFC.Size = new System.Drawing.Size(54, 13);
            this.labelFC.TabIndex = 28;
            this.labelFC.Text = "File Count";
            // 
            // labelV
            // 
            this.labelV.AutoSize = true;
            this.labelV.Location = new System.Drawing.Point(29, 23);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(42, 13);
            this.labelV.TabIndex = 27;
            this.labelV.Text = "Version";
            // 
            // textSLBVersion
            // 
            this.textSLBVersion.Location = new System.Drawing.Point(6, 19);
            this.textSLBVersion.Name = "textSLBVersion";
            this.textSLBVersion.ReadOnly = true;
            this.textSLBVersion.Size = new System.Drawing.Size(21, 20);
            this.textSLBVersion.TabIndex = 26;
            // 
            // checkOFSLB2
            // 
            this.checkOFSLB2.AutoSize = true;
            this.checkOFSLB2.Location = new System.Drawing.Point(380, 126);
            this.checkOFSLB2.Name = "checkOFSLB2";
            this.checkOFSLB2.Size = new System.Drawing.Size(106, 17);
            this.checkOFSLB2.TabIndex = 16;
            this.checkOFSLB2.Text = "Overwritte Folder";
            this.checkOFSLB2.UseVisualStyleBackColor = true;
            // 
            // checkDSLB2
            // 
            this.checkDSLB2.AutoSize = true;
            this.checkDSLB2.Location = new System.Drawing.Point(380, 103);
            this.checkDSLB2.Name = "checkDSLB2";
            this.checkDSLB2.Size = new System.Drawing.Size(86, 17);
            this.checkDSLB2.TabIndex = 15;
            this.checkDSLB2.Text = "Delete SLB2";
            this.checkDSLB2.UseVisualStyleBackColor = true;
            // 
            // buttonOSLB2
            // 
            this.buttonOSLB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOSLB2.Location = new System.Drawing.Point(417, 17);
            this.buttonOSLB2.Name = "buttonOSLB2";
            this.buttonOSLB2.Size = new System.Drawing.Size(75, 23);
            this.buttonOSLB2.TabIndex = 14;
            this.buttonOSLB2.Text = "Open";
            this.buttonOSLB2.UseVisualStyleBackColor = true;
            this.buttonOSLB2.Click += new System.EventHandler(this.buttonOSLB2_Click);
            // 
            // buttonSSLB2
            // 
            this.buttonSSLB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSSLB2.Location = new System.Drawing.Point(416, 47);
            this.buttonSSLB2.Name = "buttonSSLB2";
            this.buttonSSLB2.Size = new System.Drawing.Size(75, 23);
            this.buttonSSLB2.TabIndex = 13;
            this.buttonSSLB2.Text = "Save";
            this.buttonSSLB2.UseVisualStyleBackColor = true;
            this.buttonSSLB2.Click += new System.EventHandler(this.buttonSSLB2_Click);
            // 
            // textSSLB2
            // 
            this.textSSLB2.Location = new System.Drawing.Point(6, 49);
            this.textSSLB2.Name = "textSSLB2";
            this.textSSLB2.ReadOnly = true;
            this.textSSLB2.Size = new System.Drawing.Size(405, 20);
            this.textSSLB2.TabIndex = 11;
            this.textSSLB2.Text = "Select the Folder 2 save files in...";
            this.textSSLB2.TextChanged += new System.EventHandler(this.textSSLB2_TextChanged);
            // 
            // textOSLB2
            // 
            this.textOSLB2.Location = new System.Drawing.Point(6, 19);
            this.textOSLB2.Name = "textOSLB2";
            this.textOSLB2.ReadOnly = true;
            this.textOSLB2.Size = new System.Drawing.Size(405, 20);
            this.textOSLB2.TabIndex = 12;
            this.textOSLB2.Text = "Select PS4 SLB2 Container 2 Extract...";
            this.textOSLB2.TextChanged += new System.EventHandler(this.textOSLB2_TextChanged);
            // 
            // openSLB2
            // 
            this.openSLB2.Filter = "|*.*";
            this.openSLB2.Title = "Select PS4 SLB2 File...";
            // 
            // ExtractorDev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 441);
            this.Controls.Add(this.groupSLB2);
            this.Controls.Add(this.groupExDump);
            this.Controls.Add(this.buttonExtractNow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExtractorDev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PS4 NOR/SLB2 Extractor";
            this.Load += new System.EventHandler(this.ExtractorDev_Load);
            this.groupExDump.ResumeLayout(false);
            this.groupExDump.PerformLayout();
            this.groupCI.ResumeLayout(false);
            this.groupCI.PerformLayout();
            this.groupSLB2.ResumeLayout(false);
            this.groupSLB2.PerformLayout();
            this.SLB2I.ResumeLayout(false);
            this.SLB2I.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textOpen;
        private System.Windows.Forms.TextBox textSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExtractNow;
        private System.Windows.Forms.OpenFileDialog openPS4DMP;
        private System.Windows.Forms.FolderBrowserDialog saveFolder;
        private System.Windows.Forms.CheckBox checkDump;
        private System.Windows.Forms.CheckBox checkFolder;
        private System.Windows.Forms.GroupBox groupExDump;
        private System.Windows.Forms.GroupBox groupSLB2;
        private System.Windows.Forms.Button buttonOSLB2;
        private System.Windows.Forms.Button buttonSSLB2;
        private System.Windows.Forms.TextBox textSSLB2;
        private System.Windows.Forms.TextBox textOSLB2;
        private System.Windows.Forms.GroupBox groupCI;
        private System.Windows.Forms.Label labelSHA1;
        private System.Windows.Forms.Label labelFWV;
        private System.Windows.Forms.TextBox textSHA1;
        private System.Windows.Forms.TextBox textFWV;
        private System.Windows.Forms.Label labelSKU;
        private System.Windows.Forms.TextBox textSKU;
        private System.Windows.Forms.Label labelMAC;
        private System.Windows.Forms.Label labelCS;
        private System.Windows.Forms.TextBox textCID;
        private System.Windows.Forms.TextBox textMAC;
        private System.Windows.Forms.OpenFileDialog openSLB2;
        private System.Windows.Forms.CheckBox checkOFSLB2;
        private System.Windows.Forms.CheckBox checkDSLB2;
        private System.Windows.Forms.GroupBox SLB2I;
        private System.Windows.Forms.TextBox textSLBFilecount;
        private System.Windows.Forms.Label labelFC;
        private System.Windows.Forms.Label labelV;
        private System.Windows.Forms.TextBox textSLBVersion;
        private System.Windows.Forms.Button buttonCleardmp;
        private System.Windows.Forms.Button buttonClearslb;
        private System.Windows.Forms.Label label1SHAslb;
        private System.Windows.Forms.TextBox textSHAslb;
    }
}