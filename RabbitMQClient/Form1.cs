using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace RabbitMQClient
{
    public partial class Form1 : Form
    {
        private ConnectionFactory MC_connectionFactory = null;
        private IConnection MC_connection = null;
        private IModel MC_channel = null;

        private enum LogType
        {
            error,
            info,
            warning
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                int rabbitMQPort = 0;
                int.TryParse(txt_RabbitMQPort.Text.Trim(), out rabbitMQPort);

                MC_connectionFactory = new ConnectionFactory();

                MC_connectionFactory.HostName = txt_RabbitMQHostName.Text.Trim();
                MC_connectionFactory.Port = rabbitMQPort;
                MC_connectionFactory.UserName = txt_RabbitMQUserName.Text.Trim();
                MC_connectionFactory.Password = txt_RabbitMQPassword.Text.Trim();

                MC_connection = MC_connectionFactory.CreateConnection();
                MC_channel = MC_connection.CreateModel();



                btn_Connect.Enabled = false;
            }
            catch (Exception ex)
            {
                ShowLog("连接错误，原因是：" + ex.Message, LogType.error);
            }
        }

        private void ShowLog(string messageString, LogType logType)
        {
            if (logType == LogType.error)
            {
                txt_LogText.SelectionColor = System.Drawing.Color.Red;
                txt_LogText.AppendText(messageString + "\n");
            }
            else if (logType == LogType.info)
            {
                txt_LogText.SelectionColor = System.Drawing.Color.Green;
                txt_LogText.AppendText(messageString + "\n");
            }
            else if (logType == LogType.warning)
            {
                txt_LogText.SelectionColor = System.Drawing.Color.Yellow;
                txt_LogText.AppendText(messageString + "\n");
            }
            txt_LogText.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MC_channel != null)
            {
                MC_channel.Close();
            }
            if (MC_connection != null)
            {
                MC_connection.Close();
            }
        }


        //声明委托
        private delegate void ShowMessageDelegate(string message, LogType logType);
        private void ShowMessage(string message, LogType logType)
        {
            if (this.InvokeRequired)
            {
                ShowMessageDelegate showMessageDelegate = ShowMessage;
                this.Invoke(showMessageDelegate, new object[] { message, logType });
            }
            else
            {
                ShowLog(message, logType);                
            }
        }

        private void btn_ReceivedDirect_Click(object sender, EventArgs e)
        {
            try
            {
                MC_channel.QueueDeclare(txt_DirectQueueName.Text.Trim(), true, false, false, null);

                var consumer = new EventingBasicConsumer(MC_channel);
                MC_channel.BasicConsume(txt_DirectQueueName.Text.Trim(), false, consumer);

                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);

                    ShowMessage("接收到Direct=>" + txt_DirectQueueName.Text.Trim() + "消息：" + message, LogType.info);

                    //MC_channel.BasicAck(ea.DeliveryTag, false);
                };

                //var consumer = new EventingBasicConsumer(MC_channel);
                //MC_channel.BasicConsume(txt_DirectQueueName.Text.Trim(), false, consumer);

                //while (true)
                //{
                //    var ea = (BasicDeliverEventArgs)consumer.Queue.Dequeue();

                //    var body = ea.Body;
                //    var message = Encoding.UTF8.GetString(body);

                //    int dots = message.Split('.').Length - 1;



                //    channel.BasicAck(ea.DeliveryTag, false);
                //}
            }
            catch (Exception ex)
            {
                ShowLog("接收Direct错误，原因是：" + ex.Message, LogType.error);
            }
        }

        private void btn_ReceviedFanout_Click(object sender, EventArgs e)
        {
            try
            {
                MC_channel.QueueDeclare(txt_FanoutQueueName.Text.Trim(), true, false, false, null);

                var consumer = new EventingBasicConsumer(MC_channel);
                MC_channel.BasicConsume(txt_FanoutQueueName.Text.Trim(), false, consumer);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                    ShowLog("接收到Fanout=>" + txt_FanoutQueueName.Text.Trim() + "消息：" + message, LogType.info);
                };
            }
            catch (Exception ex)
            {
                ShowLog("接收Fanout错误，原因是：" + ex.Message, LogType.error);
            }
        }

        private void btn_ReceviedTopic_Click(object sender, EventArgs e)
        {
            try
            {
                MC_channel.QueueDeclare(txt_TopicQueueName.Text.Trim(), true, false, false, null);

                var consumer = new EventingBasicConsumer(MC_channel);
                MC_channel.BasicConsume(txt_TopicQueueName.Text.Trim(), false, consumer);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                    ShowLog("接收到Topic=>" + txt_TopicQueueName.Text.Trim() + "消息：" + message, LogType.info);
                };
            }
            catch (Exception ex)
            {
                ShowLog("接收Topic错误，原因是：" + ex.Message, LogType.error);
            }
        }
    }
}
