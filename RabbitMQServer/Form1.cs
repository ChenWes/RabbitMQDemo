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

namespace RabbitMQServer
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

                MC_channel.ConfirmSelect();

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

        private void btn_SendDirectMessage_Click(object sender, EventArgs e)
        {
            try
            {
                if (DirectExchangePublishMessageToServerAndWaitConfirm(txt_DirectExchange.Text.Trim(), txt_DirectRouting.Text.Trim(), txt_DirectQueue.Text.Trim(), txt_DirectMessageString.Text.Trim()))
                {
                    ShowLog("发送Direct消息成功", LogType.info);
                }
            }
            catch (Exception ex)
            {
                ShowLog("发送Direct消息错误，原因是：" + ex.Message, LogType.error);
            }
        }

        private void btn_SendFanoutMessage_Click(object sender, EventArgs e)
        {
            try
            {
                if (FanoutExchangePublishMessageToServerAndWaitConfirm(txt_FanoutExchange.Text.Trim(), txt_FanoutRouting.Text.Trim(), txt_FanoutQueue.Text.Trim(), txt_FanoutMessageString.Text.Trim()))
                {
                    ShowLog("发送Fanout消息成功", LogType.info);
                }
            }
            catch (Exception ex)
            {
                ShowLog("发送Fanout消息错误，原因是：" + ex.Message, LogType.error);
            }
        }

        private void btn_SendTopicMessage_Click(object sender, EventArgs e)
        {
            try
            {
                if (TopicExchangePublishMessageToServerAndWaitConfirm(txt_TopicExchange.Text.Trim(), txt_TopicRouting.Text.Trim(), txt_TopicQueue.Text.Trim(), txt_TopicMessageString.Text.Trim()))
                {
                    ShowLog("发送Topic消息成功", LogType.info);
                }
            }
            catch (Exception ex)
            {
                ShowLog("发送Topic消息错误，原因是：" + ex.Message, LogType.error);
            }
        }

        /// <summary>
        /// Direct路由，发送消息至服务端
        /// </summary>
        /// <param name="exchangeName">交换机名称</param>
        /// <param name="routingKey">RoutingKey</param>
        /// <param name="queueName">队列名称</param>
        /// <param name="message">消息内容</param>
        /// <returns></returns>
        private bool DirectExchangePublishMessageToServerAndWaitConfirm(string exchangeName, string routingKey, string queueName, string message)
        {
            try
            {
                if (MC_connection == null) throw new Exception("连接为空");
                if (MC_channel == null) throw new Exception("通送为空");

                //创建一个持久化的频道
                bool queueDurable = true;

                string QueueName = queueName;
                string ExchangeName = exchangeName;
                string RoutingKey = routingKey;

                //声明交换机
                MC_channel.ExchangeDeclare(ExchangeName, ExchangeType.Direct);
                //声明队列
                MC_channel.QueueDeclare(QueueName, queueDurable, false, false, null);
                //路由绑定队列
                MC_channel.QueueBind(QueueName, ExchangeName, RoutingKey, null);

                //设置消息持久性
                IBasicProperties props = MC_channel.CreateBasicProperties();
                props.ContentType = "text/plain";
                props.DeliveryMode = 2;//持久性

                //消息内容转码，并发送至服务器
                var messageBody = System.Text.Encoding.UTF8.GetBytes(message);
                MC_channel.BasicPublish(ExchangeName, RoutingKey, null, messageBody);

                //等待确认
                return MC_channel.WaitForConfirms();
            }
            catch (Exception ex)
            {
                ShowLog("发送Direct消息错误，原因是：" + ex.Message, LogType.error);

                return false;
            }
        }

        /// <summary>
        /// Fanout路由，发送消息至服务端
        /// </summary>
        /// <param name="exchangeName">交换机名称</param>
        /// <param name="routingKey">RoutingKey</param>
        /// <param name="queueName">队列名称</param>
        /// <param name="message">消息内容</param>
        /// <returns></returns>
        private bool FanoutExchangePublishMessageToServerAndWaitConfirm(string exchangeName, string routingKey, string queueName, string message)
        {
            try
            {
                if (MC_connection == null) throw new Exception("连接为空");
                if (MC_channel == null) throw new Exception("通送为空");

                //创建一个持久化的频道
                bool queueDurable = true;

                string QueueName = queueName;
                string ExchangeName = exchangeName;
                string RoutingKey = routingKey;

                //声明交换机
                MC_channel.ExchangeDeclare(ExchangeName, ExchangeType.Fanout);
                //声明队列
                //MC_channel.QueueDeclare(QueueName, queueDurable, false, false, null);
                //路由绑定队列
                //MC_channel.QueueBind(QueueName, ExchangeName, RoutingKey, null);

                //设置消息持久性
                IBasicProperties props = MC_channel.CreateBasicProperties();
                props.ContentType = "text/plain";
                props.DeliveryMode = 2;//持久性

                //消息内容转码，并发送至服务器
                var messageBody = System.Text.Encoding.UTF8.GetBytes(message);
                MC_channel.BasicPublish(ExchangeName, RoutingKey, null, messageBody);

                //等待确认
                return MC_channel.WaitForConfirms();
            }
            catch (Exception ex)
            {
                ShowLog("发送Fanout消息错误，原因是：" + ex.Message, LogType.error);

                return false;
            }
        }

        /// <summary>
        /// Topic路由，发送消息至服务端
        /// </summary>
        /// <param name="exchangeName">交换机名称</param>
        /// <param name="routingKey">RoutingKey</param>
        /// <param name="queueName">队列名称</param>
        /// <param name="message">消息内容</param>
        /// <returns></returns>
        private bool TopicExchangePublishMessageToServerAndWaitConfirm(string exchangeName, string routingKey, string queueName, string message)
        {
            try
            {
                if (MC_connection == null) throw new Exception("连接为空");
                if (MC_channel == null) throw new Exception("通送为空");

                //创建一个持久化的频道
                bool queueDurable = true;

                string QueueName = queueName;
                string ExchangeName = exchangeName;
                string RoutingKey = routingKey;

                //声明交换机
                MC_channel.ExchangeDeclare(ExchangeName, ExchangeType.Topic);
                //声明队列
                MC_channel.QueueDeclare(QueueName, queueDurable, false, false, null);
                //路由绑定队列
                MC_channel.QueueBind(QueueName, ExchangeName, RoutingKey, null);

                //设置消息持久性
                IBasicProperties props = MC_channel.CreateBasicProperties();
                props.ContentType = "text/plain";
                props.DeliveryMode = 2;//持久性

                //消息内容转码，并发送至服务器
                var messageBody = System.Text.Encoding.UTF8.GetBytes(message);
                MC_channel.BasicPublish(ExchangeName, RoutingKey, null, messageBody);

                //等待确认
                return MC_channel.WaitForConfirms();
            }
            catch (Exception ex)
            {
                ShowLog("发送Topic消息错误，原因是：" + ex.Message, LogType.error);

                return false;
            }
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

    }
}
