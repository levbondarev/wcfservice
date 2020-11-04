using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using Microsoft.VisualBasic;
using System.Threading;
namespace interfax_webclient
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
         void ThreadVoid() {
            try
            {
                Service1Client c = new Service1Client();
                string[] temparray = c.HandleMessage("labels").Split(new char[] { Convert.ToChar("\r"), Convert.ToChar("\n") }, StringSplitOptions.RemoveEmptyEntries);
                for (int o = 0; o < temparray.Count(); o++)
                {
                    string optimizeRow = temparray[o];
                    string[] newRow = optimizeRow.Split(new char[] { Convert.ToChar("#") }, StringSplitOptions.RemoveEmptyEntries);
                    if (this.dateLabel.InvokeRequired)
                    {
                        this.dateLabel.BeginInvoke((MethodInvoker)delegate() { this.dateLabel.Text = newRow[0]; ;});
                    }
                    else
                    {
                        this.dateLabel.Text = newRow[0]; ;
                    }
                    if (this.memoryLabel.InvokeRequired)
                    {
                        this.memoryLabel.BeginInvoke((MethodInvoker)delegate() { this.memoryLabel.Text = newRow[1]; ;});
                    }
                    else
                    {
                        this.memoryLabel.Text = newRow[0]; ;
                    }

                    //memoryLabel.Text = newRow[1];
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void refreshlabelsStart()
        {
            try
            {
                Service1Client c = new Service1Client();
                string[] temparray = c.HandleMessage("labels").Split(new char[] { Convert.ToChar("\r"), Convert.ToChar("\n") }, StringSplitOptions.RemoveEmptyEntries);
                for (int o = 0; o < temparray.Count(); o++)
                {
                    string optimizeRow = temparray[o];
                    string[] newRow = optimizeRow.Split(new char[] { Convert.ToChar("#") }, StringSplitOptions.RemoveEmptyEntries);
                    dateLabel.Text = newRow[0];
                    memoryLabel.Text = newRow[1];
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        public void refreshtableEnd(object sender, AsyncCompletedEventArgs e)
        {

        }
        public void refreshtableStart()
        {
            try
            {
                Service1Client c = new Service1Client();
                string[] temparray = c.HandleMessage("array").Split(new char[] { Convert.ToChar("\r"), Convert.ToChar("\n") }, StringSplitOptions.RemoveEmptyEntries);
                for (int o = 0; o < temparray.Count() - 1; o++)
                {
                    string optimizeRow = temparray[o];
                    string[] newRow = optimizeRow.Split(new char[] { Convert.ToChar("#") }, StringSplitOptions.RemoveEmptyEntries);
                    ifDG.Rows.Add(newRow);
                }
                LoggerType.Text = temparray[temparray.Count() - 1];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                //MessageBox.Show("Не удалось обновить содержимое таблицы. Проверьте права на запись в папку приложения");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //refreshlabelsStart();
            Thread mythread = new Thread(ThreadVoid);
            mythread.Start();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshtableStart();
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "IService1")]
    public interface IService1
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/HandleMessage", ReplyAction = "http://tempuri.org/IService1/HandleMessageResponse")]
        string HandleMessage(string request);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IService1Channel : IService1, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<IService1>, IService1
    {

        public Service1Client()
        {
        }

        public Service1Client(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public Service1Client(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        public string HandleMessage(string request)
        {
            return base.Channel.HandleMessage(request);
        }
    }

   
}
