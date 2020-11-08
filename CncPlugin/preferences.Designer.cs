namespace CncPlugin
{
    partial class preferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(preferences));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_unit_inch = new System.Windows.Forms.RadioButton();
            this.rb_unit_mm = new System.Windows.Forms.RadioButton();
            this.txt_step_4 = new System.Windows.Forms.TextBox();
            this.txt_step_3 = new System.Windows.Forms.TextBox();
            this.step_size = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_step1_key = new System.Windows.Forms.TextBox();
            this.txt_step2_key = new System.Windows.Forms.TextBox();
            this.txt_step3_key = new System.Windows.Forms.TextBox();
            this.txt_step5_key = new System.Windows.Forms.TextBox();
            this.txt_step4_key = new System.Windows.Forms.TextBox();
            this.txt_step_1 = new System.Windows.Forms.TextBox();
            this.txt_step_2 = new System.Windows.Forms.TextBox();
            this.txt_step_5 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_jog_z_plus = new System.Windows.Forms.TextBox();
            this.txt_jog_z_minus = new System.Windows.Forms.TextBox();
            this.txt_jog_y_minus = new System.Windows.Forms.TextBox();
            this.txt_jog_x_plus = new System.Windows.Forms.TextBox();
            this.txt_jog_x_minus = new System.Windows.Forms.TextBox();
            this.txt_jog_y_plus = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_spindle_pwm = new System.Windows.Forms.TextBox();
            this.txt_spindle_stop = new System.Windows.Forms.TextBox();
            this.txt_spindle_start = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupWindows = new System.Windows.Forms.GroupBox();
            this.cb_globalkeys = new System.Windows.Forms.CheckBox();
            this.cb_EnSpindle = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.step_size.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupWindows.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(899, 469);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 28);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(899, 427);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 28);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_unit_inch);
            this.groupBox1.Controls.Add(this.rb_unit_mm);
            this.groupBox1.Location = new System.Drawing.Point(393, 258);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(208, 65);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit";
            // 
            // rb_unit_inch
            // 
            this.rb_unit_inch.AutoSize = true;
            this.rb_unit_inch.Location = new System.Drawing.Point(105, 31);
            this.rb_unit_inch.Margin = new System.Windows.Forms.Padding(4);
            this.rb_unit_inch.Name = "rb_unit_inch";
            this.rb_unit_inch.Size = new System.Drawing.Size(55, 21);
            this.rb_unit_inch.TabIndex = 15;
            this.rb_unit_inch.Text = "inch";
            this.rb_unit_inch.UseVisualStyleBackColor = true;
            // 
            // rb_unit_mm
            // 
            this.rb_unit_mm.AutoSize = true;
            this.rb_unit_mm.Checked = true;
            this.rb_unit_mm.Location = new System.Drawing.Point(33, 31);
            this.rb_unit_mm.Margin = new System.Windows.Forms.Padding(4);
            this.rb_unit_mm.Name = "rb_unit_mm";
            this.rb_unit_mm.Size = new System.Drawing.Size(51, 21);
            this.rb_unit_mm.TabIndex = 14;
            this.rb_unit_mm.TabStop = true;
            this.rb_unit_mm.Text = "mm";
            this.rb_unit_mm.UseVisualStyleBackColor = true;
            // 
            // txt_step_4
            // 
            this.txt_step_4.Location = new System.Drawing.Point(26, 199);
            this.txt_step_4.Margin = new System.Windows.Forms.Padding(4);
            this.txt_step_4.Name = "txt_step_4";
            this.txt_step_4.Size = new System.Drawing.Size(56, 22);
            this.txt_step_4.TabIndex = 9;
            this.txt_step_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_step_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumericalData);
            // 
            // txt_step_3
            // 
            this.txt_step_3.Location = new System.Drawing.Point(26, 163);
            this.txt_step_3.Margin = new System.Windows.Forms.Padding(4);
            this.txt_step_3.Name = "txt_step_3";
            this.txt_step_3.Size = new System.Drawing.Size(56, 22);
            this.txt_step_3.TabIndex = 8;
            this.txt_step_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_step_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumericalData);
            // 
            // step_size
            // 
            this.step_size.Controls.Add(this.label6);
            this.step_size.Controls.Add(this.label5);
            this.step_size.Controls.Add(this.txt_step1_key);
            this.step_size.Controls.Add(this.txt_step2_key);
            this.step_size.Controls.Add(this.txt_step3_key);
            this.step_size.Controls.Add(this.txt_step5_key);
            this.step_size.Controls.Add(this.txt_step4_key);
            this.step_size.Controls.Add(this.txt_step_1);
            this.step_size.Controls.Add(this.txt_step_2);
            this.step_size.Controls.Add(this.txt_step_5);
            this.step_size.Controls.Add(this.txt_step_3);
            this.step_size.Controls.Add(this.txt_step_4);
            this.step_size.Location = new System.Drawing.Point(385, 15);
            this.step_size.Margin = new System.Windows.Forms.Padding(4);
            this.step_size.Name = "step_size";
            this.step_size.Padding = new System.Windows.Forms.Padding(4);
            this.step_size.Size = new System.Drawing.Size(208, 235);
            this.step_size.TabIndex = 11;
            this.step_size.TabStop = false;
            this.step_size.Text = "Step";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Shortcut";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Distance";
            // 
            // txt_step1_key
            // 
            this.txt_step1_key.Location = new System.Drawing.Point(119, 93);
            this.txt_step1_key.Margin = new System.Windows.Forms.Padding(4);
            this.txt_step1_key.Name = "txt_step1_key";
            this.txt_step1_key.Size = new System.Drawing.Size(56, 22);
            this.txt_step1_key.TabIndex = 10;
            this.txt_step1_key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_step2_key
            // 
            this.txt_step2_key.Location = new System.Drawing.Point(119, 123);
            this.txt_step2_key.Margin = new System.Windows.Forms.Padding(4);
            this.txt_step2_key.Name = "txt_step2_key";
            this.txt_step2_key.Size = new System.Drawing.Size(56, 22);
            this.txt_step2_key.TabIndex = 11;
            this.txt_step2_key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_step3_key
            // 
            this.txt_step3_key.Location = new System.Drawing.Point(119, 162);
            this.txt_step3_key.Margin = new System.Windows.Forms.Padding(4);
            this.txt_step3_key.Name = "txt_step3_key";
            this.txt_step3_key.Size = new System.Drawing.Size(56, 22);
            this.txt_step3_key.TabIndex = 12;
            this.txt_step3_key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_step5_key
            // 
            this.txt_step5_key.Location = new System.Drawing.Point(119, 55);
            this.txt_step5_key.Margin = new System.Windows.Forms.Padding(4);
            this.txt_step5_key.Name = "txt_step5_key";
            this.txt_step5_key.Size = new System.Drawing.Size(56, 22);
            this.txt_step5_key.TabIndex = 13;
            this.txt_step5_key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_step4_key
            // 
            this.txt_step4_key.Location = new System.Drawing.Point(119, 200);
            this.txt_step4_key.Margin = new System.Windows.Forms.Padding(4);
            this.txt_step4_key.Name = "txt_step4_key";
            this.txt_step4_key.Size = new System.Drawing.Size(56, 22);
            this.txt_step4_key.TabIndex = 13;
            this.txt_step4_key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_step_1
            // 
            this.txt_step_1.Location = new System.Drawing.Point(26, 91);
            this.txt_step_1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_step_1.Name = "txt_step_1";
            this.txt_step_1.Size = new System.Drawing.Size(56, 22);
            this.txt_step_1.TabIndex = 6;
            this.txt_step_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_step_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumericalData);
            // 
            // txt_step_2
            // 
            this.txt_step_2.Location = new System.Drawing.Point(26, 127);
            this.txt_step_2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_step_2.Name = "txt_step_2";
            this.txt_step_2.Size = new System.Drawing.Size(56, 22);
            this.txt_step_2.TabIndex = 7;
            this.txt_step_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_step_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumericalData);
            // 
            // txt_step_5
            // 
            this.txt_step_5.Location = new System.Drawing.Point(26, 55);
            this.txt_step_5.Margin = new System.Windows.Forms.Padding(4);
            this.txt_step_5.Name = "txt_step_5";
            this.txt_step_5.Size = new System.Drawing.Size(56, 22);
            this.txt_step_5.TabIndex = 9;
            this.txt_step_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_step_5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumericalData);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_jog_z_plus);
            this.groupBox3.Controls.Add(this.txt_jog_z_minus);
            this.groupBox3.Controls.Add(this.txt_jog_y_minus);
            this.groupBox3.Controls.Add(this.txt_jog_x_plus);
            this.groupBox3.Controls.Add(this.txt_jog_x_minus);
            this.groupBox3.Controls.Add(this.txt_jog_y_plus);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(16, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(361, 272);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Keyboard short cuts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(8, 316);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "scan codes http://msdn.microsoft.com/en-us/library/aa243025(v=vs.60).aspx";
            // 
            // txt_jog_z_plus
            // 
            this.txt_jog_z_plus.Location = new System.Drawing.Point(276, 96);
            this.txt_jog_z_plus.Margin = new System.Windows.Forms.Padding(4);
            this.txt_jog_z_plus.Name = "txt_jog_z_plus";
            this.txt_jog_z_plus.Size = new System.Drawing.Size(49, 22);
            this.txt_jog_z_plus.TabIndex = 4;
            this.txt_jog_z_plus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_jog_z_plus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumericalData);
            // 
            // txt_jog_z_minus
            // 
            this.txt_jog_z_minus.Location = new System.Drawing.Point(276, 175);
            this.txt_jog_z_minus.Margin = new System.Windows.Forms.Padding(4);
            this.txt_jog_z_minus.Name = "txt_jog_z_minus";
            this.txt_jog_z_minus.Size = new System.Drawing.Size(49, 22);
            this.txt_jog_z_minus.TabIndex = 5;
            this.txt_jog_z_minus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_jog_z_minus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumericalData);
            // 
            // txt_jog_y_minus
            // 
            this.txt_jog_y_minus.Location = new System.Drawing.Point(116, 188);
            this.txt_jog_y_minus.Margin = new System.Windows.Forms.Padding(4);
            this.txt_jog_y_minus.Name = "txt_jog_y_minus";
            this.txt_jog_y_minus.Size = new System.Drawing.Size(49, 22);
            this.txt_jog_y_minus.TabIndex = 3;
            this.txt_jog_y_minus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_jog_y_minus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumericalData);
            // 
            // txt_jog_x_plus
            // 
            this.txt_jog_x_plus.Location = new System.Drawing.Point(171, 134);
            this.txt_jog_x_plus.Margin = new System.Windows.Forms.Padding(4);
            this.txt_jog_x_plus.Name = "txt_jog_x_plus";
            this.txt_jog_x_plus.Size = new System.Drawing.Size(49, 22);
            this.txt_jog_x_plus.TabIndex = 2;
            this.txt_jog_x_plus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_jog_x_plus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumericalData);
            // 
            // txt_jog_x_minus
            // 
            this.txt_jog_x_minus.Location = new System.Drawing.Point(56, 134);
            this.txt_jog_x_minus.Margin = new System.Windows.Forms.Padding(4);
            this.txt_jog_x_minus.Name = "txt_jog_x_minus";
            this.txt_jog_x_minus.Size = new System.Drawing.Size(49, 22);
            this.txt_jog_x_minus.TabIndex = 0;
            this.txt_jog_x_minus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_jog_x_minus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumericalData);
            // 
            // txt_jog_y_plus
            // 
            this.txt_jog_y_plus.Location = new System.Drawing.Point(116, 85);
            this.txt_jog_y_plus.Margin = new System.Windows.Forms.Padding(4);
            this.txt_jog_y_plus.Name = "txt_jog_y_plus";
            this.txt_jog_y_plus.Size = new System.Drawing.Size(49, 22);
            this.txt_jog_y_plus.TabIndex = 1;
            this.txt_jog_y_plus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_jog_y_plus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumericalData);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(8, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 246);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_EnSpindle);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_spindle_pwm);
            this.groupBox2.Controls.Add(this.txt_spindle_stop);
            this.groupBox2.Controls.Add(this.txt_spindle_start);
            this.groupBox2.Location = new System.Drawing.Point(24, 331);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(317, 170);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spindle";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.SkyBlue;
            this.label13.Location = new System.Drawing.Point(72, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 17);
            this.label13.TabIndex = 16;
            this.label13.Text = "%p = PWM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Stop";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "PWM";
            // 
            // txt_spindle_pwm
            // 
            this.txt_spindle_pwm.Location = new System.Drawing.Point(55, 131);
            this.txt_spindle_pwm.Margin = new System.Windows.Forms.Padding(4);
            this.txt_spindle_pwm.Name = "txt_spindle_pwm";
            this.txt_spindle_pwm.Size = new System.Drawing.Size(132, 22);
            this.txt_spindle_pwm.TabIndex = 18;
            // 
            // txt_spindle_stop
            // 
            this.txt_spindle_stop.Location = new System.Drawing.Point(55, 99);
            this.txt_spindle_stop.Margin = new System.Windows.Forms.Padding(4);
            this.txt_spindle_stop.Name = "txt_spindle_stop";
            this.txt_spindle_stop.Size = new System.Drawing.Size(132, 22);
            this.txt_spindle_stop.TabIndex = 17;
            // 
            // txt_spindle_start
            // 
            this.txt_spindle_start.Location = new System.Drawing.Point(55, 67);
            this.txt_spindle_start.Margin = new System.Windows.Forms.Padding(4);
            this.txt_spindle_start.Name = "txt_spindle_start";
            this.txt_spindle_start.Size = new System.Drawing.Size(132, 22);
            this.txt_spindle_start.TabIndex = 16;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(903, 391);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(105, 17);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Restore default";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupWindows
            // 
            this.groupWindows.Controls.Add(this.cb_globalkeys);
            this.groupWindows.Location = new System.Drawing.Point(677, 359);
            this.groupWindows.Margin = new System.Windows.Forms.Padding(4);
            this.groupWindows.Name = "groupWindows";
            this.groupWindows.Padding = new System.Windows.Forms.Padding(4);
            this.groupWindows.Size = new System.Drawing.Size(165, 118);
            this.groupWindows.TabIndex = 22;
            this.groupWindows.TabStop = false;
            this.groupWindows.Text = "Windows";
            // 
            // cb_globalkeys
            // 
            this.cb_globalkeys.AutoSize = true;
            this.cb_globalkeys.Location = new System.Drawing.Point(32, 27);
            this.cb_globalkeys.Margin = new System.Windows.Forms.Padding(4);
            this.cb_globalkeys.Name = "cb_globalkeys";
            this.cb_globalkeys.Size = new System.Drawing.Size(106, 21);
            this.cb_globalkeys.TabIndex = 0;
            this.cb_globalkeys.Text = "Global Keys";
            this.cb_globalkeys.UseVisualStyleBackColor = true;
            // 
            // cb_EnSpindle
            // 
            this.cb_EnSpindle.AutoSize = true;
            this.cb_EnSpindle.Location = new System.Drawing.Point(11, 28);
            this.cb_EnSpindle.Margin = new System.Windows.Forms.Padding(4);
            this.cb_EnSpindle.Name = "cb_EnSpindle";
            this.cb_EnSpindle.Size = new System.Drawing.Size(174, 21);
            this.cb_EnSpindle.TabIndex = 0;
            this.cb_EnSpindle.Text = "Enable Spindle Control";
            this.cb_EnSpindle.UseVisualStyleBackColor = true;
            this.cb_EnSpindle.CheckedChanged += new System.EventHandler(this.cb_EnSpindle_CheckedChanged);
            // 
            // preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 514);
            this.Controls.Add(this.groupWindows);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.step_size);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "preferences";
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.preferences_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.step_size.ResumeLayout(false);
            this.step_size.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupWindows.ResumeLayout(false);
            this.groupWindows.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_unit_inch;
        private System.Windows.Forms.RadioButton rb_unit_mm;
        private System.Windows.Forms.TextBox txt_step_4;
        private System.Windows.Forms.TextBox txt_step_3;
        private System.Windows.Forms.GroupBox step_size;
        private System.Windows.Forms.TextBox txt_step_1;
        private System.Windows.Forms.TextBox txt_step_2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_jog_z_plus;
        private System.Windows.Forms.TextBox txt_jog_z_minus;
        private System.Windows.Forms.TextBox txt_jog_y_minus;
        private System.Windows.Forms.TextBox txt_jog_x_plus;
        private System.Windows.Forms.TextBox txt_jog_x_minus;
        private System.Windows.Forms.TextBox txt_jog_y_plus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_spindle_pwm;
        private System.Windows.Forms.TextBox txt_spindle_stop;
        private System.Windows.Forms.TextBox txt_spindle_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_step1_key;
        private System.Windows.Forms.TextBox txt_step2_key;
        private System.Windows.Forms.TextBox txt_step3_key;
        private System.Windows.Forms.TextBox txt_step4_key;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupWindows;
        private System.Windows.Forms.CheckBox cb_globalkeys;
        private System.Windows.Forms.TextBox txt_step5_key;
        private System.Windows.Forms.TextBox txt_step_5;
        private System.Windows.Forms.CheckBox cb_EnSpindle;
    }
}