namespace GearClient
{
    partial class GearForm
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
            this.dgvGear = new System.Windows.Forms.DataGridView();
            this.grSearch = new System.Windows.Forms.GroupBox();
            this.lbl_keyword = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxBrand = new System.Windows.Forms.ComboBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbl_brand = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.grAction = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGear)).BeginInit();
            this.grSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGear
            // 
            this.dgvGear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGear.Location = new System.Drawing.Point(13, 91);
            this.dgvGear.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGear.Name = "dgvGear";
            this.dgvGear.RowHeadersWidth = 82;
            this.dgvGear.Size = new System.Drawing.Size(779, 272);
            this.dgvGear.TabIndex = 0;
            this.dgvGear.SelectionChanged += new System.EventHandler(this.dgvGear_SelectionChanged);
            // 
            // grSearch
            // 
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
            this.grSearch.Text = "Search Gear";
            // 
            // lbl_keyword
            // 
            this.lbl_keyword.AutoSize = true;
            this.lbl_keyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_keyword.Location = new System.Drawing.Point(8, 32);
            this.lbl_keyword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_keyword.Name = "lbl_keyword";
            this.lbl_keyword.Size = new System.Drawing.Size(142, 25);
            this.lbl_keyword.TabIndex = 2;
            this.lbl_keyword.Text = "Enter keyword:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(668, 27);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 40);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(158, 32);
            this.txtKeyword.Margin = new System.Windows.Forms.Padding(4);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(502, 30);
            this.txtKeyword.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxBrand);
            this.groupBox1.Controls.Add(this.cbxCategory);
            this.groupBox1.Controls.Add(this.lbl_Price);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.lbl_brand);
            this.groupBox1.Controls.Add(this.lbl_category);
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lbl_ID);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 381);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(521, 209);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail Gear";
            // 
            // cbxBrand
            // 
            this.cbxBrand.FormattingEnabled = true;
            this.cbxBrand.Location = new System.Drawing.Point(137, 130);
            this.cbxBrand.Margin = new System.Windows.Forms.Padding(2);
            this.cbxBrand.Name = "cbxBrand";
            this.cbxBrand.Size = new System.Drawing.Size(361, 28);
            this.cbxBrand.TabIndex = 12;
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(137, 98);
            this.cbxCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(361, 28);
            this.cbxCategory.TabIndex = 11;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(8, 164);
            this.lbl_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(90, 20);
            this.lbl_Price.TabIndex = 10;
            this.lbl_Price.Text = "Price Gear";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(137, 160);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(361, 26);
            this.txtPrice.TabIndex = 9;
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            this.lbl_brand.Location = new System.Drawing.Point(8, 132);
            this.lbl_brand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(101, 20);
            this.lbl_brand.TabIndex = 8;
            this.lbl_brand.Text = "Brand Gear:";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(8, 100);
            this.lbl_category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(123, 20);
            this.lbl_category.TabIndex = 6;
            this.lbl_category.Text = "Category Gear:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(8, 68);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(100, 20);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Gear Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(137, 64);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(361, 26);
            this.txtName.TabIndex = 3;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(8, 36);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(73, 20);
            this.lbl_ID.TabIndex = 2;
            this.lbl_ID.Text = "ID Gear:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(137, 32);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(361, 26);
            this.txtID.TabIndex = 0;
            // 
            // grAction
            // 
            this.grAction.Controls.Add(this.btnDelete);
            this.grAction.Controls.Add(this.btnUpdate);
            this.grAction.Controls.Add(this.btnAdd);
            this.grAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grAction.Location = new System.Drawing.Point(544, 381);
            this.grAction.Margin = new System.Windows.Forms.Padding(4);
            this.grAction.Name = "grAction";
            this.grAction.Padding = new System.Windows.Forms.Padding(4);
            this.grAction.Size = new System.Drawing.Size(249, 209);
            this.grAction.TabIndex = 4;
            this.grAction.TabStop = false;
            this.grAction.Text = "Action";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(67, 145);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 52);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(67, 81);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(138, 52);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(67, 17);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 52);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // GearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(812, 585);
            this.Controls.Add(this.grAction);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grSearch);
            this.Controls.Add(this.dgvGear);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GearForm";
            this.Text = "Gear Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GearForm_FormClosed);
            this.Load += new System.EventHandler(this.GearForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGear)).EndInit();
            this.grSearch.ResumeLayout(false);
            this.grSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGear;
        private System.Windows.Forms.GroupBox grSearch;
        private System.Windows.Forms.Label lbl_keyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbl_brand;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox grAction;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxBrand;
        private System.Windows.Forms.ComboBox cbxCategory;
    }
}