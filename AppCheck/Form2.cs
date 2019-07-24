using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppChecker
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            setRichTextBox1();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Change the color of the link text by setting LinkVisited   
            // to true.  
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser   
            //with a URL:  
            System.Diagnostics.Process.Start("http://www.edenland.pl");
        }
        public void setRichTextBox1()
        {
            String textDoBox = "Program na licencji GNU GPL." + Environment.NewLine + "Bezpłatny do użytku prywatnego i w celach komercyjnych." + Environment.NewLine + Environment.NewLine 
                                + "Jeśli uważasz, że program jest dla Ciebie przydatny, prześlij nam swoją opinię, również sugestie odnośnie nowych fukcji w programie."
                                 + Environment.NewLine + "Może to pomóc w rozwoju programu." + Environment.NewLine +Environment.NewLine + 
                                 "Możesz też przesłać dowolną dotację, z pewnością będzie to miły gest, który zmotywuje do dalszej pracy nad projektem."
                                 + Environment.NewLine + "Wpłata Skrill " +Environment.NewLine + "Etherum: ";
            richTextBox1.Text = textDoBox;
            richTextBox1.Refresh();
        }
    }
}

