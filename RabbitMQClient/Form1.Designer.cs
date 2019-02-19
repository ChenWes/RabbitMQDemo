namespace RabbitMQClient
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
            this.txt_LogText = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_ReceivedDirect = new System.Windows.Forms.Button();
            this.btn_ReceviedFanout = new System.Windows.Forms.Button();
            this.btn_ReceviedTopic = new System.Windows.Forms.Button();
            this.txt_DirectQueueName = new System.Windows.Forms.TextBox();
            this.txt_FanoutQueueName = new System.Windows.Forms.TextBox();
            this.txt_TopicQueueName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            this.panel1.TabIndex = 1;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 536);
            this.panel2.TabIndex = 2;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_DirectQueueName);
            this.panel3.Controls.Add(this.btn_ReceivedDirect);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 170);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt_FanoutQueueName);
            this.panel4.Controls.Add(this.btn_ReceviedFanout);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 179);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(388, 170);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txt_TopicQueueName);
            this.panel5.Controls.Add(this.btn_ReceviedTopic);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 355);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(388, 172);
            this.panel5.TabIndex = 2;
            // 
            // btn_ReceivedDirect
            // 
            this.btn_ReceivedDirect.Location = new System.Drawing.Point(282, 76);
            this.btn_ReceivedDirect.Name = "btn_ReceivedDirect";
            this.btn_ReceivedDirect.Size = new System.Drawing.Size(75, 23);
            this.btn_ReceivedDirect.TabIndex = 0;
            this.btn_ReceivedDirect.Text = "监听";
            this.btn_ReceivedDirect.UseVisualStyleBackColor = true;
            this.btn_ReceivedDirect.Click += new System.EventHandler(this.btn_ReceivedDirect_Click);
            // 
            // btn_ReceviedFanout
            // 
            this.btn_ReceviedFanout.Location = new System.Drawing.Point(282, 87);
            this.btn_ReceviedFanout.Name = "btn_ReceviedFanout";
            this.btn_ReceviedFanout.Size = new System.Drawing.Size(75, 23);
            this.btn_ReceviedFanout.TabIndex = 0;
            this.btn_ReceviedFanout.Text = "监听";
            this.btn_ReceviedFanout.UseVisualStyleBackColor = true;
            this.btn_ReceviedFanout.Click += new System.EventHandler(this.btn_ReceviedFanout_Click);
            // 
            // btn_ReceviedTopic
            // 
            this.btn_ReceviedTopic.Location = new System.Drawing.Point(282, 71);
            this.btn_ReceviedTopic.Name = "btn_ReceviedTopic";
            this.btn_ReceviedTopic.Size = new System.Drawing.Size(75, 23);
            this.btn_ReceviedTopic.TabIndex = 0;
            this.btn_ReceviedTopic.Text = "监听";
            this.btn_ReceviedTopic.UseVisualStyleBackColor = true;
            this.btn_ReceviedTopic.Click += new System.EventHandler(this.btn_ReceviedTopic_Click);
            // 
            // txt_DirectQueueName
            // 
            this.txt_DirectQueueName.Location = new System.Drawing.Point(124, 78);
            this.txt_DirectQueueName.Name = "txt_DirectQueueName";
            this.txt_DirectQueueName.Size = new System.Drawing.Size(152, 21);
            this.txt_DirectQueueName.TabIndex = 1;
            // 
            // txt_FanoutQueueName
            // 
            this.txt_FanoutQueueName.Location = new System.Drawing.Point(124, 87);
            this.txt_FanoutQueueName.Name = "txt_FanoutQueueName";
            this.txt_FanoutQueueName.Size = new System.Drawing.Size(152, 21);
            this.txt_FanoutQueueName.TabIndex = 1;
            // 
            // txt_TopicQueueName
            // 
            this.txt_TopicQueueName.Location = new System.Drawing.Point(124, 71);
            this.txt_TopicQueueName.Name = "txt_TopicQueueName";
            this.txt_TopicQueueName.Size = new System.Drawing.Size(152, 21);
            this.txt_TopicQueueName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "QueueName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "QueueName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "QueueName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "RabbitMQ客户端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.TextBox txt_RabbitMQPassword;
        private System.Windows.Forms.TextBox txt_RabbitMQUserName;
        private System.Windows.Forms.TextBox txt_RabbitMQPort;
        private System.Windows.Forms.TextBox txt_RabbitMQHostName;
        private System.Windows.Forms.RichTextBox txt_LogText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_ReceviedTopic;
        private System.Windows.Forms.Button btn_ReceviedFanout;
        private System.Windows.Forms.Button btn_ReceivedDirect;
        private System.Windows.Forms.TextBox txt_TopicQueueName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_FanoutQueueName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_DirectQueueName;
        private System.Windows.Forms.Label label5;
    }
}

