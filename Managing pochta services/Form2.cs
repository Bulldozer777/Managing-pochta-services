using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Managing_pochta_services
{
    public partial class Form2 : Form
    {
        string ip;
        public Form2()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
        public Form2(string ip, List<string> listService)
        {
            this.ip = ip;
            InitializeComponent();
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.DataSource = listService;
        }
        public Form2(string ip, string[] massService, string numberOps)
        {
            this.ip = ip;
            InitializeComponent();
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.DataSource = massService;
            label1.Text = "IP: " + this.ip;
            textBox1.Text = numberOps;
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
        //Остановить
       async private void button1_Click(object sender, EventArgs e)
        {
            //string nameService = comboBox1.SelectedItem.ToString();
            //Form1 form1 = new Form1(comboBox1);
            //await Task.Run(() => form1.Async_Power_Shell_Service(ip, nameService, "Stopped", progressBar2, textBox2));
        }
        //Запустить
       async private void button2_Click(object sender, EventArgs e)
        {
            //string nameService = comboBox1.SelectedItem.ToString();
            //Form1 form1 = new Form1(comboBox1);
            //await Task.Run(() => form1.Async_Power_Shell_Service(ip, nameService, "Running", progressBar2, textBox2));
        }
        //Состояние
      async  private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() != "")
            {
                textBox2.Clear();
                string result = "";
                string nameService = comboBox1.SelectedItem.ToString();
                Form1 form1 = new Form1(comboBox1);
                await Task.Run(() => form1.Power_Shell_1($"get-service -DisplayName \"{nameService}\"" +
                                           $" -ComputerName " + ip + " | format-table Status -autosize", out result));
                textBox2.Text = result;
            }
            else
            {
                MessageBox.Show("Выберите службу для управления из выпадающего списка");
            }
            
        }
        //Перезапустить
       async private void button3_Click(object sender, EventArgs e)
        {
            string nameService = comboBox1.SelectedItem.ToString();
            progressBar2.Value = 20;
            Form1 form1 = new Form1(comboBox1);
            await Task.Run(() => form1.Async_Power_Shell_Service_Rebut(ip, nameService,
                progressBar2, textBox2));
        }
        public void ComboBoxDataSourseService()
        {
            string IP = textBox1.Text; 
            List<string> list_name_service = new List<string>{ "Russian.Post.EAS4.Cart",
                        "Russian.Post.EAS4.Cash", "Russian.Post.EAS4.Fiscal", "Russian.Post.EAS4.PinPad", "Russian.Post.MARS.Discovery", "Russian.Post.MARS.Downloader",
                "Russian.Post.MARS.Launcher","Russian.Post.MARS.NSS","Russian.Post.MARS.PerformanceCounter","Russian.Post.MARS.Replicator","Russian.Post.MARS.Updater",
                "Russian.Post.MARS.WatchDog"};
            List<string> list_name_service_small = new List<string>{
                        "Russian.Post.EAS4.Fiscal", "Russian.Post.EAS4.PinPad", "Russian.Post.MARS.Downloader",
                "Russian.Post.MARS.Launcher","Russian.Post.MARS.PerformanceCounter","Russian.Post.MARS.Updater",
                "Russian.Post.MARS.WatchDog"};
            List<string> nul = new List<string>();
            if (IP.Length > 6)
            {
                comboBox1.DataSource = list_name_service_small.ToArray();
            }
            else if (IP.Length == 6)
            {
                comboBox1.DataSource = list_name_service.ToArray();
            }
            else
            {
                comboBox1.DataSource = nul.ToArray();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox1.Text.Length >= 6)
            {
                Form1 form1 = new Form1();
                //form1.Ping("-n", textBox1, label1, 2);
                ComboBoxDataSourseService();
            }
            else
                MessageBox.Show($"\nНекорректный ввод индекса отделения");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox1.Text.Length >= 6)
            {
                Form1 form1 = new Form1();
                //form1.Ping("", textBox1, label1, 2);
                ComboBoxDataSourseService();
            }
            else
                MessageBox.Show($"\nНекорректный ввод индекса отделения");

        }
    }
}
