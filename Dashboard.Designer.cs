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
            this.dashboardsOption = new System.Windows.Forms.ToolStripMenuItem();
            this.addDashboardOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientButton = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giveDashboardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnDashboardsOption = new System.Windows.Forms.ToolStripMenuItem();
            this.completeDashboardDetailsOption = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.menuStrip1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardsOption,
            this.clientButton,
            this.giveDashboardsToolStripMenuItem,
            this.returnDashboardsOption,
            this.completeDashboardDetailsOption,
            this.exitButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1652, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardsOption
            // 
            this.dashboardsOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDashboardOption,
            this.viewDashboardToolStripMenuItem});
            this.dashboardsOption.Image = ((System.Drawing.Image)(resources.GetObject("dashboardsOption.Image")));
            this.dashboardsOption.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dashboardsOption.Name = "dashboardsOption";
            this.dashboardsOption.Size = new System.Drawing.Size(227, 54);
            this.dashboardsOption.Text = "Dashboards";
            // 
            // addDashboardOption
            // 
            this.addDashboardOption.BackColor = System.Drawing.Color.White;
            this.addDashboardOption.Image = ((System.Drawing.Image)(resources.GetObject("addDashboardOption.Image")));
            this.addDashboardOption.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addDashboardOption.Name = "addDashboardOption";
            this.addDashboardOption.Size = new System.Drawing.Size(343, 60);
            this.addDashboardOption.Text = "Add Dashboard";
            this.addDashboardOption.Click += new System.EventHandler(this.addDashboardOption_Click);
            // 
            // viewDashboardToolStripMenuItem
            // 
            this.viewDashboardToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewDashboardToolStripMenuItem.Image")));
            this.viewDashboardToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewDashboardToolStripMenuItem.Name = "viewDashboardToolStripMenuItem";
            this.viewDashboardToolStripMenuItem.Size = new System.Drawing.Size(343, 60);
            this.viewDashboardToolStripMenuItem.Text = "View Dashboard";
            // 
            // clientButton
            // 
            this.clientButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClientToolStripMenuItem});
            this.clientButton.Image = ((System.Drawing.Image)(resources.GetObject("clientButton.Image")));
            this.clientButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientButton.Name = "clientButton";
            this.clientButton.Size = new System.Drawing.Size(144, 54);
            this.clientButton.Text = "Client";
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addClientToolStripMenuItem.Image")));
            this.addClientToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(296, 60);
            this.addClientToolStripMenuItem.Text = "Add Client";
            // 
            // giveDashboardsToolStripMenuItem
            // 
            this.giveDashboardsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("giveDashboardsToolStripMenuItem.Image")));
            this.giveDashboardsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.giveDashboardsToolStripMenuItem.Name = "giveDashboardsToolStripMenuItem";
            this.giveDashboardsToolStripMenuItem.Size = new System.Drawing.Size(288, 54);
            this.giveDashboardsToolStripMenuItem.Text = "Give Dashboards";
            // 
            // returnDashboardsOption
            // 
            this.returnDashboardsOption.Image = ((System.Drawing.Image)(resources.GetObject("returnDashboardsOption.Image")));
            this.returnDashboardsOption.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.returnDashboardsOption.Name = "returnDashboardsOption";
            this.returnDashboardsOption.Size = new System.Drawing.Size(322, 54);
            this.returnDashboardsOption.Text = "Return Dashboards";
            // 
            // completeDashboardDetailsOption
            // 
            this.completeDashboardDetailsOption.Image = ((System.Drawing.Image)(resources.GetObject("completeDashboardDetailsOption.Image")));
            this.completeDashboardDetailsOption.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.completeDashboardDetailsOption.Name = "completeDashboardDetailsOption";
            this.completeDashboardDetailsOption.Size = new System.Drawing.Size(430, 54);
            this.completeDashboardDetailsOption.Text = "Complete Dashboard Details";
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(132, 54);
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1652, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
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
        private System.Windows.Forms.ToolStripMenuItem dashboardsOption;
        private System.Windows.Forms.ToolStripMenuItem clientButton;
        private System.Windows.Forms.ToolStripMenuItem giveDashboardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnDashboardsOption;
        private System.Windows.Forms.ToolStripMenuItem completeDashboardDetailsOption;
        private System.Windows.Forms.ToolStripMenuItem exitButton;
        private System.Windows.Forms.ToolStripMenuItem addDashboardOption;
        private System.Windows.Forms.ToolStripMenuItem viewDashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
    }
}