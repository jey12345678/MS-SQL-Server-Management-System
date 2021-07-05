namespace MS_SQL_Management_System
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDashboardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewClientInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnDashboardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeDashboardDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardsToolStripMenuItem,
            this.addNewDashboardToolStripMenuItem,
            this.viewBookToolStripMenuItem,
            this.returnDashboardsToolStripMenuItem,
            this.completeDashboardDetailsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1129, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardsToolStripMenuItem
            // 
            this.dashboardsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDashboardToolStripMenuItem1,
            this.viewDashboardsToolStripMenuItem});
            this.dashboardsToolStripMenuItem.Name = "dashboardsToolStripMenuItem";
            this.dashboardsToolStripMenuItem.Size = new System.Drawing.Size(124, 29);
            this.dashboardsToolStripMenuItem.Text = "Dashboards";
            // 
            // addNewDashboardToolStripMenuItem
            // 
            this.addNewDashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClientToolStripMenuItem,
            this.viewClientInfoToolStripMenuItem});
            this.addNewDashboardToolStripMenuItem.Name = "addNewDashboardToolStripMenuItem";
            this.addNewDashboardToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.addNewDashboardToolStripMenuItem.Text = "Client";
            this.addNewDashboardToolStripMenuItem.Click += new System.EventHandler(this.addNewDashboardToolStripMenuItem_Click);
            // 
            // viewBookToolStripMenuItem
            // 
            this.viewBookToolStripMenuItem.Name = "viewBookToolStripMenuItem";
            this.viewBookToolStripMenuItem.Size = new System.Drawing.Size(163, 29);
            this.viewBookToolStripMenuItem.Text = "Give Dashboards";
            // 
            // addNewDashboardToolStripMenuItem1
            // 
            this.addNewDashboardToolStripMenuItem1.Name = "addNewDashboardToolStripMenuItem1";
            this.addNewDashboardToolStripMenuItem1.Size = new System.Drawing.Size(281, 34);
            this.addNewDashboardToolStripMenuItem1.Text = "Add New Dashboard";
            // 
            // viewDashboardsToolStripMenuItem
            // 
            this.viewDashboardsToolStripMenuItem.Name = "viewDashboardsToolStripMenuItem";
            this.viewDashboardsToolStripMenuItem.Size = new System.Drawing.Size(281, 34);
            this.viewDashboardsToolStripMenuItem.Text = "View Dashboards";
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addClientToolStripMenuItem.Text = "Add Client";
            // 
            // viewClientInfoToolStripMenuItem
            // 
            this.viewClientInfoToolStripMenuItem.Name = "viewClientInfoToolStripMenuItem";
            this.viewClientInfoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.viewClientInfoToolStripMenuItem.Text = "View Client Info";
            // 
            // returnDashboardsToolStripMenuItem
            // 
            this.returnDashboardsToolStripMenuItem.Name = "returnDashboardsToolStripMenuItem";
            this.returnDashboardsToolStripMenuItem.Size = new System.Drawing.Size(180, 29);
            this.returnDashboardsToolStripMenuItem.Text = "Return Dashboards";
            // 
            // completeDashboardDetailsToolStripMenuItem
            // 
            this.completeDashboardDetailsToolStripMenuItem.Name = "completeDashboardDetailsToolStripMenuItem";
            this.completeDashboardDetailsToolStripMenuItem.Size = new System.Drawing.Size(256, 29);
            this.completeDashboardDetailsToolStripMenuItem.Text = "Complete Dashboard Details";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewDashboardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewClientInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnDashboardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeDashboardDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}