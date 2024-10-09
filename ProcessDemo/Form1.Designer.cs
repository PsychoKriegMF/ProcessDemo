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
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ProcessDemo = new System.Diagnostics.Process();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnCmd = new System.Windows.Forms.RadioButton();
            this.rbtnCalc = new System.Windows.Forms.RadioButton();
            this.rbtnBrowser = new System.Windows.Forms.RadioButton();
            this.rbtnWord = new System.Windows.Forms.RadioButton();
            this.rbtnNotepad = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(433, 82);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(140, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Выполнить";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(27, 23);
            this.tbPath.Multiline = true;
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(546, 53);
            this.tbPath.TabIndex = 1;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(27, 82);
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
            this.panel1.Controls.Add(this.rbtnNotepad);
            this.panel1.Controls.Add(this.rbtnWord);
            this.panel1.Controls.Add(this.rbtnBrowser);
            this.panel1.Controls.Add(this.rbtnCalc);
            this.panel1.Controls.Add(this.rbtnCmd);
            this.panel1.Location = new System.Drawing.Point(27, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 166);
            this.panel1.TabIndex = 3;
            // 
            // rbtnCmd
            // 
            this.rbtnCmd.AutoSize = true;
            this.rbtnCmd.Location = new System.Drawing.Point(4, 18);
            this.rbtnCmd.Name = "rbtnCmd";
            this.rbtnCmd.Size = new System.Drawing.Size(120, 17);
            this.rbtnCmd.TabIndex = 0;
            this.rbtnCmd.TabStop = true;
            this.rbtnCmd.Text = "Командная строка";
            this.rbtnCmd.UseVisualStyleBackColor = true;
            // 
            // rbtnCalc
            // 
            this.rbtnCalc.AutoSize = true;
            this.rbtnCalc.Location = new System.Drawing.Point(4, 42);
            this.rbtnCalc.Name = "rbtnCalc";
            this.rbtnCalc.Size = new System.Drawing.Size(90, 17);
            this.rbtnCalc.TabIndex = 1;
            this.rbtnCalc.TabStop = true;
            this.rbtnCalc.Text = "Калькулятор";
            this.rbtnCalc.UseVisualStyleBackColor = true;
            // 
            // rbtnBrowser
            // 
            this.rbtnBrowser.AutoSize = true;
            this.rbtnBrowser.Location = new System.Drawing.Point(4, 66);
            this.rbtnBrowser.Name = "rbtnBrowser";
            this.rbtnBrowser.Size = new System.Drawing.Size(67, 17);
            this.rbtnBrowser.TabIndex = 2;
            this.rbtnBrowser.TabStop = true;
            this.rbtnBrowser.Text = "Браузер";
            this.rbtnBrowser.UseVisualStyleBackColor = true;
            // 
            // rbtnWord
            // 
            this.rbtnWord.AutoSize = true;
            this.rbtnWord.Location = new System.Drawing.Point(4, 90);
            this.rbtnWord.Name = "rbtnWord";
            this.rbtnWord.Size = new System.Drawing.Size(70, 17);
            this.rbtnWord.TabIndex = 3;
            this.rbtnWord.TabStop = true;
            this.rbtnWord.Text = "MS Word";
            this.rbtnWord.UseVisualStyleBackColor = true;
            // 
            // rbtnNotepad
            // 
            this.rbtnNotepad.AutoSize = true;
            this.rbtnNotepad.Location = new System.Drawing.Point(4, 114);
            this.rbtnNotepad.Name = "rbtnNotepad";
            this.rbtnNotepad.Size = new System.Drawing.Size(78, 17);
            this.rbtnNotepad.TabIndex = 4;
            this.rbtnNotepad.TabStop = true;
            this.rbtnNotepad.Text = "Notepad++";
            this.rbtnNotepad.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btnRun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.Process ProcessDemo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnWord;
        private System.Windows.Forms.RadioButton rbtnBrowser;
        private System.Windows.Forms.RadioButton rbtnCalc;
        private System.Windows.Forms.RadioButton rbtnCmd;
        private System.Windows.Forms.RadioButton rbtnNotepad;
    }
}

