using Log;
using nor4ps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;

namespace PS4AC1DFlashTool
{
    public partial class DevBoard : Form
    {
        #region Vars
        static int i = 0;
        static int s, r;
        static string com, cmd, path, finalVar, bufferString;
        static string py = "SPIway.bat";
        static string l = "log.txt";
        public static string overLoad = "";
        //static string dc = "developer.conf";
        static byte[] bufferA = new byte[0];
        static byte[] bufferB = new byte[0];
        static byte[] bufferC = new byte[0];
        static byte[] bufferD = new byte[0];
        static byte[] bufferE = new byte[0];
        #endregion Vars

        private void CheckSerialPort()
        {
            var ports = SerialPort.GetPortNames();
            selectSerialPort.DataSource = ports;
        }

        private void CheckDumpPS4(string str)
        {
            s = 0;
            r = 0;

            if (str == "s")
            {
                bufferString = textSave.Text;
            }
            else if (str == "o")
            {
                bufferString = textOpen.Text;
            }

            ASCIIEncoding encode = new ASCIIEncoding();
            PS4Nor.CheckDumpFull(bufferString);

            #region CheckingResult
            if (PS4Nor._sceBigMagic == true)
            {
                s++;
                console.WriteOutput("sceBigMagic is OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "sceBigMagic is OK!");
            }
            else
            {
                r++;
                console.WriteOutput("sceBigMagic is NOT OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "sceBigMagic is NOT OK!");
            }
            if (PS4Nor._sceSmallMagic1 == true)
            {
                s++;
                console.WriteOutput("sceSmallMagic1 is OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "sceSmallMagic1 is OK!");
            }
            else
            {
                r++;
                console.WriteOutput("sceSmallMagic1 is NOT OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "sceSmallMagic1 is NOT OK!");
            }
            if (PS4Nor._sceSmallMagic2 == true)
            {
                s++;
                console.WriteOutput("sceSmallMagic2 is OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "sceSmallMagic2 is OK!");
            }
            else
            {
                r++;
                console.WriteOutput("sceSmallMagic2 is NOT OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "sceSmallMagic2 is NOT OK!");
            }
            if (PS4Nor._dbcbMagic1 == true)
            {
                s++;
                console.WriteOutput("dbcbMagic1 is OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "dbcbMagic1 is OK!");
            }
            else
            {
                r++;
                console.WriteOutput("dbcbMagic1 is NOT OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "dbcbMagic1 is NOT OK!");
            }
            if (PS4Nor._dbcbMagic2 == true)
            {
                s++;
                console.WriteOutput("dbcbMagic2 is OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "dbcbMagic2 is OK!");
            }
            else
            {
                r++;
                console.WriteOutput("dbcbMagic2 is NOT OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "dbcbMagic2 is NOT OK!");
            }
            if (PS4Nor._dbcbMagic3 == true)
            {
                s++;
                console.WriteOutput("dbcbMagic3 is OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "dbcbMagic3 is OK!");
            }
            else
            {
                r++;
                console.WriteOutput("dbcbMagic3 is NOT OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "dbcbMagic3 is NOT OK!");
            }
            if (PS4Nor._scevtrmMagic1 == true)
            {
                s++;
                console.WriteOutput("scevtrmMagic1 is OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "scevtrmMagic1 is OK!");
            }
            else
            {
                r++;
                console.WriteOutput("scevtrmMagic1 is NOT OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "scevtrmMagic1 is NOT OK!");
            }
            if (PS4Nor._scevtrmMagic2 == true)
            {
                s++;
                console.WriteOutput("scevtrmMagic2 is OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "scevtrmMagic2 is OK!");
            }
            else
            {
                r++;
                console.WriteOutput("scevtrmMagic2 is NOT OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "scevtrmMagic2 is NOT OK!");
            }
            if (PS4Nor._slb2Magic1 == true)
            {
                s++;
                console.WriteOutput("slb2Magic1 is OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "slb2Magic1 is OK!");
            }
            else
            {
                r++;
                console.WriteOutput("slb2Magic1 is NOT OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "slb2Magic1 is NOT OK!");
            }
            if (PS4Nor._slb2Magic2 == true)
            {
                s++;
                console.WriteOutput("slb2Magic2 is OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "slb2Magic2 is OK!");
            }
            else
            {
                r++;
                console.WriteOutput("slb2Magic2 is NOT OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "slb2Magic2 is NOT OK!");
            }
            if (PS4Nor._slb2Magic3 == true)
            {
                s++;
                console.WriteOutput("slb2Magic3 is OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "slb2Magic3 is OK!");
            }
            else
            {
                r++;
                console.WriteOutput("slb2Magic3 is NOT OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "slb2Magic3 is NOT OK!");
            }
            if (PS4Nor._slb2Magic4 == true)
            {
                s++;
                console.WriteOutput("slb2Magic4 is OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "slb2Magic4 is OK!");
            }
            else
            {
                r++;
                console.WriteOutput("slb2Magic4 is NOT OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "slb2Magic4 is NOT OK!");
            }
            if (PS4Nor._blobMagic1 == true)
            {
                s++;
                console.WriteOutput("1 512 byte long Hex-Blob with constant Offset in Unk File is OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "1 512 byte long Hex-Blob with constant Offset in Unk File is OK!");
            }
            else
            {
                r++;
                console.WriteOutput("1 512 byte long Hex-Blob with constant Offset in Unk File is NOT OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "1 512 byte long Hex-Blob with constant Offset in Unk File is NOT OK!");
            }
            if (PS4Nor._blobMagic2 == true)
            {
                s++;
                console.WriteOutput("2 512 byte long Hex-Blob with constant Offset in Unk File is OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "2 512 byte long Hex-Blob with constant Offset in Unk File is OK!");
            }
            else
            {
                r++;
                console.WriteOutput("2 512 byte long Hex-Blob with constant Offset in Unk File is NOT OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "2 512 byte long Hex-Blob with constant Offset in Unk File is NOT OK!");
            }
            if (PS4Nor._blobMagic3 == true)
            {
                s++;
                console.WriteOutput("3 512 byte long Hex-Blob with constant Offset in Unk File is OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "3 512 byte long Hex-Blob with constant Offset in Unk File is OK!");
            }
            else
            {
                r++;
                console.WriteOutput("3 512 byte long Hex-Blob with constant Offset in Unk File is NOT OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "3 512 byte long Hex-Blob with constant Offset in Unk File is NOT OK!");
            }
            if (PS4Nor._blobMagic4 == true)
            {
                s++;
                console.WriteOutput("4 512 byte long Hex-Blob with constant Offset in Unk File is OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "4 512 byte long Hex-Blob with constant Offset in Unk File is OK!");
            }
            else
            {
                r++;
                console.WriteOutput("4 512 byte long Hex-Blob with constant Offset in Unk File is NOT OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "4 512 byte long Hex-Blob with constant Offset in Unk File is NOT OK!");
            }
            if (PS4Nor._blobMagic5 == true)
            {
                s++;
                console.WriteOutput("5 304 byte long Hex-Blob with constant Offset in Unk File is OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "5 304 byte long Hex-Blob with constant Offset in Unk File is OK!");
            }
            else
            {
                r++;
                console.WriteOutput("5 304 byte long Hex-Blob with constant Offset in Unk File is NOT OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "5 304 byte long Hex-Blob with constant Offset in Unk File is NOT OK!");
            }
            if (PS4Nor._blobMagic6 == true)
            {
                s++;
                console.WriteOutput("6 224 byte long Hex-Blob with constant Offset in Unk File is OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "6 224 byte long Hex-Blob with constant Offset in Unk File is OK!");
            }
            else
            {
                r++;
                console.WriteOutput("6 224 byte long Hex-Blob with constant Offset in Unk File is NOT OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "6 224 byte long Hex-Blob with constant Offset in Unk File is NOT OK!");
            }
            if (PS4Nor._blobMagic7 == true)
            {
                s++;
                console.WriteOutput("7 352 byte long Hex-Blob with constant Offset in Unk File is OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "7 352 byte long Hex-Blob with constant Offset in Unk File is OK!");
            }
            else
            {
                r++;
                console.WriteOutput("7 352 byte long Hex-Blob with constant Offset in Unk File is NOT OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "7 352 byte long Hex-Blob with constant Offset in Unk File is NOT OK!");
            }
            if (PS4Nor._blobMagic8 == true)
            {
                s++;
                console.WriteOutput("8 64 byte long Hex-Blob with constant Offset in Unk File is OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "8 64 byte long Hex-Blob with constant Offset in Unk File is OK!");
            }
            else
            {
                r++;
                console.WriteOutput("8 64 byte long Hex-Blob with constant Offset in Unk File is NOT OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "8 64 byte long Hex-Blob with constant Offset in Unk File is NOT OK!");
            }
            if (PS4Nor._blobMagic9 == true)
            {
                s++;
                console.WriteOutput("2 32 byte long Hex-Blob of Console Specific Constant in SCEVTRM is OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "2 32 byte long Hex-Blob of Console Specific Constant in SCEVTRM is OK!");
            }
            else
            {
                r++;
                console.WriteOutput("2 32 byte long Hex-Blob of Console Specific Constant in SCEVTRM is NOT OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "2 32 byte long Hex-Blob of Console Specific Constant in SCEVTRM is NOT OK!");
            }
            if (PS4Nor._ccMagic1 == true)
            {
                s++;
                console.WriteOutput("1 50 byte long Console Constant Hex-Blob in SCEVTRM is OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "1 50 byte long Console Constant Hex-Blob in SCEVTRM is OK!");
            }
            else
            {
                r++;
                console.WriteOutput("1 50 byte long Console Constant Hex-Blob in SCEVTRM is NOT OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "1 50 byte long Console Constant Hex-Blob in SCEVTRM is NOT OK!");
            }
            if (PS4Nor._ccMagic2 == true)
            {
                s++;
                console.WriteOutput("2 48 byte long Console Constant Hex-Blob in Unk File is OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "2 48 byte long Console Constant Hex-Blob in Unk File is OK!");
            }
            else
            {
                r++;
                console.WriteOutput("2 48 byte long Console Constant Hex-Blob in Unk File is NOT OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "2 48 byte long Console Constant Hex-Blob in Unk File is NOT OK!\n");
            }
            if (PS4Nor._ccMagic3 == true)
            {
                s++;
                console.WriteOutput("3 9 byte long Console Constant Hex-Blob in Unk File is OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "3 9 byte long Console Constant Hex-Blob in Unk File is OK!");
            }
            else
            {
                r++;
                console.WriteOutput("3 9 byte long Console Constant Hex-Blob in Unk File is NOT OK!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "3 9 byte long Console Constant Hex-Blob in Unk File is NOT OK!");
            }
            if (PS4Nor._c01A == true)
            {
                s++;
                console.WriteOutput("1 32 byte long Hex-Blob of MediaCon FW Stage1 & Stage2 do Match between each Other!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "1 32 byte long Hex-Blob of MediaCon FW Stage1 & Stage2 do Match between each Other!");
            }
            else
            {
                r++;
                console.WriteOutput("1 32 byte long Hex-Blob of MediaCon FW Stage1 & Stage2 do NOT Match between each Other!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "1 32 byte long Hex-Blob of MediaCon FW Stage1 & Stage2 do NOT Match between each Other!");
            }
            if (PS4Nor._c01B == true)
            {
                s++;
                console.WriteOutput("2 32 byte long Hex-Blob of MediaCon FW Stage1 & Stage2 do Match between each Other!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "2 32 byte long Hex-Blob of MediaCon FW Stage1 & Stage2 do Match between each Other!");
            }
            else
            {
                r++;
                console.WriteOutput("2 32 byte long Hex-Blob of MediaCon FW Stage1 & Stage2 do NOT Match between each Other!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "2 32 byte long Hex-Blob of MediaCon FW Stage1 & Stage2 do NOT Match between each Other!");
            }
            if (PS4Nor._slb2NR3Checksum == true)
            {
                s++;
                console.WriteOutput("Checksum of the Third SLB2 in Flash Image is not Null or only FF bytes...does look Good!\n\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "Checksum of the Third SLB2 in Flash Image is not Null or only FF bytes...does look Good!");
            }
            else
            {
                r++;
                console.WriteOutput("Checksum of the Third SLB2 in Flash Image is Null or only FF bytes...does NOT look Good!\n\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "Checksum of the Third SLB2 in Flash Image is Null or only FF bytes...does NOT look Good!");
            }
            #endregion CheckingResult

            #region GetCID
            //Checking MAC Address and Display it in the GUI
            bufferA = PS4Nor.GetMAC(textOpen.Text);
            if (bufferA != null && bufferA != PS4Nor.ffMAC)
            {
                s++;
                textMAC.Text = BitConverter.ToString(bufferA).Replace("-", ":");
                console.WriteOutput("Console MAC Address is: " + textMAC.Text + "\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "Console MAC Address is: " + textMAC.Text);
            }
            else
            {
                r++;
                console.WriteOutput("Console MAC Address is only Null or FF Bytes!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "Console MAC Address is only Null or FF Bytes!");
            }
            bufferA = null;

            // Checking Console Serial and Display it in the GUI
            bufferA = PS4Nor.GetCID(textOpen.Text);
            if (bufferA != null && bufferA != PS4Nor.ffCSerial)
            {
                s++;
                bufferString = encode.GetString(bufferA);
                textCID.Text = bufferString.Insert(10, "-");
                console.WriteOutput("Console Serial is: " + textCID.Text + "\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "Console Serial is:" + textCID.Text);
            }
            else
            {
                r++;
                console.WriteOutput("Console Serial is only Null or FF Bytes!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "Console Serial is only Null or FF Bytes!");
            }
            bufferA = null;

            // Checking SKU Version and Display it in the GUI
            bufferA = PS4Nor.GetSKU(textOpen.Text);
            if (bufferA != null && bufferA != PS4Nor.ffSKU)
            {
                s++;
                textSKU.Text = encode.GetString(bufferA);
                console.WriteOutput("Console SKU Version is: " + textSKU.Text + "\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "Console SKU Version is: " + textSKU.Text);
            }
            else
            {
                r++;
                console.WriteOutput("Console SKU Version is only Null or FF Bytes!\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "Console SKU Version is only Null or FF Bytes!");
            }
            bufferA = null;

            // Checking FirmWare Version and Display it in the GUI
            bufferA = PS4Nor.GetFWV(textOpen.Text);
            if (bufferA != null && bufferA != PS4Nor.ffMAC)
            {
                s++;
                bufferString = BitConverter.ToString(bufferA).Replace("-", "");
                textFWV.Text = bufferString.Insert(2, ".").Replace("01.", "1.").Replace("02.", "2.").Replace("03.", "3.").Replace("04.", "4.").Replace("05.", "5.").Replace("06.", "6.").Replace("07.", "7.").Replace("08.", "8.").Replace("09.", "9.").Insert(4, ".");
                console.WriteOutput("Console FirmWare Version is: " + textFWV.Text + "\n\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "Console FirmWare Version is: " + textFWV.Text);
            }
            else
            {
                r++;
                console.WriteOutput("Console FirmWare Version is only Null or FF Bytes!\n\n", System.Drawing.Color.Yellow);
                Logger.WriteLine(l, "Console FirmWare Version is only Null or FF Bytes!");
            }
            bufferA = null;
            #endregion CheckingCID

            Logger.WriteLine(l, "Result: " + s.ToString() + " of 31 Checks Passed!!\nErrors: " + r.ToString() + " where Detected!!");
            console.WriteOutput("Result: " + s.ToString() + " of 31 Checks Passed\nErrors: " + r.ToString() + " where Detected!!\n\n", System.Drawing.Color.Yellow);

            if (r == 0 && str == "o" || r != 0 && str == "o" && File.Exists("developer.conf") == true)
            {
                Write.Enabled = true;
                WriteV.Enabled = true;
                buttonOL.Enabled = true;
            }
            else if (r == 0 && str == "s" || r != 0 && str == "s" && File.Exists("developer.conf") == true)
            {
                buttonOL.Enabled = true;
            }
        }

        private void CheckPython272()
        {
            if (Tool.CheckInstalledSoft("hklm", @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall", "DisplayName", "Python 2.7.2") == true)
            {
                labeliPY.Text = "Installed";
                iPY.Enabled = false;
                console.WriteOutput("Python 2.7.2 is Installed\n", System.Drawing.Color.Yellow);
            }
            else
            {
                labeliPY.Text = "Not Installed";
                iPY.Enabled = true;
                console.WriteOutput("Python 2.7.2 is Not Installed\n", System.Drawing.Color.Yellow);
            }
        }

        private void CheckPythonSerial()
        {
            if (Tool.CheckInstalledSoft("hkcu", @"Software\Microsoft\Windows\CurrentVersion\Uninstall", "DisplayName", "Python 2.7 pyserial-2.5") == true)
            {
                labeliPYS.Text = "Installed";
                iPYS.Enabled = false;
                console.WriteOutput("Python Serial is Installed\n\n", System.Drawing.Color.Yellow);
            }
            else
            {
                labeliPYS.Text = "Not Installed";
                iPYS.Enabled = true;
                console.WriteOutput("Python Serial is Not Installed\n\n", System.Drawing.Color.Yellow);
            }
        }
        
        public DevBoard()
        {
            InitializeComponent();
        }

        private void DevBoard_Load(object sender, EventArgs e)
        {
            console.ShowDiagnostics = true;
            console.WriteOutput("Welcome to the Flash Manager\nby cfwprophet (c)\n\nThe Teensy will be handled by @judges SPIway.py script\n\nConsoleControl.dll by Dave Kerr\n\n", System.Drawing.Color.Yellow);
            CheckSerialPort();
            CheckPython272();
            CheckPythonSerial();
            Write.Enabled = false;
            WriteV.Enabled = false;
            buttonSIDB.Enabled = false;
            buttonOL.Enabled = false;
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (openDump.ShowDialog() == DialogResult.OK)
            {
                SHA1 sha = new SHA1CryptoServiceProvider();
                textOpen.Text = openDump.FileName;
                s = textOpen.Text.Length;
                bufferString = textOpen.Text.Replace(" ", "");
                r = bufferString.Length;

                if (s != r && s != 0 && r != 0)
                {
                    MessageBox.Show("Please don't use Spaces in Filenames\nThis time i'll Rename the File for you");
                    Logger.WriteLine(l, "Please don't use Spaces in Filenames\nThis time i'll Rename the File for you\n\n");
                    File.Move(openDump.FileName, bufferString);
                    textOpen.Text = bufferString;

                    if (!File.Exists(textOpen.Text))
                    {
                        MessageBox.Show("Something went wrong, I can't find/access the renamed File");
                        Logger.WriteLine(l, "Something went wrong, I can't find/access the renamed File\n\n");
                    }
                    else
                    {
                        console.WriteOutput("Input Dump specified: " + textOpen.Text + "\n", System.Drawing.Color.Yellow);
                        Logger.WriteLine(l, "Input Dump specified: " + textOpen.Text);

                        bufferB = new byte[20];
                        Tool.readBuffer = null;
                        Tool.ReadWriteData(textOpen.Text, null, "r");
                        bufferB = sha.ComputeHash(Tool.readBuffer);
                        textSHA1.Text = BitConverter.ToString(bufferB).Replace("-", "");

                        console.WriteOutput("SHA1 is: " + textSHA1.Text + "\n\n", System.Drawing.Color.Yellow);
                        Logger.WriteLine(l, "SHA1 is: " + textSHA1.Text);

                        i = 1;
                        s = 0; r = 0;

                        CheckDumpPS4("o");
                    }
                }
                else
                {
                    console.WriteOutput("Input Dump specified: " + textOpen.Text + "\n", System.Drawing.Color.Yellow);
                    Logger.WriteLine(l, "Input Dump specified: " + textOpen.Text);

                    bufferB = new byte[20];
                    Tool.readBuffer = null;
                    Tool.ReadWriteData(textOpen.Text, null, "r");
                    bufferB = sha.ComputeHash(Tool.readBuffer);
                    textSHA1.Text = BitConverter.ToString(bufferB).Replace("-", "");

                    console.WriteOutput("SHA1 is: " + textSHA1.Text + "\n\n", System.Drawing.Color.Yellow);
                    Logger.WriteLine(l, "SHA1 is: " + textSHA1.Text);

                    i = 1;
                    s = 0; r = 0;

                    CheckDumpPS4("o");
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (saveDump.ShowDialog() == DialogResult.OK)
            {
                textSave.Text = saveDump.FileName;
                s = 0; r = 0;
                s = textSave.Text.Length;
                bufferString = textSave.Text.Replace(" ", "");
                r = bufferString.Length;

                if (s != r && s != 0 && r != 0)
                {
                    MessageBox.Show("Please don't use Spaces in Filenames\nThis time i'll Rename the File for you");
                    Logger.WriteLine(l, "Please don't use Spaces in Filenames\nThis time i'll Rename the File for you\n\n");
                    File.Create(bufferString);
                    textSave.Text = bufferString;

                    if (!File.Exists(textSave.Text))
                    {
                        MessageBox.Show("Something went wrong, I can't find/access the renamed File");
                        Logger.WriteLine(l, "Something went wrong, I can't find/access the renamed File\n\n");
                    }
                    else
                    {
                        console.WriteOutput("Output Dump specified: " + textSave.Text + "\n", System.Drawing.Color.Yellow);
                        Logger.WriteLine(l, "Output Dump specified: " + textSave.Text);
                        i = 1;
                        s = 0; r = 0;
                    }
                }
                else
                {
                    File.Create(textSave.Text);

                    console.WriteOutput("Output Dump specified: " + textSave.Text + "\n", System.Drawing.Color.Yellow);
                    Logger.WriteLine(l, "Output Dump specified: " + textSave.Text);
                    i = 1;
                    s = 0; r = 0;
                }
            }
        }

        private void buttonSIDB_Click(object sender, EventArgs e)
        {
            // We write the Console Infos into a DataBase for later use
            // But first we check if the DataBase allready exists, if not we generate one.
            if (!File.Exists("dump.db"))
            {
                File.Create("dump.db").Close();
                Logger.WriteText("dump.db", "|-------------------------------------------------------------------------------------------------------|");
                Logger.WriteText("dump.db", "|------------------------------------|  PS4 Flash Dump DataBase  |--------------------------------------|");
                Logger.WriteText("dump.db", "|-------------------------------------------------------------------------------------------------------|");

            }
            else
            {
                Logger.WriteText("dump.db", "|----------------| New Entry |----------------| New Entry |----------------| New Entry |----------------|");
                Logger.WriteText("dump.db", "|-------------------------------------------------------------------------------------------------------|");
            }

            if (textOpen.Text != "Open PS4 NOR Dump...")
            {
                bufferString = textOpen.Text;
            }
            else if (textSave.Text != "Save PS4 NOR Dump...")
            {
                bufferString = textSave.Text;
            }

            int n = 77;
            int l = bufferString.Length;
            string result = bufferString;

            if (l <= n)
            {
                int m = n - l;
                string[] buffer = new string[m];
                StringBuilder newString = new StringBuilder();
                newString.Append(" |");

                for (int z = 0; z < m; z++)
                {
                    buffer[z] = "-";
                }

                foreach (string value in buffer)
                {
                    newString.Append(value);
                }

                result = bufferString + newString.ToString() + "|";
            }

            Logger.WriteText("dump.db", "| Name and Path of File: " + result);
            Logger.WriteText("dump.db", "|-------------------------------------------------------------------------------------------------------|");
            Logger.WriteText("dump.db", "| SHA1 Checksum of File: " + textSHA1.Text + " |-------------------------------------|");
            Logger.WriteText("dump.db", "|-------------------------------------------|-----------------------------------------------------------|");
            Logger.WriteText("dump.db", "| Console FirmW Version: " + textFWV.Text + "          |-----------------------------------------------------------|");
            Logger.WriteText("dump.db", "|-------------------------------------------|-----------------------------------------------------------|");
            Logger.WriteText("dump.db", "| Console Serial Number: " + textCID.Text + " |-----------------------------------------------------------|");
            Logger.WriteText("dump.db", "|-------------------------------------------|-----------------------------------------------------------|");
            Logger.WriteText("dump.db", "| Console MAC Address: " + textMAC.Text + "    |-----------------------------------------------------------|");
            Logger.WriteText("dump.db", "|-------------------------------------------|-----------------------------------------------------------|");
            Logger.WriteText("dump.db", "| Console SKU Version: " + textSKU.Text + "       |-----------------------------------------------------------|");
            Logger.WriteText("dump.db", "|-------------------------------------------|-----------------------------------------------------------|");
            Logger.WriteText("dump.db", "|----------------| New Entry |----------------| New Entry |----------------| New Entry |----------------|");

            MessageBox.Show("Console Infos saved to DataBase....");
        }

        private void iPY_Click(object sender, EventArgs e)
        {
            // Install Phyton if not allready on the Sys   
            console.StartProcess(@"Installers\python-2.7.2.msi", null);
            CheckPython272();
        }

        private void iPYS_Click(object sender, EventArgs e)
        {
            // Instal Phyton Serial if not allready on the Sys
            console.StartProcess(@"Installers\pyserial-2.5.win32.exe", null);
            CheckPythonSerial();
        }

        private void CheckSCP_Click(object sender, EventArgs e)
        {
            CheckSerialPort();
        }

        private void ChipInfo_Click(object sender, EventArgs e)
        {
            com = selectSerialPort.Text;
            cmd = " info";
            finalVar = com + cmd;
            console.StartProcess(py, finalVar);
            Logger.WriteLine(l, py + finalVar);
        }

        private void Dump_Click(object sender, EventArgs e)
        {
            if (textSave.Text == "Save PS4 NOR Dump...")
            {
                MessageBox.Show("No PS4 NOR Dump to save defined !");
                if (saveDump.ShowDialog() == DialogResult.OK)
                {
                    textSave.Text = saveDump.FileName;
                    s = 0; r = 0;
                    s = textSave.Text.Length;
                    bufferString = textSave.Text.Replace(" ", "");
                    r = bufferString.Length;

                    if (s != r && s != 0 && r != 0)
                    {
                        MessageBox.Show("Please don't use Spaces in Filenames\nThis time i'll Rename the File for you");
                        Logger.WriteLine(l, "Please don't use Spaces in Filenames\nThis time i'll Rename the File for you\n\n");
                        File.Create(bufferString);
                        textSave.Text = bufferString;

                        if (!File.Exists(textSave.Text))
                        {
                            MessageBox.Show("Something went wrong, I can't find/access the renamed File");
                            Logger.WriteLine(l, "Something went wrong, I can't find/access the renamed File\n\n");
                        }
                    }
                    else
                    {
                        File.Create(textSave.Text).Close();
                    }

                    console.WriteOutput("Output Dump specified: " + textSave.Text, System.Drawing.Color.Yellow);
                    Logger.WriteLine(l, "Output Dump specified: " + textSave.Text);
                    com = selectSerialPort.Text;
                    cmd = " dump ";
                    path = textSave.Text;
                    finalVar = com + cmd + path;

                    console.StartProcess(py, finalVar);
                }
            }
            else
            {
                if (!File.Exists(textSave.Text))
                {
                    MessageBox.Show("Something went wrong, I can't find/access your File");
                    Logger.WriteLine(l, "Something went wrong, I can't find/access your File\n\n");
                }
                else
                {
                    if (i == 0)
                    {
                        console.WriteOutput("Output Dump specified: " + textSave.Text, System.Drawing.Color.Yellow);
                        Logger.WriteLine(l, "Output Dump specified: " + textSave.Text);
                    }

                    com = selectSerialPort.Text;
                    cmd = " dump ";
                    path = textSave.Text;
                    finalVar = com + cmd + path;

                    console.StartProcess(py, finalVar);
                }
            }
        }

        private void buttonDV_Click(object sender, EventArgs e)
        {
            if (textSave.Text == "Save PS4 NOR Dump...")
            {
                MessageBox.Show("No PS4 NOR Dump to save defined!");
                if (saveDump.ShowDialog() == DialogResult.OK)
                {
                    textSave.Text = saveDump.FileName;
                    s = 0; r = 0;
                    s = textSave.Text.Length;
                    bufferString = textSave.Text.Replace(" ", "");
                    r = bufferString.Length;

                    if (s != r && s != 0 && r != 0)
                    {
                        MessageBox.Show("Please don't use Spaces in Filenames\nThis time i'll Rename the File for you");
                        Logger.WriteLine(l, "Please don't use Spaces in Filenames\nThis time i'll Rename the File for you\n\n");
                        File.Create(bufferString);
                        textSave.Text = bufferString;
                        if (!File.Exists(textSave.Text))
                        {
                            MessageBox.Show("Something went wrong, I can't find/access the renamed File");
                            Logger.WriteLine(l, "Something went wrong, I can't find/access the renamed File\n\n");
                        }
                    }
                    else
                    {
                        File.Create(textSave.Text);
                    }

                    // We repeat the Dump and Check Process 3 times and everytime write the SHA1 into a buffer. Then we compare all 3 SHA1 sums if they match against each other
                    console.WriteOutput("Output Dump specified: " + textSave.Text, System.Drawing.Color.Yellow);
                    Logger.WriteLine(l, "Output Dump specified: " + textSave.Text);
                    com = selectSerialPort.ToString();
                    cmd = " dump ";
                    path = textSave.Text;
                    finalVar = (com + cmd + path);
                    console.StartProcess(py, finalVar);
                    s = 0; r = 0;

                    if (File.Exists(textSave.Text))
                    {
                        int i = 1;
                        while (i != 4)
                        {
                            CheckDumpPS4("s");
                            SHA1 sha = new SHA1CryptoServiceProvider();
                            bufferB = new byte[20];
                            Tool.readBuffer = null;
                            Tool.ReadWriteData(textSave.Text, null, "r");
                            bufferB = sha.ComputeHash(Tool.readBuffer);
                            textSHA1.Text = BitConverter.ToString(bufferB).Replace("-", "");
                            console.WriteOutput("SHA1 is: " + textSHA1.Text + "\n\n", System.Drawing.Color.Yellow);
                            Logger.WriteLine(l, "SHA1 is: " + textSHA1.Text);

                            if (i == 1)
                            {
                                bufferC = new byte[20];
                                bufferC = bufferB;
                            }

                            if (i == 2)
                            {
                                bufferD = new byte[20];
                                bufferD = bufferB;
                            }

                            if (i == 3)
                            {
                                bufferE = new byte[20];
                                bufferE = bufferB;
                            }

                            i++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!!I can't access the specified Dump File!!");
                        console.WriteOutput("Something went wrong!!I can't access the specified Dump File!!\n\n", System.Drawing.Color.Yellow);
                        Logger.WriteLine(l, "Something went wrong!!I can't access the specified Dump File!!");
                    }

                    if (Tool.CompareBytes(bufferC, bufferD) == true && Tool.CompareBytes(bufferD, bufferE) == true)
                    {
                        MessageBox.Show("The SHA1 of all 3 Dumped Files do match against each other!!");
                        console.WriteOutput("The SHA1 of all 3 Dumped Files do match against each other!!\n\n", System.Drawing.Color.Yellow);
                        Logger.WriteLine(l, "The SHA1 of all 3 Dumped Files do match against each other!!");
                    }
                }
            }
            else
            {
                s = 0; r = 0;
                s = textSave.Text.Length;
                bufferString = textSave.Text.Replace(" ", "");
                r = bufferString.Length;

                if (s != r && s != 0 && r != 0)
                {
                    MessageBox.Show("Please don't use Spaces in Filenames\nThis time i'll Rename the File for you");
                    Logger.WriteLine(l, "Please don't use Spaces in Filenames\nThis time i'll Rename the File for you\n\n");
                    File.Move(saveDump.FileName, bufferString);
                    textSave.Text = bufferString;
                    if (!File.Exists(textSave.Text))
                    {
                        MessageBox.Show("Something went wrong, I can't find/access the renamed File");
                        Logger.WriteLine(l, "Something went wrong, I can't find/access the renamed File\n\n");
                    }
                    else
                    {
                        console.WriteOutput("Output Dump specified: " + textSave.Text, System.Drawing.Color.Yellow);
                        Logger.WriteLine(l, "Output Dump specified: " + textSave.Text);
                        i = 1;
                    }
                }

                if (i == 0)
                {
                    console.WriteOutput("Output Dump specified: " + textSave.Text, System.Drawing.Color.Yellow);
                    Logger.WriteLine(l, "Output Dump specified: " + textSave.Text);
                }

                // We repeat the Dump and Check Process 3 times and everytime write the SHA1 into a buffer. Then we compare all 3 SHA1 sums if they match against each other
                com = selectSerialPort.ToString();
                cmd = " dump ";
                path = textSave.Text;
                finalVar = (com + cmd + path);
                console.StartProcess(py, finalVar);
                s = 0; r = 0;

                if (File.Exists(textSave.Text))
                {
                    i = 1;
                    while (i != 4)
                    {
                        CheckDumpPS4("s");
                        SHA1 sha = new SHA1CryptoServiceProvider();
                        bufferB = new byte[20];
                        Tool.readBuffer = null;
                        Tool.ReadWriteData(textSave.Text, null, "r");
                        bufferB = sha.ComputeHash(Tool.readBuffer);
                        textSHA1.Text = BitConverter.ToString(bufferB).Replace("-", "");
                        console.WriteOutput("SHA1 is: " + textSHA1.Text + "\n\n", System.Drawing.Color.Yellow);
                        Logger.WriteLine(l, "SHA1 is: " + textSHA1.Text);

                        if (i == 1)
                        {
                            bufferC = new byte[20];
                            bufferC = bufferB;
                        }

                        if (i == 2)
                        {
                            bufferD = new byte[20];
                            bufferD = bufferB;
                        }

                        if (i == 3)
                        {
                            bufferE = new byte[20];
                            bufferE = bufferB;
                        }

                        i++;
                    }
                }
                else
                {
                    MessageBox.Show("Something went wrong!!I can't access the specified Dump File!!");
                    console.WriteOutput("Something went wrong!!I can't access the specified Dump File!!\n\n", System.Drawing.Color.Yellow);
                    Logger.WriteLine(l, "Something went wrong!!I can't access the specified Dump File!!");
                }

                if (Tool.CompareBytes(bufferC, bufferD) == true && Tool.CompareBytes(bufferD, bufferE) == true)
                {
                    MessageBox.Show("The SHA1 of all 3 Dumped Files do match against each other!!");
                    console.WriteOutput("The SHA1 of all 3 Dumped Files do match against each other!!\n\n", System.Drawing.Color.Yellow);
                    Logger.WriteLine(l, "The SHA1 of all 3 Dumped Files do match against each other!!");
                }
            }
        }

        private void Write_Click(object sender, EventArgs e)
        {
            com = selectSerialPort.ToString();
            cmd = " write ";
            path = textOpen.Text;
            finalVar = (com + cmd + path);
            console.StartProcess(py, finalVar);
        }

        private void WriteV_Click(object sender, EventArgs e)
        {
            com = selectSerialPort.Text;
            cmd = " vwrite ";
            path = textOpen.Text;
            finalVar = (com + cmd + path);
            console.StartProcess(py, finalVar);
        }

        private void Erase_Click(object sender, EventArgs e)
        {
            com = selectSerialPort.ToString();
            cmd = " erasechip";
            finalVar = (com + cmd);
            console.StartProcess(py, finalVar);
        }

        private void textSHA1_TextChanged(object sender, EventArgs e)
        {
            if (textSHA1.Text != "")
            {
                buttonSIDB.Enabled = true;
            }
        }

        private void buttonOL_Click(object sender, EventArgs e)
        {
            overLoad = textSave.Text;
            this.Hide();
            Logger.WriteLine(l, "Dump File OverLoaded...");
            ExtractorDev ExtractorDev = new ExtractorDev();
            Logger.WriteLine(l, "Starting Extractor...");
            ExtractorDev.ShowDialog();
            this.Close();
            Logger.WriteLine(l, "Closing now Flash Manager...\n");
        }
    }
}
