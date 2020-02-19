namespace CiscoCP3905Configurator
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tspEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.tspPortuguese = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSetup = new System.Windows.Forms.GroupBox();
            this.lblFirmwareVersion = new System.Windows.Forms.Label();
            this.btnTransmitter = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPhoneID = new System.Windows.Forms.Label();
            this.txtFirmwareVersion = new System.Windows.Forms.ComboBox();
            this.txtPhoneID = new System.Windows.Forms.TextBox();
            this.btnGetConfig = new System.Windows.Forms.Button();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.btnSaveRun = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvXML = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.grpSetup.SuspendLayout();
            this.grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXML)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspEnglish,
            this.tspPortuguese,
            this.btnTransmitter,
            this.btnHelp,
            this.btnAbout});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // tspEnglish
            // 
            this.tspEnglish.Image = global::CiscoCP3905Configurator.Properties.Resources._001_united_kingdom;
            this.tspEnglish.Name = "tspEnglish";
            resources.ApplyResources(this.tspEnglish, "tspEnglish");
            this.tspEnglish.Click += new System.EventHandler(this.tspEnglish_Click);
            // 
            // tspPortuguese
            // 
            this.tspPortuguese.Image = global::CiscoCP3905Configurator.Properties.Resources._002_brazil;
            this.tspPortuguese.Name = "tspPortuguese";
            resources.ApplyResources(this.tspPortuguese, "tspPortuguese");
            this.tspPortuguese.Click += new System.EventHandler(this.tspPortuguese_Click);
            // 
            // grpSetup
            // 
            resources.ApplyResources(this.grpSetup, "grpSetup");
            this.grpSetup.Controls.Add(this.btnGetConfig);
            this.grpSetup.Controls.Add(this.txtPhoneID);
            this.grpSetup.Controls.Add(this.txtFirmwareVersion);
            this.grpSetup.Controls.Add(this.lblPhoneID);
            this.grpSetup.Controls.Add(this.lblFirmwareVersion);
            this.grpSetup.Name = "grpSetup";
            this.grpSetup.TabStop = false;
            // 
            // lblFirmwareVersion
            // 
            resources.ApplyResources(this.lblFirmwareVersion, "lblFirmwareVersion");
            this.lblFirmwareVersion.Name = "lblFirmwareVersion";
            // 
            // btnTransmitter
            // 
            this.btnTransmitter.Name = "btnTransmitter";
            resources.ApplyResources(this.btnTransmitter, "btnTransmitter");
            // 
            // lblPhoneID
            // 
            resources.ApplyResources(this.lblPhoneID, "lblPhoneID");
            this.lblPhoneID.Name = "lblPhoneID";
            // 
            // txtFirmwareVersion
            // 
            resources.ApplyResources(this.txtFirmwareVersion, "txtFirmwareVersion");
            this.txtFirmwareVersion.FormattingEnabled = true;
            this.txtFirmwareVersion.Name = "txtFirmwareVersion";
            // 
            // txtPhoneID
            // 
            resources.ApplyResources(this.txtPhoneID, "txtPhoneID");
            this.txtPhoneID.Name = "txtPhoneID";
            // 
            // btnGetConfig
            // 
            resources.ApplyResources(this.btnGetConfig, "btnGetConfig");
            this.btnGetConfig.Name = "btnGetConfig";
            this.btnGetConfig.UseVisualStyleBackColor = true;
            // 
            // grpOptions
            // 
            resources.ApplyResources(this.grpOptions, "grpOptions");
            this.grpOptions.Controls.Add(this.dgvXML);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.TabStop = false;
            // 
            // btnSaveRun
            // 
            resources.ApplyResources(this.btnSaveRun, "btnSaveRun");
            this.btnSaveRun.Name = "btnSaveRun";
            this.btnSaveRun.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Name = "btnHelp";
            resources.ApplyResources(this.btnHelp, "btnHelp");
            // 
            // btnAbout
            // 
            this.btnAbout.Name = "btnAbout";
            resources.ApplyResources(this.btnAbout, "btnAbout");
            // 
            // dgvXML
            // 
            this.dgvXML.AllowUserToAddRows = false;
            this.dgvXML.AllowUserToDeleteRows = false;
            this.dgvXML.AllowUserToResizeColumns = false;
            this.dgvXML.AllowUserToResizeRows = false;
            this.dgvXML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvXML, "dgvXML");
            this.dgvXML.MultiSelect = false;
            this.dgvXML.Name = "dgvXML";
            this.dgvXML.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSaveRun);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.grpSetup);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpSetup.ResumeLayout(false);
            this.grpSetup.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXML)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tspEnglish;
        private System.Windows.Forms.ToolStripMenuItem tspPortuguese;
        private System.Windows.Forms.GroupBox grpSetup;
        private System.Windows.Forms.ToolStripMenuItem btnTransmitter;
        private System.Windows.Forms.ToolStripMenuItem btnHelp;
        private System.Windows.Forms.ToolStripMenuItem btnAbout;
        private System.Windows.Forms.Button btnGetConfig;
        private System.Windows.Forms.TextBox txtPhoneID;
        private System.Windows.Forms.ComboBox txtFirmwareVersion;
        private System.Windows.Forms.Label lblPhoneID;
        private System.Windows.Forms.Label lblFirmwareVersion;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.DataGridView dgvXML;
        private System.Windows.Forms.Button btnSaveRun;
    }
}

