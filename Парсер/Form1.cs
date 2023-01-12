using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Парсер
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        int LL;

        private void buttonGO_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Parser m = new Parser();
                string text = "";
                List<string> Go = new List<string>();
                StringToList(textBox1.Text, Go);
                for (int i = 0; i < LL; i++)
                {
                    if (Go[i][0] == 'x' || Go[i][0] == 'y' || Go[i][0] == 'z' || Go[i][0] == 'X' || Go[i][0] == 'Y' || Go[i][0] == 'Z')
                    {
                        switch (Go[i][0])
                        {
                            case 'x':
                            case 'X':
                                text += textBoxX.Text;
                                break;
                            case 'y':
                            case 'Y':
                                text += textBoxY.Text;
                                break;
                            case 'z':
                            case 'Z':
                                text += textBoxZ.Text;
                                break;
                        }
                    }
                    else
                    text += Go[i];
                }

                textBox2.Text = Convert.ToString(m.Evaluate(text));
                if (textBox2.Text == "∞")
                {
                    m.ERROR = true;
                    MessageBox.Show("Деление на нуль!");
                }

                if (m.ERROR == false)
                    listBoxHistory.Items.Add(text + "=" + textBox2.Text);
                else
                    textBox2.Text = "";
            }
            else
            {
                Parser m = new Parser();
                textBox2.Text = Convert.ToString(m.Evaluate(textBox1.Text));
                if (textBox2.Text== "∞")
                {
                    m.ERROR = true;
                    MessageBox.Show("Деление на нуль!");
                }

                if (m.ERROR == false)
                    listBoxHistory.Items.Add(textBox1.Text + "=" + textBox2.Text);
                else
                    textBox2.Text = "";
            }

        }

        public List<string> StringToList(string go, List<string> Go)
        {
            string num = "";
            LL = 0;
            for (int i = 0; i < go.Length; i++)
            {
                if (go[i] == '0' || go[i] == '1' || go[i] == '2' || go[i] == '3' || go[i] == '4' || go[i] == '5' || go[i] == '6' || go[i] == '7' || go[i] == '8' || go[i] == '9' || go[i] == ',')
                {
                    num = num + Convert.ToString(go[i]);
                    if (i == go.Length - 1)
                    {
                        Go.Add(num);
                        LL++;
                    }
                }
                else
                {
                    if (num != "")
                    {
                        Go.Add(num);
                        num = "";
                        LL++;
                    }
                    Go.Add(Convert.ToString(go[i]));
                    LL++;
                }
            }
            return Go;
        }
        
        public void ShowError (int a)
        {
            switch (a)
            {
                case 0:
                    MessageBox.Show("Синтаксическая ошибка!");
                    break;
                case 1:
                    MessageBox.Show("Дисбаланс скобок!");
                    break;
                case 2:
                    MessageBox.Show("Выражение отсутствует!");
                    break;
                case 3:
                    MessageBox.Show("Деление на нуль!");
                    break;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            buttonHistory.Visible = false;
        }

        private void buttonHistoryClear_Click(object sender, EventArgs e)
        {
            listBoxHistory.Items.Clear();
        }

        private void buttonHistoryVisible_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            buttonHistory.Visible = true;
        }
    }
}
