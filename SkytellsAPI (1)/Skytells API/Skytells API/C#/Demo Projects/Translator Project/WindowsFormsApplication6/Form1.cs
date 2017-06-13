using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Skytells;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Skytells.Translator.TranslateText(txtLitter.Text, cInputLang.Text, cOutputLang.Text) == true)
                txtLitter.Text = Skytells.Translator.TranslatedWord;
        }

      

        
    }
}
