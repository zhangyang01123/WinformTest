using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FenXingApp
{
    public partial class ConsoleForm : Form
    {
        private FormBigScreen bigScreen;
        public ConsoleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bigScreen = new FormBigScreen(16, 300, 200, 200, 80, 4, 400, 4, 250);
            bigScreen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowID = 0;
            int colID = 0;

            if (!Int32.TryParse(TextOfRowID.Text.Trim(), out rowID))
            {
                MessageBox.Show("输入的行号数值错误！！！");
                return;
            }

            if (!Int32.TryParse(TextOfColID.Text.Trim(), out colID))
            {
                MessageBox.Show("输入的列号数值错误！！！");
                return;
            }

            bigScreen.ShowQuestionOne(rowID, colID);
        }
    }
}
