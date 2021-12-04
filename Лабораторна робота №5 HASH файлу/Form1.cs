using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Diagnostics;

namespace Лабораторна_робота__5_HASH_файлу
{
    public partial class Form1 : Form
    {
        bool rBCRC32, rBHashAlgorithm, rBRIPEMD160, rBMD5, rBSHA1, rBSHA256, rBSHA384, rBSHA512;
        public Form1()
        {
            InitializeComponent();
            rB_CRC32.Checked = true;
        }
        private void button_fileIN_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileINpath = openFileDialog.FileName;
                    textBox_fileIN.Text = fileINpath;
                }
            }
        }
        private void button_fileOUT_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileOUTpath = saveFileDialog.FileName;
                textBox_fileOUT.Text = fileOUTpath;
            }
        }
        private void button_start_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                // Begin timing.
                stopwatch.Start();
                Cursor.Current = Cursors.WaitCursor;
                byte[] inArr = File.ReadAllBytes(textBox_fileIN.Text); // читаємо байти з файлу
                byte[] arr = myEncoding(inArr); //Закодований масив байт

                stopwatch.Stop();
               label_time.Text = stopwatch.Elapsed.ToString(@"mm\:ss\.fff");

                FileInfo fileIN = new FileInfo(textBox_fileIN.Text);
                long size = fileIN.Length;
                label_fileIN.Text = ("Вхідний файл: " + size.ToString() + " байт");

                mySaveToFileOUT(arr, textBox_fileOUT.Text); //збереження у файл

                FileInfo fileOUT = new FileInfo(textBox_fileOUT.Text);
                long size1 = fileOUT.Length;
                label_fileOUT.Text = ("Вихідний файл: " + size1.ToString() + " байт");

                Cursor.Current = Cursors.Default;
                MessageBox.Show("У файлі записане число (контрольна сума вхідного файлу):\n" + BitConverter.ToString(arr), Name = "Результат");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_fileIN.Text = "";
            textBox_fileOUT.Text = "";
            textBox_fileIN.Focus();
            label_fileIN.Text = "Вхідний файл:";
            label_fileOUT.Text = "Вихідний файл:";
            label7.Text = "Тривалість кодування:";
        }


        private byte[] myEncoding(byte[] inArr)
        {
            byte[] result = { 0 };

            if (rB_CRC32.Checked == true)
            {
                uint a = Crc.Crc32(inArr);
                return BitConverter.GetBytes(a);
            }
            if (rB_HAVAL.Checked == true)
            {
                HashAlgorithm sha = KeyedHashAlgorithm.Create();
                return sha.ComputeHash(inArr);
            }
            if (rB_RIPEMD160.Checked == true)
            {
                HashAlgorithm sha = RIPEMD160.Create();
                return sha.ComputeHash(inArr);
            }
            if (rB_MD5.Checked == true)
            {
                HashAlgorithm sha = MD5.Create();
                return sha.ComputeHash(inArr);
            }
            if (rB_SHA1.Checked == true)
            {
                HashAlgorithm sha = SHA1.Create();
                return sha.ComputeHash(inArr);
            }
            if (rB_SHA256.Checked == true)
            {
                HashAlgorithm sha = SHA256.Create();
                return sha.ComputeHash(inArr);
            }
            if (rB_SHA384.Checked == true)
            {
                HashAlgorithm sha = SHA384.Create();
                return sha.ComputeHash(inArr);
            }
            if (rB_SHA512.Checked == true)
            {
                HashAlgorithm sha = SHA512.Create();
                return sha.ComputeHash(inArr);
            }

            return result;
        }

        private void rB_CRC32_CheckedChanged(object sender, EventArgs e)
        {
            rBCRC32 = true;
            rBHashAlgorithm = false;
            rBRIPEMD160 = false;
            rBMD5 = false;
            rBSHA1 = false;
            rBSHA256 = false;
            rBSHA384 = false;
            rBSHA512 = false;
        }
        private void rB_HAVAL_CheckedChanged(object sender, EventArgs e)
        {
            rBCRC32 = false;
            rBHashAlgorithm = true;
            rBRIPEMD160 = false;
            rBMD5 = false;
            rBSHA1 = false;
            rBSHA256 = false;
            rBSHA384 = false;
            rBSHA512 = false;
        }

        private void rB_RIPEMD160_CheckedChanged(object sender, EventArgs e)
        {
            rBCRC32 = false;
            rBHashAlgorithm = false;
            rBRIPEMD160 = true;
            rBMD5 = false;
            rBSHA1 = false;
            rBSHA256 = false;
            rBSHA384 = false;
            rBSHA512 = false;
        }

        private void rB_MD5_CheckedChanged(object sender, EventArgs e)
        {
            rBCRC32 = false;
            rBHashAlgorithm = false;
            rBRIPEMD160 = false;
            rBMD5 = true;
            rBSHA1 = false;
            rBSHA256 = false;
            rBSHA384 = false;
            rBSHA512 = false;
        }

        private void rB_SHA1_CheckedChanged(object sender, EventArgs e)
        {
            rBCRC32 = false;
            rBHashAlgorithm = false;
            rBRIPEMD160 = false;
            rBMD5 = false;
            rBSHA1 = true;
            rBSHA256 = false;
            rBSHA384 = false;
            rBSHA512 = false;
        }

        private void rB_SHA256_CheckedChanged(object sender, EventArgs e)
        {
            rBCRC32 = false;
            rBHashAlgorithm = false;
            rBRIPEMD160 = false;
            rBMD5 = false;
            rBSHA1 = false;
            rBSHA256 = true;
            rBSHA384 = false;
            rBSHA512 = false;
        }
        private void rB_SHA384_CheckedChanged(object sender, EventArgs e)
        {
            rBCRC32 = false;
            rBHashAlgorithm = false;
            rBRIPEMD160 = false;
            rBMD5 = false;
            rBSHA1 = false;
            rBSHA256 = false;
            rBSHA384 = true;
            rBSHA512 = false;
        }

        private void rB_SHA512_CheckedChanged(object sender, EventArgs e)
        {
            rBCRC32 = false;
            rBHashAlgorithm = false;
            rBRIPEMD160 = false;
            rBMD5 = false;
            rBSHA1 = false;
            rBSHA256 = false;
            rBSHA384 = false;
            rBSHA512 = true;
        }
        private void mySaveToFileOUT(byte[] arrCipher, string fileOUTpath)
        {
            //Збереження у файл
            using (FileStream fs = File.Create(fileOUTpath))
            {
                fs.Write(arrCipher, 0, arrCipher.Length);
                fs.Close();
            }
        }

    }
}
