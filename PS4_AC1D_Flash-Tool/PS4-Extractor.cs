using ConsoleControl;
using Log;
using nor4ps;
using SLB2PS4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;

namespace PS4AC1DFlashTool
{
    public partial class ExtractorDev : Form
    {
        #region Variables
        static string bufferString;
        static byte[] bufferA = new byte[4];
        static byte[] bufferB = new byte[0];
        static int flag = 0;
        string l = "log.txt";
        #endregion Variables

        private void CheckDumpPS4(string str)
        {
            int s = 0; 
            int r = 0;
            string bufferString = "";

            ASCIIEncoding encode = new ASCIIEncoding();
            PS4Nor.CheckDumpFull(textOpen.Text);

            #region CheckingCID
            //Checking MAC Address and Display it in the GUI
            bufferA = PS4Nor.GetMAC(textOpen.Text);
            if (bufferA != null && bufferA != PS4Nor.ffMAC)
            {
                s++;
                textMAC.Text = BitConverter.ToString(bufferA).Replace("-", ":");
                Logger.WriteLine(l, "Console MAC Address is: " + textMAC.Text);
            }
            else
            {
                r++;
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
                Logger.WriteLine(l, "Console Serial is:" + textCID.Text);
            }
            else
            {
                r++;
                Logger.WriteLine(l, "Console Serial is only Null or FF Bytes!");
            }
            bufferA = null;

            // Checking SKU Version and Display it in the GUI
            bufferA = PS4Nor.GetSKU(textOpen.Text);
            if (bufferA != null && bufferA != PS4Nor.ffSKU)
            {
                s++;
                textSKU.Text = encode.GetString(bufferA);
                Logger.WriteLine(l, "Console SKU Version is: " + textSKU.Text);
            }
            else
            {
                r++;
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
                Logger.WriteLine(l, "Console FirmWare Version is: " + textFWV.Text);
            }
            else
            {
                r++;
                Logger.WriteLine(l, "Console FirmWare Version is only Null or FF Bytes!");
            }
            bufferA = null;
            #endregion CheckingCID

            Logger.WriteLine(l, "Result: " + s.ToString() + " of 31 Checks Passed!!\nErrors: " + r.ToString() + " where Detected!!");
        }

        public ExtractorDev()
        {
            InitializeComponent();
        }

