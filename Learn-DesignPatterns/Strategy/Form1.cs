using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strategy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //策略模式：它是对一系列（返回值和参数相同但实现不同）不同计算的封装，就是使用的时候是一样的
        //但是实现上不一样，减少使用算法类和各种算法类之间的耦合

        //策略模式是在一个个独立算法中定义各种算法，在Context中定义了一系列可供重用的算法和行为


        //显示总金额
        double total = 0.0d;
        private void button1_Click(object sender, EventArgs e)
        {
            //策略和工厂的结合让客户端只是看见了Context类，它们结合的地方正是在Context类里
            //客户端看不到是谁在使用算法，客户端只是告诉你我要进行哪种行为
            ContextStrategy contextStrategy = new ContextStrategy(comboBox1.Text.Trim());

            //购买一种商品的总金额
            double totalprices = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text);

            //算法之后的总金额
            totalprices = contextStrategy.GetPayment(totalprices);

            total = total + totalprices;
            
            listBox1.Items.Add("单价：" + textBox1.Text + ";数量：" + textBox2.Text + ";总价：" + totalprices.ToString());
            label5.Text = total.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            textBox2.Text = "";
            textBox1.Text = "";
            label5.Text = "0";
            listBox1.Items.Clear();
        }
    }
}
