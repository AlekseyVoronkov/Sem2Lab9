using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using NLog;

namespace CSharpLab8
{
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
        }

        public event EventHandler<EventArgs> SyncronizeDirectoriesEvent;
        string IView.SourceDirectory() { return sourceDirectoryTextBox.Text; }
        string IView.TargetDirectory() { return targetDirectoryTextBox.Text; }

        void IView.TryToSynchronize(List<string> message)
        {
            listBox.Items.Clear();

            List<string> outputList = message;

            foreach (string output in outputList)
            {
                listBox.Items.Add(output);
            }
        }


        private void Form1_Load(object sender, EventArgs inputEvent)
        {

        }

        private void buttonSynchronizeDirectories_Click(object sender, EventArgs inputEvent)
        {
            SyncronizeDirectoriesEvent(sender, inputEvent);
        }
    }
}