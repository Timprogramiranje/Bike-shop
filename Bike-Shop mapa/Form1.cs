using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string street = txt_street.Text;

            string city = txt_city.Text;

            string state = txt_state.Text;

            string zip = txt_zip.Text; 
            StringBuilder quearyadress = new StringBuilder();
            quearyadress.Append("http://google.com/maps?q=");
                 
            if(street != string.Empty)
            {
                quearyadress.Append(street + "," + "+");


            }

            if (city!= string.Empty)
            {
                quearyadress.Append(city + "," + "+");


            }

            if (state != string.Empty)
            {
                quearyadress.Append(state+ "," + "+");


            }

            if (zip != string.Empty)
            {
                quearyadress.Append(zip + "," + "+");


            }

            webBrowser1.Navigate(quearyadress.ToString());


        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
