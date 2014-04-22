namespace PS4AC1DFlashTool
{
    partial class DevBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevBoard));
            this.Dump = new System.Windows.Forms.Button();
            this.ChipInfo = new System.Windows.Forms.Button();
            this.console = new ConsoleControl.ConsoleControl();
            this.Write = new System.Windows.Forms.Button();
            this.Erase = new System.Windows.Forms.Button();
            this.openDump = new System.Windows.Forms.OpenFileDialog();
            this.saveDump = new System.Windows.Forms.SaveFileDialog();
            this.textOpen = new System.Windows.Forms.TextBox();
            this.textSave = new System.Windows.Forms.TextBox();
            this.Open = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.CheckSCP = new System.Windows.Forms.Button();
            this.WriteV = new System.Windows.Forms.Button();
            this.iPYS = new System.Windows.Forms.Button();
            this.iPY = new System.Windows.Forms.Button();
            this.selectSerialPort = new System.Windows.Forms.ComboBox();
            this.textMAC = new System.Windows.Forms.TextBox();
            this.textCID = new System.Windows.Forms.TextBox();
            this.groupCI = new System.Windows.Forms.GroupBox();
            this.labelSHA1 = new System.Windows.Forms.Label();
            this.labelFWV = new System.Windows.Forms.Label();
            this.textSHA1 = new System.Windows.Forms.TextBox();
            this.textFWV = new System.Windows.Forms.TextBox();
            this.labelSKU = new System.Windows.Forms.Label();
            this.textSKU = new System.Windows.Forms.TextBox();
            this.labelMAC = new System.Windows.Forms.Label();
            this.labelCS = new System.Windows.Forms.Label();
            this.buttonDV = new System.Windows.Forms.Button();
            this.groupBoxOO = new System.Windows.Forms.GroupBox();
            this.buttonOL = new System.Windows.Forms.Button();
            this.labeliPYS = new System.Windows.Forms.Label();
            this.labeliPY = new System.Windows.Forms.Label();
            this.buttonSIDB = new System.Windows.Forms.Button();
            this.groupSPIW = new System.Windows.Forms.GroupBox();
            this.groupCI.SuspendLayout();
            this.groupBoxOO.SuspendLayout();
            this.groupSPIW.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dump
            // 
            this.Dump.Location = new System.Drawing.Point(98, 50);
            this.Dump.Name = "Dump";
            this.Dump.Size = new System.Drawing.Size(91, 23);
            this.Dump.TabIndex = 1;
            this.Dump.Text = "Dump";
            this.Dump.UseVisualStyleBackColor = true;
            this.Dump.Click += new System.EventHandler(this.Dump_Click);
            // 
            // ChipInfo
            // 
            this.ChipInfo.Location = new System.Drawing.Point(6, 50);
            this.ChipInfo.Name = "ChipInfo";
            this.ChipInfo.Size = new System.Drawing.Size(75, 23);
            this.ChipInfo.TabIndex = 2;
            this.ChipInfo.Text = "Chip Info";
            this.ChipInfo.UseVisualStyleBackColor = true;
            this.ChipInfo.Click += new System.EventHandler(this.ChipInfo_Click);
            // 
            // console
            // 
            this.console.IsInputEnabled = true;
            this.console.Location = new System.Drawing.Point(0, 83);
            this.console.Name = "console";
            this.console.SendKeyboardCommandsToProcess = false;
            this.console.ShowDiagnostics = false;
            this.console.Size = new System.Drawing.Size(654, 395);
            this.console.TabIndex = 3;
            // 
            // Write
            // 
            this.Write.Location = new System.Drawing.Point(216, 50);
            this.Write.Name = "Write";
            this.Write.Size = new System.Drawing.Size(91, 23);
            this.Write.TabIndex = 4;
            this.Write.Text = "Write";
            this.Write.UseVisualStyleBackColor = true;
            this.Write.Click += new System.EventHandler(this.Write_Click);
            // 
            // Erase
            // 
            this.Erase.Location = new System.Drawing.Point(573, 50);
            this.Erase.Name = "Erase";
            this.Erase.Size = new System.Drawing.Size(75, 23);
            this.Erase.TabIndex = 5;
            this.Erase.Text = "Erase";
            this.Erase.UseVisualStyleBackColor = true;
            this.Erase.Click += new System.EventHandler(this.Erase_Click);
            // 
            // openDump
            // 
            this.openDump.FileName = "PS4NORDUMP";
            this.openDump.Filter = "|*.BIN";
            this.openDump.Title = "Open PS4 NOR Dump";
            // 
            // saveDump
            // 
            this.saveDump.FileName = "PS4NORDUMP";
            this.saveDump.Filter = "|*.BIN";
            this.saveDump.Title = "Save PS4 NOR Dump";
            // 
            // textOpen
            // 
            this.textOpen.Location = new System.Drawing.Point(12, 9);
            this.textOpen.Name = "textOpen";
            this.textOpen.Size = new System.Drawing.Size(527, 20);
            this.textOpen.TabIndex = 6;
            this.textOpen.Text = "Open PS4 NOR Dump...";
            // 
            // textSave
            // 
            this.textSave.Location = new System.Drawing.Point(12, 38);
            this.textSave.Name = "textSave";
            this.textSave.Size = new System.Drawing.Size(527, 20);
            this.textSave.TabIndex = 7;
            this.textSave.Text = "Save PS4 NOR Dump...";
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(545, 8);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(121, 23);
            this.Open.TabIndex = 8;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(545, 37);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(121, 23);
            this.Save.TabIndex = 9;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // CheckSCP
            // 
            this.CheckSCP.Location = new System.Drawing.Point(228, 19);
            this.CheckSCP.Name = "CheckSCP";
            this.CheckSCP.Size = new System.Drawing.Size(110, 21);
            this.CheckSCP.TabIndex = 11;
            this.CheckSCP.Text = "Check COM Ports";
            this.CheckSCP.UseVisualStyleBackColor = true;
            this.CheckSCP.Click += new System.EventHandler(this.CheckSCP_Click);
            // 
            // WriteV
            // 
            this.WriteV.Location = new System.Drawing.Point(456, 50);
            this.WriteV.Name = "WriteV";
            this.WriteV.Size = new System.Drawing.Size(91, 23);
            this.WriteV.TabIndex = 12;
            this.WriteV.Text = "Write with Verify";
            this.WriteV.UseVisualStyleBackColor = true;
            this.WriteV.Click += new System.EventHandler(this.WriteV_Click);
            // 
            // iPYS
            // 
            this.iPYS.Location = new System.Drawing.Point(101, 41);
            this.iPYS.Name = "iPYS";
            this.iPYS.Size = new System.Drawing.Size(172, 23);
            this.iPYS.TabIndex = 13;
            this.iPYS.Text = "INSTALL PYSERIAL 2.5";
            this.iPYS.UseVisualStyleBackColor = true;
            this.iPYS.Click += new System.EventHandler(this.iPYS_Click);
            // 
            // iPY
            // 
            this.iPY.Location = new System.Drawing.Point(101, 12);
            this.iPY.Name = "iPY";
            this.iPY.Size = new System.Drawing.Size(172, 23);
            this.iPY.TabIndex = 14;
            this.iPY.Text = "INSTALL PYTHON 2.7.2";
            this.iPY.UseVisualStyleBackColor = true;
            this.iPY.Click += new System.EventHandler(this.iPY_Click);
            // 
            // selectSerialPort
            // 
            this.selectSerialPort.FormattingEnabled = true;
            this.selectSerialPort.Location = new System.Drawing.Point(6, 19);
            this.selectSerialPort.Name = "selectSerialPort";
            this.selectSerialPort.Size = new System.Drawing.Size(216, 21);
            this.selectSerialPort.TabIndex = 15;
            this.selectSerialPort.Text = "No Searial COM Port found...";
            // 
            // textMAC
            // 
            this.textMAC.Location = new System.Drawing.Point(6, 51);
            this.textMAC.Name = "textMAC";
            this.textMAC.ReadOnly = true;
            this.textMAC.Size = new System.Drawing.Size(100, 20);
            this.textMAC.TabIndex = 16;
            // 
            // textCID
            // 
            this.textCID.Location = new System.Drawing.Point(6, 77);
            this.textCID.Name = "textCID";
            this.textCID.ReadOnly = true;
            this.textCID.Size = new System.Drawing.Size(115, 20);
            this.textCID.TabIndex = 17;
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
            this.groupCI.Location = new System.Drawing.Point(12, 64);
            this.groupCI.Name = "groupCI";
            this.groupCI.Size = new System.Drawing.Size(368, 130);
            this.groupCI.TabIndex = 18;
            this.groupCI.TabStop = false;
            this.groupCI.Text = "Console Information";
            // 
            // labelSHA1
            // 
            this.labelSHA1.AutoSize = true;
            this.labelSHA1.Location = new System.Drawing.Point(278, 107);
            this.labelSHA1.Name = "labelSHA1";
            this.labelSHA1.Size = new System.Drawing.Size(35, 13);
            this.labelSHA1.TabIndex = 25;
            this.labelSHA1.Text = "SHA1";
            // 
            // labelFWV
            // 
            this.labelFWV.AutoSize = true;
            this.labelFWV.Location = new System.Drawing.Point(71, 28);
            this.labelFWV.Name = "labelFWV";
            this.labelFWV.Size = new System.Drawing.Size(90, 13);
            this.labelFWV.TabIndex = 23;
            this.labelFWV.Text = "FirmWare Version";
            // 
            // textSHA1
            // 
            this.textSHA1.Location = new System.Drawing.Point(6, 104);
            this.textSHA1.Name = "textSHA1";
            this.textSHA1.ReadOnly = true;
            this.textSHA1.Size = new System.Drawing.Size(267, 20);
            this.textSHA1.TabIndex = 24;
            this.textSHA1.TextChanged += new System.EventHandler(this.textSHA1_TextChanged);
            // 
            // textFWV
            // 
            this.textFWV.Location = new System.Drawing.Point(6, 25);
            this.textFWV.Name = "textFWV";
            this.textFWV.ReadOnly = true;
            this.textFWV.Size = new System.Drawing.Size(60, 20);
            this.textFWV.TabIndex = 22;
            // 
            // labelSKU
            // 
            this.labelSKU.AutoSize = true;
            this.labelSKU.Location = new System.Drawing.Point(303, 80);
            this.labelSKU.Name = "labelSKU";
            this.labelSKU.Size = new System.Drawing.Size(61, 13);
            this.labelSKU.TabIndex = 20;
            this.labelSKU.Text = "SKU Model";
            // 
            // textSKU
            // 
            this.textSKU.Location = new System.Drawing.Point(203, 77);
            this.textSKU.Name = "textSKU";
            this.textSKU.ReadOnly = true;
            this.textSKU.Size = new System.Drawing.Size(95, 20);
            this.textSKU.TabIndex = 21;
            // 
            // labelMAC
            // 
            this.labelMAC.AutoSize = true;
            this.labelMAC.Location = new System.Drawing.Point(111, 54);
            this.labelMAC.Name = "labelMAC";
            this.labelMAC.Size = new System.Drawing.Size(71, 13);
            this.labelMAC.TabIndex = 19;
            this.labelMAC.Text = "MAC Address";
            // 
            // labelCS
            // 
            this.labelCS.AutoSize = true;
            this.labelCS.Location = new System.Drawing.Point(125, 80);
            this.labelCS.Name = "labelCS";
            this.labelCS.Size = new System.Drawing.Size(74, 13);
            this.labelCS.TabIndex = 18;
            this.labelCS.Text = "Console Serial";
            // 
            // buttonDV
            // 
            this.buttonDV.Location = new System.Drawing.Point(335, 50);
            this.buttonDV.Name = "buttonDV";
            this.buttonDV.Size = new System.Drawing.Size(95, 23);
            this.buttonDV.TabIndex = 19;
            this.buttonDV.Text = "Dump with Verify";
            this.buttonDV.UseVisualStyleBackColor = true;
            this.buttonDV.Click += new System.EventHandler(this.buttonDV_Click);
            // 
            // groupBoxOO
            // 
            this.groupBoxOO.Controls.Add(this.buttonOL);
            this.groupBoxOO.Controls.Add(this.labeliPYS);
            this.groupBoxOO.Controls.Add(this.labeliPY);
            this.groupBoxOO.Controls.Add(this.buttonSIDB);
            this.groupBoxOO.Controls.Add(this.iPY);
            this.groupBoxOO.Controls.Add(this.iPYS);
            this.groupBoxOO.Location = new System.Drawing.Point(386, 64);
            this.groupBoxOO.Name = "groupBoxOO";
            this.groupBoxOO.Size = new System.Drawing.Size(280, 130);
            this.groupBoxOO.TabIndex = 22;
            this.groupBoxOO.TabStop = false;
            this.groupBoxOO.Text = "Other Options";
            // 
            // buttonOL
            // 
            this.buttonOL.Location = new System.Drawing.Point(7, 100);
            this.buttonOL.Name = "buttonOL";
            this.buttonOL.Size = new System.Drawing.Size(172, 23);
            this.buttonOL.TabIndex = 24;
            this.buttonOL.Text = "Open Dump in Extractor";
            this.buttonOL.UseVisualStyleBackColor = true;
            this.buttonOL.Click += new System.EventHandler(this.buttonOL_Click);
            // 
            // labeliPYS
            // 
            this.labeliPYS.AutoSize = true;
            this.labeliPYS.Location = new System.Drawing.Point(22, 46);
            this.labeliPYS.Name = "labeliPYS";
            this.labeliPYS.Size = new System.Drawing.Size(0, 13);
            this.labeliPYS.TabIndex = 17;
            // 
            // labeliPY
            // 
            this.labeliPY.AutoSize = true;
            this.labeliPY.Location = new System.Drawing.Point(22, 17);
            this.labeliPY.Name = "labeliPY";
            this.labeliPY.Size = new System.Drawing.Size(0, 13);
            this.labeliPY.TabIndex = 16;
            // 
            // buttonSIDB
            // 
            this.buttonSIDB.Location = new System.Drawing.Point(7, 71);
            this.buttonSIDB.Name = "buttonSIDB";
            this.buttonSIDB.Size = new System.Drawing.Size(172, 23);
            this.buttonSIDB.TabIndex = 15;
            this.buttonSIDB.Text = "Save Info 2 Data Base";
            this.buttonSIDB.UseVisualStyleBackColor = true;
            this.buttonSIDB.Click += new System.EventHandler(this.buttonSIDB_Click);
            // 
            // groupSPIW
            // 
            this.groupSPIW.Controls.Add(this.console);
            this.groupSPIW.Controls.Add(this.selectSerialPort);
            this.groupSPIW.Controls.Add(this.buttonDV);
            this.groupSPIW.Controls.Add(this.Dump);
            this.groupSPIW.Controls.Add(this.ChipInfo);
            this.groupSPIW.Controls.Add(this.Write);
            this.groupSPIW.Controls.Add(this.WriteV);
            this.groupSPIW.Controls.Add(this.Erase);
            this.groupSPIW.Controls.Add(this.CheckSCP);
            this.groupSPIW.Location = new System.Drawing.Point(12, 197);
            this.groupSPIW.Name = "groupSPIW";
            this.groupSPIW.Size = new System.Drawing.Size(654, 478);
            this.groupSPIW.TabIndex = 23;
            this.groupSPIW.TabStop = false;
            this.groupSPIW.Text = "SPIway";
            // 
            // DevBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 681);
            this.Controls.Add(this.groupSPIW);
            this.Controls.Add(this.groupBoxOO);
            this.Controls.Add(this.groupCI);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.textSave);
            this.Controls.Add(this.textOpen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DevBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PS4 Flash Manager";
            this.Load += new System.EventHandler(this.DevBoard_Load);
            this.groupCI.ResumeLayout(false);
            this.groupCI.PerformLayout();
            this.groupBoxOO.ResumeLayout(false);
            this.groupBoxOO.PerformLayout();
            this.groupSPIW.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Dump;
        private System.Windows.Forms.Button ChipInfo;
        private ConsoleControl.ConsoleControl console;
        private System.Windows.Forms.Button Write;
        private System.Windows.Forms.Button Erase;
        private System.Windows.Forms.OpenFileDialog openDump;
        private System.Windows.Forms.SaveFileDialog saveDump;
        private System.Windows.Forms.TextBox textOpen;
        private System.Windows.Forms.TextBox textSave;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button CheckSCP;
        private System.Windows.Forms.Button WriteV;
        private System.Windows.Forms.Button iPYS;
        private System.Windows.Forms.Button iPY;
        private System.Windows.Forms.ComboBox selectSerialPort;
        private System.Windows.Forms.TextBox textMAC;
        private System.Windows.Forms.TextBox textCID;
        private System.Windows.Forms.GroupBox groupCI;
        private System.Windows.Forms.Label labelMAC;
        private System.Windows.Forms.Label labelCS;
        private System.Windows.Forms.Button buttonDV;
        private System.Windows.Forms.Label labelSKU;
        private System.Windows.Forms.TextBox textSKU;
        private System.Windows.Forms.GroupBox groupBoxOO;
        private System.Windows.Forms.Button buttonSIDB;
        private System.Windows.Forms.GroupBox groupSPIW;
        private System.Windows.Forms.TextBox textSHA1;
        private System.Windows.Forms.Label labelSHA1;
        private System.Windows.Forms.TextBox textFWV;
        private System.Windows.Forms.Label labelFWV;
        private System.Windows.Forms.Label labeliPYS;
        private System.Windows.Forms.Label labeliPY;
        private System.Windows.Forms.Button buttonOL;
    }
}