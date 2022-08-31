namespace GearClient
{
    partial class BrandGearForm
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
            this.dgvBrand = new System.Windows.Forms.DataGridView();
            this.grSearch = new System.Windows.Forms.GroupBox();
            this.lbl_keyword = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.grAction = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).BeginInit();
            this.grSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBrand
            // 
            this.dgvBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrand.Location = new System.Drawing.Point(14, 97);
            this.dgvBrand.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBrand.Name = "dgvBrand";
            this.dgvBrand.RowHeadersWidth = 82;
            this.dgvBrand.Size = new System.Drawing.Size(779, 260);
            this.dgvBrand.TabIndex = 0;
            this.dgvBrand.SelectionChanged += new System.EventHandler(this.dgvBrand_SelectionChanged);
            // 
            // grSearch
            // 
            this.grSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grSearch.Controls.Add(this.lbl_keyword);
            this.grSearch.Controls.Add(this.btnSearch);
            this.grSearch.Controls.Add(this.txtKeyword);
            this.grSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grSearch.Location = new System.Drawing.Point(16, 15);
            this.grSearch.Margin = new System.Windows.Forms.Padding(4);
            this.grSearch.Name = "grSearch";
            this.grSearch.Padding = new System.Windows.Forms.Padding(4);
            this.grSearch.Size = new System.Drawing.Size(777, 85);
            this.grSearch.TabIndex = 1;
            this.grSearch.TabStop = false;
            this.grSearch.Text = "Search Brand Gear";
            // 
            // lbl_keyword
            // 
            this.lbl_keyword.AutoSize = true;
            this.lbl_keyword.Location = new System.Drawing.Point(8, 36);
            this.lbl_keyword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_keyword.Name = "lbl_keyword";
            this.lbl_keyword.Size = new System.Drawing.Size(142, 25);
            this.lbl_keyword.TabIndex = 2;
            this.lbl_keyword.Text = "Enter keyword:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearch.Location = new System.Drawing.Point(668, 27);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 41);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Seach";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(173, 32);
            this.txtKeyword.Margin = new System.Windows.Forms.Padding(4);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(487, 30);
            this.txtKeyword.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lbl_ID);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 377);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(521, 172);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details Brand Gear";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(7, 118);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(127, 25);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Brand Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(195, 113);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(302, 30);
            this.txtName.TabIndex = 3;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(8, 61);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(94, 25);
            this.lbl_ID.TabIndex = 2;
            this.lbl_ID.Text = "ID Brand:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(195, 58);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(302, 30);
            this.txtID.TabIndex = 0;
            // 
            // grAction
            // 
            this.grAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grAction.Controls.Add(this.btnDelete);
            this.grAction.Controls.Add(this.btnUpdate);
            this.grAction.Controls.Add(this.btnAdd);
            this.grAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grAction.Location = new System.Drawing.Point(550, 377);
            this.grAction.Margin = new System.Windows.Forms.Padding(4);
            this.grAction.Name = "grAction";
            this.grAction.Padding = new System.Windows.Forms.Padding(4);
            this.grAction.Size = new System.Drawing.Size(249, 172);
            this.grAction.TabIndex = 4;
            this.grAction.TabStop = false;
            this.grAction.Text = "Action";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(67, 122);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 38);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(67, 77);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 38);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(67, 31);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // BrandGearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(812, 572);
            this.Controls.Add(this.grAction);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grSearch);
            this.Controls.Add(this.dgvBrand);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BrandGearForm";
            this.Text = "Brand Gear Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BrandGearForm_FormClosed);
            this.Load += new System.EventHandler(this.BrandGearForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).EndInit();
            this.grSearch.ResumeLayout(false);
            this.grSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBrand;
        private System.Windows.Forms.GroupBox grSearch;
        private System.Windows.Forms.Label lbl_keyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox grAction;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}