        private void ExtractorDev_Load(object sender, EventArgs e)
        {
            buttonExtractNow.Enabled = false;
            buttonCleardmp.Enabled = false;
            buttonClearslb.Enabled = false;

            if (DevBoard.overLoad != "notSet" && DevBoard.overLoad != "")
            {
                textOpen.Text = DevBoard.overLoad;
                DevBoard.overLoad = "notSet";
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openPS4DMP.ShowDialog() == DialogResult.OK)
            {
                textOpen.Text = openPS4DMP.FileName;

                if (PS4Nor.CheckHeader(textOpen.Text) == true)
                {
                    if (PS4Nor.CheckSize(textOpen.Text) == true)
                    {
                        SHA1 sha = new SHA1CryptoServiceProvider();
                        ASCIIEncoding encode = new ASCIIEncoding();
                        bufferB = new byte[20];
                        Tool.readBuffer = null;
                        Tool.ReadWriteData(textOpen.Text, null, "r");
                        bufferB = sha.ComputeHash(Tool.readBuffer);
                        textSHA1.Text = BitConverter.ToString(bufferB).Replace("-", "");

                        #region GetCID
                        //Checking MAC Address and Display it in the GUI
                        bufferA = PS4Nor.GetMAC(textOpen.Text);
                        if (bufferA != null && bufferA != PS4Nor.ffMAC)
                        {
                            textMAC.Text = BitConverter.ToString(bufferA).Replace("-", ":");
                            Logger.WriteLine(l, "Console MAC Address is: " + textMAC.Text);
                        }
                        else
                        {
                            Logger.WriteLine(l, "Console MAC Address is only Null or FF Bytes!");
                        }

                        bufferA = null;

                        // Checking Console Serial and Display it in the GUI
                        bufferA = PS4Nor.GetCID(textOpen.Text);
                        if (bufferA != null && bufferA != PS4Nor.ffCSerial)
                        {
                            bufferString = encode.GetString(bufferA);
                            textCID.Text = bufferString.Insert(10, "-");
                            Logger.WriteLine(l, "Console Serial is:" + textCID.Text);
                        }
                        else
                        {
                            Logger.WriteLine(l, "Console Serial is only Null or FF Bytes!");
                        }

                        bufferA = null;

                        // Checking SKU Version and Display it in the GUI
                        bufferA = PS4Nor.GetSKU(textOpen.Text);
                        if (bufferA != null && bufferA != PS4Nor.ffSKU)
                        {
                            textSKU.Text = encode.GetString(bufferA);
                            Logger.WriteLine(l, "Console SKU Version is: " + textSKU.Text);
                        }
                        else
                        {
                            Logger.WriteLine(l, "Console SKU Version is only Null or FF Bytes!");
                        }

                        bufferA = null;

                        // Checking FirmWare Version and Display it in the GUI
                        bufferA = PS4Nor.GetFWV(textOpen.Text);
                        if (bufferA != null && bufferA != PS4Nor.ffMAC)
                        {
                            bufferString = BitConverter.ToString(bufferA).Replace("-", "");
                            textFWV.Text = bufferString.Insert(2, ".").Replace("01.", "1.").Replace("02.", "2.").Replace("03.", "3.").Replace("04.", "4.").Replace("05.", "5.").Replace("06.", "6.").Replace("07.", "7.").Replace("08.", "8.").Replace("09.", "9.").Insert(4, ".");
                            Logger.WriteLine(l, "Console FirmWare Version is: " + textFWV.Text);
                        }
                        else
                        {
                            Logger.WriteLine(l, "Console FirmWare Version is only Null or FF Bytes!");
                        }
                        bufferA = null;
                        #endregion CheckingCID

                        buttonExtractNow.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("PS4 NOR Dump is corrupted\nSize miss match\n\n");
                        Logger.WriteLine(l, "PS4 NOR Dump is corrupted\nSize miss match\n\n");
                        textOpen.Text = "Select PS4 NOR Dump 2 Extract...";
                    }
                }
                else
                {
                    MessageBox.Show("This is NOT a valide PS4 NOR Dump file\nHeader miss match\n\n");
                    Logger.WriteLine(l, "This is NOT a valide PS4 NOR Dump file\nHeader miss match\n\n");
                    textOpen.Text = "Select PS4 NOR Dump 2 Extract...";
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFolder.ShowDialog() == DialogResult.OK)
            {
                textSave.Text = saveFolder.SelectedPath;;
            }
        }

        private void buttonOSLB2_Click(object sender, EventArgs e)
        {
            if (openSLB2.ShowDialog() == DialogResult.OK)
            {
                SHA1 sha = new SHA1CryptoServiceProvider();
                bufferB = new byte[20];
                Tool.readBuffer = null;

                textOSLB2.Text = openSLB2.FileName;
                if (SLB2.CheckHeader(textOSLB2.Text) != true)
                {
                    MessageBox.Show("That's NOT a valied SLB2 Container!\nHeader miss match");
                    Logger.WriteLine(l, "That's NOT a valied SLB2 Container!\nHeader miss match\n\n");
                    textOSLB2.Text = "Select PS4 SLB2 Container 2 Extract...";
                }
                else
                {
                    SLB2.Read(textOSLB2.Text);

                    if (SLB2.CheckSize() != true)
                    {
                        MessageBox.Show("SLB2 Container is corrupted!\nFile size miss match");
                        Logger.WriteLine(l, "SLB2 Container is corrupted!\nFile size miss match\n\n");

                        textOSLB2.Text = "Select PS4 SLB2 Container 2 Extract...";
                    }
                    else
                    {
                        Tool.ReadWriteData(textOSLB2.Text, null, "r");
                        bufferB = sha.ComputeHash(Tool.readBuffer);
                        textSHAslb.Text = BitConverter.ToString(bufferB).Replace("-", "");
                        textSLBVersion.Text = SLB2.GetVersion().ToString();
                        textSLBFilecount.Text = SLB2.GetFileCount().ToString();

                        buttonExtractNow.Enabled = true;
                    }
                }
            }
        }

        private void buttonSSLB2_Click(object sender, EventArgs e)
        {
            if (saveFolder.ShowDialog() == DialogResult.OK)
            {
                textSSLB2.Text = saveFolder.SelectedPath;
            }
        }

        private void textOpen_TextChanged(object sender, EventArgs e)
        {
            if (textOpen.Text != "" || textOpen.Text != "Select PS4 NOR Dump 2 Extract..." && textSave.Text != "" || textSave.Text != "Select the Folder 2 save files in...")
            {
                buttonExtractNow.Enabled = true;
                buttonCleardmp.Enabled = true;
                buttonOSLB2.Enabled = false;
                buttonSSLB2.Enabled = false;
            }
        }

        private void textSave_TextChanged(object sender, EventArgs e)
        {
            if (textOpen.Text != "" || textOpen.Text != "Select PS4 NOR Dump 2 Extract..." && textSave.Text != "" || textSave.Text != "Select the Folder 2 save files in...")
            {
                buttonExtractNow.Enabled = true;
                buttonCleardmp.Enabled = true;
                buttonOSLB2.Enabled = false;
                buttonSSLB2.Enabled = false;
            }
        }

        private void textOSLB2_TextChanged(object sender, EventArgs e)
        {
            if (textOSLB2.Text != "" || textOSLB2.Text != "Select PS4 SLB2 Container 2 Extract..." && textSSLB2.Text != "" || textSSLB2.Text != "Select the Folder 2 save files in...")
            {
                buttonExtractNow.Enabled = true;
                buttonClearslb.Enabled = true;
                buttonOpen.Enabled = false;
                buttonSave.Enabled = false;
            }
        }

        private void textSSLB2_TextChanged(object sender, EventArgs e)
        {
            if (textOSLB2.Text != "" || textOSLB2.Text != "Select PS4 SLB2 Container 2 Extract..." && textSSLB2.Text != "" || textSSLB2.Text != "Select the Folder 2 save files in...")
            {
                buttonExtractNow.Enabled = true;
                buttonClearslb.Enabled = true;
                buttonOpen.Enabled = false;
                buttonSave.Enabled = false;
            }
        }

        private void buttonCleardmp_Click(object sender, EventArgs e)
        {
            textOpen.Text = "Select PS4 NOR Dump 2 Extract...";
            textSave.Text = "Select the Folder 2 save files in...";
            textFWV.Text = "";
            textMAC.Text = "";
            textSKU.Text = "";
            textCID.Text = "";
            textSHA1.Text = "";
            buttonExtractNow.Enabled = false;
            buttonCleardmp.Enabled = false;
        }

        private void buttonClearslb_Click(object sender, EventArgs e)
        {
            textOSLB2.Text = "Select PS4 SLB2 Container 2 Extract...";
            textSSLB2.Text = "Select the Folder 2 save files in...";
            textSLBVersion.Text = "";
            textSLBFilecount.Text = "";
            textSHAslb.Text = "";
            buttonExtractNow.Enabled = false;
            buttonClearslb.Enabled = false;
        }

        private void buttonExtractNow_Click(object sender, EventArgs e)
        {
            // Final Process for PS4 NOR Dump Extraction
            if (textOpen.Text != "Select PS4 NOR Dump 2 Extract...")
            {
            NORExtract:
                if (textSave.Text != "Select the Folder 2 save files in...")
                {
                    if (!Directory.Exists(textSave.Text + @"\flash_extracted\") == true)
                    {
                        Directory.CreateDirectory(textSave.Text + @"\flash_extracted\");

                        if (!Directory.Exists(textSave.Text + @"\flash_extracted\") == true)
                        {
                            MessageBox.Show("Can't create the Folder!");
                        }
                        else
                        {
                            flag = 3;
                        }
                    }
                    else if (checkFolder.Checked == true)
                    {
                        if (Directory.Exists(textSave.Text + @"\flash_extracted\"))
                        {
                            Directory.Delete(textSave.Text + @"\flash_extracted\", true);

                            if (Directory.Exists(textSave.Text + @"\flash_extracted\") == true)
                            {
                                MessageBox.Show("Sorry something went wrong, I can't delete the old Folder!\nPlease Move/Delete the Folder on your own.");
                            }
                            else
                            {
                                Directory.CreateDirectory(textSave.Text + @"\flash_extracted\");

                                if (!Directory.Exists(textSave.Text + @"\flash_extracted\") == true)
                                {
                                    MessageBox.Show("Can't create the Folder!");
                                }
                                else
                                {
                                    flag = 3;
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Folder allready exists!\nMove/Delete your files or Activate the Folder Override Chechbox.");
                    }

                    if (flag == 3)
                    {
                        int exception = 0;

                        try
                        {
                            PS4Nor.ExtractDump(textOpen.Text, textSave.Text);
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show(a.ToString());
                            exception = 1;
                        }
                        finally
                        {
                            if (exception != 1)
                            {
                                MessageBox.Show("NOR Dump Successfull Extracted !");
                            }
                        }
                    }
                }
                else
                {
                    if (saveFolder.ShowDialog() == DialogResult.OK)
                    {
                        textSave.Text = saveFolder.SelectedPath;
                        goto NORExtract;
                    }
                }
            }
                
            
            
            // Final Process for PS4 SLB2 Extraction
            if (textOSLB2.Text != "Select PS4 SLB2 Container 2 Extract...")
            {
            SLB2Extract:
                if (textSSLB2.Text != "Select the Folder 2 save files in...")
                {
                    if (!Directory.Exists(textSSLB2.Text + @"\slb2_extracted\") == true)
                    {
                        Directory.CreateDirectory(textSSLB2.Text + @"\slb2_extracted\");

                        if (!Directory.Exists(textSSLB2.Text + @"\slb2_extracted\") == true)
                        {
                            MessageBox.Show("Can't create the Folder!");
                        }
                        else
                        {
                            flag = 4;
                        }
                    }
                    else if (checkOFSLB2.Checked == true)
                    {
                        if (Directory.Exists(textSSLB2.Text + @"\slb2_extracted\"))
                        {
                            Directory.Delete(textSSLB2.Text + @"\slb2_extracted\", true);

                            if (Directory.Exists(textSSLB2.Text + @"\slb2_extracted\") == true)
                            {
                                MessageBox.Show("Sorry something went wrong, I can't delete the old Folder!\nPlease Move/Delete the Folder on your own.");
                            }
                            else
                            {
                                Directory.CreateDirectory(textSSLB2.Text + @"\slb2_extracted\");

                                if (!Directory.Exists(textSSLB2.Text + @"\slb2_extracted\") == true)
                                {
                                    MessageBox.Show("Can't create the Folder!");
                                }
                                else
                                {
                                    flag = 4;
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Folder allready exists!\nMove/Delete your files or Activate the Folder Override Chechbox.");
                    }

                    if (flag == 4)
                    {
                        int exception = 0;

                        try
                        {
                            SLB2.Extract(textOSLB2.Text, textSSLB2.Text + @"\slb2_extracted\");
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show(a.ToString());
                            exception = 1;
                        }
                        finally
                        {
                            if (exception != 1)
                            {
                                MessageBox.Show("SLB2 Container Successfull Extracted !");
                            }
                        }
                    }
                }
                else
                {
                    if (saveFolder.ShowDialog() == DialogResult.OK)
                    {
                        textSSLB2.Text = saveFolder.SelectedPath;
                        goto SLB2Extract;
                    }
                }
            }

            flag = 0;
        }
    }
}
