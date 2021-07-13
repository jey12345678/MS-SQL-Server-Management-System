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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDashboardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewClientInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnDashboardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeDashboardDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.menuStrip1.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.menuStrip1.Size = new System.Drawing.Size(1288, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardsToolStripMenuItem
            // 
            this.dashboardsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dashboardsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDashboardToolStripMenuItem1,
            this.viewDashboardsToolStripMenuItem});
            this.dashboardsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dashboardsToolStripMenuItem.Image")));
            this.dashboardsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dashboardsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dashboardsToolStripMenuItem.Name = "dashboardsToolStripMenuItem";
            this.dashboardsToolStripMenuItem.Size = new System.Drawing.Size(184, 54);
            this.dashboardsToolStripMenuItem.Text = "Dashboards";
            // 
            // addNewDashboardToolStripMenuItem1
            // 
            this.addNewDashboardToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("addNewDashboardToolStripMenuItem1.Image")));
            this.addNewDashboardToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewDashboardToolStripMenuItem1.Name = "addNewDashboardToolStripMenuItem1";
            this.addNewDashboardToolStripMenuItem1.Size = new System.Drawing.Size(324, 60);
            this.addNewDashboardToolStripMenuItem1.Text = "Add New Dashboard";
            this.addNewDashboardToolStripMenuItem1.Click += new System.EventHandler(this.addNewDashboardToolStripMenuItem1_Click);
            // 
            // viewDashboardsToolStripMenuItem
            // 
            this.viewDashboardsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewDashboardsToolStripMenuItem.Image")));
            this.viewDashboardsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewDashboardsToolStripMenuItem.Name = "viewDashboardsToolStripMenuItem";
            this.viewDashboardsToolStripMenuItem.Size = new System.Drawing.Size(324, 60);
            this.viewDashboardsToolStripMenuItem.Text = "View Dashboards";
            // 
            // addNewDashboardToolStripMenuItem
            // 
            this.addNewDashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClientToolStripMenuItem,
            this.viewClientInfoToolStripMenuItem});
            this.addNewDashboardToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewDashboardToolStripMenuItem.Image")));
            this.addNewDashboardToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewDashboardToolStripMenuItem.Name = "addNewDashboardToolStripMenuItem";
            this.addNewDashboardToolStripMenuItem.Size = new System.Drawing.Size(124, 54);
            this.addNewDashboardToolStripMenuItem.Text = "Client";
            this.addNewDashboardToolStripMenuItem.Click += new System.EventHandler(this.addNewDashboardToolStripMenuItem_Click);
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addClientToolStripMenuItem.Image")));
            this.addClientToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(289, 60);
            this.addClientToolStripMenuItem.Text = "Add Client";
            // 
            // viewClientInfoToolStripMenuItem
            // 
            this.viewClientInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewClientInfoToolStripMenuItem.Image")));
            this.viewClientInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewClientInfoToolStripMenuItem.Name = "viewClientInfoToolStripMenuItem";
            this.viewClientInfoToolStripMenuItem.Size = new System.Drawing.Size(289, 60);
            this.viewClientInfoToolStripMenuItem.Text = "View Client Info";
            // 
            // viewBookToolStripMenuItem
            // 
            this.viewBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewBookToolStripMenuItem.Image")));
            this.viewBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewBookToolStripMenuItem.Name = "viewBookToolStripMenuItem";
            this.viewBookToolStripMenuItem.Size = new System.Drawing.Size(252, 54);
            this.viewBookToolStripMenuItem.Text = "Assign Dashboards";
            // 
            // returnDashboardsToolStripMenuItem
            // 
            this.returnDashboardsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("returnDashboardsToolStripMenuItem.Image")));
            this.returnDashboardsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.returnDashboardsToolStripMenuItem.Name = "returnDashboardsToolStripMenuItem";
            this.returnDashboardsToolStripMenuItem.Size = new System.Drawing.Size(255, 54);
            this.returnDashboardsToolStripMenuItem.Text = "Return Dashboards";
            // 
            // completeDashboardDetailsToolStripMenuItem
            // 
            this.completeDashboardDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("completeDashboardDetailsToolStripMenuItem.Image")));
            this.completeDashboardDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.completeDashboardDetailsToolStripMenuItem.Name = "completeDashboardDetailsToolStripMenuItem";
            this.completeDashboardDetailsToolStripMenuItem.Size = new System.Drawing.Size(341, 54);
            this.completeDashboardDetailsToolStripMenuItem.Text = "Complete Dashboard Details";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 54);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1288, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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