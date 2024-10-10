using System;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace ProcessDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsProgramRunning(string programName)
        {
            // Проверяем, запущена ли программа
            return Process.GetProcessesByName(programName).Length > 0;
        }

        private void RunProcess()
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
                return "chrome"; // Запуск браузера
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
                if (Uri.IsWellFormedUriString(program, UriKind.Absolute))
                {
                    // Открываем URL в браузере
                    Process.Start(new ProcessStartInfo(program) { UseShellExecute = true });
                }
                else
                {
                    // Запускаем приложение
                    Process.Start(program);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось запустить программу: {ex.Message}");
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            RunProcess();
        }

        private void CloseCurrentProcess()
        {
            string openProgram = GetSelectedProgram();
            if (!string.IsNullOrEmpty(openProgram))
            {
                if(GetSelectedProgram() == "calc")
                {
                    ProcessStartInfo processInfo = new ProcessStartInfo("taskkill", "/IM ApplicationFrameHost.exe /F");
                    processInfo.CreateNoWindow = true; // Не показывать окно командной строки
                    processInfo.UseShellExecute = false; // Использовать ShellExecute = false для работы в фоновом режиме
                    Process process = Process.Start(processInfo);
                    process.WaitForExit(); // Ждем завершения процесса taskkill
                }
                foreach (var process in Process.GetProcessesByName(openProgram))
                {
                    try
                    {
                        // Пытаемся отправить сигнал для закрытия окна
                        process.CloseMainWindow();

                        // Ждем, пока процесс закроется
                        if (!process.WaitForExit(1000)) // Ждем 1 секунду
                        {
                            // Если процесс все еще работает, принудительно закрываем его
                            process.Kill();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Не удалось закрыть программу: {ex.Message}");
                    }
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
            this.Text = DateTime.Now.ToString("HH:mm"); // Исправленный формат времени
        }

        private void LaunchPing(string args)
        {
            try
            {
                // Разбиваем аргументы на части
                string[] splitArgs = args.Split(' ');
                string ipAddress = splitArgs[0]; // Предполагаем, что первый аргумент - это IP-адрес или домен

                using (Ping ping = new Ping())
                {
                    PingReply reply = ping.Send(ipAddress);
                    if (reply.Status == IPStatus.Success)
                    {
                        MessageBox.Show($"Ресурс {ipAddress} доступен.", "Результат пинга", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Ресурс {ipAddress} недоступен. Статус: {reply.Status}", "Результат пинга", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при выполнении пинга: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPing_Click(object sender, EventArgs e)
        {       
            string resource = tbInput.Text; // Получаем введённое значение
                if (!string.IsNullOrWhiteSpace(resource))
                {
                    string _CommandArgs = $"{resource} -n 10 -l 1024";
                    LaunchPing(_CommandArgs);
                }
                else
                {
                    MessageBox.Show("Вы не ввели ресурс.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }            
           
        }
    }
}
