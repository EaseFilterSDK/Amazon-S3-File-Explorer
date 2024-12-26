﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AmazonS3Explorer
{
    public partial class InputForm : Form
    {
        public string InputText = string.Empty;

        public InputForm(string caption, string promptText,string inputText)
        {
            InitializeComponent();
            this.Text = caption;
            label_InputPrompt.Text = promptText;
            textBox_Input.Text = inputText;
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            InputText = textBox_Input.Text;
        }

      
    }
}
