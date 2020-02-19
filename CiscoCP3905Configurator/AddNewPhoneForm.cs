using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CiscoCP3905Configurator
{
    public partial class AddNewPhoneForm : Form
    {
        public AddNewPhoneForm()
        {
            InitializeComponent();
        }

        private void AddNewPhoneForm_Load(object sender, EventArgs e)
        {
            cmbTemplate.Items.Add("Default");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            try
            {
                if (true) { }
            }
            catch(Exception ex)
            {

            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
