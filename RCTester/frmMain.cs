using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArgTester
{
    public partial class frmMain : Form
    {
        public string noArgs = "No arguments were passed!";
        public frmMain(string[] args)
        {
            InitializeComponent();
            InitializeApp(args);
        }

        private void InitializeApp(string[] args)
        {
            // Set application title with current timestamp
            UpdateTitle();

            // Log passed arguments
            LogArguments(args);
        }

        private void UpdateTitle()
        {
            string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            this.Text = $"ArgTester - {currentTime}";
        }

        private void LogArguments(string[] args)
        {
            if(args.Length > 0)
            {
                foreach (string arg in args)
                {
                    txtLog.AppendText($"{arg}{Environment.NewLine}");
                }
            }
            else
            {
                txtLog.AppendText($"{noArgs}{Environment.NewLine}");
            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
