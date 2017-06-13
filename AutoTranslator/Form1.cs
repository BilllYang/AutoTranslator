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
        int start_tran = 0;
        string is_change = null;
        string to_tran = null;
        string has_tran = null;
        public Form1()
        {
            InitializeComponent();
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if(start_tran == 0)
            {
                start_tran = 1;
                timer1.Enabled = true;
            }
            else
            {
                start_tran = 0;
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Declares an IDataObject to hold the data returned from the clipboard.
            // Retrieves the data from the clipboard.
            IDataObject iData = Clipboard.GetDataObject();
            // Determines whether the data is in a format you can use.
            if (iData.GetDataPresent(DataFormats.Text))
            {
                to_tran = (String)iData.GetData(DataFormats.Text);
                if (is_change != to_tran)
                {
                    is_change = to_tran;
                    if (Skytells.Translator.TranslateText(to_tran, textBox1.Text, textBox2.Text) == true)
                    {
                                has_tran = Skytells.Translator.TranslatedWord;
                    }
                            MessageBox.Show(has_tran);
                }
            }
                        
        }
    }
}
