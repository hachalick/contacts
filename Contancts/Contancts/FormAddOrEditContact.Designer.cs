namespace Contancts
{
  partial class FormAddOrEditContact
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddOrEditContact));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.textBoxName = new System.Windows.Forms.TextBox();
      this.textBoxFamily = new System.Windows.Forms.TextBox();
      this.textBoxMobile = new System.Windows.Forms.TextBox();
      this.dateTimePickerBirthData = new System.Windows.Forms.DateTimePicker();
      this.buttonSubmitAddOrEdit = new System.Windows.Forms.Button();
      this.labelBirthDate = new System.Windows.Forms.Label();
      this.labelMobile = new System.Windows.Forms.Label();
      this.labelFamily = new System.Windows.Forms.Label();
      this.labelName = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.textBoxName);
      this.groupBox1.Controls.Add(this.textBoxFamily);
      this.groupBox1.Controls.Add(this.textBoxMobile);
      this.groupBox1.Controls.Add(this.dateTimePickerBirthData);
      this.groupBox1.Controls.Add(this.buttonSubmitAddOrEdit);
      this.groupBox1.Controls.Add(this.labelBirthDate);
      this.groupBox1.Controls.Add(this.labelMobile);
      this.groupBox1.Controls.Add(this.labelFamily);
      this.groupBox1.Controls.Add(this.labelName);
      this.groupBox1.Location = new System.Drawing.Point(16, 14);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.groupBox1.Size = new System.Drawing.Size(306, 393);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "اطلاعات کاربر";
      // 
      // textBoxName
      // 
      this.textBoxName.Location = new System.Drawing.Point(7, 58);
      this.textBoxName.Name = "textBoxName";
      this.textBoxName.Size = new System.Drawing.Size(289, 31);
      this.textBoxName.TabIndex = 1;
      // 
      // textBoxFamily
      // 
      this.textBoxFamily.Location = new System.Drawing.Point(7, 132);
      this.textBoxFamily.Name = "textBoxFamily";
      this.textBoxFamily.Size = new System.Drawing.Size(289, 31);
      this.textBoxFamily.TabIndex = 1;
      // 
      // textBoxMobile
      // 
      this.textBoxMobile.Location = new System.Drawing.Point(7, 219);
      this.textBoxMobile.Name = "textBoxMobile";
      this.textBoxMobile.Size = new System.Drawing.Size(289, 31);
      this.textBoxMobile.TabIndex = 1;
      // 
      // dateTimePickerBirthData
      // 
      this.dateTimePickerBirthData.Location = new System.Drawing.Point(7, 298);
      this.dateTimePickerBirthData.Name = "dateTimePickerBirthData";
      this.dateTimePickerBirthData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.dateTimePickerBirthData.RightToLeftLayout = true;
      this.dateTimePickerBirthData.Size = new System.Drawing.Size(287, 31);
      this.dateTimePickerBirthData.TabIndex = 2;
      // 
      // buttonSubmitAddOrEdit
      // 
      this.buttonSubmitAddOrEdit.Location = new System.Drawing.Point(7, 349);
      this.buttonSubmitAddOrEdit.Name = "buttonSubmitAddOrEdit";
      this.buttonSubmitAddOrEdit.Size = new System.Drawing.Size(75, 34);
      this.buttonSubmitAddOrEdit.TabIndex = 3;
      this.buttonSubmitAddOrEdit.Text = "ذخیره اطلاعات";
      this.buttonSubmitAddOrEdit.UseVisualStyleBackColor = true;
      this.buttonSubmitAddOrEdit.Click += new System.EventHandler(this.buttonSubmitAddOrEdit_Click);
      // 
      // labelBirthDate
      // 
      this.labelBirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.labelBirthDate.AutoSize = true;
      this.labelBirthDate.Location = new System.Drawing.Point(230, 269);
      this.labelBirthDate.Name = "labelBirthDate";
      this.labelBirthDate.Size = new System.Drawing.Size(69, 26);
      this.labelBirthDate.TabIndex = 0;
      this.labelBirthDate.Text = "تاریخ تولد";
      // 
      // labelMobile
      // 
      this.labelMobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.labelMobile.AutoSize = true;
      this.labelMobile.Location = new System.Drawing.Point(215, 190);
      this.labelMobile.Name = "labelMobile";
      this.labelMobile.Size = new System.Drawing.Size(86, 26);
      this.labelMobile.TabIndex = 0;
      this.labelMobile.Text = "شماره همراه";
      this.labelMobile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // labelFamily
      // 
      this.labelFamily.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.labelFamily.AutoSize = true;
      this.labelFamily.Location = new System.Drawing.Point(214, 103);
      this.labelFamily.Name = "labelFamily";
      this.labelFamily.Size = new System.Drawing.Size(85, 26);
      this.labelFamily.TabIndex = 0;
      this.labelFamily.Text = "نام خانوادگی";
      this.labelFamily.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // labelName
      // 
      this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.labelName.AutoSize = true;
      this.labelName.Location = new System.Drawing.Point(270, 29);
      this.labelName.Name = "labelName";
      this.labelName.Size = new System.Drawing.Size(29, 26);
      this.labelName.TabIndex = 0;
      this.labelName.Text = "نام";
      this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // FormAddOrEditContact
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 26F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(335, 419);
      this.Controls.Add(this.groupBox1);
      this.Font = new System.Drawing.Font("Vazirmatn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "FormAddOrEditContact";
      this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "افزودن کاربر";
      this.Load += new System.EventHandler(this.FormAddOrEditContact_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox textBoxName;
    private System.Windows.Forms.Label labelBirthDate;
    private System.Windows.Forms.Label labelMobile;
    private System.Windows.Forms.Label labelFamily;
    private System.Windows.Forms.Label labelName;
    private System.Windows.Forms.TextBox textBoxFamily;
    private System.Windows.Forms.TextBox textBoxMobile;
    private System.Windows.Forms.DateTimePicker dateTimePickerBirthData;
    private System.Windows.Forms.Button buttonSubmitAddOrEdit;
  }
}