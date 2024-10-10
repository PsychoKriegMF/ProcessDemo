namespace ProcessDemo
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
            this.components = new System.ComponentModel.Container();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ProcessDemo = new System.Diagnostics.Process();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnNotepad = new System.Windows.Forms.RadioButton();
            this.rbtnWord = new System.Windows.Forms.RadioButton();
            this.rbtnBrowser = new System.Windows.Forms.RadioButton();
            this.rbtnCalc = new System.Windows.Forms.RadioButton();
            this.rbtnCmd = new System.Windows.Forms.RadioButton();
            this.pictureBoxNotepad = new System.Windows.Forms.PictureBox();
            this.pictureBoxWord = new System.Windows.Forms.PictureBox();
            this.pictureBoxBrowser = new System.Windows.Forms.PictureBox();
            this.pictureBoxCalc = new System.Windows.Forms.PictureBox();
            this.pictureBoxCmd = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNotepad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrowser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCmd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(341, 12);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(140, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Запустить";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(341, 54);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(140, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Остановить";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProcessDemo
            // 
            this.ProcessDemo.StartInfo.Domain = "";
            this.ProcessDemo.StartInfo.LoadUserProfile = false;
            this.ProcessDemo.StartInfo.Password = null;
            this.ProcessDemo.StartInfo.StandardErrorEncoding = null;
            this.ProcessDemo.StartInfo.StandardOutputEncoding = null;
            this.ProcessDemo.StartInfo.UserName = "";
            this.ProcessDemo.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBoxNotepad);
            this.panel1.Controls.Add(this.pictureBoxWord);
            this.panel1.Controls.Add(this.pictureBoxBrowser);
            this.panel1.Controls.Add(this.pictureBoxCalc);
            this.panel1.Controls.Add(this.rbtnNotepad);
            this.panel1.Controls.Add(this.rbtnWord);
            this.panel1.Controls.Add(this.rbtnBrowser);
            this.panel1.Controls.Add(this.rbtnCalc);
            this.panel1.Controls.Add(this.pictureBoxCmd);
            this.panel1.Controls.Add(this.rbtnCmd);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 209);
            this.panel1.TabIndex = 3;
            // 
            // rbtnNotepad
            // 
            this.rbtnNotepad.AutoSize = true;
            this.rbtnNotepad.Location = new System.Drawing.Point(57, 173);
            this.rbtnNotepad.Name = "rbtnNotepad";
            this.rbtnNotepad.Size = new System.Drawing.Size(78, 17);
            this.rbtnNotepad.TabIndex = 4;
            this.rbtnNotepad.TabStop = true;
            this.rbtnNotepad.Text = "Notepad++";
            this.rbtnNotepad.UseVisualStyleBackColor = true;
            // 
            // rbtnWord
            // 
            this.rbtnWord.AutoSize = true;
            this.rbtnWord.Location = new System.Drawing.Point(57, 131);
            this.rbtnWord.Name = "rbtnWord";
            this.rbtnWord.Size = new System.Drawing.Size(70, 17);
            this.rbtnWord.TabIndex = 3;
            this.rbtnWord.TabStop = true;
            this.rbtnWord.Text = "MS Word";
            this.rbtnWord.UseVisualStyleBackColor = true;
            // 
            // rbtnBrowser
            // 
            this.rbtnBrowser.AutoSize = true;
            this.rbtnBrowser.Location = new System.Drawing.Point(57, 94);
            this.rbtnBrowser.Name = "rbtnBrowser";
            this.rbtnBrowser.Size = new System.Drawing.Size(67, 17);
            this.rbtnBrowser.TabIndex = 2;
            this.rbtnBrowser.TabStop = true;
            this.rbtnBrowser.Text = "Браузер";
            this.rbtnBrowser.UseVisualStyleBackColor = true;
            // 
            // rbtnCalc
            // 
            this.rbtnCalc.AutoSize = true;
            this.rbtnCalc.Location = new System.Drawing.Point(57, 57);
            this.rbtnCalc.Name = "rbtnCalc";
            this.rbtnCalc.Size = new System.Drawing.Size(90, 17);
            this.rbtnCalc.TabIndex = 1;
            this.rbtnCalc.TabStop = true;
            this.rbtnCalc.Text = "Калькулятор";
            this.rbtnCalc.UseVisualStyleBackColor = true;
            // 
            // rbtnCmd
            // 
            this.rbtnCmd.AutoSize = true;
            this.rbtnCmd.Location = new System.Drawing.Point(57, 19);
            this.rbtnCmd.Name = "rbtnCmd";
            this.rbtnCmd.Size = new System.Drawing.Size(120, 17);
            this.rbtnCmd.TabIndex = 0;
            this.rbtnCmd.TabStop = true;
            this.rbtnCmd.Text = "Командная строка";
            this.rbtnCmd.UseVisualStyleBackColor = true;
            // 
            // pictureBoxNotepad
            // 
            this.pictureBoxNotepad.Image = global::ProcessDemo.Properties.Resources.icons8_word_30;
            this.pictureBoxNotepad.Location = new System.Drawing.Point(8, 117);
            this.pictureBoxNotepad.Name = "pictureBoxNotepad";
            this.pictureBoxNotepad.Size = new System.Drawing.Size(37, 31);
            this.pictureBoxNotepad.TabIndex = 5;
            this.pictureBoxNotepad.TabStop = false;
            // 
            // pictureBoxWord
            // 
            this.pictureBoxWord.Image = global::ProcessDemo.Properties.Resources.icons8_notepad_30;
            this.pictureBoxWord.Location = new System.Drawing.Point(8, 159);
            this.pictureBoxWord.Name = "pictureBoxWord";
            this.pictureBoxWord.Size = new System.Drawing.Size(37, 31);
            this.pictureBoxWord.TabIndex = 6;
            this.pictureBoxWord.TabStop = false;
            this.pictureBoxWord.Click += new System.EventHandler(this.pictureBoxWord_Click);
            // 
            // pictureBoxBrowser
            // 
            this.pictureBoxBrowser.Image = global::ProcessDemo.Properties.Resources.icons8_browser_30;
            this.pictureBoxBrowser.Location = new System.Drawing.Point(8, 80);
            this.pictureBoxBrowser.Name = "pictureBoxBrowser";
            this.pictureBoxBrowser.Size = new System.Drawing.Size(37, 31);
            this.pictureBoxBrowser.TabIndex = 7;
            this.pictureBoxBrowser.TabStop = false;
            // 
            // pictureBoxCalc
            // 
            this.pictureBoxCalc.Image = global::ProcessDemo.Properties.Resources.icons8_calculator_30;
            this.pictureBoxCalc.Location = new System.Drawing.Point(7, 42);
            this.pictureBoxCalc.Name = "pictureBoxCalc";
            this.pictureBoxCalc.Size = new System.Drawing.Size(37, 31);
            this.pictureBoxCalc.TabIndex = 8;
            this.pictureBoxCalc.TabStop = false;
            // 
            // pictureBoxCmd
            // 
            this.pictureBoxCmd.Image = global::ProcessDemo.Properties.Resources.icons8_cmd_30;
            this.pictureBoxCmd.Location = new System.Drawing.Point(7, 5);
            this.pictureBoxCmd.Name = "pictureBoxCmd";
            this.pictureBoxCmd.Size = new System.Drawing.Size(37, 31);
            this.pictureBoxCmd.TabIndex = 4;
            this.pictureBoxCmd.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNotepad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBrowser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCmd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.Process ProcessDemo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnWord;
        private System.Windows.Forms.RadioButton rbtnBrowser;
        private System.Windows.Forms.RadioButton rbtnCalc;
        private System.Windows.Forms.RadioButton rbtnCmd;
        private System.Windows.Forms.RadioButton rbtnNotepad;
        private System.Windows.Forms.PictureBox pictureBoxNotepad;
        private System.Windows.Forms.PictureBox pictureBoxWord;
        private System.Windows.Forms.PictureBox pictureBoxBrowser;
        private System.Windows.Forms.PictureBox pictureBoxCalc;
        private System.Windows.Forms.PictureBox pictureBoxCmd;
    }
}

