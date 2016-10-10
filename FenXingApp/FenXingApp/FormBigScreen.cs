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
    public partial class FormBigScreen : Form
    {
        private int countOfImage;
        private int widthOfImage;
        private int heightOfImage;
        private int countOfCol;
        private int WidthOfColume;
        private int countOfRow;
        private int HeightOfRow;
        private int initLeft;
        private int initTop;
        private System.Windows.Forms.PictureBox[] firstPagePictureArray;
        private System.Windows.Forms.PictureBox centralImage = new PictureBox();

        public FormBigScreen(int numOfImage, int widthOfSingleImage, int heightOfSingleImage, int left, int top, int col, int width, int row, int height)
        {
            countOfImage = numOfImage;
            widthOfImage = widthOfSingleImage;
            heightOfImage = heightOfSingleImage;
            initLeft = left;
            initTop = top;
            countOfCol = col;
            WidthOfColume = width;
            countOfRow = row;
            HeightOfRow = height;
            InitializeComponent();
        }

        public void ShowQuestionOne(int row, int col)
        {
            if (row < 1 || row > countOfRow || col < 1 || col > countOfCol)
            {
                MessageBox.Show("输入的行号和列号不合法！！！");
                return;
            }

            int id = (row - 1) * countOfCol + (col - 1);


            this.SuspendLayout();

            this.panel1.Visible = false;
            pictureBox1.ImageLocation = @".\images\800x800.jpg";
            pictureBox1.Size = new System.Drawing.Size(800, 800);
            pictureBox1.BackColor = Color.Transparent;
            this.pictureBox1.Visible = true;

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FormBigScreen_Load(object sender, EventArgs e)
        {
            firstPagePictureArray = new System.Windows.Forms.PictureBox[countOfImage];
            for (int i = 0; i < countOfImage; i++)
            {
                this.firstPagePictureArray[i] = new System.Windows.Forms.PictureBox();
                this.firstPagePictureArray[i].Location = 
                    new System.Drawing.Point(initLeft + i % countOfCol * WidthOfColume, initTop + i / countOfRow * HeightOfRow);
                this.firstPagePictureArray[i].Name = "pictureBox" + i.ToString();
                this.firstPagePictureArray[i].Size = new System.Drawing.Size(widthOfImage, heightOfImage);
                this.firstPagePictureArray[i].BackColor = Color.Transparent;
                this.firstPagePictureArray[i].TabIndex = i;
                this.firstPagePictureArray[i].TabStop = false;
                this.panel1.Controls.Add(this.firstPagePictureArray[i]);
                this.firstPagePictureArray[i].ImageLocation = @".\images\200x200.jpg";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ShowQuestionOne(2,1);
        }
    }
}
