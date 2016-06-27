using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locker
{
    public partial class Form1 : Form
    {
        publics publics = new publics();
        public Form1()
        {
            InitializeComponent();
            mainBox.AppendText("Your machine has been LOCKED. \n");
            mainBox.AppendText("The administrator for your system has chosen to lock the computer and requires that you enter a code to access your machine normally. \n");
            mainBox.AppendText("Please enter the code in the text boxes below. Then, press the \"unlock\" button. \n");
            mainBox.AppendText("Security measures are being taken....\n");
            publics.disableTaskManager();
            publics.disableTaskBar();
            mainBox.AppendText("Done. Please enter the code. \n");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkKey();
        }


        public void checkKey()
        {
            var boxOneText = boxOne.Text;
            var boxTwoText = boxTwo.Text;
            var boxThreeText = boxThree.Text;
            var boxFourText = boxFour.Text;

            if (boxOneText == "ABC")
                if (boxTwoText == "123")
                    if (boxThreeText == "EZ")
                        if (boxFourText == "EZPZ")
                        {
                            publics.enableTaskBar();
                            publics.enableTaskManager();
                        }
                            
                            
            else
                        {
                            MessageBox.Show("Code was invalid.");
                        }                

        }
    }
}
