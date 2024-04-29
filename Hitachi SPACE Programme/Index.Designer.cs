namespace Hitachi_SPACE_Programme
{
    partial class Index
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            dataEntryControl1 = new DataEntryControl();
            menuStrip1 = new MenuStrip();
            languageToolStripMenuItem = new ToolStripMenuItem();
            englishToolStripMenuItem = new ToolStripMenuItem();
            deutschToolStripMenuItem = new ToolStripMenuItem();
            indexControl1 = new IndexControl();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataEntryControl1
            // 
            resources.ApplyResources(dataEntryControl1, "dataEntryControl1");
            dataEntryControl1.Name = "dataEntryControl1";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Items.AddRange(new ToolStripItem[] { languageToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            // 
            // languageToolStripMenuItem
            // 
            resources.ApplyResources(languageToolStripMenuItem, "languageToolStripMenuItem");
            languageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { englishToolStripMenuItem, deutschToolStripMenuItem });
            languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            languageToolStripMenuItem.Click += languageToolStripMenuItem_Click;
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(englishToolStripMenuItem, "englishToolStripMenuItem");
            englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            englishToolStripMenuItem.Click += englishToolStripMenuItem_Click;
            // 
            // deutschToolStripMenuItem
            // 
            resources.ApplyResources(deutschToolStripMenuItem, "deutschToolStripMenuItem");
            deutschToolStripMenuItem.Name = "deutschToolStripMenuItem";
            deutschToolStripMenuItem.Click += deutschToolStripMenuItem_Click;
            // 
            // indexControl1
            // 
            resources.ApplyResources(indexControl1, "indexControl1");
            indexControl1.BackColor = Color.White;
            indexControl1.Name = "indexControl1";
            // 
            // Index
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(indexControl1);
            Controls.Add(dataEntryControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Index";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataEntryControl dataEntryControl1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem languageToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        private ToolStripMenuItem deutschToolStripMenuItem;
        private IndexControl indexControl1;
    }
}