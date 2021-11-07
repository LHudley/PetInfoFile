using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetInfoFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string name, age, health, meds;

            name = txtName.Text;
            age = txtAge.Text;
            health = txtHealth.Text;
            meds = txtMed.Text;

            try
            {
                StreamWriter outputFile;

                /* Creating File:
                 outputFile = File.CreateText("RockyInfo.txt");*/

                //Appending to same file
                outputFile = File.AppendText("RockyInfo.txt");

                outputFile.WriteLine("\n\n"+ name + "\n" + age + "\n"+ health + "\n" + meds);

                outputFile.Close();

                MessageBox.Show("Your file has been written");


                txtName.Text = "";
                txtAge.Text = "";
                txtHealth.Text = "";
                txtMed.Text = "";

                txtName.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
