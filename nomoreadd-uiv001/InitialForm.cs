using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace nomoreadd_uiv001
{
        public partial class Form1 : Form
        {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CAPTION = 0x2;

        //makes the window moveable 
        //gently copied from: "elimad" & "Wai Ha Lee"
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        //makes the window corners rounded
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
            );

            public Form1()
            {
                InitializeComponent();
                this.FormBorderStyle = FormBorderStyle.None;
                Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            }

        private void closeWindowBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void closeWindowBtn_MouseEnter(object sender, EventArgs e)
        {
            closeWindowBtn.Image = Properties.Resources.close_active_ico;
        }
        private void closeWindowBtn_MouseLeave(object sender, EventArgs e)
        {
            closeWindowBtn.Image = Properties.Resources.close_ico;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void contactsBtn_MouseEnter(object sender, EventArgs e)
        {
            contactsBtn.Image = Properties.Resources.contacts_hover_ico;
        }

        private void contactsBtn_MouseLeave(object sender, EventArgs e)
        {
            contactsBtn.Image = Properties.Resources.contacts_ico;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            //Generates the link and the Contact Object, then send it to the 
            //hide browser that calls the wpp.app, and to the ContactList.class
            //to create the actual contact in the list

            if (inputNumber.Text == "") return;

            WebBrowser Browser = new WebBrowser();
            Generator gen = new Generator();
            Browser.Navigate(gen.GenerateLinkDDI(labelDDI.Text, inputNumber.Text));
            gen.PrintLink();
            //object obj = new { name = "name", number = 1 };
            //return obj;
        }

        private void inputName_Enter(object sender, EventArgs e)
        {
            if(inputName.ForeColor == Color.FromArgb(37, 69, 79))
            {
                inputName.Text = "";
                inputName.ForeColor = Color.FromArgb(3, 255, 207);
            }
        }
        private void inputName_Leave(object sender, EventArgs e)
        {
            if(Regex.IsMatch(inputName.Text, "^$"))
            {
                inputName.Text = "name";
                inputName.ForeColor = Color.FromArgb(37, 69, 79);
            }
        }

        private void inputNumber_Enter(object sender, EventArgs e)
        {
            if (inputNumber.ForeColor == Color.FromArgb(37, 69, 79))
            {
                inputNumber.Text = "";
                inputNumber.ForeColor = Color.FromArgb(3, 255, 207);
            }
        }
        private void inputNumber_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(inputNumber.Text, "^$"))
            {
                inputNumber.Text = "number";
                inputNumber.ForeColor = Color.FromArgb(37, 69, 79);
            }
        }

        private void inputNumber_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(inputNumber.Text, "[^0-9]"))
            {
                string txt = inputNumber.Text;

                if (!inputNumber.Text.Equals("") || !inputName.Text.Equals("number"))
                {
                    //New string
                    string new_txt = "";

                    for (int i = 0; i <= txt.Length - 1; i++)
                    {
                        //Ignore the char if its not a number
                        if(!Regex.IsMatch(txt[i].ToString(), "[^0-9]"))
                        {
                            new_txt += txt[i];
                        }
                    }
                    //inputNumber.Text = inputNumber.Text.Remove(inputNumber.Text.Length - 1);
                    inputNumber.Text = new_txt;
                    inputNumber.SelectionStart = (inputNumber.Text.Length);
                    
                }
            }
        }
    }
}
