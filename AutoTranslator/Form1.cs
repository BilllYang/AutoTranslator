using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Skytells;

namespace AutoTranslator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Declares an IDataObject to hold the data returned from the clipboard.
            // Retrieves the data from the clipboard.
            IDataObject iData = Clipboard.GetDataObject();
            string is_change = null;
            string to_tran = null;
            string has_tran = null;
            // Determines whether the data is in a format you can use.
            while (true)
            {
                if (iData.GetDataPresent(DataFormats.Text))
                {
                    if(is_change != (String)iData.GetData(DataFormats.Text)){
                        to_tran = (String)iData.GetData(DataFormats.Text);
                        if(Skytells.Translator.TranslateText(to_tran,textBox1.Text,textBox2.Text) == true)
                        {
                            has_tran = Skytells.Translator.TranslatedWord;
                        }
                        MessageBox.Show(has_tran);
                    }
                }
                else
                {
                    // No it is not.
                    textBox2.Text = "Could not retrieve data off the clipboard.";
                }
                is_change = (String)iData.GetData(DataFormats.Text);
            }
        }
    }
}
