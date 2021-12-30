using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using yt_DesignUI.Components;
using yt_DesignUI.Controls;

namespace Managing_pochta_services
{
    public partial class Form1 : ShadowedForm
    {
        ComboBox comboBox2;
        bool IsWindow;
        string ip;
        string resultService;
        int progress = 0;
        int progressIP = 0;
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Clear();
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            yt_DesignUI.Animator.Start();
            //EgoldsFormStyle.fStyle = 2;

            AutoCompleteStringCollection source = new AutoCompleteStringCollection()
        {
                 "248000",
"248001",
"248002",
"248003",
"248007",
"248008",
"248009",
"248010",
"248012",
"248016",
"248017",
"248018",
"248021",
"248022",
"248023",
"248025",
"248028",
"248029",
"248030",
"248031",
"248032",
"248033",
"248035",
"248036",
"248037",
"248038",
"248039",
"248901",
"248903",
"248911",
"248912",
"248915",
"248918",
"248920",
"248921",
"248926",
"249000",
"249001",
"249004",
"249007",
"249008",
"249009",
"249010",
"249011",
"249013",
"249015",
"249017",
"249018",
"249020",
"249021",
"249022",
"249023",
"249024",
"249025",
"249026",
"249027",
"249028",
"249031",
"249032",
"249033",
"249034",
"249035",
"249037",
"249038",
"249039",
"249051",
"249052",
"249053",
"249054",
"249056",
"249060",
"249061",
"249062",
"249064",
"249070",
"249071",
"249073",
"249076",
"249080",
"249081",
"249082",
"249086",
"249087",
"249091",
"249092",
"249093",
"249094",
"249096",
"249100",
"249101",
"249103",
"249104",
"249105",
"249106",
"249107",
"249108",
"249109",
"249111",
"249120",
"249122",
"249123",
"249124",
"249127",
"249130",
"249134",
"249135",
"249136",
"249137",
"249139",
"249140",
"249141",
"249142",
"249143",
"249144",
"249160",
"249161",
"249162",
"249163",
"249164",
"249165",
"249166",
"249167",
"249168",
"249172",
"249173",
"249174",
"249180",
"249181",
"249183",
"249184",
"249185",
"249187",
"249191",
"249192",
"249200",
"249201",
"249205",
"249210",
"249212",
"249213",
"249214",
"249215",
"249217",
"249221",
"249222",
"249223",
"249224",
"249225",
"249230",
"249231",
"249232",
"249235",
"249236",
"249240",
"249242",
"249243",
"249246",
"249247",
"249250",
"249251",
"249252",
"249254",
"249255",
"249261",
"249264",
"249265",
"249266",
"249267",
"249268",
"249271",
"249273",
"249274",
"249275",
"249276",
"249277",
"249278",
"249280",
"249281",
"249282",
"249284",
"249286",
"249290",
"249292",
"249296",
"249300",
"249301",
"249303",
"249304",
"249305",
"249306",
"249310",
"249311",
"249312",
"249313",
"249314",
"249315",
"249320",
"249322",
"249332",
"249333",
"249340",
"249342",
"249343",
"249349",
"249350",
"249352",
"249356",
"249357",
"249360",
"249363",
"249364",
"249365",
"249370",
"249371",
"249372",
"249373",
"249376",
"249377",
"249378",
"249381",
"249382",
"249383",
"249401",
"249402",
"249403",
"249405",
"249406",
"249410",
"249411",
"249412",
"249413",
"249414",
"249415",
"249417",
"249418",
"249419",
"249425",
"249431",
"249432",
"249433",
"249434",
"249435",
"249436",
"249438",
"249440",
"249441",
"249442",
"249443",
"249444",
"249448",
"249450",
"249451",
"249452",
"249453",
"249454",
"249455",
"249456",
"249457",
"249458",
"249459",
"249500",
"249502",
"249503",
"249505",
"249510",
"249511",
"249513",
"249515",
"249516",
"249517",
"249518",
"249519",
"249600",
"249601",
"249603",
"249610",
"249611",
"249616",
"249620",
"249621",
"249622",
"249623",
"249625",
"249627",
"249630",
"249640",
"249650",
"249651",
"249652",
"249654",
"249655",
"249656",
"249658",
"249660",
"249662",
"249664",
"249665",
"249701",
"249703",
"249705",
"249706",
"249708",
"249710",
"249711",
"249712",
"249713",
"249716",
"249720",
"249722",
"249723",
"249725",
"249726",
"249730",
"249732",
"249736",
"249750",
"249757",
"249760",
"249764",
"249766",
"249771",
"249774",
"249775",
"249800",
"249802",
"249803",
"249804",
"249806",
"249808",
"249811",
"249812",
"249815",
"249831",
"249832",
"249833",
"249834",
"249840",
"249841",
"249842",
"249844",
"249845",
"249846",
"249849",
"249850",
"249851",
"249852",
"249855",
"249856",
"249857",
"249858",
"249859",
"249860",
"249861",
"249862",
"249863",
"249864",
"249865",
"249866",
"249867",
"249868",
"249870",
"249873",
"249875",
"249880",
"249882",
"249884",
"249890",
"249891",
"249892",
"249901",
"249902",
"249903",
"249910",
"249911",
"249912",
"249913",
"249920",
"249921",
"249922",
"249923",
"249924",
"249925",
"249930",
"249932",
"249933",
"249934",
"249936",
"249941",
"249942",
"249946",
"249950",
"249951",
"249953",
"249954",
"249955",
"249960",
"249961",
"249962",
"249963",
"249966",
"249967",
"249968",
        };
            textBox1.AutoCompleteCustomSource = source;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
            public Form1(ComboBox comboBox)
        {
            InitializeComponent();
            comboBox1.Items.Clear();
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox2 = comboBox;
            //comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            AutoCompleteStringCollection source = new AutoCompleteStringCollection()
        {
                 "248000",
"248001",
"248002",
"248003",
"248007",
"248008",
"248009",
"248010",
"248012",
"248016",
"248017",
"248018",
"248021",
"248022",
"248023",
"248025",
"248028",
"248029",
"248030",
"248031",
"248032",
"248033",
"248035",
"248036",
"248037",
"248038",
"248039",
"248901",
"248903",
"248911",
"248912",
"248915",
"248918",
"248920",
"248921",
"248926",
"249000",
"249001",
"249004",
"249007",
"249008",
"249009",
"249010",
"249011",
"249013",
"249015",
"249017",
"249018",
"249020",
"249021",
"249022",
"249023",
"249024",
"249025",
"249026",
"249027",
"249028",
"249031",
"249032",
"249033",
"249034",
"249035",
"249037",
"249038",
"249039",
"249051",
"249052",
"249053",
"249054",
"249056",
"249060",
"249061",
"249062",
"249064",
"249070",
"249071",
"249073",
"249076",
"249080",
"249081",
"249082",
"249086",
"249087",
"249091",
"249092",
"249093",
"249094",
"249096",
"249100",
"249101",
"249103",
"249104",
"249105",
"249106",
"249107",
"249108",
"249109",
"249111",
"249120",
"249122",
"249123",
"249124",
"249127",
"249130",
"249134",
"249135",
"249136",
"249137",
"249139",
"249140",
"249141",
"249142",
"249143",
"249144",
"249160",
"249161",
"249162",
"249163",
"249164",
"249165",
"249166",
"249167",
"249168",
"249172",
"249173",
"249174",
"249180",
"249181",
"249183",
"249184",
"249185",
"249187",
"249191",
"249192",
"249200",
"249201",
"249205",
"249210",
"249212",
"249213",
"249214",
"249215",
"249217",
"249221",
"249222",
"249223",
"249224",
"249225",
"249230",
"249231",
"249232",
"249235",
"249236",
"249240",
"249242",
"249243",
"249246",
"249247",
"249250",
"249251",
"249252",
"249254",
"249255",
"249261",
"249264",
"249265",
"249266",
"249267",
"249268",
"249271",
"249273",
"249274",
"249275",
"249276",
"249277",
"249278",
"249280",
"249281",
"249282",
"249284",
"249286",
"249290",
"249292",
"249296",
"249300",
"249301",
"249303",
"249304",
"249305",
"249306",
"249310",
"249311",
"249312",
"249313",
"249314",
"249315",
"249320",
"249322",
"249332",
"249333",
"249340",
"249342",
"249343",
"249349",
"249350",
"249352",
"249356",
"249357",
"249360",
"249363",
"249364",
"249365",
"249370",
"249371",
"249372",
"249373",
"249376",
"249377",
"249378",
"249381",
"249382",
"249383",
"249401",
"249402",
"249403",
"249405",
"249406",
"249410",
"249411",
"249412",
"249413",
"249414",
"249415",
"249417",
"249418",
"249419",
"249425",
"249431",
"249432",
"249433",
"249434",
"249435",
"249436",
"249438",
"249440",
"249441",
"249442",
"249443",
"249444",
"249448",
"249450",
"249451",
"249452",
"249453",
"249454",
"249455",
"249456",
"249457",
"249458",
"249459",
"249500",
"249502",
"249503",
"249505",
"249510",
"249511",
"249513",
"249515",
"249516",
"249517",
"249518",
"249519",
"249600",
"249601",
"249603",
"249610",
"249611",
"249616",
"249620",
"249621",
"249622",
"249623",
"249625",
"249627",
"249630",
"249640",
"249650",
"249651",
"249652",
"249654",
"249655",
"249656",
"249658",
"249660",
"249662",
"249664",
"249665",
"249701",
"249703",
"249705",
"249706",
"249708",
"249710",
"249711",
"249712",
"249713",
"249716",
"249720",
"249722",
"249723",
"249725",
"249726",
"249730",
"249732",
"249736",
"249750",
"249757",
"249760",
"249764",
"249766",
"249771",
"249774",
"249775",
"249800",
"249802",
"249803",
"249804",
"249806",
"249808",
"249811",
"249812",
"249815",
"249831",
"249832",
"249833",
"249834",
"249840",
"249841",
"249842",
"249844",
"249845",
"249846",
"249849",
"249850",
"249851",
"249852",
"249855",
"249856",
"249857",
"249858",
"249859",
"249860",
"249861",
"249862",
"249863",
"249864",
"249865",
"249866",
"249867",
"249868",
"249870",
"249873",
"249875",
"249880",
"249882",
"249884",
"249890",
"249891",
"249892",
"249901",
"249902",
"249903",
"249910",
"249911",
"249912",
"249913",
"249920",
"249921",
"249922",
"249923",
"249924",
"249925",
"249930",
"249932",
"249933",
"249934",
"249936",
"249941",
"249942",
"249946",
"249950",
"249951",
"249953",
"249954",
"249955",
"249960",
"249961",
"249962",
"249963",
"249966",
"249967",
"249968",
        };
            textBox1.AutoCompleteCustomSource = source;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        public void Ping(string domain, yt_DesignUI.EgoldsGoogleTextBox TextBox1IP, Label label, int form)
        {
            CheckForIllegalCrossThreadCalls = false;
            try
            {
                IPAddress ipAddress = Dns.GetHostEntry("r40-" + TextBox1IP.Text + domain).AddressList[0];
                Ping ping = new Ping();
                PingReply pingReply = ping.Send(ipAddress);
                if (pingReply.Address == null | pingReply.Address.ToString() == "")
                {
                    MessageBox.Show("Пк выключен");
                }
                else
                {
                    if (pingReply.Address.ToString() != "10.94.187.117"
                                    & pingReply.Address.ToString() != "10.94.209.149"
                                    & pingReply.Address.ToString() != "10.94.187.101"
                                    & pingReply.Address.ToString() != "10.94.185.21"
                                    & pingReply.Address.ToString() != "10.94.225.101"
                                    & pingReply.Address.ToString() != "10.94.205.197"
                                    & pingReply.Address.ToString() != "10.94.185.85"
                                    & pingReply.Address.ToString() != "10.94.206.69"
                                    & pingReply.Address.ToString() != "10.94.219.165"
                                    & pingReply.Address.ToString() != "10.94.185.117"
                                    & pingReply.Address.ToString() != "10.94.218.53"
                                    & pingReply.Address.ToString() != "10.94.207.245")
                    {
                        string result = pingReply.Address.ToString();
                        this.ip = result;
                        Clipboard.SetText(TextBox1IP.Text);
                        if (form == 1)
                        {
                            if (progressIP == 0)
                            {
                                egoldsGoogleTextBox2.BorderColor = System.Drawing.Color.RoyalBlue;
                                egoldsGoogleTextBox2.BorderColorNotActive = System.Drawing.Color.RoyalBlue;
                                egoldsGoogleTextBox2.TextInput = result;
                                egoldsGoogleTextBox2.TextPreview = result;
                                egoldsGoogleTextBox2.Text = result;
                            }
                            else
                            {
                                if(progressIP == 1)
                                {
                                    egoldsGoogleTextBox3.BorderColor = System.Drawing.Color.DodgerBlue;
                                    egoldsGoogleTextBox3.BorderColorNotActive = System.Drawing.Color.DodgerBlue;
                                    egoldsGoogleTextBox2.TextInput = result;
                                    egoldsGoogleTextBox2.TextPreview = $"IP Адрес:";
                                    egoldsGoogleTextBox2.Text = result;
                                }
                            }
                        }
                        else
                        {
                            label.Text = "IP: " + result;
                        }                        
                    }
                    else
                    {
                        MessageBox.Show("Пк выключен");
                    }
                }
            }
            catch (PingException ex)
            {
                MessageBox.Show($"\nКоманда пинг - не проходит.\n{ex.Message}");
            }
            catch (SocketException)
            {
                MessageBox.Show("\nКоманда пинг - не проходит.\nCould not resolve host name.");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show($"{ex}\nКоманда пинг - не проходит.\nPlease enter the host name or IP address to ping.");
            }
            catch (System.Net.NetworkInformation.NetworkInformationException)
            {
                MessageBox.Show($"\nКоманда пинг - не проходит.\nПк ОПС {textBox1.Text} - выключен или без интернета");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show($"\nКоманда пинг - не проходит.\nПк ОПС {textBox1.Text} - выключен или без интернета");
            }
            catch (Exception)
            {
                MessageBox.Show($"\nКоманда пинг - не проходит.\nПк ОПС {textBox1.Text} - выключен или без интернета");
            }
            textBox1.Focus();
        }
        async private void AsyncProcessStart(string path)
        {
            if (egoldsGoogleTextBox2.Text != "")
            {
                try
                {
                    await Task.Run(() =>
                    {
                        try
                        {
                            Process.Start(path);
                        }
                        catch (System.ComponentModel.Win32Exception)
                        {
                            MessageBox.Show($"Диск Е не найден на данном ПК");
                        }
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка {ex}");
                }
            }
            else
                MessageBox.Show("Поле IP Адрес пустое");
        }
        private void StartRemoteAccess(string nameProcess, string path)
        {
            try
            {
                bool count = true;
                foreach (Process pr in Process.GetProcessesByName(nameProcess))
                {
                    count = false;
                    ShowNormal(pr);
                }
                if (count)
                    AsyncProcessStart(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}");
            }
        }
        public void ShowNormal(Process proc)
        {
            WinAPI.ShowWindow(proc.MainWindowHandle, WinAPI.Consts.SHOWWINDOW.SW_SHOWNORMAL);
        }
        public void SetFocus(Process proc)
        {
            WinAPI.SetForegroundWindow(proc.MainWindowHandle);
        }
        /// <summary>
        /// Набор WinAPI функций, как есть (Или почти как есть)
        /// </summary>
        public static class WinAPI
        {

            /// <summary>
            ///  Устанавливает состояние показа определяемого окна.
            ///  Если функция завершилась успешно, возвращается значение
            ///  отличное от нуля. Если функция потерпела неудачу,
            ///  возвращаемое значение - ноль.
            /// </summary>
            /// <param name="hWnd">Дескриптор окна</param>
            /// <param name="nCmdShow">Определяет, как окно должно быть показано.</param>
            /// <returns>
            ///  Если функция завершилась успешно, возвращается значение
            ///  отличное от нуля. Если функция потерпела неудачу,
            ///  возвращаемое значение - ноль.
            ///  </returns>
            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

            /// <summary>
            ///  Устанавливает состояние показа определяемого окна.
            ///  Если функция завершилась успешно, возвращается значение
            ///  отличное от нуля. Если функция потерпела неудачу,
            ///  возвращаемое значение - ноль.
            /// </summary>
            /// <param name="hWnd">Дескриптор окна</param>
            /// <param name="nCmdShow">Определяет, как окно должно быть показано.</param>
            /// <returns>
            ///  Если функция завершилась успешно, возвращается значение
            ///  отличное от нуля. Если функция потерпела неудачу,
            ///  возвращаемое значение - ноль.
            ///  </returns>
            public static bool ShowWindow(IntPtr hWnd, Consts.SHOWWINDOW nCmdShow)
            {
                return ShowWindow(hWnd, (int)nCmdShow);
            }

            /// <summary>
            /// Установить окно на передний план
            /// </summary>
            /// <param name="hWnd">Handle окна</param>
            /// <returns>Удачность</returns>
            [DllImport("user32.dll")]
            public static extern bool SetForegroundWindow(IntPtr hWnd);


            /// <summary>
            /// Набор констант
            /// </summary>
            public static class Consts
            {

                /// <summary>
                /// Параметры к функции ShowWindow. 
                /// Внимание! Некоторые параметры имеют одинаковое значение
                /// (Почему? За ответом к дяде Биллу)
                /// </summary>
                public enum SHOWWINDOW : uint
                {
                    /// <summary>
                    /// Скрывает окно и активизирует другое окно
                    /// </summary>
                    SW_HIDE = 0,
                    /// <summary>
                    /// Активизирует и отображает окно.
                    /// Если окно свернуто или развернуто,
                    /// Windows восстанавливает его в 
                    /// первоначальном размере и позиции. 
                    /// Прикладная программа должна установить 
                    /// этот флажок при отображении окна впервые
                    /// </summary>
                    SW_SHOWNORMAL = 1,
                    SW_NORMAL = 1,
                    /// <summary>
                    /// Активизирует окно и отображает его как свернутое окно
                    /// </summary>
                    SW_SHOWMINIMIZED = 2,
                    /// <summary>
                    /// Активизирует окно и отображает его как развернутое окно
                    /// </summary>
                    SW_SHOWMAXIMIZED = 3,
                    /// <summary>
                    /// Развертывает определяемое окно
                    /// </summary>
                    SW_MAXIMIZE = 3,
                    /// <summary>
                    /// Отображает окно в его самом современном размере и позиции. 
                    /// Активное окно остается активным
                    /// </summary>
                    SW_SHOWNOACTIVATE = 4,
                    /// <summary>
                    /// Активизирует окно и отображает его текущие размеры и позицию
                    /// </summary>
                    SW_SHOW = 5,
                    /// <summary>
                    /// Свертывает определяемое окно и активизирует следующее окно 
                    /// верхнего уровня в Z-последовательности
                    /// </summary>
                    SW_MINIMIZE = 6,
                    /// <summary>
                    /// Отображает окно как свернутое окно. Активное окно остается активным
                    /// </summary>
                    SW_SHOWMINNOACTIVE = 7,
                    /// <summary>
                    /// Отображает окно в его текущем состоянии. Активное окно остается активным
                    /// </summary>
                    SW_SHOWNA = 8,
                    /// <summary>
                    /// Активизирует и отображает окно. 
                    /// Если окно свернуто или развернуто, 
                    /// Windows восстанавливает в его первоначальных 
                    /// размерах и позиции. Прикладная программа должна 
                    /// установить этот флажок при восстановлении свернутого окна
                    /// </summary>
                    SW_RESTORE = 9,
                    /// <summary>
                    /// Устанавливает состояние показа, основанное на флажке SW_
                    /// , определенном в структуре STARTUPINFO, 
                    /// переданной в функцию CreateProcess программой, 
                    /// которая запустила прикладную программу
                    /// </summary>
                    SW_SHOWDEFAULT = 10,
                    /// <summary>
                    /// Windows 2000/XP: Свертывает окно, даже если поток,
                    /// который владеет окном, зависает. Этот флажок должен 
                    /// быть использоваться только при свертывании окон 
                    /// другого потока
                    /// </summary>
                    SW_FORCEMINIMIZE = 11,
                    SW_MAX = 11,
                }
            }
        }
        //Метод представляющий процесс, запускающий power_shell с командами, передаваемыми через параметр string action_power_shell
        //Метод ожидает своей отработки, т е пока поток не отработает, основная программа не будет выполнять код, ниже которого вызван этот метод
        public static void Power_Shell(string action_power_shell)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "powershell",
                Arguments = $"/command {action_power_shell}",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true
            }).WaitForExit();
        }

