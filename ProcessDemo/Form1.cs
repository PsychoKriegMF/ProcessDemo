using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace ProcessDemo
{
    public partial class Form1 : Form
    {
        Process _process;
        public Form1()
        {
            InitializeComponent();
        }
        private bool IsProgramRunning(string programName)
        {
            // Проверяем, запущена ли программа
            return Process.GetProcessesByName(programName).Length > 0;
        }
        private void RunProcess(string _path)
        {
            string program = GetSelectedProgram();

            if (!string.IsNullOrEmpty(program))
            {
                if (IsProgramRunning(program))
                {
                    // Запрашиваем пользователя, хочет ли он открыть новое приложение
                    DialogResult result = MessageBox.Show("Приложение уже запущено, открыть новое?",
                                                          "Информация",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Information);

                    if (result == DialogResult.No)
                    {
                        return; // Выходим из метода, если пользователь выбрал "Нет"
                    }
                    
                }

                LaunchProgram(program);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите программу для запуска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetSelectedProgram()
        {
            if (rbtnCalc.Checked)
                return "calc"; // Запуск калькулятора
            else if (rbtnCmd.Checked)
                return "cmd"; // Запуск командной строки
            else if (rbtnBrowser.Checked)
                return "http:\\ya.ru"; // Запуск браузера
            else if (rbtnWord.Checked)
                return "winword"; // Запуск ворда
            else if (rbtnNotepad.Checked)
                return "notepad++"; // Запуск Notepad++
            return string.Empty; // Ничего не выбрано
        }
        private void LaunchProgram(string program)
        {            
            try
            {
                _process = Process.Start(program);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось запустить программу: {ex.Message}");
            }
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            RunProcess(GetSelectedProgram());
        }
        private void CloseCurrentProcess()
        {
            string openProgram = GetSelectedProgram();
            if (!string.IsNullOrEmpty(openProgram))
            {
                if (IsProgramRunning(openProgram))
                {
                    _process.Kill(); // Завершаем процесс
                    _process = null; // Обнуляем ссылку                
                }
            }
            else
            {
                MessageBox.Show("Нет запущенных приложений для закрытия.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            CloseCurrentProcess();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString("HH:MM");
        }
    }
}
