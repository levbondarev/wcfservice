using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfax_client
{
    public partial class Form1 : Form
    {
        public static string connString;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            try
            {
                connString = System.IO.File.ReadAllText("connString.txt");
            }
            catch (Exception)
            {
                connString=Microsoft.VisualBasic.Interaction.InputBox("Введите базовый адрес данных", "Адрес данных");
                try
                {
                    System.IO.File.WriteAllText("connString.txt", connString);
                }
                catch (Exception)
                {
                    MessageBox.Show("Не удалось сохранить адрес на будущее использование");
                }
            }
        }
        public void refreshlabelsEnd(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                string[] temparray = System.IO.File.ReadAllLines("labels.txt");
                for (int o = 0; o < temparray.Count(); o++)
                {
                    string optimizeRow = temparray[o];
                    string[] newRow = optimizeRow.Split(new char[] { Convert.ToChar("#") }, StringSplitOptions.RemoveEmptyEntries);
                    dateLabel.Text = newRow[0];
                    memoryLabel.Text = newRow[1];
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось обновить содержимое меток. Проверьте права на запись в папку приложения");
            }
        }
        public void refreshlabelsStart()
        {
            System.Net.WebClient t = new System.Net.WebClient();
            t.DownloadFileCompleted += new AsyncCompletedEventHandler(refreshlabelsEnd);
            t.DownloadFileAsync(new System.Uri(connString + "/labels"), "labels.txt");
        }
        public void refreshtableEnd( object sender, AsyncCompletedEventArgs e) {
            try
            {
                string[] temparray = System.IO.File.ReadAllLines("array.txt");
                for (int o = 0; o < temparray.Count()-1; o++) {
                    string optimizeRow = temparray[o];
                    string[] newRow = optimizeRow.Split(new char[] { Convert.ToChar("#") },StringSplitOptions.RemoveEmptyEntries);
                    ifDG.Rows.Add(newRow);
                }
                LoggerType.Text = temparray[temparray.Count() - 1];
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось обновить содержимое таблицы. Проверьте права на запись в папку приложения");
            }
        }
        public void refreshtableStart() {
             System.Net.WebClient t = new System.Net.WebClient();
            t.DownloadFileCompleted += new AsyncCompletedEventHandler(refreshtableEnd);
            t.DownloadFileAsync(new System.Uri(connString+"/array"), "array.txt"); 
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshtableStart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            refreshlabelsStart();
        }
    }
}
