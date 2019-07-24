using AppCheck;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppChecker
{
    public partial class Form1 : Form
    {
        Process myProcess = new Process();
        DateTime data = DateTime.UtcNow.ToLocalTime();
        int starter = 0;
        String fileName = null;

        public Form1()
        {
            InitializeComponent();
            //Console.WriteLine("Miejsce 00");
        }

        public void TlumaczStart()
        { 
           //Console.WriteLine("Miejsce 01");           
            try
            {
                //using (myProcess)
                //{
                if (starter == 0)
                {
                    //Console.WriteLine("Miejsce 02" + myProcess);
                    myProcess.StartInfo.UseShellExecute = false;
                    //myProcess.StartInfo.FileName = fileName;
                    //myProcess.StartInfo.FileName = "notepad";
                    myProcess.StartInfo.CreateNoWindow = true;
                    myProcess.Start();
                    //Process[] localByName = Process.GetProcessesByName("notepad");
                    //Boolean program = localByName[0];
                    starter++;
                    //       return myProcess;
                }
                //}
                //while (true)
                //{
                if (!myProcess.HasExited)
                    {
                        //Console.WriteLine("Uruchomiony Tlumacz - ");
                        //dzialanieObiekt.dzialanie("Uruchomiony Tlumacz");
                        DateTime data = DateTime.UtcNow.ToLocalTime();
                        label2.Text = "Ostatnie sprawdzenie  " + data;
                        label2.Refresh();
                    }
                    else
                    {
                    //myProcess.StartInfo.FileName = "notepad";
                    //Console.WriteLine("Nie Uruchomiony Tlumacz - ");
                    //dzialanieObiekt.dzialanie("Nie uruchomiony Tlumacz");
                    DateTime data = DateTime.UtcNow.ToLocalTime();
                    label2.Text = "Wyłączenie   " + data;
                    label2.Refresh();
                    textBox1.AppendText("\r\n" + (data.ToString("dd-MM-yyyy hh:mm:ss")));
                    myProcess.Start();
                    }
                    //Thread.Sleep(500000);
                    //Thread.Sleep(5000);
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
                //label2.Text = e.Message + fileName;
                label2.Text = "Brak pliku, wybierz właściwy plik*.exe";
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine("Miejsce 03");
            TlumaczStart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            var fileName = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    fileName = openFileDialog.SafeFileName;
                    myProcess.StartInfo.FileName = fileName;
                    label6.Text = fileName;
                    label6.Refresh();
                    //Read the contents of the file into a stream
                    //var fileStream = openFileDialog.OpenFile();

                    //using (StreamReader reader = new StreamReader(fileStream))
                    //{
                    //    fileContent = reader.ReadToEnd();
                    //}
                }
            }

            //MessageBox.Show(fileContent,"File name " + fileName + "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

            private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void OpisProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}