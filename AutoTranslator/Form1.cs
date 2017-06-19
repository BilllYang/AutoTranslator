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
            comboBox1.Items.Add("英文");
            comboBox1.Items.Add("正體中文");
            comboBox1.Items.Add("法文");
            comboBox1.Items.Add("德文");
            comboBox1.Items.Add("阿拉伯文");
            comboBox1.Items.Add("西班牙文");
            comboBox1.Items.Add("葡萄牙文");
            comboBox1.SelectedItem = "英文"; ;
            comboBox2.Items.Add("英文");
            comboBox2.Items.Add("正體中文");
            comboBox2.Items.Add("法文");
            comboBox2.Items.Add("德文");
            comboBox2.Items.Add("阿拉伯文");
            comboBox2.Items.Add("西班牙文");
            comboBox2.Items.Add("葡萄牙文");
            comboBox2.SelectedItem = "正體中文";

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem == "英文")
            {
                textBox1.Text = "EN";
            }
            else if (comboBox1.SelectedItem == "正體中文")
            {
                textBox1.Text = "zh-HK";
            }
            else if (comboBox1.SelectedItem == "簡體中文")
            {
                textBox1.Text = "zh_CN";
            }

            else if (comboBox1.SelectedItem == "法文")
            {
                textBox1.Text = "FR";
            }

            else if (comboBox1.SelectedItem == "德文")
            {
                textBox1.Text = "DE";
            }

            else if (comboBox1.SelectedItem == "阿拉伯文")
            {
                textBox1.Text = "AR";
            }

            else if (comboBox1.SelectedItem == "西班牙文")
            {
                textBox1.Text = "ES";
            }
            else if (comboBox1.SelectedItem == "葡萄牙文")
            {
                textBox1.Text = "PT";
            }



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == "英文")
            {
                textBox2.Text = "EN";
            }
            else if (comboBox2.SelectedItem == "正體中文")
            {
                textBox2.Text = "zh-HK";
            }
            else if (comboBox2.SelectedItem == "簡體中文")
            {
                textBox2.Text = "zh_CN";
            }

            else if (comboBox2.SelectedItem == "法文")
            {
                textBox2.Text = "FR";
            }

            else if (comboBox2.SelectedItem == "德文")
            {
                textBox2.Text = "DE";
            }

            else if (comboBox2.SelectedItem == "阿拉伯文")
            {
                textBox2.Text = "AR";
            }

            else if (comboBox2.SelectedItem == "西班牙文")
            {
                textBox2.Text = "ES";
            }
            else if (comboBox2.SelectedItem == "葡萄牙文")
            {
                textBox2.Text = "PT";
            }
        }
    }
}
