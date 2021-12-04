namespace Лабораторна_робота__5_HASH_файлу
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rB_SHA512 = new System.Windows.Forms.RadioButton();
            this.rB_SHA384 = new System.Windows.Forms.RadioButton();
            this.rB_SHA256 = new System.Windows.Forms.RadioButton();
            this.rB_SHA1 = new System.Windows.Forms.RadioButton();
            this.rB_MD5 = new System.Windows.Forms.RadioButton();
            this.rB_RIPEMD160 = new System.Windows.Forms.RadioButton();
            this.rB_HAVAL = new System.Windows.Forms.RadioButton();
            this.rB_CRC32 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_fileIN = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_fileOUT = new System.Windows.Forms.Label();
            this.textBox_fileIN = new System.Windows.Forms.TextBox();
            this.textBox_fileOUT = new System.Windows.Forms.TextBox();
            this.button_fileIN = new System.Windows.Forms.Button();
            this.button_fileOUT = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вхідний файл:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вихідний файл:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rB_SHA512);
            this.groupBox1.Controls.Add(this.rB_SHA384);
            this.groupBox1.Controls.Add(this.rB_SHA256);
            this.groupBox1.Controls.Add(this.rB_SHA1);
            this.groupBox1.Controls.Add(this.rB_MD5);
            this.groupBox1.Controls.Add(this.rB_RIPEMD160);
            this.groupBox1.Controls.Add(this.rB_HAVAL);
            this.groupBox1.Controls.Add(this.rB_CRC32);
            this.groupBox1.Location = new System.Drawing.Point(9, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 118);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим роботи:";
            // 
            // rB_SHA512
            // 
            this.rB_SHA512.AutoSize = true;
            this.rB_SHA512.Location = new System.Drawing.Point(115, 88);
            this.rB_SHA512.Name = "rB_SHA512";
            this.rB_SHA512.Size = new System.Drawing.Size(68, 17);
            this.rB_SHA512.TabIndex = 7;
            this.rB_SHA512.TabStop = true;
            this.rB_SHA512.Text = "SHA-512";
            this.rB_SHA512.UseVisualStyleBackColor = true;
            this.rB_SHA512.CheckedChanged += new System.EventHandler(this.rB_SHA512_CheckedChanged);
            // 
            // rB_SHA384
            // 
            this.rB_SHA384.AutoSize = true;
            this.rB_SHA384.Location = new System.Drawing.Point(115, 65);
            this.rB_SHA384.Name = "rB_SHA384";
            this.rB_SHA384.Size = new System.Drawing.Size(68, 17);
            this.rB_SHA384.TabIndex = 6;
            this.rB_SHA384.TabStop = true;
            this.rB_SHA384.Text = "SHA-384";
            this.rB_SHA384.UseVisualStyleBackColor = true;
            this.rB_SHA384.CheckedChanged += new System.EventHandler(this.rB_SHA384_CheckedChanged);
            // 
            // rB_SHA256
            // 
            this.rB_SHA256.AutoSize = true;
            this.rB_SHA256.Location = new System.Drawing.Point(115, 42);
            this.rB_SHA256.Name = "rB_SHA256";
            this.rB_SHA256.Size = new System.Drawing.Size(68, 17);
            this.rB_SHA256.TabIndex = 5;
            this.rB_SHA256.TabStop = true;
            this.rB_SHA256.Text = "SHA-256";
            this.rB_SHA256.UseVisualStyleBackColor = true;
            this.rB_SHA256.CheckedChanged += new System.EventHandler(this.rB_SHA256_CheckedChanged);
            // 
            // rB_SHA1
            // 
            this.rB_SHA1.AutoSize = true;
            this.rB_SHA1.Location = new System.Drawing.Point(115, 19);
            this.rB_SHA1.Name = "rB_SHA1";
            this.rB_SHA1.Size = new System.Drawing.Size(56, 17);
            this.rB_SHA1.TabIndex = 4;
            this.rB_SHA1.TabStop = true;
            this.rB_SHA1.Text = "SHA-1";
            this.rB_SHA1.UseVisualStyleBackColor = true;
            this.rB_SHA1.CheckedChanged += new System.EventHandler(this.rB_SHA1_CheckedChanged);
            // 
            // rB_MD5
            // 
            this.rB_MD5.AutoSize = true;
            this.rB_MD5.Location = new System.Drawing.Point(6, 88);
            this.rB_MD5.Name = "rB_MD5";
            this.rB_MD5.Size = new System.Drawing.Size(48, 17);
            this.rB_MD5.TabIndex = 3;
            this.rB_MD5.TabStop = true;
            this.rB_MD5.Text = "MD5";
            this.rB_MD5.UseVisualStyleBackColor = true;
            this.rB_MD5.CheckedChanged += new System.EventHandler(this.rB_MD5_CheckedChanged);
            // 
            // rB_RIPEMD160
            // 
            this.rB_RIPEMD160.AutoSize = true;
            this.rB_RIPEMD160.Location = new System.Drawing.Point(6, 65);
            this.rB_RIPEMD160.Name = "rB_RIPEMD160";
            this.rB_RIPEMD160.Size = new System.Drawing.Size(85, 17);
            this.rB_RIPEMD160.TabIndex = 2;
            this.rB_RIPEMD160.TabStop = true;
            this.rB_RIPEMD160.Text = "RIPEMD160";
            this.rB_RIPEMD160.UseVisualStyleBackColor = true;
            this.rB_RIPEMD160.CheckedChanged += new System.EventHandler(this.rB_RIPEMD160_CheckedChanged);
            // 
            // rB_HAVAL
            // 
            this.rB_HAVAL.AutoSize = true;
            this.rB_HAVAL.Location = new System.Drawing.Point(6, 42);
            this.rB_HAVAL.Name = "rB_HAVAL";
            this.rB_HAVAL.Size = new System.Drawing.Size(93, 17);
            this.rB_HAVAL.TabIndex = 1;
            this.rB_HAVAL.TabStop = true;
            this.rB_HAVAL.Text = "HashAlgorithm";
            this.rB_HAVAL.UseVisualStyleBackColor = true;
            this.rB_HAVAL.CheckedChanged += new System.EventHandler(this.rB_HAVAL_CheckedChanged);
            // 
            // rB_CRC32
            // 
            this.rB_CRC32.AutoSize = true;
            this.rB_CRC32.Location = new System.Drawing.Point(6, 19);
            this.rB_CRC32.Name = "rB_CRC32";
            this.rB_CRC32.Size = new System.Drawing.Size(59, 17);
            this.rB_CRC32.TabIndex = 0;
            this.rB_CRC32.TabStop = true;
            this.rB_CRC32.Text = "CRC32";
            this.rB_CRC32.UseVisualStyleBackColor = true;
            this.rB_CRC32.CheckedChanged += new System.EventHandler(this.rB_CRC32_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_fileIN);
            this.groupBox2.Location = new System.Drawing.Point(215, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 36);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Оцінка розміру (Мбайт):";
            // 
            // label_fileIN
            // 
            this.label_fileIN.AutoSize = true;
            this.label_fileIN.Location = new System.Drawing.Point(6, 16);
            this.label_fileIN.Name = "label_fileIN";
            this.label_fileIN.Size = new System.Drawing.Size(87, 13);
            this.label_fileIN.TabIndex = 0;
            this.label_fileIN.Text = "Вхідного файлу:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_fileOUT);
            this.groupBox3.Location = new System.Drawing.Point(215, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 35);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Оцінка розміру (Байти):";
            // 
            // label_fileOUT
            // 
            this.label_fileOUT.AutoSize = true;
            this.label_fileOUT.Location = new System.Drawing.Point(6, 16);
            this.label_fileOUT.Name = "label_fileOUT";
            this.label_fileOUT.Size = new System.Drawing.Size(93, 13);
            this.label_fileOUT.TabIndex = 0;
            this.label_fileOUT.Text = "Вихідного файлу:";
            // 
            // textBox_fileIN
            // 
            this.textBox_fileIN.Location = new System.Drawing.Point(95, 6);
            this.textBox_fileIN.Name = "textBox_fileIN";
            this.textBox_fileIN.Size = new System.Drawing.Size(240, 20);
            this.textBox_fileIN.TabIndex = 5;
            // 
            // textBox_fileOUT
            // 
            this.textBox_fileOUT.Location = new System.Drawing.Point(95, 33);
            this.textBox_fileOUT.Name = "textBox_fileOUT";
            this.textBox_fileOUT.Size = new System.Drawing.Size(240, 20);
            this.textBox_fileOUT.TabIndex = 6;
            // 
            // button_fileIN
            // 
            this.button_fileIN.Location = new System.Drawing.Point(341, 6);
            this.button_fileIN.Name = "button_fileIN";
            this.button_fileIN.Size = new System.Drawing.Size(40, 21);
            this.button_fileIN.TabIndex = 7;
            this.button_fileIN.Text = "...";
            this.button_fileIN.UseVisualStyleBackColor = true;
            this.button_fileIN.Click += new System.EventHandler(this.button_fileIN_Click);
            // 
            // button_fileOUT
            // 
            this.button_fileOUT.Location = new System.Drawing.Point(341, 33);
            this.button_fileOUT.Name = "button_fileOUT";
            this.button_fileOUT.Size = new System.Drawing.Size(40, 23);
            this.button_fileOUT.TabIndex = 8;
            this.button_fileOUT.Text = "...";
            this.button_fileOUT.UseVisualStyleBackColor = true;
            this.button_fileOUT.Click += new System.EventHandler(this.button_fileOUT_Click);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(215, 180);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 9;
            this.button_start.Text = "Виконати";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_clean
            // 
            this.button_clean.Location = new System.Drawing.Point(297, 180);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(75, 23);
            this.button_clean.TabIndex = 10;
            this.button_clean.Text = "Очстити";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Тривалість кодування:";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(213, 162);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(0, 13);
            this.label_time.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 213);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_fileOUT);
            this.Controls.Add(this.button_fileIN);
            this.Controls.Add(this.textBox_fileOUT);
            this.Controls.Add(this.textBox_fileIN);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Циклічний надлишковий код (CRC)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rB_SHA512;
        private System.Windows.Forms.RadioButton rB_SHA384;
        private System.Windows.Forms.RadioButton rB_SHA256;
        private System.Windows.Forms.RadioButton rB_SHA1;
        private System.Windows.Forms.RadioButton rB_MD5;
        private System.Windows.Forms.RadioButton rB_RIPEMD160;
        private System.Windows.Forms.RadioButton rB_HAVAL;
        private System.Windows.Forms.RadioButton rB_CRC32;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_fileIN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_fileOUT;
        private System.Windows.Forms.TextBox textBox_fileIN;
        private System.Windows.Forms.TextBox textBox_fileOUT;
        private System.Windows.Forms.Button button_fileIN;
        private System.Windows.Forms.Button button_fileOUT;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_time;
    }
}

