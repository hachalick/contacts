namespace Contancts
{
  partial class FormContacts
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContacts));
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.toolStripButton1 = new System.Windows.Forms.ToolStripSplitButton();
      this.ToolStripMenuItemInsertCustomer = new System.Windows.Forms.ToolStripMenuItem();
      this.dataGridViewContacts = new System.Windows.Forms.DataGridView();
      this.groupBoxListContacts = new System.Windows.Forms.GroupBox();
      this.buttonDeleteCustomer = new System.Windows.Forms.Button();
      this.buttonUpdateCustomer = new System.Windows.Forms.Button();
      this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.family = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.birth_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.toolStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).BeginInit();
      this.groupBoxListContacts.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolStrip1
      // 
      this.toolStrip1.Font = new System.Drawing.Font("Vazirmatn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(584, 25);
      this.toolStrip1.TabIndex = 0;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // toolStripButton1
      // 
      this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemInsertCustomer});
      this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
      this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton1.Name = "toolStripButton1";
      this.toolStripButton1.Size = new System.Drawing.Size(32, 22);
      this.toolStripButton1.Text = "fg";
      // 
      // ToolStripMenuItemInsertCustomer
      // 
      this.ToolStripMenuItemInsertCustomer.Name = "ToolStripMenuItemInsertCustomer";
      this.ToolStripMenuItemInsertCustomer.Size = new System.Drawing.Size(180, 26);
      this.ToolStripMenuItemInsertCustomer.Text = "ایجاد مشتری";
      this.ToolStripMenuItemInsertCustomer.Click += new System.EventHandler(this.ToolStripMenuItemInsertCustomer_Click);
      // 
      // dataGridViewContacts
      // 
      this.dataGridViewContacts.AllowUserToAddRows = false;
      this.dataGridViewContacts.AllowUserToDeleteRows = false;
      this.dataGridViewContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridViewContacts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataGridViewContacts.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
      this.dataGridViewContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.family,
            this.mobile,
            this.birth_date});
      this.dataGridViewContacts.GridColor = System.Drawing.SystemColors.ButtonShadow;
      this.dataGridViewContacts.Location = new System.Drawing.Point(6, 30);
      this.dataGridViewContacts.Name = "dataGridViewContacts";
      this.dataGridViewContacts.ReadOnly = true;
      this.dataGridViewContacts.Size = new System.Drawing.Size(550, 201);
      this.dataGridViewContacts.TabIndex = 1;
      // 
      // groupBoxListContacts
      // 
      this.groupBoxListContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxListContacts.Controls.Add(this.buttonUpdateCustomer);
      this.groupBoxListContacts.Controls.Add(this.buttonDeleteCustomer);
      this.groupBoxListContacts.Controls.Add(this.dataGridViewContacts);
      this.groupBoxListContacts.Location = new System.Drawing.Point(10, 28);
      this.groupBoxListContacts.Name = "groupBoxListContacts";
      this.groupBoxListContacts.Size = new System.Drawing.Size(562, 273);
      this.groupBoxListContacts.TabIndex = 2;
      this.groupBoxListContacts.TabStop = false;
      this.groupBoxListContacts.Text = "نمایش مشتریان";
      // 
      // buttonDeleteCustomer
      // 
      this.buttonDeleteCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonDeleteCustomer.Location = new System.Drawing.Point(458, 237);
      this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
      this.buttonDeleteCustomer.Size = new System.Drawing.Size(98, 30);
      this.buttonDeleteCustomer.TabIndex = 2;
      this.buttonDeleteCustomer.Text = "حذف";
      this.buttonDeleteCustomer.UseVisualStyleBackColor = true;
      this.buttonDeleteCustomer.Click += new System.EventHandler(this.buttonDeleteCustomer_Click);
      // 
      // buttonUpdateCustomer
      // 
      this.buttonUpdateCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonUpdateCustomer.Location = new System.Drawing.Point(351, 237);
      this.buttonUpdateCustomer.Name = "buttonUpdateCustomer";
      this.buttonUpdateCustomer.Size = new System.Drawing.Size(101, 30);
      this.buttonUpdateCustomer.TabIndex = 2;
      this.buttonUpdateCustomer.Text = "ویرایش";
      this.buttonUpdateCustomer.UseVisualStyleBackColor = true;
      this.buttonUpdateCustomer.Click += new System.EventHandler(this.buttonUpdateCustomer_Click);
      // 
      // id
      // 
      this.id.DataPropertyName = "contact_id";
      this.id.HeaderText = "id";
      this.id.Name = "id";
      this.id.ReadOnly = true;
      this.id.Visible = false;
      // 
      // name
      // 
      this.name.DataPropertyName = "name";
      this.name.HeaderText = "نام";
      this.name.Name = "name";
      this.name.ReadOnly = true;
      // 
      // family
      // 
      this.family.DataPropertyName = "family";
      this.family.HeaderText = "نام خانوادگی";
      this.family.Name = "family";
      this.family.ReadOnly = true;
      // 
      // mobile
      // 
      this.mobile.DataPropertyName = "mobile";
      this.mobile.HeaderText = "موبایل";
      this.mobile.Name = "mobile";
      this.mobile.ReadOnly = true;
      // 
      // birth_date
      // 
      this.birth_date.DataPropertyName = "birth_date";
      this.birth_date.HeaderText = "تاریخ تولد";
      this.birth_date.Name = "birth_date";
      this.birth_date.ReadOnly = true;
      // 
      // FormContacts
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 26F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(584, 313);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.groupBoxListContacts);
      this.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
      this.MinimumSize = new System.Drawing.Size(600, 300);
      this.Name = "FormContacts";
      this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "دفترچه تلفن";
      this.Load += new System.EventHandler(this.FormContacts_Load);
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).EndInit();
      this.groupBoxListContacts.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.DataGridView dataGridViewContacts;
    private System.Windows.Forms.GroupBox groupBoxListContacts;
    private System.Windows.Forms.ToolStripSplitButton toolStripButton1;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInsertCustomer;
    private System.Windows.Forms.Button buttonDeleteCustomer;
    private System.Windows.Forms.Button buttonUpdateCustomer;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn name;
    private System.Windows.Forms.DataGridViewTextBoxColumn family;
    private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
    private System.Windows.Forms.DataGridViewTextBoxColumn birth_date;
  }
}

