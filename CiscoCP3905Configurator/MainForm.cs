using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;
using System.Xml;
using System.IO;

namespace CiscoCP3905Configurator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string activeXML = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                foreach(string str in System.IO.Directory.GetFiles(Application.StartupPath + @"\server\", "*.loads"))
                {
                    txtFirmwareVersion.Items.Add(str);
                }

                if(txtFirmwareVersion.Items.Count > 0)
                {
                    txtFirmwareVersion.Text = txtFirmwareVersion.Items[0].ToString();
                }
            }
            catch(Exception ex)
            {
                //deu pau
            }
        }

        private void tspEnglish_Click(object sender, EventArgs e)
        {

        }

        private void tspPortuguese_Click(object sender, EventArgs e)
        {

        }

        DataSet dataSet = new DataSet();

        private void btnGetConfig_Click(object sender, EventArgs e)
        {
            activeXML = Application.StartupPath + @"\server\SEP" + @txtPhoneID.Text + @".cnf.xml";

            Config config = new Config();
            prpClass.SelectedObject = config;

            //dataSet.ReadXml(activeXML);
            //dgvXML.DataSource = dataSet.Tables[0];
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            new AddNewPhoneForm().ShowDialog();
        }
    }
}