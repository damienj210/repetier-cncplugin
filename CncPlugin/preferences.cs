﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepetierHostExtender.interfaces;
using System.Globalization;


/* TODO

 * 0.1mm round error
 * use the pref values in the other dialog
 * dropdown with key friendly names
  
  */

namespace CncPlugin
{
    public partial class preferences : Form
    {
        private IHost host;
        private PluginPreferences pref;
        private CncControl _cc;

        public preferences(IHost h, PluginPreferences _pref, CncControl cc)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            host = h;
            pref = _pref;
            _cc = cc;
            pref.loadDefaults();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void loadDefault()
        {
            txt_jog_x_minus.Text = pref.jog_key_x_minus.ToString();
            txt_jog_x_plus.Text = pref.jog_key_x_plus.ToString();
            txt_jog_y_minus.Text = pref.jog_key_y_minus.ToString();
            txt_jog_y_plus.Text = pref.jog_key_y_plus.ToString();
            txt_jog_z_minus.Text = pref.jog_key_z_minus.ToString();
            txt_jog_z_plus.Text = pref.jog_key_z_plus.ToString();

            txt_step_1.Text = pref.jog_step_1.ToString();
            txt_step_2.Text = pref.jog_step_2.ToString();
            txt_step_3.Text = pref.jog_step_3.ToString();
            txt_step_4.Text = pref.jog_step_4.ToString();
            txt_step_5.Text = pref.jog_step_5.ToString();

            txt_step1_key.Text = pref.step_key_1.ToString();
            txt_step2_key.Text = pref.step_key_2.ToString();
            txt_step3_key.Text = pref.step_key_3.ToString();
            txt_step4_key.Text = pref.step_key_4.ToString();
            txt_step5_key.Text = pref.step_key_5.ToString();

            txt_spindle_start.Text = pref.spindle_start;
            txt_spindle_stop.Text = pref.spindle_stop;
            txt_spindle_pwm.Text = pref.spindle_pwm;

            if (pref.jog_unit == "mm") { rb_unit_mm.Checked = true; } else { rb_unit_inch.Checked = true; }

            cb_globalkeys.Checked = pref.globalkeys;
            cb_EnSpindle.Checked = pref.enablespindle;
        }

        private void preferences_Load(object sender, EventArgs e)
        {
            loadDefault();
            if (host.IsMono)
            {
                groupWindows.Enabled = false;
                cb_globalkeys.Checked = false;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            SavePreferences();
            this.Close();
        }

        private void SavePreferences()
        {
            pref.jog_key_x_minus = int.Parse(txt_jog_x_minus.Text);
            pref.jog_key_x_plus = int.Parse(txt_jog_x_plus.Text);
            pref.jog_key_y_minus = int.Parse(txt_jog_y_minus.Text);
            pref.jog_key_y_plus = int.Parse(txt_jog_y_plus.Text);
            pref.jog_key_z_minus = int.Parse(txt_jog_z_minus.Text);
            pref.jog_key_z_plus = int.Parse(txt_jog_z_plus.Text);

            pref.jog_step_1 = Double.Parse(txt_step_1.Text);
            pref.jog_step_2 = Double.Parse(txt_step_2.Text);
            pref.jog_step_3 = Double.Parse(txt_step_3.Text);
            pref.jog_step_4 = Double.Parse(txt_step_4.Text);
            pref.jog_step_5 = Double.Parse(txt_step_5.Text);

            pref.step_key_1 = int.Parse(txt_step1_key.Text);
            pref.step_key_2 = int.Parse(txt_step2_key.Text);
            pref.step_key_3 = int.Parse(txt_step3_key.Text);
            pref.step_key_4 = int.Parse(txt_step4_key.Text);
            pref.step_key_5 = int.Parse(txt_step5_key.Text);

            pref.spindle_start = txt_spindle_start.Text;
            pref.spindle_stop = txt_spindle_stop.Text;
            pref.spindle_pwm = txt_spindle_pwm.Text;

            if (rb_unit_mm.Checked == true) { pref.jog_unit = "mm"; } else { pref.jog_unit = "inch"; }
            pref.globalkeys = cb_globalkeys.Checked;
            pref.enablespindle = cb_EnSpindle.Checked;

            host.LogMessage("CncPlugin: Preferences saved");
            pref.save();
            _cc.refreshPref();
        }

        private void OnlyNumericalData(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))) e.Handled = true;
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IRegMemoryFolder reg = host.GetRegistryFolder("CncPlugin");
            reg.DeleteThisFolder();
            pref.loadDefaults();
            loadDefault();
            _cc.refreshPref();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cb_EnSpindle_CheckedChanged(object sender, EventArgs e)
        {
            (this.Owner as form).groupBox4.Visible = cb_EnSpindle.Checked;
        }
    }
}
