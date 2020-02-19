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
            this.mstpMain = new System.Windows.Forms.MenuStrip();
            this.btnTransmitter = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portuguêsBrasilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPhones = new System.Windows.Forms.TabPage();
            this.dgvPhones = new System.Windows.Forms.DataGridView();
            this.phoneID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tspListPhones = new System.Windows.Forms.ToolStrip();
            this.btnAddPhone = new System.Windows.Forms.ToolStripButton();
            this.btnDelPhone = new System.Windows.Forms.ToolStripButton();
            this.btnRenamePhone = new System.Windows.Forms.ToolStripButton();
            this.tabTemplates = new System.Windows.Forms.TabPage();
            this.dgvTemplates = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tspTemplateList = new System.Windows.Forms.ToolStrip();
            this.btnAddTemplate = new System.Windows.Forms.ToolStripButton();
            this.btnDelTemplate = new System.Windows.Forms.ToolStripButton();
            this.btnRenameTemplate = new System.Windows.Forms.ToolStripButton();
            this.stpEditor = new System.Windows.Forms.StatusStrip();
            this.lblEditingNow = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEditingNowWhat = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabCompleteEditor = new System.Windows.Forms.TabPage();
            this.prpClass = new System.Windows.Forms.PropertyGrid();
            this.tabFastEditor = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFE_SIPHostname = new System.Windows.Forms.TextBox();
            this.lblFE_SIPHostname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.mstpMain.SuspendLayout();
            this.grpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPhones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhones)).BeginInit();
            this.tspListPhones.SuspendLayout();
            this.tabTemplates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemplates)).BeginInit();
            this.tspTemplateList.SuspendLayout();
            this.stpEditor.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabCompleteEditor.SuspendLayout();
            this.tabFastEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstpMain
            // 
            this.mstpMain.AllowMerge = false;
            this.mstpMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTransmitter,
            this.languageToolStripMenuItem,
            this.appFilesToolStripMenuItem,
            this.btnHelp});
            this.mstpMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            resources.ApplyResources(this.mstpMain, "mstpMain");
            this.mstpMain.Name = "mstpMain";
            // 
            // btnTransmitter
            // 
            this.btnTransmitter.Image = global::CiscoCP3905Configurator.Properties.Resources._001_satellite_dish;
            this.btnTransmitter.Name = "btnTransmitter";
            resources.ApplyResources(this.btnTransmitter, "btnTransmitter");
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portuguêsBrasilToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.languageToolStripMenuItem.Image = global::CiscoCP3905Configurator.Properties.Resources._005_translate;
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // portuguêsBrasilToolStripMenuItem
            // 
            this.portuguêsBrasilToolStripMenuItem.Name = "portuguêsBrasilToolStripMenuItem";
            resources.ApplyResources(this.portuguêsBrasilToolStripMenuItem, "portuguêsBrasilToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            // 
            // appFilesToolStripMenuItem
            // 
            this.appFilesToolStripMenuItem.Image = global::CiscoCP3905Configurator.Properties.Resources._006_folder;
            this.appFilesToolStripMenuItem.Name = "appFilesToolStripMenuItem";
            resources.ApplyResources(this.appFilesToolStripMenuItem, "appFilesToolStripMenuItem");
            // 
            // btnHelp
            // 
            this.btnHelp.Image = global::CiscoCP3905Configurator.Properties.Resources._002_lifebuoy;
            this.btnHelp.Name = "btnHelp";
            resources.ApplyResources(this.btnHelp, "btnHelp");
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
            this.splitContainer1.Panel2.Controls.Add(this.stpEditor);
            this.splitContainer1.Panel2.Controls.Add(this.tabMain);
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
            this.tabPhones.Controls.Add(this.dgvPhones);
            this.tabPhones.Controls.Add(this.tspListPhones);
            resources.ApplyResources(this.tabPhones, "tabPhones");
            this.tabPhones.Name = "tabPhones";
            this.tabPhones.UseVisualStyleBackColor = true;
            // 
            // dgvPhones
            // 
            this.dgvPhones.AllowUserToAddRows = false;
            this.dgvPhones.AllowUserToDeleteRows = false;
            this.dgvPhones.AllowUserToResizeRows = false;
            this.dgvPhones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phoneID,
            this.phoneDesc});
            resources.ApplyResources(this.dgvPhones, "dgvPhones");
            this.dgvPhones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPhones.Name = "dgvPhones";
            this.dgvPhones.ReadOnly = true;
            this.dgvPhones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPhones.RowHeadersVisible = false;
            this.dgvPhones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhones_CellDoubleClick);
            // 
            // phoneID
            // 
            resources.ApplyResources(this.phoneID, "phoneID");
            this.phoneID.Name = "phoneID";
            this.phoneID.ReadOnly = true;
            // 
            // phoneDesc
            // 
            resources.ApplyResources(this.phoneDesc, "phoneDesc");
            this.phoneDesc.Name = "phoneDesc";
            this.phoneDesc.ReadOnly = true;
            // 
            // tspListPhones
            // 
            this.tspListPhones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspListPhones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddPhone,
            this.btnDelPhone,
            this.btnRenamePhone});
            resources.ApplyResources(this.tspListPhones, "tspListPhones");
            this.tspListPhones.Name = "tspListPhones";
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.Image = global::CiscoCP3905Configurator.Properties.Resources._002_plus;
            resources.ApplyResources(this.btnAddPhone, "btnAddPhone");
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Click += new System.EventHandler(this.btnAddPhone_Click);
            // 
            // btnDelPhone
            // 
            this.btnDelPhone.Image = global::CiscoCP3905Configurator.Properties.Resources._001_remove;
            resources.ApplyResources(this.btnDelPhone, "btnDelPhone");
            this.btnDelPhone.Name = "btnDelPhone";
            this.btnDelPhone.Click += new System.EventHandler(this.btnDelPhone_Click);
            // 
            // btnRenamePhone
            // 
            resources.ApplyResources(this.btnRenamePhone, "btnRenamePhone");
            this.btnRenamePhone.Name = "btnRenamePhone";
            // 
            // tabTemplates
            // 
            this.tabTemplates.Controls.Add(this.dgvTemplates);
            this.tabTemplates.Controls.Add(this.tspTemplateList);
            resources.ApplyResources(this.tabTemplates, "tabTemplates");
            this.tabTemplates.Name = "tabTemplates";
            this.tabTemplates.UseVisualStyleBackColor = true;
            // 
            // dgvTemplates
            // 
            this.dgvTemplates.AllowUserToAddRows = false;
            this.dgvTemplates.AllowUserToDeleteRows = false;
            this.dgvTemplates.AllowUserToResizeRows = false;
            this.dgvTemplates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTemplates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTemplates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemplates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            resources.ApplyResources(this.dgvTemplates, "dgvTemplates");
            this.dgvTemplates.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTemplates.Name = "dgvTemplates";
            this.dgvTemplates.ReadOnly = true;
            this.dgvTemplates.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTemplates.RowHeadersVisible = false;
            this.dgvTemplates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTemplates.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTemplates_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // tspTemplateList
            // 
            this.tspTemplateList.AllowMerge = false;
            this.tspTemplateList.CanOverflow = false;
            this.tspTemplateList.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspTemplateList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddTemplate,
            this.btnDelTemplate,
            this.btnRenameTemplate});
            resources.ApplyResources(this.tspTemplateList, "tspTemplateList");
            this.tspTemplateList.Name = "tspTemplateList";
            // 
            // btnAddTemplate
            // 
            this.btnAddTemplate.Image = global::CiscoCP3905Configurator.Properties.Resources._002_plus;
            resources.ApplyResources(this.btnAddTemplate, "btnAddTemplate");
            this.btnAddTemplate.Name = "btnAddTemplate";
            // 
            // btnDelTemplate
            // 
            this.btnDelTemplate.Image = global::CiscoCP3905Configurator.Properties.Resources._001_remove;
            resources.ApplyResources(this.btnDelTemplate, "btnDelTemplate");
            this.btnDelTemplate.Name = "btnDelTemplate";
            // 
            // btnRenameTemplate
            // 
            resources.ApplyResources(this.btnRenameTemplate, "btnRenameTemplate");
            this.btnRenameTemplate.Name = "btnRenameTemplate";
            // 
            // stpEditor
            // 
            this.stpEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEditingNow,
            this.lblEditingNowWhat});
            resources.ApplyResources(this.stpEditor, "stpEditor");
            this.stpEditor.Name = "stpEditor";
            // 
            // lblEditingNow
            // 
            this.lblEditingNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEditingNow.Name = "lblEditingNow";
            resources.ApplyResources(this.lblEditingNow, "lblEditingNow");
            this.lblEditingNow.Spring = true;
            // 
            // lblEditingNowWhat
            // 
            resources.ApplyResources(this.lblEditingNowWhat, "lblEditingNowWhat");
            this.lblEditingNowWhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblEditingNowWhat.Name = "lblEditingNowWhat";
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
            // prpClass
            // 
            resources.ApplyResources(this.prpClass, "prpClass");
            this.prpClass.Name = "prpClass";
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
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtFE_SIPHostname
            // 
            resources.ApplyResources(this.txtFE_SIPHostname, "txtFE_SIPHostname");
            this.txtFE_SIPHostname.Name = "txtFE_SIPHostname";
            // 
            // lblFE_SIPHostname
            // 
            resources.ApplyResources(this.lblFE_SIPHostname, "lblFE_SIPHostname");
            this.lblFE_SIPHostname.Name = "lblFE_SIPHostname";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Name = "label4";
            // 
            // btnSaveChanges
            // 
            resources.ApplyResources(this.btnSaveChanges, "btnSaveChanges");
            this.btnSaveChanges.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSaveChanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSaveChanges.Image = global::CiscoCP3905Configurator.Properties.Resources.floppy_disk;
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.mstpMain);
            this.MainMenuStrip = this.mstpMain;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mstpMain.ResumeLayout(false);
            this.mstpMain.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPhones.ResumeLayout(false);
            this.tabPhones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhones)).EndInit();
            this.tspListPhones.ResumeLayout(false);
            this.tspListPhones.PerformLayout();
            this.tabTemplates.ResumeLayout(false);
            this.tabTemplates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemplates)).EndInit();
            this.tspTemplateList.ResumeLayout(false);
            this.tspTemplateList.PerformLayout();
            this.stpEditor.ResumeLayout(false);
            this.stpEditor.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabCompleteEditor.ResumeLayout(false);
            this.tabFastEditor.ResumeLayout(false);
            this.tabFastEditor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstpMain;
        private System.Windows.Forms.ToolStripMenuItem btnTransmitter;
        private System.Windows.Forms.ToolStripMenuItem btnHelp;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.PropertyGrid prpClass;
        private System.Windows.Forms.SplitContainer splitContainer1;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.ToolStrip tspTemplateList;
        private System.Windows.Forms.ToolStripButton btnAddTemplate;
        private System.Windows.Forms.ToolStripButton btnDelTemplate;
        private System.Windows.Forms.DataGridView dgvPhones;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneID;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDesc;
        private System.Windows.Forms.ToolStripButton btnRenamePhone;
        private System.Windows.Forms.DataGridView dgvTemplates;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portuguêsBrasilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnRenameTemplate;
        private System.Windows.Forms.StatusStrip stpEditor;
        private System.Windows.Forms.ToolStripStatusLabel lblEditingNow;
        private System.Windows.Forms.ToolStripStatusLabel lblEditingNowWhat;
    }
}

