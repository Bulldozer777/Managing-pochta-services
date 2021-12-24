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
        }
        public Form2(string ip)
        {
            this.ip = ip;
            InitializeComponent();
        }
        //Остановить
       async private void button1_Click(object sender, EventArgs e)
        {
            string nameService = comboBox1.SelectedItem.ToString();
            Form1 form1 = new Form1();
            await Task.Run(() => form1.Async_Power_Shell_Service(ip, nameService, "Stopped", progressBar2, textBox2));
        }
        //Запустить
       async private void button2_Click(object sender, EventArgs e)
        {
            string nameService = comboBox1.SelectedItem.ToString();
            Form1 form1 = new Form1();
            await Task.Run(() => form1.Async_Power_Shell_Service(ip, nameService, "Running", progressBar2, textBox2));
        }
        //Состояние
      async  private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            string result = "";
            string nameService = comboBox1.SelectedItem.ToString();
            Form1 form1 = new Form1();
            await Task.Run(() => form1.Power_Shell_1($"get-service -DisplayName \"{nameService}\"" +
                                       $" -ComputerName " + ip + " | format-table Status -autosize", out result));
            textBox2.Text = result;
        }
        //Перезапустить
       async private void button3_Click(object sender, EventArgs e)
        {
            string nameService = comboBox1.SelectedItem.ToString();
            progressBar2.Value = 20;
            Form1 form1 = new Form1();
            await Task.Run(() => form1.Async_Power_Shell_Service_Rebut(ip, nameService,
                progressBar2, textBox2));
        }
    }
}
