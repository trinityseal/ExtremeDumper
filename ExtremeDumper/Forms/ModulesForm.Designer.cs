namespace ExtremeDumper.Forms
{
    partial class ModulesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModulesForm));
            this.lvwModules = new System.Windows.Forms.ListView();
            this.chModuleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chModuleHandle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chModuleSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chModulePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mnuModulesContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuDumpModule = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRefreshModuleList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewFunctions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuOnlyDotNetModule = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuGotoLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdlgDumped = new System.Windows.Forms.SaveFileDialog();
            this.chDomainName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCLRVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mnuModulesContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwModules
            // 
            resources.ApplyResources(this.lvwModules, "lvwModules");
            this.lvwModules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwModules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chModuleName,
            this.chDomainName,
            this.chCLRVersion,
            this.chModuleHandle,
            this.chModuleSize,
            this.chModulePath});
            this.lvwModules.ContextMenuStrip = this.mnuModulesContext;
            this.lvwModules.FullRowSelect = true;
            this.lvwModules.Name = "lvwModules";
            this.lvwModules.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvwModules.UseCompatibleStateImageBehavior = false;
            this.lvwModules.View = System.Windows.Forms.View.Details;
            this.lvwModules.Resize += new System.EventHandler(this.lvwModules_Resize);
            // 
            // chModuleName
            // 
            resources.ApplyResources(this.chModuleName, "chModuleName");
            // 
            // chModuleHandle
            // 
            resources.ApplyResources(this.chModuleHandle, "chModuleHandle");
            // 
            // chModuleSize
            // 
            resources.ApplyResources(this.chModuleSize, "chModuleSize");
            // 
            // chModulePath
            // 
            resources.ApplyResources(this.chModulePath, "chModulePath");
            // 
            // mnuModulesContext
            // 
            resources.ApplyResources(this.mnuModulesContext, "mnuModulesContext");
            this.mnuModulesContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDumpModule,
            this.mnuRefreshModuleList,
            this.mnuViewFunctions,
            this.toolStripSeparator1,
            this.mnuOnlyDotNetModule,
            this.toolStripSeparator2,
            this.mnuGotoLocation});
            this.mnuModulesContext.Name = "mnuModulesContext";
            // 
            // mnuDumpModule
            // 
            resources.ApplyResources(this.mnuDumpModule, "mnuDumpModule");
            this.mnuDumpModule.Name = "mnuDumpModule";
            this.mnuDumpModule.Click += new System.EventHandler(this.mnuDumpModule_Click);
            // 
            // mnuRefreshModuleList
            // 
            resources.ApplyResources(this.mnuRefreshModuleList, "mnuRefreshModuleList");
            this.mnuRefreshModuleList.Name = "mnuRefreshModuleList";
            this.mnuRefreshModuleList.Click += new System.EventHandler(this.mnuRefreshModuleList_Click);
            // 
            // mnuViewFunctions
            // 
            resources.ApplyResources(this.mnuViewFunctions, "mnuViewFunctions");
            this.mnuViewFunctions.Name = "mnuViewFunctions";
            this.mnuViewFunctions.Click += new System.EventHandler(this.mnuViewFunctions_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // mnuOnlyDotNetModule
            // 
            resources.ApplyResources(this.mnuOnlyDotNetModule, "mnuOnlyDotNetModule");
            this.mnuOnlyDotNetModule.CheckOnClick = true;
            this.mnuOnlyDotNetModule.Name = "mnuOnlyDotNetModule";
            this.mnuOnlyDotNetModule.Click += new System.EventHandler(this.mnuOnlyDotNetModule_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // mnuGotoLocation
            // 
            resources.ApplyResources(this.mnuGotoLocation, "mnuGotoLocation");
            this.mnuGotoLocation.Name = "mnuGotoLocation";
            this.mnuGotoLocation.Click += new System.EventHandler(this.mnuGotoLocation_Click);
            // 
            // sfdlgDumped
            // 
            resources.ApplyResources(this.sfdlgDumped, "sfdlgDumped");
            // 
            // chDomainName
            // 
            resources.ApplyResources(this.chDomainName, "chDomainName");
            // 
            // chCLRVersion
            // 
            resources.ApplyResources(this.chCLRVersion, "chCLRVersion");
            // 
            // ModulesForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvwModules);
            this.Icon = global::ExtremeDumper.Forms.Resources.Icon;
            this.Name = "ModulesForm";
            this.mnuModulesContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwModules;
        private System.Windows.Forms.ColumnHeader chModuleName;
        private System.Windows.Forms.ColumnHeader chModuleHandle;
        private System.Windows.Forms.ColumnHeader chModuleSize;
        private System.Windows.Forms.ColumnHeader chModulePath;
        private System.Windows.Forms.SaveFileDialog sfdlgDumped;
        private System.Windows.Forms.ContextMenuStrip mnuModulesContext;
        private System.Windows.Forms.ToolStripMenuItem mnuDumpModule;
        private System.Windows.Forms.ToolStripMenuItem mnuRefreshModuleList;
        private System.Windows.Forms.ToolStripMenuItem mnuViewFunctions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuOnlyDotNetModule;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuGotoLocation;
		private System.Windows.Forms.ColumnHeader chDomainName;
		private System.Windows.Forms.ColumnHeader chCLRVersion;
	}
}
