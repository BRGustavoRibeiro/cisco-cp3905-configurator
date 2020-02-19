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
            this.btnTransmitter = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSetup = new System.Windows.Forms.GroupBox();
            this.btnGetConfig = new System.Windows.Forms.Button();
            this.txtPhoneID = new System.Windows.Forms.TextBox();
            this.txtFirmwareVersion = new System.Windows.Forms.ComboBox();
            this.lblPhoneID = new System.Windows.Forms.Label();
            this.lblFirmwareVersion = new System.Windows.Forms.Label();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.prpClass = new System.Windows.Forms.PropertyGrid();
            this.tspListPhones = new System.Windows.Forms.ToolStrip();
            this.lstPhones = new System.Windows.Forms.ListBox();
            this.btnAddPhone = new System.Windows.Forms.ToolStripButton();
            this.btnDelPhone = new System.Windows.Forms.ToolStripButton();
            this.tspEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.tspPortuguese = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabCompleteEditor = new System.Windows.Forms.TabPage();
            this.tabFastEditor = new System.Windows.Forms.TabPage();
            this.lblFE_SIPHostname = new System.Windows.Forms.Label();
            this.txtFE_SIPHostname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPhones = new System.Windows.Forms.TabPage();
            this.tabTemplates = new System.Windows.Forms.TabPage();
            this.lstTemplates = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.grpSetup.SuspendLayout();
            this.grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tspListPhones.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabCompleteEditor.SuspendLayout();
            this.tabFastEditor.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPhones.SuspendLayout();
            this.tabTemplates.SuspendLayout();
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
            // btnTransmitter
            // 
            this.btnTransmitter.Name = "btnTransmitter";
            resources.ApplyResources(this.btnTransmitter, "btnTransmitter");
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
            // btnGetConfig
            // 
            resources.ApplyResources(this.btnGetConfig, "btnGetConfig");
            this.btnGetConfig.Name = "btnGetConfig";
            this.btnGetConfig.UseVisualStyleBackColor = true;
            this.btnGetConfig.Click += new System.EventHandler(this.btnGetConfig_Click);
            // 
            // txtPhoneID
            // 
            resources.ApplyResources(this.txtPhoneID, "txtPhoneID");
            this.txtPhoneID.Name = "txtPhoneID";
            // 
            // txtFirmwareVersion
            // 
            resources.ApplyResources(this.txtFirmwareVersion, "txtFirmwareVersion");
            this.txtFirmwareVersion.FormattingEnabled = true;
            this.txtFirmwareVersion.Name = "txtFirmwareVersion";
            // 
            // lblPhoneID
            // 
            resources.ApplyResources(this.lblPhoneID, "lblPhoneID");
            this.lblPhoneID.Name = "lblPhoneID";
            // 
            // lblFirmwareVersion
            // 
            resources.ApplyResources(this.lblFirmwareVersion, "lblFirmwareVersion");
            this.lblFirmwareVersion.Name = "lblFirmwareVersion";
            // 
            // grpOptions
            // 
            resources.ApplyResources(this.grpOptions, "grpOptions");
            this.grpOptions.Controls.Add(this.splitContainer1);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.TabStop = false;
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabMain);
            // 
            // prpClass
            // 
            resources.ApplyResources(this.prpClass, "prpClass");
            this.prpClass.Name = "prpClass";
            // 
            // tspListPhones
            // 
            this.tspListPhones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspListPhones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddPhone,
            this.btnDelPhone});
            resources.ApplyResources(this.tspListPhones, "tspListPhones");
            this.tspListPhones.Name = "tspListPhones";
            // 
            // lstPhones
            // 
            resources.ApplyResources(this.lstPhones, "lstPhones");
            this.lstPhones.FormattingEnabled = true;
            this.lstPhones.Name = "lstPhones";
            // 
            // btnAddPhone
            // 
            resources.ApplyResources(this.btnAddPhone, "btnAddPhone");
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Click += new System.EventHandler(this.btnAddPhone_Click);
            // 
            // btnDelPhone
            // 
            resources.ApplyResources(this.btnDelPhone, "btnDelPhone");
            this.btnDelPhone.Name = "btnDelPhone";
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
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabCompleteEditor);
            this.tabMain.Controls.Add(this.tabFastEditor);
            resources.ApplyResources(this.tabMain, "tabMain");
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            // 
            // tabCompleteEditor
            // 
            this.tabCompleteEditor.Controls.Add(this.prpClass);
            resources.ApplyResources(this.tabCompleteEditor, "tabCompleteEditor");
            this.tabCompleteEditor.Name = "tabCompleteEditor";
            this.tabCompleteEditor.UseVisualStyleBackColor = true;
            // 
            // tabFastEditor
            // 
            this.tabFastEditor.Controls.Add(this.label3);
            this.tabFastEditor.Controls.Add(this.label2);
            this.tabFastEditor.Controls.Add(this.textBox3);
            this.tabFastEditor.Controls.Add(this.textBox2);
            this.tabFastEditor.Controls.Add(this.textBox1);
            this.tabFastEditor.Controls.Add(this.label1);
            this.tabFastEditor.Controls.Add(this.txtFE_SIPHostname);
            this.tabFastEditor.Controls.Add(this.lblFE_SIPHostname);
            resources.ApplyResources(this.tabFastEditor, "tabFastEditor");
            this.tabFastEditor.Name = "tabFastEditor";
            this.tabFastEditor.UseVisualStyleBackColor = true;
            // 
            // lblFE_SIPHostname
            // 
            resources.ApplyResources(this.lblFE_SIPHostname, "lblFE_SIPHostname");
            this.lblFE_SIPHostname.Name = "lblFE_SIPHostname";
            // 
            // txtFE_SIPHostname
            // 
            resources.ApplyResources(this.txtFE_SIPHostname, "txtFE_SIPHostname");
            this.txtFE_SIPHostname.Name = "txtFE_SIPHostname";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPhones);
            this.tabControl1.Controls.Add(this.tabTemplates);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPhones
            // 
            this.tabPhones.Controls.Add(this.lstPhones);
            resources.ApplyResources(this.tabPhones, "tabPhones");
            this.tabPhones.Name = "tabPhones";
            this.tabPhones.UseVisualStyleBackColor = true;
            this.tabPhones.Controls.Add(this.tspListPhones);
            // 
            // tabTemplates
            // 
            this.tabTemplates.Controls.Add(this.lstTemplates);
            resources.ApplyResources(this.tabTemplates, "tabTemplates");
            this.tabTemplates.Name = "tabTemplates";
            this.tabTemplates.UseVisualStyleBackColor = true;
            // 
            // lstTemplates
            // 
            resources.ApplyResources(this.lstTemplates, "lstTemplates");
            this.lstTemplates.FormattingEnabled = true;
            this.lstTemplates.Name = "lstTemplates";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.grpSetup);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpSetup.ResumeLayout(false);
            this.grpSetup.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tspListPhones.ResumeLayout(false);
            this.tspListPhones.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabCompleteEditor.ResumeLayout(false);
            this.tabFastEditor.ResumeLayout(false);
            this.tabFastEditor.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPhones.ResumeLayout(false);
            this.tabTemplates.ResumeLayout(false);
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
        private System.Windows.Forms.PropertyGrid prpClass;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lstPhones;
        private System.Windows.Forms.ToolStrip tspListPhones;
        private System.Windows.Forms.ToolStripButton btnAddPhone;
        private System.Windows.Forms.ToolStripButton btnDelPhone;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabCompleteEditor;
        private System.Windows.Forms.TabPage tabFastEditor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFE_SIPHostname;
        private System.Windows.Forms.Label lblFE_SIPHostname;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPhones;
        private System.Windows.Forms.TabPage tabTemplates;
        private System.Windows.Forms.ListBox lstTemplates;
    }
}

