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
using System.Xml.Serialization;
using System.Xml.Linq;

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
                UpdateLists();
            }
            catch(Exception ex)
            {
                //deu pau
            }
        }

        private void UpdateLists()
        {
            // Reload Registered XML
            List<Phone> listPhone = new List<Phone>();

            XmlTextReader reader = new XmlTextReader(Application.StartupPath + @"\phoneList.xml");
            int counter = 1;
            Phone tempPhone = new Phone();
            while (reader.Read())
            {
                if (counter > 2) counter = 1;

                switch (reader.NodeType)
                {
                    case XmlNodeType.Text: //Display the text in each element.
                        string currentVal = reader.Value;
                        if (counter == 1)
                        {
                            tempPhone.phoneID = reader.Value;
                        }
                        else
                        {
                            tempPhone.phoneDesc = reader.Value;
                            if (File.Exists(Application.StartupPath + @"\server\SEP" + tempPhone.phoneID + ".cnf.xml"))
                            {
                                dgvPhones.Rows.Add(tempPhone.phoneID, tempPhone.phoneDesc);
                                listPhone.Add(tempPhone);
                            }
                            tempPhone.Clear();
                        }
                        counter++;
                        break;
                }
            }

            // Find for more files that aren't registered in the XML file
            foreach (string str in Directory.GetFiles(Application.StartupPath + @"\server\", "*.cnf.xml"))
            {
                string fgd = Path.GetFileNameWithoutExtension(str).Substring(3).Split('.')[0].Split('.')[0];
                bool SamePhoneIDFoundInTable = false;

                foreach (DataGridViewRow dgrow in dgvPhones.Rows)
                {
                    if (dgrow.Cells[0].Value.ToString() == fgd)
                    {
                        SamePhoneIDFoundInTable = true;
                        break;
                    }
                }

                if(!SamePhoneIDFoundInTable)
                {
                    dgvPhones.Rows.Add(fgd, "Unnamed");
                }
            }
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            new AddNewPhoneForm().ShowDialog();

            UpdateLists();
        }

        private void dgvPhones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblEditingNow.Text = "Editing now: " + dgvPhones.Rows[e.RowIndex].Cells[0].Value.ToString() + " / " + dgvPhones.Rows[e.RowIndex].Cells[1].Value.ToString();
            lblEditingNowWhat.Text = "Phone File";
            lblEditingNowWhat.ForeColor = Color.Blue;

            activeXML = Application.StartupPath + @"\server\SEP" + dgvPhones.Rows[e.RowIndex].Cells[0].Value.ToString() + @".cnf.xml";

            Config config = new Config();
            prpClass.SelectedObject = config;

            tabMain.Enabled = true;
        }

        private void dgvTemplates_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblEditingNow.Text = "Editing now: " + dgvTemplates.Rows[e.RowIndex].Cells[0].Value.ToString();
            lblEditingNowWhat.Text = "Template File";
            lblEditingNowWhat.ForeColor = Color.Red;

            tabMain.Enabled = true;
        }

        private void btnDelPhone_Click(object sender, EventArgs e)
        {
            if(dgvPhones.SelectedRows.Count <= 0)
            {
                MessageBox.Show("You haven't selected any file. Please select a file to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                DialogResult msgBoxDelete = MessageBox.Show("Do you really want to delete this file? You will not be able to recover it or use it anymore.", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (msgBoxDelete == DialogResult.OK)
                {
                    try
                    {
                        File.Delete(Application.StartupPath + @"\server\SEP" + dgvPhones.SelectedRows[0].Cells[0].Value.ToString() + @".cnf.xml");
                        MessageBox.Show("File deleted successfully.", "File deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                    catch(Exception ex)
                    {
                        //trial error
                    }
                }
            }

            UpdateLists();
        }
    }
}