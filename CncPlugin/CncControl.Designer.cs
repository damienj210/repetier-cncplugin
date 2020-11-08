namespace CncPlugin
{
    partial class CncControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        
        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CncControl));
            this.button1 = new System.Windows.Forms.Button();
            this.txtProbeMeasurment = new System.Windows.Forms.TextBox();
            this.btn_probe_read = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_set_probe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_step_3 = new System.Windows.Forms.Button();
            this.btn_step_5 = new System.Windows.Forms.Button();
            this.btn_step_4 = new System.Windows.Forms.Button();
            this.btn_step_1 = new System.Windows.Forms.Button();
            this.btn_step_2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_z_minus = new System.Windows.Forms.Button();
            this.btn_z_plus = new System.Windows.Forms.Button();
            this.btn_x_minus = new System.Windows.Forms.Button();
            this.btn_x_plus = new System.Windows.Forms.Button();
            this.btn_y_minus = new System.Windows.Forms.Button();
            this.btn_y_plus = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_spindle = new System.Windows.Forms.Button();
            this.slide_spindlespeed = new System.Windows.Forms.TrackBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblPosZ = new System.Windows.Forms.Label();
            this.lblPosY = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPosX = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_send_manual_command = new System.Windows.Forms.Button();
            this.txt_manual_command = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.txt_g92_x = new System.Windows.Forms.TextBox();
            this.txt_g92_y = new System.Windows.Forms.TextBox();
            this.txt_g92_z = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.txt_g0_z = new System.Windows.Forms.TextBox();
            this.txt_g0_y = new System.Windows.Forms.TextBox();
            this.txt_g0_x = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblReleaseMessage = new System.Windows.Forms.Label();
            this.lnkConnectDisconnect = new System.Windows.Forms.LinkLabel();
            this.lnkPreferences = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slide_spindlespeed)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "Probe";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_probe);
            // 
            // txtProbeMeasurment
            // 
            this.txtProbeMeasurment.Location = new System.Drawing.Point(136, 31);
            this.txtProbeMeasurment.Margin = new System.Windows.Forms.Padding(4);
            this.txtProbeMeasurment.Name = "txtProbeMeasurment";
            this.txtProbeMeasurment.Size = new System.Drawing.Size(80, 22);
            this.txtProbeMeasurment.TabIndex = 11;
            this.txtProbeMeasurment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_probe_read
            // 
            this.btn_probe_read.Location = new System.Drawing.Point(400, 31);
            this.btn_probe_read.Margin = new System.Windows.Forms.Padding(4);
            this.btn_probe_read.Name = "btn_probe_read";
            this.btn_probe_read.Size = new System.Drawing.Size(123, 25);
            this.btn_probe_read.TabIndex = 13;
            this.btn_probe_read.Text = "Read";
            this.btn_probe_read.UseMnemonic = false;
            this.btn_probe_read.UseVisualStyleBackColor = true;
            this.btn_probe_read.Click += new System.EventHandler(this.btn_probe_read_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_set_probe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtProbeMeasurment);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btn_probe_read);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(12, 369);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(544, 87);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Z-Probe";
            // 
            // btn_set_probe
            // 
            this.btn_set_probe.Location = new System.Drawing.Point(272, 31);
            this.btn_set_probe.Margin = new System.Windows.Forms.Padding(4);
            this.btn_set_probe.Name = "btn_set_probe";
            this.btn_set_probe.Size = new System.Drawing.Size(120, 25);
            this.btn_set_probe.TabIndex = 12;
            this.btn_set_probe.Text = "Set ref";
            this.btn_set_probe.UseVisualStyleBackColor = true;
            this.btn_set_probe.Click += new System.EventHandler(this.btn_set_probe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "mm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.SkyBlue;
            this.label12.Location = new System.Drawing.Point(61, 59);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "G30";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.SkyBlue;
            this.label11.Location = new System.Drawing.Point(301, 59);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "G92 Z[n]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.SkyBlue;
            this.label10.Location = new System.Drawing.Point(440, 59);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "G31";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_step_3);
            this.groupBox2.Controls.Add(this.btn_step_5);
            this.groupBox2.Controls.Add(this.btn_step_4);
            this.groupBox2.Controls.Add(this.btn_step_1);
            this.groupBox2.Controls.Add(this.btn_step_2);
            this.groupBox2.Location = new System.Drawing.Point(388, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(165, 355);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Distance";
            // 
            // btn_step_3
            // 
            this.btn_step_3.BackColor = System.Drawing.SystemColors.Control;
            this.btn_step_3.Location = new System.Drawing.Point(16, 214);
            this.btn_step_3.Margin = new System.Windows.Forms.Padding(4);
            this.btn_step_3.Name = "btn_step_3";
            this.btn_step_3.Size = new System.Drawing.Size(131, 38);
            this.btn_step_3.TabIndex = 8;
            this.btn_step_3.UseVisualStyleBackColor = false;
            this.btn_step_3.Click += new System.EventHandler(this.btn_step_3_Click);
            // 
            // btn_step_5
            // 
            this.btn_step_5.BackColor = System.Drawing.SystemColors.Control;
            this.btn_step_5.Location = new System.Drawing.Point(16, 37);
            this.btn_step_5.Margin = new System.Windows.Forms.Padding(4);
            this.btn_step_5.Name = "btn_step_5";
            this.btn_step_5.Size = new System.Drawing.Size(131, 38);
            this.btn_step_5.TabIndex = 9;
            this.btn_step_5.UseVisualStyleBackColor = false;
            this.btn_step_5.Click += new System.EventHandler(this.btn_step5_Click);
            // 
            // btn_step_4
            // 
            this.btn_step_4.Location = new System.Drawing.Point(16, 273);
            this.btn_step_4.Margin = new System.Windows.Forms.Padding(4);
            this.btn_step_4.Name = "btn_step_4";
            this.btn_step_4.Size = new System.Drawing.Size(131, 38);
            this.btn_step_4.TabIndex = 9;
            this.btn_step_4.UseVisualStyleBackColor = true;
            this.btn_step_4.Click += new System.EventHandler(this.btn_step4_Click);
            // 
            // btn_step_1
            // 
            this.btn_step_1.BackColor = System.Drawing.SystemColors.Control;
            this.btn_step_1.Location = new System.Drawing.Point(16, 96);
            this.btn_step_1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_step_1.Name = "btn_step_1";
            this.btn_step_1.Size = new System.Drawing.Size(131, 38);
            this.btn_step_1.TabIndex = 6;
            this.btn_step_1.UseVisualStyleBackColor = false;
            this.btn_step_1.Click += new System.EventHandler(this.btn_step_1_Click);
            // 
            // btn_step_2
            // 
            this.btn_step_2.BackColor = System.Drawing.SystemColors.Control;
            this.btn_step_2.Location = new System.Drawing.Point(16, 155);
            this.btn_step_2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_step_2.Name = "btn_step_2";
            this.btn_step_2.Size = new System.Drawing.Size(131, 38);
            this.btn_step_2.TabIndex = 7;
            this.btn_step_2.UseVisualStyleBackColor = false;
            this.btn_step_2.Click += new System.EventHandler(this.btn_step_2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_z_minus);
            this.groupBox3.Controls.Add(this.btn_z_plus);
            this.groupBox3.Controls.Add(this.btn_x_minus);
            this.groupBox3.Controls.Add(this.btn_x_plus);
            this.groupBox3.Controls.Add(this.btn_y_minus);
            this.groupBox3.Controls.Add(this.btn_y_plus);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(9, 43);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(360, 267);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Jog";
            // 
            // btn_z_minus
            // 
            this.btn_z_minus.Location = new System.Drawing.Point(273, 156);
            this.btn_z_minus.Margin = new System.Windows.Forms.Padding(4);
            this.btn_z_minus.Name = "btn_z_minus";
            this.btn_z_minus.Size = new System.Drawing.Size(45, 42);
            this.btn_z_minus.TabIndex = 5;
            this.btn_z_minus.Text = "-Z";
            this.btn_z_minus.UseVisualStyleBackColor = true;
            this.btn_z_minus.Click += new System.EventHandler(this.btn_z_minus_Click);
            // 
            // btn_z_plus
            // 
            this.btn_z_plus.Location = new System.Drawing.Point(273, 81);
            this.btn_z_plus.Margin = new System.Windows.Forms.Padding(4);
            this.btn_z_plus.Name = "btn_z_plus";
            this.btn_z_plus.Size = new System.Drawing.Size(45, 42);
            this.btn_z_plus.TabIndex = 4;
            this.btn_z_plus.Text = "+Z";
            this.btn_z_plus.UseVisualStyleBackColor = true;
            this.btn_z_plus.Click += new System.EventHandler(this.btn_z_plus_Click);
            // 
            // btn_x_minus
            // 
            this.btn_x_minus.Location = new System.Drawing.Point(60, 119);
            this.btn_x_minus.Margin = new System.Windows.Forms.Padding(4);
            this.btn_x_minus.Name = "btn_x_minus";
            this.btn_x_minus.Size = new System.Drawing.Size(45, 42);
            this.btn_x_minus.TabIndex = 0;
            this.btn_x_minus.Text = "-X";
            this.btn_x_minus.UseVisualStyleBackColor = true;
            this.btn_x_minus.Click += new System.EventHandler(this.btn_x_minus_Click);
            // 
            // btn_x_plus
            // 
            this.btn_x_plus.Location = new System.Drawing.Point(167, 119);
            this.btn_x_plus.Margin = new System.Windows.Forms.Padding(4);
            this.btn_x_plus.Name = "btn_x_plus";
            this.btn_x_plus.Size = new System.Drawing.Size(45, 42);
            this.btn_x_plus.TabIndex = 3;
            this.btn_x_plus.Text = "+X";
            this.btn_x_plus.UseVisualStyleBackColor = true;
            this.btn_x_plus.Click += new System.EventHandler(this.btn_x_plus_Click);
            // 
            // btn_y_minus
            // 
            this.btn_y_minus.Location = new System.Drawing.Point(113, 166);
            this.btn_y_minus.Margin = new System.Windows.Forms.Padding(4);
            this.btn_y_minus.Name = "btn_y_minus";
            this.btn_y_minus.Size = new System.Drawing.Size(45, 42);
            this.btn_y_minus.TabIndex = 2;
            this.btn_y_minus.Text = "-Y";
            this.btn_y_minus.UseVisualStyleBackColor = true;
            this.btn_y_minus.Click += new System.EventHandler(this.btn_y_minus_Click);
            // 
            // btn_y_plus
            // 
            this.btn_y_plus.Location = new System.Drawing.Point(113, 68);
            this.btn_y_plus.Margin = new System.Windows.Forms.Padding(4);
            this.btn_y_plus.Name = "btn_y_plus";
            this.btn_y_plus.Size = new System.Drawing.Size(45, 42);
            this.btn_y_plus.TabIndex = 1;
            this.btn_y_plus.Text = "+Y";
            this.btn_y_plus.UseVisualStyleBackColor = true;
            this.btn_y_plus.Click += new System.EventHandler(this.btn_y_plus_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 246);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.btn_spindle);
            this.groupBox4.Controls.Add(this.slide_spindlespeed);
            this.groupBox4.Location = new System.Drawing.Point(12, 462);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(544, 102);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Spindle";
            this.groupBox4.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(487, 66);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 17);
            this.label14.TabIndex = 19;
            this.label14.Text = "max";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(319, 66);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 17);
            this.label15.TabIndex = 19;
            this.label15.Text = "RPM";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(169, 66);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 17);
            this.label13.TabIndex = 19;
            this.label13.Text = "min";
            // 
            // btn_spindle
            // 
            this.btn_spindle.ForeColor = System.Drawing.Color.White;
            this.btn_spindle.Location = new System.Drawing.Point(20, 32);
            this.btn_spindle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_spindle.Name = "btn_spindle";
            this.btn_spindle.Size = new System.Drawing.Size(123, 53);
            this.btn_spindle.TabIndex = 14;
            this.btn_spindle.UseMnemonic = false;
            this.btn_spindle.UseVisualStyleBackColor = true;
            this.btn_spindle.Click += new System.EventHandler(this.btn_spindle_click);
            // 
            // slide_spindlespeed
            // 
            this.slide_spindlespeed.Location = new System.Drawing.Point(167, 27);
            this.slide_spindlespeed.Margin = new System.Windows.Forms.Padding(4);
            this.slide_spindlespeed.Maximum = 255;
            this.slide_spindlespeed.Name = "slide_spindlespeed";
            this.slide_spindlespeed.Size = new System.Drawing.Size(356, 56);
            this.slide_spindlespeed.TabIndex = 15;
            this.slide_spindlespeed.TickFrequency = 16;
            this.slide_spindlespeed.Value = 128;
            this.slide_spindlespeed.ValueChanged += new System.EventHandler(this.spindle_speed_change);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblPosZ);
            this.groupBox5.Controls.Add(this.lblPosY);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.lblPosX);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.btn_send_manual_command);
            this.groupBox5.Controls.Add(this.txt_manual_command);
            this.groupBox5.Controls.Add(this.button11);
            this.groupBox5.Controls.Add(this.txt_g92_x);
            this.groupBox5.Controls.Add(this.txt_g92_y);
            this.groupBox5.Controls.Add(this.txt_g92_z);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.button10);
            this.groupBox5.Controls.Add(this.txt_g0_z);
            this.groupBox5.Controls.Add(this.txt_g0_y);
            this.groupBox5.Controls.Add(this.txt_g0_x);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(561, 6);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(544, 148);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "G Code";
            // 
            // lblPosZ
            // 
            this.lblPosZ.ForeColor = System.Drawing.Color.Green;
            this.lblPosZ.Location = new System.Drawing.Point(244, 26);
            this.lblPosZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosZ.Name = "lblPosZ";
            this.lblPosZ.Size = new System.Drawing.Size(69, 16);
            this.lblPosZ.TabIndex = 23;
            this.lblPosZ.Text = "-";
            this.lblPosZ.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPosY
            // 
            this.lblPosY.ForeColor = System.Drawing.Color.Green;
            this.lblPosY.Location = new System.Drawing.Point(145, 26);
            this.lblPosY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosY.Name = "lblPosY";
            this.lblPosY.Size = new System.Drawing.Size(69, 16);
            this.lblPosY.TabIndex = 23;
            this.lblPosY.Text = "-";
            this.lblPosY.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Z";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Y";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPosX
            // 
            this.lblPosX.ForeColor = System.Drawing.Color.Green;
            this.lblPosX.Location = new System.Drawing.Point(47, 26);
            this.lblPosX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosX.Name = "lblPosX";
            this.lblPosX.Size = new System.Drawing.Size(69, 16);
            this.lblPosX.TabIndex = 23;
            this.lblPosX.Text = "-";
            this.lblPosX.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "X";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_send_manual_command
            // 
            this.btn_send_manual_command.Location = new System.Drawing.Point(332, 108);
            this.btn_send_manual_command.Margin = new System.Windows.Forms.Padding(4);
            this.btn_send_manual_command.Name = "btn_send_manual_command";
            this.btn_send_manual_command.Size = new System.Drawing.Size(100, 28);
            this.btn_send_manual_command.TabIndex = 25;
            this.btn_send_manual_command.Text = "Send";
            this.btn_send_manual_command.UseVisualStyleBackColor = true;
            this.btn_send_manual_command.Click += new System.EventHandler(this.btnSendManual);
            // 
            // txt_manual_command
            // 
            this.txt_manual_command.Location = new System.Drawing.Point(47, 111);
            this.txt_manual_command.Margin = new System.Windows.Forms.Padding(4);
            this.txt_manual_command.Name = "txt_manual_command";
            this.txt_manual_command.Size = new System.Drawing.Size(265, 22);
            this.txt_manual_command.TabIndex = 24;
            this.txt_manual_command.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Command_KeyPress);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(332, 76);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 28);
            this.button11.TabIndex = 23;
            this.button11.Text = "Set ref";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.btnSendG92);
            // 
            // txt_g92_x
            // 
            this.txt_g92_x.Location = new System.Drawing.Point(47, 80);
            this.txt_g92_x.Margin = new System.Windows.Forms.Padding(4);
            this.txt_g92_x.Name = "txt_g92_x";
            this.txt_g92_x.Size = new System.Drawing.Size(68, 22);
            this.txt_g92_x.TabIndex = 20;
            this.txt_g92_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_g92_y
            // 
            this.txt_g92_y.Location = new System.Drawing.Point(145, 79);
            this.txt_g92_y.Margin = new System.Windows.Forms.Padding(4);
            this.txt_g92_y.Name = "txt_g92_y";
            this.txt_g92_y.Size = new System.Drawing.Size(68, 22);
            this.txt_g92_y.TabIndex = 21;
            this.txt_g92_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_g92_z
            // 
            this.txt_g92_z.Location = new System.Drawing.Point(244, 79);
            this.txt_g92_z.Margin = new System.Windows.Forms.Padding(4);
            this.txt_g92_z.Name = "txt_g92_z";
            this.txt_g92_z.Size = new System.Drawing.Size(68, 22);
            this.txt_g92_z.TabIndex = 22;
            this.txt_g92_z.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.SkyBlue;
            this.label3.Location = new System.Drawing.Point(440, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "G92";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(332, 43);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 28);
            this.button10.TabIndex = 19;
            this.button10.Text = "Move";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btnSendG1);
            // 
            // txt_g0_z
            // 
            this.txt_g0_z.Location = new System.Drawing.Point(244, 46);
            this.txt_g0_z.Margin = new System.Windows.Forms.Padding(4);
            this.txt_g0_z.Name = "txt_g0_z";
            this.txt_g0_z.Size = new System.Drawing.Size(68, 22);
            this.txt_g0_z.TabIndex = 18;
            this.txt_g0_z.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_g0_y
            // 
            this.txt_g0_y.Location = new System.Drawing.Point(145, 46);
            this.txt_g0_y.Margin = new System.Windows.Forms.Padding(4);
            this.txt_g0_y.Name = "txt_g0_y";
            this.txt_g0_y.Size = new System.Drawing.Size(68, 22);
            this.txt_g0_y.TabIndex = 17;
            this.txt_g0_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_g0_x
            // 
            this.txt_g0_x.Location = new System.Drawing.Point(47, 46);
            this.txt_g0_x.Margin = new System.Windows.Forms.Padding(4);
            this.txt_g0_x.Name = "txt_g0_x";
            this.txt_g0_x.Size = new System.Drawing.Size(68, 22);
            this.txt_g0_x.TabIndex = 16;
            this.txt_g0_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Z";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Y";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "X";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SkyBlue;
            this.label2.Location = new System.Drawing.Point(440, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "G1";
            // 
            // lblReleaseMessage
            // 
            this.lblReleaseMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReleaseMessage.Enabled = false;
            this.lblReleaseMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblReleaseMessage.ForeColor = System.Drawing.Color.Silver;
            this.lblReleaseMessage.Location = new System.Drawing.Point(1045, 676);
            this.lblReleaseMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReleaseMessage.Name = "lblReleaseMessage";
            this.lblReleaseMessage.Size = new System.Drawing.Size(36, 28);
            this.lblReleaseMessage.TabIndex = 19;
            this.lblReleaseMessage.Text = "release";
            this.lblReleaseMessage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblReleaseMessage.Visible = false;
            // 
            // lnkConnectDisconnect
            // 
            this.lnkConnectDisconnect.AutoSize = true;
            this.lnkConnectDisconnect.Location = new System.Drawing.Point(5, 6);
            this.lnkConnectDisconnect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkConnectDisconnect.Name = "lnkConnectDisconnect";
            this.lnkConnectDisconnect.Size = new System.Drawing.Size(60, 17);
            this.lnkConnectDisconnect.TabIndex = 21;
            this.lnkConnectDisconnect.TabStop = true;
            this.lnkConnectDisconnect.Text = "Connect";
            this.lnkConnectDisconnect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lnkPreferences
            // 
            this.lnkPreferences.AutoSize = true;
            this.lnkPreferences.Location = new System.Drawing.Point(95, 6);
            this.lnkPreferences.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkPreferences.Name = "lnkPreferences";
            this.lnkPreferences.Size = new System.Drawing.Size(85, 17);
            this.lnkPreferences.TabIndex = 22;
            this.lnkPreferences.TabStop = true;
            this.lnkPreferences.Text = "Preferences";
            this.lnkPreferences.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // CncControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lnkPreferences);
            this.Controls.Add(this.lnkConnectDisconnect);
            this.Controls.Add(this.lblReleaseMessage);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CncControl";
            this.Size = new System.Drawing.Size(1129, 724);
            this.Load += new System.EventHandler(this.CoolControl_Load);
            this.VisibleChanged += new System.EventHandler(this.VisibleChange);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slide_spindlespeed)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtProbeMeasurment;
        private System.Windows.Forms.Button btn_probe_read;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_step_4;
        private System.Windows.Forms.Button btn_step_1;
        private System.Windows.Forms.Button btn_step_2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_z_minus;
        private System.Windows.Forms.Button btn_z_plus;
        private System.Windows.Forms.Button btn_x_minus;
        private System.Windows.Forms.Button btn_x_plus;
        private System.Windows.Forms.Button btn_y_minus;
        private System.Windows.Forms.Button btn_y_plus;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_spindle;
        private System.Windows.Forms.TrackBar slide_spindlespeed;
        private System.Windows.Forms.Button btn_step_3;
        private System.Windows.Forms.Button btn_set_probe;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox txt_g92_x;
        private System.Windows.Forms.TextBox txt_g92_y;
        private System.Windows.Forms.TextBox txt_g92_z;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox txt_g0_z;
        private System.Windows.Forms.TextBox txt_g0_y;
        private System.Windows.Forms.TextBox txt_g0_x;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_send_manual_command;
        private System.Windows.Forms.TextBox txt_manual_command;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReleaseMessage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel lnkConnectDisconnect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lnkPreferences;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPosZ;
        private System.Windows.Forms.Label lblPosY;
        private System.Windows.Forms.Label lblPosX;
        private System.Windows.Forms.Button btn_step_5;
    }
}
