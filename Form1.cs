// Code for Main Page
//Below are the required header files
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Kinect
{
    public partial class Form1 : Form
    {
        int counter, counter1=0, counter2, counter3, counter4=0,counter5,counter6,counter7=0,counter8,counter9=0,counter10=0,counter11=0,counter12,counter_angle;
        int color_choice;
        OpenFileDialog opn1 = new OpenFileDialog();
        FolderBrowserDialog f1 = new FolderBrowserDialog();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if baseline program needs to be executed
            if (radioButton1.Checked)
            {
                string pass_value1 = textBox1.Text;
                string pass_value2 = textBox2.Text;
                string pass_value3 = textBox3.Text;
                string pass_value4 = textBox4.Text;
                string pass_value5 = textBox5.Text;
                string file_value = textBox8.Text;
                if(radioButton7.Checked)
                {
                    counter_angle = 2;
                }
                if (radioButton8.Checked)
                {
                    counter_angle = 1;
                }
                if (radioButton9.Checked)
                {
                    counter_angle = 3;
                }
                if(radioButton2.Checked)
                {
                    color_choice = 0;
                }
                if(radioButton10.Checked)
                {
                    color_choice = 1;
                }
                Form2 baseline = new Form2(pass_value1,pass_value2,pass_value3,pass_value4,pass_value5,file_value,counter_angle,color_choice);
                baseline.Show();
            }
           //if the final version(with all the componets need to be executed)
            if (radioButton3.Checked)
            {
                string pass_value1 = textBox1.Text;
                string pass_value2 = textBox2.Text;
                string pass_value3 = textBox3.Text;
                string pass_value4 = textBox4.Text;
                string pass_value5 = textBox5.Text;
                string pass_value6 = textBox6.Text;
                string pass_value7 = textBox7.Text;
                string file_value = textBox8.Text;
                if (radioButton7.Checked)
                {
                    counter_angle = 2;
                }
                if (radioButton8.Checked)
                {
                    counter_angle = 1;
                }
                if (radioButton9.Checked)
                {
                    counter_angle = 3;
                }
                if (checkBox1.Checked)
                {
                    counter = 1;
                }
                if (checkBox2.Checked)
                {
                    counter = 0;
                }
                if (checkBox3.Checked)
                {
                    counter1 = 1;
                }
                if (checkBox4.Checked)
                {
                    counter2 = 1;
                }
                if (checkBox5.Checked)
                {
                    counter2 = 0;
                }
                if (checkBox6.Checked)
                {
                    counter3 = 1;
                }
                if (checkBox7.Checked)
                {
                    counter3 = 0;
                }
                if (checkBox8.Checked)
                {
                    counter4 = 1;
                }
                if (checkBox9.Checked)
                {
                    counter5 = 1;
                }
                if (checkBox10.Checked)
                {
                    counter5 = 0;
                }
                if (checkBox11.Checked)
                {
                    counter6 = 1;
                }
                if (checkBox12.Checked)
                {
                    counter6 = 0;
                }
                if (checkBox13.Checked)
                {
                    counter7 = 1;
                }
                if (checkBox14.Checked)
                {
                    counter8 = 1;
                }
                if (checkBox15.Checked)
                {
                    counter8 = 0;
                }
                if (checkBox16.Checked)
                {
                    counter12 = 0;
                }
                if (checkBox17.Checked)
                {
                    counter12 = 1;
                }
                if (radioButton4.Checked)
                {
                    counter9 = 1;
                }
                if(radioButton5.Checked)
                {
                    counter10 = 1;
                }
                if(radioButton6.Checked)
                {
                    counter11 = 1;
                }
                if (radioButton2.Checked)
                {
                    color_choice = 0;
                }
                if (radioButton10.Checked)
                {
                    color_choice = 1;
                }
                Form6 baseline = new Form6(pass_value1, pass_value2, pass_value3, pass_value4, pass_value5,counter,counter1,counter2,counter3,counter4,counter5,counter6,counter7,counter8,counter9,counter10,counter11,pass_value6,counter12,pass_value7,file_value,counter_angle,color_choice);
                baseline.Show();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        //to select the video file
        private void button2_Click(object sender, EventArgs e)
        {
            if(opn1.ShowDialog()==DialogResult.OK)
            {
                textBox7.Text = opn1.FileName;
            }
        }
        //to select the path for storing the data files
        private void button3_Click(object sender, EventArgs e)
        {
            if (f1.ShowDialog() == DialogResult.OK)
            {
                textBox8.Text = f1.SelectedPath;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
