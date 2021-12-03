﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V4HubTester
{
    public partial class InputDialog : Form
    {
        HubDBContext db;
        Form1 form;
        String buttonName;
        public InputDialog(HubDBContext db, Form1 form, String buttonName)
        {
            this.db = db;
            this.form = form;
            this.buttonName = buttonName;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // verify whether the QRcode is duplicated, and alert to the user
            var hub = db.Hubs.OrderByDescending(h => h.id).FirstOrDefault(h => h.PCBA == textBox1.Text);
            if (hub != null)
            {
                //MessageBox.Show("Duplicate barcode! Did you test it before?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (MessageBox.Show("This hub has been tested before. Do you want to retest it again?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != DialogResult.OK)
                {
                    return;
                }
            }
            form.passQRCode(textBox1.Text, buttonName);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}