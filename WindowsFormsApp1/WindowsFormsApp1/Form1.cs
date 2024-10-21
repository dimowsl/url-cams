﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Hide();
            linkLabel2.Text = "Camera";
            linkLabel2.Links.Add(0, linkLabel2.Text.Length, "http://free-webcambg.com/Big-Brother-2024-6-webcams-BG.html");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            pictureBox1.Enabled = true;
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            timer1.Enabled = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://free-webcambg.com/Sofia-02-webcam-live-online-camera-Sf-kameri-na-jivo-vremeto-weather.htm");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://free-webcambg.com/Sofia-08-webcam-live-online-camera-city-street-road-Sofiq-kameri-na-jivo-vremeto-weather.htm");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url =e.Link.LinkData as string;
            if (!string.IsNullOrEmpty(url))
            {
                Process.Start(url);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Enabled = true;
            webBrowser1.Navigate("");
            WebBrowser webBrowser2 = new WebBrowser();
            webBrowser2.Location = pictureBox2.Location;
            webBrowser2.Size = pictureBox2.Size;
            webBrowser2.Navigate("https://www.youtube.com/watch?v=IFLHibAMqOQ");
            this.Controls.Add(webBrowser2);
            pictureBox2.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
