namespace GearClient
{
    partial class MainForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolstripmenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.listGear = new System.Windows.Forms.ToolStripMenuItem();
            this.listCategoryGear1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listCategoryGear = new System.Windows.Forms.ToolStripMenuItem();
            this.listBrandGear1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listBrandGear = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GearClient.Properties.Resources.gear;
            this.pictureBox1.Location = new System.Drawing.Point(0, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(817, 430);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // toolstripmenuitem
            // 
            this.toolstripmenuitem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listGear});
            this.toolstripmenuitem.Name = "toolstripmenuitem";
            this.toolstripmenuitem.Size = new System.Drawing.Size(54, 24);
            this.toolstripmenuitem.Text = "Gear";
            // 
            // listGear
            // 
            this.listGear.Name = "listGear";
            this.listGear.Size = new System.Drawing.Size(185, 26);
            this.listGear.Text = "View List Gear";
            this.listGear.Click += new System.EventHandler(this.listGear_Click);
            // 
            // listCategoryGear1
            // 
            this.listCategoryGear1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listCategoryGear});
            this.listCategoryGear1.Name = "listCategoryGear1";
            this.listCategoryGear1.Size = new System.Drawing.Size(118, 24);
            this.listCategoryGear1.Text = "Category Gear";
            // 
            // listCategoryGear
            // 
            this.listCategoryGear.Name = "listCategoryGear";
            this.listCategoryGear.Size = new System.Drawing.Size(249, 26);
            this.listCategoryGear.Text = "View List Category Gear";
            this.listCategoryGear.Click += new System.EventHandler(this.listCategoryGear_Click);
            // 
            // listBrandGear1
            // 
            this.listBrandGear1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listBrandGear});
            this.listBrandGear1.Name = "listBrandGear1";
            this.listBrandGear1.Size = new System.Drawing.Size(97, 24);
            this.listBrandGear1.Text = "Brand Gear";
            // 
            // listBrandGear
            // 
            this.listBrandGear.Name = "listBrandGear";
            this.listBrandGear.Size = new System.Drawing.Size(228, 26);
            this.listBrandGear.Text = "VIew List Brand Gear";
            this.listBrandGear.Click += new System.EventHandler(this.listBrandGear_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_logout});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // tsm_logout
            // 
            this.tsm_logout.Name = "tsm_logout";
            this.tsm_logout.Size = new System.Drawing.Size(143, 26);
            this.tsm_logout.Text = "Log out";
            this.tsm_logout.Click += new System.EventHandler(this.tsm_logout_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripmenuitem,
            this.listCategoryGear1,
            this.listBrandGear1,
            this.settingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(817, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 457);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Gear Management";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem listBrandGame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem toolstripmenuitem;
        private System.Windows.Forms.ToolStripMenuItem listGear;
        private System.Windows.Forms.ToolStripMenuItem listCategoryGear1;
        private System.Windows.Forms.ToolStripMenuItem listCategoryGear;
        private System.Windows.Forms.ToolStripMenuItem listBrandGear1;
        private System.Windows.Forms.ToolStripMenuItem listBrandGear;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_logout;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

