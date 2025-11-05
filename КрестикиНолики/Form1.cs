using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using КрестикиНолики.Properties;

namespace КрестикиНолики
{
    public partial class Form1 : Form
    {
        bool turn = true; // True - X False - O
        Image image = Resources.Крестик;
        public Form1()
        {
            InitializeComponent();
        }


        private bool CheckCell(PictureBox pictureBox)
        {
            if (pictureBox.Image == null) {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (CheckCell(pictureBox1))
            {
                pictureBox1.Image = image;
                image = turn == true ? image = Resources.Нолик : image = Resources.Крестик;
                turn = !turn; // NOT
                pictureBox1.Tag = "O";
            }
          
            //if (turn)
            //{
            //    pictureBox1.Image = Resources.Крестик;
            //    turn = false;
            //}
            //else
            //{
            //    pictureBox1.Image = Resources.Нолик;
            //    turn = true;
            //}
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (CheckCell(pictureBox2))
            {
                pictureBox2.Image = image;
                image = turn == true ? image = Resources.Нолик : image = Resources.Крестик;
                turn = !turn; // NOT
            }
               
            //if (turn)
            //{
            //    pictureBox2.Image = Resources.Крестик;
            //    turn = false;
            //}
            //else
            //{
            //    pictureBox2.Image = Resources.Нолик;
            //    turn = true;
            //}
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (CheckCell(pictureBox3))
            {
                pictureBox3.Image = image;
                image = turn == true ? image = Resources.Нолик : image = Resources.Крестик;
                turn = !turn; // NOT
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (CheckCell(pictureBox6))
            {
                pictureBox6.Image = image;
                image = turn == true ? image = Resources.Нолик : image = Resources.Крестик;
                turn = !turn; // NOT
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (CheckCell(pictureBox5))
            {
                pictureBox5.Image = image;
                image = turn == true ? image = Resources.Нолик : image = Resources.Крестик;
                turn = !turn; // NOT
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (CheckCell(pictureBox4))
            {
                pictureBox4.Image = image;
                image = turn == true ? image = Resources.Нолик : image = Resources.Крестик;
                turn = !turn; // NOT
            }

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (CheckCell(pictureBox9))
            {
                pictureBox9.Image = image;
                image = turn == true ? image = Resources.Нолик : image = Resources.Крестик;
                turn = !turn; // NOT
            }

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (CheckCell(pictureBox8))
            {
                pictureBox8.Image = image;
                image = turn == true ? image = Resources.Нолик : image = Resources.Крестик;
                turn = !turn; // NOT
            }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (CheckCell(pictureBox7))
            {
                pictureBox7.Image = image;
                image = turn == true ? image = Resources.Нолик : image = Resources.Крестик;
                turn = !turn; // NOT
            }

        }
    }
}
