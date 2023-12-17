namespace SmartHomeClientv2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGetAllDevices = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonGetDeviceById = new System.Windows.Forms.Button();
            this.textBoxDeviceId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonSaveDevice = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxUpdateId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxUpdateStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxUpdateType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxUpdateName = new System.Windows.Forms.TextBox();
            this.buttonUpdateDevice = new System.Windows.Forms.Button();
            this.textBoxDeleteDeviceId = new System.Windows.Forms.TextBox();
            this.buttonDeleteDeviceById = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGetAllDevices
            // 
            this.buttonGetAllDevices.Location = new System.Drawing.Point(42, 42);
            this.buttonGetAllDevices.Name = "buttonGetAllDevices";
            this.buttonGetAllDevices.Size = new System.Drawing.Size(340, 20);
            this.buttonGetAllDevices.TabIndex = 0;
            this.buttonGetAllDevices.Text = "Get all devices";
            this.buttonGetAllDevices.UseVisualStyleBackColor = true;
            this.buttonGetAllDevices.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(422, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(366, 696);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // buttonGetDeviceById
            // 
            this.buttonGetDeviceById.Location = new System.Drawing.Point(42, 81);
            this.buttonGetDeviceById.Name = "buttonGetDeviceById";
            this.buttonGetDeviceById.Size = new System.Drawing.Size(228, 20);
            this.buttonGetDeviceById.TabIndex = 2;
            this.buttonGetDeviceById.Text = "Get device by id: ";
            this.buttonGetDeviceById.UseVisualStyleBackColor = true;
            this.buttonGetDeviceById.Click += new System.EventHandler(this.buttonGetDevice_Click);
            // 
            // textBoxDeviceId
            // 
            this.textBoxDeviceId.Location = new System.Drawing.Point(276, 82);
            this.textBoxDeviceId.Name = "textBoxDeviceId";
            this.textBoxDeviceId.Size = new System.Drawing.Size(105, 20);
            this.textBoxDeviceId.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxStatus);
            this.groupBox1.Controls.Add(this.comboBoxType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.buttonSaveDevice);
            this.groupBox1.Location = new System.Drawing.Point(44, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 208);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create device";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(152, 114);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(178, 21);
            this.comboBoxStatus.TabIndex = 12;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(152, 44);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(178, 21);
            this.comboBoxType.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Device status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Device name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Device type";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(152, 80);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(178, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // buttonSaveDevice
            // 
            this.buttonSaveDevice.Location = new System.Drawing.Point(52, 165);
            this.buttonSaveDevice.Name = "buttonSaveDevice";
            this.buttonSaveDevice.Size = new System.Drawing.Size(228, 20);
            this.buttonSaveDevice.TabIndex = 5;
            this.buttonSaveDevice.Text = "Save device";
            this.buttonSaveDevice.UseVisualStyleBackColor = true;
            this.buttonSaveDevice.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(292, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Smart home device";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxUpdateId);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboBoxUpdateStatus);
            this.groupBox2.Controls.Add(this.comboBoxUpdateType);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxUpdateName);
            this.groupBox2.Controls.Add(this.buttonUpdateDevice);
            this.groupBox2.Location = new System.Drawing.Point(44, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 208);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update device";
            // 
            // textBoxUpdateId
            // 
            this.textBoxUpdateId.Location = new System.Drawing.Point(152, 25);
            this.textBoxUpdateId.Name = "textBoxUpdateId";
            this.textBoxUpdateId.Size = new System.Drawing.Size(178, 20);
            this.textBoxUpdateId.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Device id";
            // 
            // comboBoxUpdateStatus
            // 
            this.comboBoxUpdateStatus.FormattingEnabled = true;
            this.comboBoxUpdateStatus.Location = new System.Drawing.Point(152, 128);
            this.comboBoxUpdateStatus.Name = "comboBoxUpdateStatus";
            this.comboBoxUpdateStatus.Size = new System.Drawing.Size(178, 21);
            this.comboBoxUpdateStatus.TabIndex = 12;
            // 
            // comboBoxUpdateType
            // 
            this.comboBoxUpdateType.FormattingEnabled = true;
            this.comboBoxUpdateType.Location = new System.Drawing.Point(152, 58);
            this.comboBoxUpdateType.Name = "comboBoxUpdateType";
            this.comboBoxUpdateType.Size = new System.Drawing.Size(178, 21);
            this.comboBoxUpdateType.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Device status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Device name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Device type";
            // 
            // textBoxUpdateName
            // 
            this.textBoxUpdateName.Location = new System.Drawing.Point(152, 94);
            this.textBoxUpdateName.Name = "textBoxUpdateName";
            this.textBoxUpdateName.Size = new System.Drawing.Size(178, 20);
            this.textBoxUpdateName.TabIndex = 6;
            // 
            // buttonUpdateDevice
            // 
            this.buttonUpdateDevice.Location = new System.Drawing.Point(52, 165);
            this.buttonUpdateDevice.Name = "buttonUpdateDevice";
            this.buttonUpdateDevice.Size = new System.Drawing.Size(228, 20);
            this.buttonUpdateDevice.TabIndex = 5;
            this.buttonUpdateDevice.Text = "Update device";
            this.buttonUpdateDevice.UseVisualStyleBackColor = true;
            this.buttonUpdateDevice.Click += new System.EventHandler(this.buttonUpdateDevice_Click);
            // 
            // textBoxDeleteDeviceId
            // 
            this.textBoxDeleteDeviceId.ForeColor = System.Drawing.Color.Black;
            this.textBoxDeleteDeviceId.Location = new System.Drawing.Point(275, 609);
            this.textBoxDeleteDeviceId.Name = "textBoxDeleteDeviceId";
            this.textBoxDeleteDeviceId.Size = new System.Drawing.Size(105, 20);
            this.textBoxDeleteDeviceId.TabIndex = 15;
            // 
            // buttonDeleteDeviceById
            // 
            this.buttonDeleteDeviceById.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDeleteDeviceById.ForeColor = System.Drawing.Color.Black;
            this.buttonDeleteDeviceById.Location = new System.Drawing.Point(44, 600);
            this.buttonDeleteDeviceById.Name = "buttonDeleteDeviceById";
            this.buttonDeleteDeviceById.Size = new System.Drawing.Size(228, 36);
            this.buttonDeleteDeviceById.TabIndex = 14;
            this.buttonDeleteDeviceById.Text = "DELETE device by id: ";
            this.buttonDeleteDeviceById.UseVisualStyleBackColor = false;
            this.buttonDeleteDeviceById.Click += new System.EventHandler(this.buttonDeleteDevice_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 750);
            this.Controls.Add(this.textBoxDeleteDeviceId);
            this.Controls.Add(this.buttonDeleteDeviceById);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxDeviceId);
            this.Controls.Add(this.buttonGetDeviceById);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonGetAllDevices);
            this.Name = "Form2";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetAllDevices;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonGetDeviceById;
        private System.Windows.Forms.TextBox textBoxDeviceId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonSaveDevice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxUpdateId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxUpdateStatus;
        private System.Windows.Forms.ComboBox comboBoxUpdateType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxUpdateName;
        private System.Windows.Forms.Button buttonUpdateDevice;
        private System.Windows.Forms.TextBox textBoxDeleteDeviceId;
        private System.Windows.Forms.Button buttonDeleteDeviceById;
    }
}