namespace RabbitMQServer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.txt_RabbitMQPassword = new System.Windows.Forms.TextBox();
            this.txt_RabbitMQUserName = new System.Windows.Forms.TextBox();
            this.txt_RabbitMQPort = new System.Windows.Forms.TextBox();
            this.txt_RabbitMQHostName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_LogText = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_TopicQueue = new System.Windows.Forms.TextBox();
            this.txt_TopicExchange = new System.Windows.Forms.TextBox();
            this.txt_TopicRouting = new System.Windows.Forms.TextBox();
            this.txt_TopicMessageString = new System.Windows.Forms.TextBox();
            this.btn_SendTopicMessage = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_FanoutQueue = new System.Windows.Forms.TextBox();
            this.txt_FanoutExchange = new System.Windows.Forms.TextBox();
            this.txt_FanoutRouting = new System.Windows.Forms.TextBox();
            this.txt_FanoutMessageString = new System.Windows.Forms.TextBox();
            this.btn_SendFanoutMessage = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DirectQueue = new System.Windows.Forms.TextBox();
            this.txt_DirectExchange = new System.Windows.Forms.TextBox();
            this.txt_DirectRouting = new System.Windows.Forms.TextBox();
            this.txt_DirectMessageString = new System.Windows.Forms.TextBox();
            this.btn_SendDirectMessage = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Connect);
            this.panel1.Controls.Add(this.txt_RabbitMQPassword);
            this.panel1.Controls.Add(this.txt_RabbitMQUserName);
            this.panel1.Controls.Add(this.txt_RabbitMQPort);
            this.panel1.Controls.Add(this.txt_RabbitMQHostName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 47);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "HostName";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(699, 12);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 1;
            this.btn_Connect.Text = "连接";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // txt_RabbitMQPassword
            // 
            this.txt_RabbitMQPassword.Location = new System.Drawing.Point(580, 12);
            this.txt_RabbitMQPassword.Name = "txt_RabbitMQPassword";
            this.txt_RabbitMQPassword.Size = new System.Drawing.Size(68, 21);
            this.txt_RabbitMQPassword.TabIndex = 0;
            this.txt_RabbitMQPassword.Text = "admin123";
            // 
            // txt_RabbitMQUserName
            // 
            this.txt_RabbitMQUserName.Location = new System.Drawing.Point(417, 14);
            this.txt_RabbitMQUserName.Name = "txt_RabbitMQUserName";
            this.txt_RabbitMQUserName.Size = new System.Drawing.Size(68, 21);
            this.txt_RabbitMQUserName.TabIndex = 0;
            this.txt_RabbitMQUserName.Text = "admin";
            // 
            // txt_RabbitMQPort
            // 
            this.txt_RabbitMQPort.Location = new System.Drawing.Point(251, 12);
            this.txt_RabbitMQPort.Name = "txt_RabbitMQPort";
            this.txt_RabbitMQPort.Size = new System.Drawing.Size(46, 21);
            this.txt_RabbitMQPort.TabIndex = 0;
            this.txt_RabbitMQPort.Text = "5672";
            // 
            // txt_RabbitMQHostName
            // 
            this.txt_RabbitMQHostName.Location = new System.Drawing.Point(71, 12);
            this.txt_RabbitMQHostName.Name = "txt_RabbitMQHostName";
            this.txt_RabbitMQHostName.Size = new System.Drawing.Size(126, 21);
            this.txt_RabbitMQHostName.TabIndex = 0;
            this.txt_RabbitMQHostName.Text = "localhost";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 536);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txt_LogText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 536);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // txt_LogText
            // 
            this.txt_LogText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_LogText.Location = new System.Drawing.Point(403, 3);
            this.txt_LogText.Name = "txt_LogText";
            this.txt_LogText.Size = new System.Drawing.Size(394, 530);
            this.txt_LogText.TabIndex = 1;
            this.txt_LogText.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 530);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.txt_TopicQueue);
            this.panel5.Controls.Add(this.txt_TopicExchange);
            this.panel5.Controls.Add(this.txt_TopicRouting);
            this.panel5.Controls.Add(this.txt_TopicMessageString);
            this.panel5.Controls.Add(this.btn_SendTopicMessage);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 355);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(388, 172);
            this.panel5.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 12);
            this.label13.TabIndex = 18;
            this.label13.Text = "Queue";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 19;
            this.label14.Text = "Exchange";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 12);
            this.label15.TabIndex = 20;
            this.label15.Text = "Routing";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 140);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 21;
            this.label16.Text = "Message";
            // 
            // txt_TopicQueue
            // 
            this.txt_TopicQueue.Location = new System.Drawing.Point(61, 100);
            this.txt_TopicQueue.Name = "txt_TopicQueue";
            this.txt_TopicQueue.Size = new System.Drawing.Size(241, 21);
            this.txt_TopicQueue.TabIndex = 14;
            this.txt_TopicQueue.Text = "MES.MachineStatusLog.Queue";
            // 
            // txt_TopicExchange
            // 
            this.txt_TopicExchange.Location = new System.Drawing.Point(61, 15);
            this.txt_TopicExchange.Name = "txt_TopicExchange";
            this.txt_TopicExchange.Size = new System.Drawing.Size(241, 21);
            this.txt_TopicExchange.TabIndex = 15;
            this.txt_TopicExchange.Text = "MES.MachineStatusLog.Exchange";
            // 
            // txt_TopicRouting
            // 
            this.txt_TopicRouting.Location = new System.Drawing.Point(61, 55);
            this.txt_TopicRouting.Name = "txt_TopicRouting";
            this.txt_TopicRouting.Size = new System.Drawing.Size(241, 21);
            this.txt_TopicRouting.TabIndex = 16;
            this.txt_TopicRouting.Text = "MES.MachineStatusLog.Routing";
            // 
            // txt_TopicMessageString
            // 
            this.txt_TopicMessageString.Location = new System.Drawing.Point(61, 137);
            this.txt_TopicMessageString.Name = "txt_TopicMessageString";
            this.txt_TopicMessageString.Size = new System.Drawing.Size(241, 21);
            this.txt_TopicMessageString.TabIndex = 17;
            this.txt_TopicMessageString.Text = "Topic路由队列消息";
            // 
            // btn_SendTopicMessage
            // 
            this.btn_SendTopicMessage.Location = new System.Drawing.Point(306, 135);
            this.btn_SendTopicMessage.Name = "btn_SendTopicMessage";
            this.btn_SendTopicMessage.Size = new System.Drawing.Size(75, 23);
            this.btn_SendTopicMessage.TabIndex = 13;
            this.btn_SendTopicMessage.Text = "发送消息";
            this.btn_SendTopicMessage.UseVisualStyleBackColor = true;
            this.btn_SendTopicMessage.Click += new System.EventHandler(this.btn_SendTopicMessage_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.txt_FanoutQueue);
            this.panel4.Controls.Add(this.txt_FanoutExchange);
            this.panel4.Controls.Add(this.txt_FanoutRouting);
            this.panel4.Controls.Add(this.txt_FanoutMessageString);
            this.panel4.Controls.Add(this.btn_SendFanoutMessage);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 179);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(388, 170);
            this.panel4.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "Queue";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "Exchange";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "Routing";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 12);
            this.label12.TabIndex = 21;
            this.label12.Text = "Message";
            // 
            // txt_FanoutQueue
            // 
            this.txt_FanoutQueue.Location = new System.Drawing.Point(61, 99);
            this.txt_FanoutQueue.Name = "txt_FanoutQueue";
            this.txt_FanoutQueue.Size = new System.Drawing.Size(241, 21);
            this.txt_FanoutQueue.TabIndex = 14;
            // 
            // txt_FanoutExchange
            // 
            this.txt_FanoutExchange.Location = new System.Drawing.Point(61, 14);
            this.txt_FanoutExchange.Name = "txt_FanoutExchange";
            this.txt_FanoutExchange.Size = new System.Drawing.Size(241, 21);
            this.txt_FanoutExchange.TabIndex = 15;
            this.txt_FanoutExchange.Text = "user";
            // 
            // txt_FanoutRouting
            // 
            this.txt_FanoutRouting.Location = new System.Drawing.Point(61, 54);
            this.txt_FanoutRouting.Name = "txt_FanoutRouting";
            this.txt_FanoutRouting.Size = new System.Drawing.Size(241, 21);
            this.txt_FanoutRouting.TabIndex = 16;
            // 
            // txt_FanoutMessageString
            // 
            this.txt_FanoutMessageString.Location = new System.Drawing.Point(61, 136);
            this.txt_FanoutMessageString.Name = "txt_FanoutMessageString";
            this.txt_FanoutMessageString.Size = new System.Drawing.Size(241, 21);
            this.txt_FanoutMessageString.TabIndex = 17;
            this.txt_FanoutMessageString.Text = "Fanout路由队列消息";
            // 
            // btn_SendFanoutMessage
            // 
            this.btn_SendFanoutMessage.Location = new System.Drawing.Point(306, 134);
            this.btn_SendFanoutMessage.Name = "btn_SendFanoutMessage";
            this.btn_SendFanoutMessage.Size = new System.Drawing.Size(75, 23);
            this.btn_SendFanoutMessage.TabIndex = 13;
            this.btn_SendFanoutMessage.Text = "发送消息";
            this.btn_SendFanoutMessage.UseVisualStyleBackColor = true;
            this.btn_SendFanoutMessage.Click += new System.EventHandler(this.btn_SendFanoutMessage_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txt_DirectQueue);
            this.panel3.Controls.Add(this.txt_DirectExchange);
            this.panel3.Controls.Add(this.txt_DirectRouting);
            this.panel3.Controls.Add(this.txt_DirectMessageString);
            this.panel3.Controls.Add(this.btn_SendDirectMessage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 170);
            this.panel3.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "Queue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "Exchange";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "Routing";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "Message";
            // 
            // txt_DirectQueue
            // 
            this.txt_DirectQueue.Location = new System.Drawing.Point(65, 98);
            this.txt_DirectQueue.Name = "txt_DirectQueue";
            this.txt_DirectQueue.Size = new System.Drawing.Size(241, 21);
            this.txt_DirectQueue.TabIndex = 5;
            this.txt_DirectQueue.Text = "MES.MachineStatusLog.Queue";
            // 
            // txt_DirectExchange
            // 
            this.txt_DirectExchange.Location = new System.Drawing.Point(65, 13);
            this.txt_DirectExchange.Name = "txt_DirectExchange";
            this.txt_DirectExchange.Size = new System.Drawing.Size(241, 21);
            this.txt_DirectExchange.TabIndex = 6;
            this.txt_DirectExchange.Text = "MES.MachineStatusLog.Exchange";
            // 
            // txt_DirectRouting
            // 
            this.txt_DirectRouting.Location = new System.Drawing.Point(65, 53);
            this.txt_DirectRouting.Name = "txt_DirectRouting";
            this.txt_DirectRouting.Size = new System.Drawing.Size(241, 21);
            this.txt_DirectRouting.TabIndex = 7;
            this.txt_DirectRouting.Text = "MES.MachineStatusLog.Routing";
            // 
            // txt_DirectMessageString
            // 
            this.txt_DirectMessageString.Location = new System.Drawing.Point(65, 135);
            this.txt_DirectMessageString.Name = "txt_DirectMessageString";
            this.txt_DirectMessageString.Size = new System.Drawing.Size(241, 21);
            this.txt_DirectMessageString.TabIndex = 8;
            this.txt_DirectMessageString.Text = "Direct路由队列消息";
            // 
            // btn_SendDirectMessage
            // 
            this.btn_SendDirectMessage.Location = new System.Drawing.Point(310, 133);
            this.btn_SendDirectMessage.Name = "btn_SendDirectMessage";
            this.btn_SendDirectMessage.Size = new System.Drawing.Size(75, 23);
            this.btn_SendDirectMessage.TabIndex = 4;
            this.btn_SendDirectMessage.Text = "发送消息";
            this.btn_SendDirectMessage.UseVisualStyleBackColor = true;
            this.btn_SendDirectMessage.Click += new System.EventHandler(this.btn_SendDirectMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "RabbitMQ服务端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_RabbitMQHostName;
        private System.Windows.Forms.TextBox txt_RabbitMQPort;
        private System.Windows.Forms.TextBox txt_RabbitMQPassword;
        private System.Windows.Forms.TextBox txt_RabbitMQUserName;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox txt_LogText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DirectQueue;
        private System.Windows.Forms.TextBox txt_DirectExchange;
        private System.Windows.Forms.TextBox txt_DirectRouting;
        private System.Windows.Forms.TextBox txt_DirectMessageString;
        private System.Windows.Forms.Button btn_SendDirectMessage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_TopicQueue;
        private System.Windows.Forms.TextBox txt_TopicExchange;
        private System.Windows.Forms.TextBox txt_TopicRouting;
        private System.Windows.Forms.TextBox txt_TopicMessageString;
        private System.Windows.Forms.Button btn_SendTopicMessage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_FanoutQueue;
        private System.Windows.Forms.TextBox txt_FanoutExchange;
        private System.Windows.Forms.TextBox txt_FanoutRouting;
        private System.Windows.Forms.TextBox txt_FanoutMessageString;
        private System.Windows.Forms.Button btn_SendFanoutMessage;
    }
}

