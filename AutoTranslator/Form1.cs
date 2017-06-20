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
        string historyh = null;//to tran
        string historyt = null;//has tran
        string strtarget = null;
        string searchWithinThis = null;
        int found = 0;
        int totFinds = 0;
        int linenumber = 0;
        string change = null;
        int[] lineaddress = new int[50];
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
                            historyt = to_tran;
                            historyh = has_tran;
                            linenumber++;
                            change = Convert.ToString(linenumber);
                            textBox3.AppendText(change+".  ");
                            textBox5.AppendText(change+".  ");
                            textBox3.AppendText(historyt);
                            textBox3.AppendText("\n");
                            textBox5.AppendText(historyh);
                            textBox5.AppendText("\n");
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

        private void button1_Click(object sender, EventArgs e)
        {
            strtarget = textBox4.Text;
            searchWithinThis = textBox3.Text;
            int firstCharacter = searchWithinThis.IndexOf(strtarget);

            for (int k = 1; k <= linenumber+1; k++)
            {
                lineaddress[k - 1] = searchWithinThis.IndexOf(Convert.ToString(k));
            }
            if (firstCharacter >= 0)
            {
                for (int k = 1; k <= linenumber+1; k++)
                {
                    if (firstCharacter <= lineaddress[k - 1])
                    {
                        MessageBox.Show("first character find in" + (k-1) + "line");
                        break;
                    }
                    else if(lineaddress[k - 1] > lineaddress[k])
                    {
                        MessageBox.Show("first character find in" + k + "line");
                        break;
                    }
                }
                // MessageBox.Show("first character find in" + firstCharacter+"position");//輸出尋找單字的第一個字元的位子
            }
            else
            {
                MessageBox.Show("not found");//找不到
            }
        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == false)
            {
                textBox3.Visible = false;
            }
            else
            {
                textBox3.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == false)
            {
                textBox5.Visible = false;
            }
            else
            {
                textBox5.Visible = true;
            }
        }
    }
}