        //Метод представляющий процесс, запускающий power_shell с фиксированной командой, заточенной под остановку службы на удаленном пк в вашей сети,
        //Метод ожидает своей отработки .WaitForExit(); 
        public static void Powershell_service_Force(string ip, string name_service, string action_more)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "powershell",
                Arguments = "/command Get-Service -Computer " + ip + " -Name " + name_service + " | Stop-Service -Force" + action_more,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true
            }).WaitForExit();
        }

        private string ReNameService(string name_service)
        {
            string[] reName_mass_name_service = new string[]{ "Russian.Post.EAS4.Cart",
                        "Russian.Post.EAS4.Cash", "Russian.Post.EAS4.Fiscal", "Russian.Post.EAS4.PinPad", "Russian.Post.MARS.Discovery", "Russian.Post.MARS.Downloader",
                "Russian.Post.MARS.Launcher","Russian.Post.MARS.NSS","Russian.Post.MARS.PerformanceCounter","Russian.Post.MARS.Replicator","Russian.Post.MARS.Updater",
                "Russian.Post.MARS.WatchDog"};
            string[] mass_name_service = new string[]{ "eas4-cart",
                        "eas4-cash", "eas4-fiscal", "eas4-pinpad", "mars-discovery", "mars-downloader",
                "mars-launcher","mars-nss","mars-performancecounter","mars-replicator","mars-updater",
                "mars-watchdog"};
            for (int i = 0; i < mass_name_service.Length; i++)
            {
                if (name_service == reName_mass_name_service[i])
                {
                    name_service = mass_name_service[i];
                    return name_service;
                }
            }
            string a = "";
            return a;
        }
        //Метод для контроля результата выполения метода Powershell_service,
        //исходя из результата Powershell_service, метод движется по разным сценариям
        async public void Async_Power_Shell_Service(string ip, string name_service, string action_service, yt_DesignUI.EgoldsProgressBar progressBar, yt_DesignUI.EgoldsGoogleTextBox textBox)
        {
            if (ip != "")
            {
                try
                {
                    if (action_service == "Running")
                    {
                        Powershell_service_checked(ip, name_service, out string check_action1);
                        if (check_action1 != "\r\nRunning\r\n\r\n\r\n")
                        {
                            progressBar.Value = 40;
                            string action_power_shell = $"set-service {ReNameService(name_service)} -ComputerName {ip} -Status {action_service} -PassThru | format-table Status -autosize";
                            Power_Shell(action_power_shell);
                            Thread.Sleep(500);
                            progressBar.Value = 70;
                            Powershell_service_checked(ip, name_service, out string check_action);
                            progressBar.Value = 90;
                            Check_Service(check_action, ip, name_service, action_service, progressBar, textBox, out string result);
                        }
                        else
                        {
                            progressBar.Value = 100;
                            MessageBox.Show($"Служба \"{name_service}\"\nНа компьютере {ip} - {Action_service_info(action_service)}");
                            progressBar.Value = 0;
                            textBox.Text = check_action1.Replace("\r\n", "");
                        }
                    }
                    if (action_service == "Stopped")
                    {
                        Powershell_service_checked(ip, name_service, out string check_action1);
                        if (check_action1 != "\r\nStopped\r\n\r\n\r\n")
                        {
                            progressBar.Value = 40;
                            string action_more = "";
                            Powershell_service_Force(ip, name_service, action_more);
                            Thread.Sleep(500);
                            progressBar.Value = 70;
                            Powershell_service_checked(ip, name_service, out string check_action);
                            progressBar.Value = 90;
                            Check_Service(check_action, ip, name_service, action_service, progressBar, textBox, out string result);
                        }
                        else
                        {
                            progressBar.Value = 100;
                            MessageBox.Show($"Служба \"{name_service}\"\nНа компьютере {ip} - {Action_service_info(action_service)}");
                            progressBar.Value = 0;
                            textBox.Text = check_action1.Replace("\r\n", "");
                        }
                    }
                    if (action_service == "Restart")
                    {
                        action_service = "R-Stopped";
                        textBox.Text = action_service.Substring(2);
                        progressBar.Value = 15;
                        string action_more = "";
                        Powershell_service_Force(ip, name_service, action_more);
                        progressBar.Value = 30;
                        string check_action = "";
                        string check_action_1 = "";
                        await Task.Run(() => Powershell_service_checked(ip, name_service, out check_action));
                        progressBar.Value = 45;
                        Check_Service(check_action, ip, name_service, action_service, progressBar, textBox, out string result_1);
                        if (result_1 == "\r\nStopped\r\n\r\n\r\n")
                        {
                            action_service = "R-Running";
                            progressBar.Value = 60;
                            string action_power_shell = $"set-service {name_service} -ComputerName {ip} -Status {action_service.Substring(2)} -PassThru | format-table Status -autosize";
                            Power_Shell(action_power_shell);
                            progressBar.Value = 75;
                            await Task.Run(() => Powershell_service_checked(ip, name_service, out check_action_1));
                            progressBar.Value = 90;
                            Check_Service(check_action_1, ip, name_service, action_service, progressBar, textBox, out string result);
                            if (result == "\r\nRunning\r\n\r\n\r\n")
                            {
                                progressBar.Value = 100;
                                MessageBox.Show($"Служба \"{name_service}\"\nНа компьютере {ip} - Перезапущена");
                                progressBar.Value = 0;
                                textBox.Text = result.Replace("\r\n", "");
                            }
                            else
                            {
                                progressBar.Value = 100;
                                MessageBox.Show($"Служба \"{name_service}\"\nНа компьютере {ip} - НЕ Перезапустилась, Ошибка запуска службы");
                                progressBar.Value = 0;
                                textBox.Text = "Ошибка";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка из метода Async_Power_Shell_Service \nПк выключен или нет интернета\nИли запрашиваемая служба отсутствует на данном ПК\n\n\nОписание:\n\n{ex}");
                }
            }
            else
                MessageBox.Show($"\nПоле IP Адрес - пустое");
        }
        public void Powershell_service(string ip, string action, string name_service, string action_more, ProgressBar processBar, out string p)
        {
            p = "";
            try
            {
                Process process1 = Process.Start(new ProcessStartInfo
                {
                    FileName = "powershell",
                    Arguments = "/command set-service " + name_service + " -ComputerName " + ip + " -Status " + action + " -PassThru | format-table Status -autosize" + action_more,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true
                });
                Thread.Sleep(500);
                string h = process1.StandardOutput.ReadToEnd();
                string k = h.Substring(18);
                Thread.Sleep(500);
                if (k == "\r\nStopped\r\n\r\n\r\n")
                {
                    p = k;
                }
                else if (k == "\r\nRunning\r\n\r\n\r\n")
                {
                    p = k;
                }
                else
                    p = "Блок еlse";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"\nСлужба не найдена");
                processBar.Value = 100;
                MessageBox.Show($"Ошибка: {ex}");
            }
        }
        public void Check_Service(string check_action, string ip, string name_service, string action_service, yt_DesignUI.EgoldsProgressBar progressBar, yt_DesignUI.EgoldsGoogleTextBox textBox, out string result)
        {
            if (action_service != "R-Stopped" | action_service != "R-Running")
            {
                result = check_action;
                if (check_action == $"\r\n{action_service}\r\n\r\n\r\n")
                {
                    result = check_action;
                    progressBar.Value = 100;
                    MessageBox.Show($"Служба \"{name_service}\"\nНа компьютере {ip} - {Action_service_info(action_service)}");
                    progressBar.Value = 0;
                    textBox.Text = check_action.Replace("\r\n", "");
                }
                if (check_action == "Блок еlse")
                {
                    result = check_action;
                    MessageBox.Show($"Блок else \nСлужба \"{name_service}\"на компьютере {ip} - {Action_service_info(action_service)}");
                    progressBar.Value = 0;
                }
                if (check_action == "Нет данных")
                {
                    result = check_action;
                    textBox.Text = check_action;
                    progressBar.Value = 0;
                }
                if (check_action == $"\r\n{Inversion_Action_service(action_service)}\r\n\r\n\r\n")
                {
                    result = check_action;
                    progressBar.Value = 100;
                    MessageBox.Show($"Служба \"{name_service}\"\nНа компьютере {ip} - {Action_service_info(action_service + "-Error")}");
                    textBox.Text = Inversion_Action_service(action_service);
                    progressBar.Value = 0;
                }
            }
            else
            {
                result = "";
                if (check_action == $"\r\nStopped\r\n\r\n\r\n")
                {
                    result = check_action;
                    textBox.Text = check_action.Replace("\r\n", "");
                }
                if (check_action == "Блок еlse")
                {
                    result = check_action;
                    textBox.Text = $"Блок else \nСлужба \"{name_service}\"на компьютере {ip} - {Action_service_info(action_service)}";
                }
                if (check_action == "Нет данных")
                {
                    result = check_action;
                    textBox.Text = check_action;
                }
                if (check_action == $"\r\n{Inversion_Action_service(action_service)}\r\n\r\n\r\n")
                {
                    result = check_action;
                    progressBar.Value = 100;
                    MessageBox.Show($"Служба \"{name_service}\"\nНа компьютере {ip} - {Action_service_info(action_service + "-Error")}");
                    textBox.Text = Inversion_Action_service(action_service);
                    progressBar.Value = 0;
                }
            }
        }
        public string Inversion_Action_service(string action_service)
        {
            if (action_service == "Stopped")
                return "Running";
            if (action_service == "Running")
                return "Stopped";
            else
                return $"\nОшибка: action_service = {action_service}\nМетод Async_Power_Shell_Service далее Action_service_info";
        }


        //Метод для вывода состояния службы в MessageBox, исходя из значения переменной action_service
        public string Action_service_info(string action_service)
        {
            if (action_service == "Stopped")
                return "Остановлена";
            if (action_service == "Stopped-Error")
                return "не остановилась\nОшибка остановки службы";
            if (action_service == "Running")
                return "Запущена";
            if (action_service == "Running-Error")
                return "не запустилась\nОшибка запуска службы";
            else
                return $"\nОшибка: action_service = {action_service}\nМетод Async_Power_Shell_Service далее Action_service_info";
        }

        //Метод представляющий процесс, запускающий power_shell с командами,
        //редактируемыми по параметрам метода и служащими для управления службами на удаленных пк, в сетке, где находится сама программа
        //Удаленные пк задаются в виде их ip (айпи адреса), в самом Power_shell, в его команде, после объявления командлета "-ComputerName" 
        public void Powershell_service_checked(string ip, string name_service, out string check_action)
        {
            //check_action = "";
            try
            {
                Process process1 = Process.Start(new ProcessStartInfo
                {
                    FileName = "powershell",
                    Arguments = "/command get-service " +
                                      $"-DisplayName \"{name_service}\"" +
                                      " -ComputerName " + ip + "" +
                                      " | format-table Status -autosize",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true
                });
                string h = process1.StandardOutput.ReadToEnd();
                string k = h.Substring(18);
                if (textBox1.Text.Length == 6 & k != "\r\nStopped\r\n\r\n\r\n" & k != "\r\nRunning\r\n\r\n\r\n")
                {
                    check_action = "Нет данных";
                }
                else if (k == "\r\nStopped\r\n\r\n\r\n")
                {
                    check_action = k;
                }
                else if (k == "\r\nRunning\r\n\r\n\r\n")  //else выполниться, исходя из значения последнего невыполненого if,
                                                          //на значения других if конструкция не распространяется
                {
                    check_action = k;
                }
                else
                    check_action = "Блок еlse";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Служба не найдена");
                //MessageBox.Show($"Ошибка из метода Powershell_service \nПк выключен или нет интернета\nИли запрашиваемая служба отсутствует на данном ПК\n\n\nОписание:\n\n{ex}");
                check_action = "Нет данных";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text != "" & textBox1.Text.Length >= 6)
            //{
            //    var form2 = new Form2();
            //    Ping("-n", textBox1, form2.label1, 1);
            //    ComboBoxDataSourseService();
            //    //comboBox2.DataSource = list_name_service;

            //    List<string> list_name_service_small = new List<string>{
            //            "Russian.Post.EAS4.Fiscal", "Russian.Post.EAS4.PinPad", "Russian.Post.MARS.Downloader",
            //    "Russian.Post.MARS.Launcher","Russian.Post.MARS.PerformanceCounter","Russian.Post.MARS.Updater",
            //    "Russian.Post.MARS.WatchDog"};
            //    string ip = textBox3.Text;
            //    var form = new Form2(ip, ComboBoxDataSourseServiceForm2(), textBox1.Text.ToString());
            //    form.comboBox1.DataSource = list_name_service_small;
            //}
            //else
            //    MessageBox.Show($"\nНекорректный ввод индекса отделения");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text != "" & textBox1.Text.Length >= 6)
            //{
            //    var form2 = new Form2();
            //    Ping("", textBox1, form2.label1, 1);
            //    ComboBoxDataSourseService();
            //    //comboBox2.DataSource = list_name_service_small;
            //    List<string> list_name_service_small = new List<string>{
            //            "Russian.Post.EAS4.Fiscal", "Russian.Post.EAS4.PinPad", "Russian.Post.MARS.Downloader",
            //    "Russian.Post.MARS.Launcher","Russian.Post.MARS.PerformanceCounter","Russian.Post.MARS.Updater",
            //    "Russian.Post.MARS.WatchDog"};
            //    string ip = textBox3.Text;
            //    var form = new Form2(ip, ComboBoxDataSourseServiceForm2(), textBox1.Text.ToString());
            //    form.comboBox1.DataSource = list_name_service_small;
            //}
            //else
            //    MessageBox.Show($"\nНекорректный ввод индекса отделения");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //AsyncProcessStart(@"\\" + textBox3.Text + @"\c$");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //AsyncProcessStart(@"\\" + textBox3.Text + @"\d$");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //AsyncProcessStart(@"\\" + textBox3.Text + @"\e$");
        }
        private void button10_Click(object sender, EventArgs e)
        {
            //StartRemoteAccess("mstsc", @"C:\WINDOWS\system32\mstsc.exe");
        }
        private void button11_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox3.Text);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox4.Text);
        }


        //Остановить службу
        async private void button1_Click(object sender, EventArgs e)
        {
            //string nameService = comboBox1.SelectedItem.ToString();
            //await Task.Run(() => Async_Power_Shell_Service(textBox3.Text, nameService, "Stopped", progressBar2, textBox2));
        }
        //Запустить службу
        async private void button2_Click(object sender, EventArgs e)
        {
            //string nameService = comboBox1.SelectedItem.ToString();
            //await Task.Run(() => Async_Power_Shell_Service(textBox3.Text, nameService, "Running", progressBar2, textBox2));
        }
        //Перезапустить службу
        public void Async_Power_Shell_Service_Rebut(string ip, string name_service, ProgressBar progressBar, TextBox textBox)
        {
            try
            {
                string check_action;
                progressBar.Value = 40;
                Powershell_service(ip, "Stopped", ReNameService(name_service), "", progressBar, out check_action);
                if (check_action == "\r\nStopped\r\n\r\n\r\n")
                {
                    progressBar.Value = 60;
                    Powershell_service(ip, "Running", ReNameService(name_service), "", progressBar, out check_action);
                    progressBar.Value = 100;
                    MessageBox.Show($"Служба \"{name_service}\"\nНа компьютере {ip} - Перезапущена\n");
                    progressBar.Value = 0;
                    textBox.Text = check_action.Replace("\r\n", "");
                }
                if (check_action == "Блок еlse")
                {
                    MessageBox.Show($"Блок else \nСлужба \"{name_service}\"на компьютере {ip} - Остановлена");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"\nСлужба не найдена");
                //MessageBox.Show($"Ошибка:\n {ex}");
            }
        }
        async private void button3_Click(object sender, EventArgs e)
        {
            string nameService = comboBox1.SelectedItem.ToString();
            progressBar2.Value = 20;
            await Task.Run(() => Async_Power_Shell_Service_Rebut(textBox3.Text, nameService,
                progressBar2, textBox2));

        }
        public void Power_Shell_1(string command_power_shell, out string result)
        {
            result = "";
            if (ip != "")
            {
                try
                {
                    Process process = Process.Start(new ProcessStartInfo
                    {
                        FileName = "powershell",
                        Arguments = $"/command {command_power_shell}",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true
                    });
                    string k;
                    k = process.StandardOutput.ReadToEnd().Substring(18);
                    result = k.Replace("\r\n", "");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"\nСлужба не найдена");
                    //MessageBox.Show($"Ошибка из метода Power_Shell_1 \nПк выключен или нет интернета\n\n\nОписание:\n\n{ex}");
                }
            }
            else
                MessageBox.Show($"\nПоле IP Aдрес - пустое");
        }
        //Состояние службы
        async private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            string result = "";
            string nameService = comboBox1.SelectedItem.ToString();
            await Task.Run(() => Power_Shell_1($"get-service -DisplayName \"{nameService}\"" +
                                       $" -ComputerName " + textBox3.Text + " | format-table Status -autosize", out result));
            textBox2.Text = result;
        }
        //Состояние всех служб ЕАС
        public string[] Status_all_Service()
        {
            try
            {
                string ip = egoldsGoogleTextBox2.Text;
                List<string> list_name_service = new List<string>{ "Russian.Post.EAS4.Cart",
                        "Russian.Post.EAS4.Cash", "Russian.Post.EAS4.Fiscal", "Russian.Post.EAS4.PinPad", "Russian.Post.MARS.Discovery", "Russian.Post.MARS.Downloader",
                "Russian.Post.MARS.Launcher","Russian.Post.MARS.NSS","Russian.Post.MARS.PerformanceCounter","Russian.Post.MARS.Replicator","Russian.Post.MARS.Updater",
                "Russian.Post.MARS.WatchDog"};
                List<string> list_name_service_small = new List<string>{ "Russian.Post.EAS4.Fiscal", "Russian.Post.EAS4.PinPad", "Russian.Post.MARS.Downloader",
                "Russian.Post.MARS.Launcher","Russian.Post.MARS.PerformanceCounter","Russian.Post.MARS.Updater",
                "Russian.Post.MARS.WatchDog"};
                if (egoldsGoogleTextBox1.Text.Length > 6)
                {
                    return Mass_Service_EAS(ip, list_name_service_small, 7);
                }
                else if (egoldsGoogleTextBox1.Text.Length == 6)
                {
                    return Mass_Service_EAS(ip, list_name_service, 12);
                }
                else
                {
                    MessageBox.Show($"Длинна поля номер ОПС - не корректна");
                    return new string[1];
                }

            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show($"Количество установленных служб Eas4 и Mars не равно 7");
                return new string[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка:\n {ex}");
                return new string[1];
            }
        }
        private string[] Mass_Service_EAS(string ip, List<string> list_name_service, int list_lenth)
        {
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "powershell",
                Arguments = $"/command get-service -DisplayName Russian.Post* -ComputerName {ip} | format-table Status -autosize",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true
            });
            string status_service = process.StandardOutput.ReadToEnd().Substring(18);
            List<string> list_status = new List<string>();
            string status_service_1 = status_service.Replace("\r\n", " ");
            List<string> status_service_list = status_service_1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            for (int i = 0; i < status_service_list.Count; i++)
            {
                if (status_service_list[i] == "------")
                {
                    status_service_list[i] = "Running";
                    //list_status[i] = list_name_service[i] + " - " + status_service_list[i];
                    list_status.Add(list_name_service[i].ToString() + " - " + status_service_list[i].ToString());
                }
                else
                    list_status.Add(list_name_service[i].ToString() + " - " + status_service_list[i].ToString());

                //list_status[i] = list_name_service[i] + " - " + status_service_list[i];
            }
            return list_status.ToArray();
        }
        async private void button13_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (textBox3.Text != "")
            //    {
            //        CheckForIllegalCrossThreadCalls = false; // нехороший лайфхак,
            //                                                 // отменяет отслеживание ошибок,
            //                                                 // но дает передать компоненты формы в другой поток 
            //        listBox1.Items.Clear();
            //        await Task.Run(() =>
            //        {
            //            if (Status_all_Service().Length != 1)
            //            {
            //                listBox1.Items.AddRange(Status_all_Service());
            //            }
            //        });
            //    }
            //    if (textBox3.Text == "")
            //    {
            //        MessageBox.Show($"\nПоле для ввода общего ip,\nдля управления службыми МПК - пустое,\nвведите ip отделения почтовой связи\n");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Ошибка:\n {ex}");
            //}
        }
        //Перезапустить все EAS4
        private void button14_Click(object sender, EventArgs e)
        {

        }
        private bool IsChecked()
        {
            if (egoldsGoogleTextBox1.Text.Length > 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Start_ALL_Service(ProgressBar progress, TextBox text, List<string> list_name_service)
        {
            try
            {
                //if (IsChecked())
                //{
                //    list_name_service.Skip(1).Skip(2).Skip(5).Skip(8).Skip(10);
                //    Start_Service_EAS(list_name_service, text, progress, 7);
                //}
                //else if (IsChecked())
                //{
                //    Start_Service_EAS(list_name_service, text, progress, 5);
                //}
                //else
                //{
                //    MessageBox.Show($"Длинна поля номер ОПС - не корректна");
                //}
            }
            catch (Exception ex)
            {
                progress.Value = 100;
                MessageBox.Show($"Ошибка: \n{ex}");
                progress.Value = 0;
            }
        }
        private void Start_Service_EAS(string[] list_name_service, TextBox text, ProgressBar progress, int ProgressBarValue)
        {
            try
            { 
            string[] mass_result = new string[list_name_service.Length];
            string ip = text.Text;
            progress.Value = 3;
            string check_action;
            for (int i = 0; i < list_name_service.Length; i++)
            {
                Powershell_service(ip, "Running", list_name_service[i], "", progress, out check_action);
                if (check_action == "\r\nRunning\r\n\r\n\r\n")
                {
                    progress.Value += ProgressBarValue;
                    mass_result[i] = list_name_service[i] + " - " + "Running (запущена)\n";
                }
                if (check_action == "Блок еlse")
                {
                    //progress.Value += 5;
                    mass_result[i] = $"\nСлужба \"{ list_name_service[i]}\"на компьютере {ip} - Запущена";
                }
                if (check_action != "\r\nRunning\r\n\r\n\r\n" & check_action != "Блок еlse")
                {
                    progress.Value += ProgressBarValue;
                    mass_result[i] = $"\nСлужба \"{ list_name_service[i]}\"на компьютере {ip} - Ошибка";
                }
            }
            progress.Value = 100;
            string result = "";
            foreach (string i in mass_result)
                result += i;
            MessageBox.Show($"\nCлужбы на компьютере {ip}: \n\n{result} ");
            progress.Value = 0;
            }
            catch (Exception ex)
            {
                progress.Value = 100;
                MessageBox.Show($"Ошибка: \n{ex}");
                progress.Value = 0;
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                CheckForIllegalCrossThreadCalls = false; // нехороший лайфхак,
                                                         // отменяет отслеживание ошибок,
                                                         // но дает передать компоненты формы в другой поток 
                Thread thread = new Thread(
       () =>
       {
           Start_Service_EAS(ComboBoxDataSourseServicev2().ToArray(), textBox3, progressBar1, 5);
       });
                thread.Start();
            }
            else
                MessageBox.Show("Поле для ввода пустое.\nВведите ip отделения почтовой связи.");
        }
        //Остановка всех служб 
        public void Stop_Service_All(string[] mass_name_service, ProgressBar progress, TextBox text)
        {
            try
            {
                string[] mass_result = new string[mass_name_service.Length];
                progress.Minimum = 0;
                progress.Maximum = 100;
                string ip = text.Text;
                progress.Value = 3;
                string check_action;
                for (int i = 0; i < mass_name_service.Length; i++)
                {
                    Powershell_service(ip, "Stopped", mass_name_service[i], "", progress, out check_action);
                    if (check_action == "\r\nStopped\r\n\r\n\r\n")
                    {
                        progress.Value += 5;
                        mass_result[i] = mass_name_service[i] + " - " + "Stopped (остановлена)\n";
                    }
                    if (check_action == "Блок еlse")
                    {
                        //progress.Value += 5;
                        mass_result[i] = $"\nСлужба \"{ mass_name_service[i]}\"на компьютере {ip} - Остановлена";
                    }
                    if (check_action != "\r\nRunning\r\n\r\n\r\n" & check_action != "Блок еlse")
                    {
                        progress.Value += 5;
                        mass_result[i] = $"\nСлужба \"{ mass_name_service[i]}\"на компьютере {ip} - Ошибка";
                    }
                }
                progress.Value = 100;
                string result = "";
                foreach (string i in mass_result)
                    result += i;
                MessageBox.Show($"\nCлужбы на компьютере {ip}: \n\n{result} ");
                progress.Value = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: \n{ex}");
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                CheckForIllegalCrossThreadCalls = false; // нехороший лайфхак,
                                                         // отменяет отслеживание ошибок,
                                                         // но дает передать компоненты формы в другой поток 

                Thread thread = new Thread(
                    () =>
                    {
                        Stop_Service_All(ComboBoxDataSourseServicev2().ToArray(), progressBar1, textBox3);
                    });
                thread.Start();
            }
            else
                MessageBox.Show("Поле для ввода пустое.\nВведите ip отделения почтовой связи.");
        }
        //Перезапуск всех служб
        public void Rebut_MPK_Service(ProgressBar progressBar, string[] mass_name_service)
        {
            if (textBox3.Text != "")
            {
                try
                {
                    string ip = textBox3.Text;
                    progressBar.Value = 10;
                    progressBar.Value = 3;
                    string check_action;
                    string[] mass_result = new string[mass_name_service.Length];
                    for (int i = 0; i < mass_name_service.Length; i++)
                    {
                        Powershell_service(ip, "Stopped", mass_name_service[i], "", progressBar, out check_action);
                        if (check_action == "\r\nStopped\r\n\r\n\r\n")
                        {
                            progressBar.Value += 5;
                            Powershell_service(ip, "Running", mass_name_service[i], "", progressBar, out check_action);
                            if (check_action == "\r\nRunning\r\n\r\n\r\n")
                                mass_result[i] = mass_name_service[i] + " - " + "Перезапущена ,Status - Running\n";
                            else
                                mass_result[i] = mass_name_service[i] + " - " + "Не Перезапущена\n";
                        }
                        else
                            mass_result[i] = mass_name_service[i] + " - " + "Не остановлена\n";
                    }
                    progressBar.Value = 100;
                    string result = "";
                    foreach (string i in mass_result)
                        result += i;
                    MessageBox.Show($"\nCлужбы на компьютере {ip}: \n\n{ result}");
                    progressBar.Value = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: \n{ex}");
                }
            }
            else
                MessageBox.Show("Поле для ввода пустое.\nВведите ip отделения почтовой связи.");
        }
        private void button14_Click_1(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                CheckForIllegalCrossThreadCalls = false; // нехороший лайфхак,
                                                         // отменяет отслеживание ошибок,
                                                         // но дает передать компоненты формы в другой поток 
                Thread thread = new Thread(
                    () =>
                    {
                        Rebut_MPK_Service(progressBar1, ComboBoxDataSourseServicev2().ToArray());
                    });
                thread.Start();
            }
            else
                MessageBox.Show("Поле для ввода пустое.\nВведите ip отделения почтовой связи.");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(ServiceForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Activate();
        }
        private void ServiceForm()
        {
            string ip = textBox3.Text;
            var form = new Form2(ip, ComboBoxDataSourseServiceForm2(), textBox1.Text.ToString());
            form.ShowDialog();
        }
        public void ComboBoxDataSourseService()
        {
            List<string> list_name_service = new List<string>{ "Russian.Post.EAS4.Cart",
                        "Russian.Post.EAS4.Cash", "Russian.Post.EAS4.Fiscal", "Russian.Post.EAS4.PinPad", "Russian.Post.MARS.Discovery", "Russian.Post.MARS.Downloader",
                "Russian.Post.MARS.Launcher","Russian.Post.MARS.NSS","Russian.Post.MARS.PerformanceCounter","Russian.Post.MARS.Replicator","Russian.Post.MARS.Updater",
                "Russian.Post.MARS.WatchDog"};
            List<string> list_name_service_small = new List<string>{
                        "Russian.Post.EAS4.Fiscal", "Russian.Post.EAS4.PinPad", "Russian.Post.MARS.Downloader",
                "Russian.Post.MARS.Launcher","Russian.Post.MARS.PerformanceCounter","Russian.Post.MARS.Updater",
                "Russian.Post.MARS.WatchDog"};
            List<string> nul = new List<string>();
            if (IsChecked())
            {
                comboBox1.DataSource = list_name_service_small.ToArray();
            }
            else if (egoldsGoogleTextBox1.Text.Length == 6)
            {
                comboBox1.DataSource = list_name_service.ToArray();
            }
            else
            {
                comboBox1.DataSource = nul.ToArray();
            }
        }
        public string[] ComboBoxDataSourseServicev2()
        {
            string[] mass_name_service = new string[]{ "eas4-cart",
                    "eas4-cash", "eas4-fiscal", "eas4-pinpad", "mars-discovery", "mars-downloader",
            "mars-launcher","mars-nss","mars-performancecounter","mars-replicator","mars-updater",
            "mars-watchdog"};
            List<string> list_name_service_small = new List<string>{
                        "eas4-fiscal", "eas4-pinpad",  "mars-downloader",
            "mars-launcher","mars-performancecounter","mars-updater",
                "mars-watchdog"};
            List<string> nul = new List<string>();
            if (IsChecked())
            {
                return list_name_service_small.ToArray();
            }
            else if (textBox1.Text.Length == 6)
            {
                return mass_name_service.ToArray();
            }
            else
            {
                return nul.ToArray();
            }
        }
        public string[] ComboBoxDataSourseServiceForm2()
        {

            List<string> list_name_service = new List<string>{ "Russian.Post.EAS4.Cart",
                        "Russian.Post.EAS4.Cash", "Russian.Post.EAS4.Fiscal", "Russian.Post.EAS4.PinPad", "Russian.Post.MARS.Discovery", "Russian.Post.MARS.Downloader",
                "Russian.Post.MARS.Launcher","Russian.Post.MARS.NSS","Russian.Post.MARS.PerformanceCounter","Russian.Post.MARS.Replicator","Russian.Post.MARS.Updater",
                "Russian.Post.MARS.WatchDog"};
            List<string> list_name_service_small = new List<string>{
                        "Russian.Post.EAS4.Fiscal", "Russian.Post.EAS4.PinPad", "Russian.Post.MARS.Downloader",
                "Russian.Post.MARS.Launcher","Russian.Post.MARS.PerformanceCounter","Russian.Post.MARS.Updater",
                "Russian.Post.MARS.WatchDog"};
            List<string> nul = new List<string>();
            if (IsChecked())
            {
                return list_name_service_small.ToArray();
            }
            else if (egoldsGoogleTextBox1.Text.Length == 6)
            {
                return list_name_service.ToArray();
            }
            else
            {
                return nul.ToArray();
            }
        }

        private void yt_Button6_Click(object sender, EventArgs e)
        {
            if (egoldsGoogleTextBox1.Text != "" & egoldsGoogleTextBox1.Text.Length >= 6)
            {
                var form2 = new Form2();
                Ping("-n", egoldsGoogleTextBox1, form2.label1, 1);
                ComboBoxDataSourseService();
                //comboBox2.DataSource = list_name_service;

                List<string> list_name_service_small = new List<string>{
                        "Russian.Post.EAS4.Fiscal", "Russian.Post.EAS4.PinPad", "Russian.Post.MARS.Downloader",
                "Russian.Post.MARS.Launcher","Russian.Post.MARS.PerformanceCounter","Russian.Post.MARS.Updater",
                "Russian.Post.MARS.WatchDog"};
                string ip = textBox3.Text;
                var form = new Form2(ip, ComboBoxDataSourseServiceForm2(), textBox1.Text);
                form.comboBox1.DataSource = list_name_service_small;
            }
            else
                MessageBox.Show($"\nНекорректный ввод индекса отделения");
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            if (egoldsGoogleTextBox1.Text != "" & egoldsGoogleTextBox1.Text.Length >= 6)
            {
                var form2 = new Form2();
                Ping("", egoldsGoogleTextBox1, form2.label1, 1);
                ComboBoxDataSourseService();
                //comboBox2.DataSource = list_name_service_small;
                List<string> list_name_service_small = new List<string>{
                        "Russian.Post.EAS4.Fiscal", "Russian.Post.EAS4.PinPad", "Russian.Post.MARS.Downloader",
                "Russian.Post.MARS.Launcher","Russian.Post.MARS.PerformanceCounter","Russian.Post.MARS.Updater",
                "Russian.Post.MARS.WatchDog"};
                string ip = textBox3.Text;
                var form = new Form2(ip, ComboBoxDataSourseServiceForm2(), textBox1.Text.ToString());
                form.comboBox1.DataSource = list_name_service_small;
            }
            else
                MessageBox.Show($"\nНекорректный ввод индекса отделения");
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void egoldsGoogleTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void yt_Button2_Click(object sender, EventArgs e)
        {
            AsyncProcessStart(@"\\" + ip + @"\c$");
        }

        private void yt_Button3_Click(object sender, EventArgs e)
        {
            AsyncProcessStart(@"\\" + ip + @"\d$");
        }

        private void yt_Button4_Click(object sender, EventArgs e)
        {
            AsyncProcessStart(@"\\" + ip + @"\e$");
        }

        private void yt_Button7_Click(object sender, EventArgs e)
        {
            StartRemoteAccess("mstsc", @"C:\WINDOWS\system32\mstsc.exe");
        }

        private void yt_Button5_Click(object sender, EventArgs e)
        {

        }

        private void yt_Button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (egoldsGoogleTextBox2.Text != "")
                {
                    CheckForIllegalCrossThreadCalls = false; // нехороший лайфхак,
                                                             // отменяет отслеживание ошибок,
                                                             // но дает передать компоненты формы в другой поток 
                    listBox1.Items.Clear();
                    Thread thread = new Thread(
                       () =>
                       {

                           if (Status_all_Service().Length != 1)
                    {
                        listBox1.Items.AddRange(Status_all_Service());
                    }
                       });
                    thread.Start();
                }
                if (egoldsGoogleTextBox2.Text == "")
                {
                    MessageBox.Show($"\nПоле для ввода общего ip,\nдля управления службыми МПК - пустое,\nвведите ip отделения почтовой связи\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка:\n {ex}");
            }
        }

        private void yt_Button5_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(egoldsGoogleTextBox2.Text);
        }

        private void egoldsGoogleTextBox2_Click(object sender, EventArgs e)
        {
            progressIP = 1;
            egoldsGoogleTextBox2.TextPreview = "IP Адрес:";
            egoldsGoogleTextBox2.BorderColor = System.Drawing.Color.DodgerBlue;
            egoldsGoogleTextBox2.BorderColorNotActive = System.Drawing.Color.DodgerBlue;
        }

      async private void yt_Button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (egoldsGoogleTextBox2.Text != "")
                {
                    CheckForIllegalCrossThreadCalls = false; // нехороший лайфхак,
                                                             // отменяет отслеживание ошибок,
                                                             // но дает передать компоненты формы в другой поток 

                    string nameService = comboBox1.SelectedItem.ToString();
                    if (nameService != "" & egoldsGoogleTextBox2.Text.Length > 9)
                    {
                        egoldsGoogleTextBox3.Text = "";
                        egoldsGoogleTextBox3.TextInput = "";
                        egoldsGoogleTextBox3.TextPreview = "";
                        string result = "";
                        string resultsr = "";
                        await Task.Run(() => Power_Shell_1($"get-service -DisplayName \"{nameService}\"" +
                                                   $" -ComputerName " + egoldsGoogleTextBox2.Text + " | format-table Status -autosize", out resultsr));
                        await Task.Run(() =>
                        {
                            if (progress == 0)
                            {
                                resultService = resultsr;
                                egoldsGoogleTextBox3.BorderColor = System.Drawing.Color.RoyalBlue;
                                egoldsGoogleTextBox3.BorderColorNotActive = System.Drawing.Color.RoyalBlue;
                                egoldsGoogleTextBox3.TextInput = resultsr;
                                egoldsGoogleTextBox3.TextPreview = resultsr;
                                egoldsGoogleTextBox3.Text = resultsr;
                            }
                            else
                            {
                                if(progress == 1)
                                {
                                    resultService = resultsr;
                                    egoldsGoogleTextBox3.BorderColor = System.Drawing.Color.DodgerBlue;
                                    egoldsGoogleTextBox3.BorderColorNotActive = System.Drawing.Color.DodgerBlue;
                                    egoldsGoogleTextBox3.TextInput = resultsr;
                                    egoldsGoogleTextBox3.TextPreview = "Service: " + egoldsGoogleTextBox2.Text;
                                    egoldsGoogleTextBox3.Text = resultsr;
                                }
                            }
                        });
                    }
                    else
                    {
                        MessageBox.Show($"Служба не выбрана");
                    }
                }
                if (egoldsGoogleTextBox2.Text == "")
                {
                    MessageBox.Show($"\nПоле для ввода общего ip,\nдля управления службыми МПК - пустое,\nвведите ip отделения почтовой связи\n");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка:\n {ex}");
            }
        }
        public string StatusService()
        {
            string result = "";
            string nameService = comboBox1.SelectedItem.ToString();
            string a = egoldsGoogleTextBox2.Text;
            string command_power_shell = $"get-service -DisplayName \"{nameService}\"" +
                                       $" -ComputerName " + a + " | format-table Status -autosize";
            Process process = Process.Start(new ProcessStartInfo
            {
                FileName = "powershell",
                Arguments = $"/command {command_power_shell}",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true
            });
            result = process.StandardOutput.ReadToEnd().Substring(18);
            return result;          
        }

        private void egoldsGoogleTextBox3_Click(object sender, EventArgs e)
        {
            progress = 1;
            if (resultService == "Running" | resultService == "Stopped")
            {
                egoldsGoogleTextBox3.TextPreview = "Service: " + egoldsGoogleTextBox2.Text;
                egoldsGoogleTextBox3.BorderColor = System.Drawing.Color.DodgerBlue;
                egoldsGoogleTextBox3.BorderColorNotActive = System.Drawing.Color.DodgerBlue;
            }
            else
            {
                egoldsGoogleTextBox3.TextPreview = "Status";
                egoldsGoogleTextBox3.BorderColor = System.Drawing.Color.DodgerBlue;
                egoldsGoogleTextBox3.BorderColorNotActive = System.Drawing.Color.DodgerBlue;
            }
        }

        private void egoldsGoogleTextBox4_Click(object sender, EventArgs e)
        {
            //egoldsGoogleTextBox4.TextPreview = resultService;
            //egoldsGoogleTextBox4.TextPreview = "Status: " + egoldsGoogleTextBox2.Text;
            //egoldsGoogleTextBox4.BorderColor = System.Drawing.Color.DodgerBlue;
            //egoldsGoogleTextBox4.BorderColorNotActive = System.Drawing.Color.DodgerBlue;
        }

       async private void yt_Button9_Click(object sender, EventArgs e)
        {
            string nameService = comboBox1.SelectedItem.ToString();
            await Task.Run(() => Async_Power_Shell_Service(ip, nameService, "Stopped", egoldsProgressBar1, egoldsGoogleTextBox3));
        }

        async private void yt_Button10_Click(object sender, EventArgs e)
        {
            string nameService = comboBox1.SelectedItem.ToString();
            await Task.Run(() => Async_Power_Shell_Service(ip, nameService, "Running", egoldsProgressBar1, egoldsGoogleTextBox3));
        }
    }
}
