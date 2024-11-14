using Contancts.Repository;
using Contancts.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace Contancts
{
  public partial class FormAddOrEditContact : Form
  {
    IContactsRepository repository;
    public int contact_id = 0;
    public FormAddOrEditContact()
    {
      InitializeComponent();
      repository = new ContactsRepository();
    }

    private void FormAddOrEditContact_Load(object sender, System.EventArgs e)
    {
      if (contact_id == 0)
      {
        this.Text = "افزودن کاربر";

      }
      else
      {
        this.Text = "ویرایش کاربر";
        DataTable dt = repository.SelectById(contact_id);
        textBoxName.Text = dt.Rows[0][1].ToString();
        textBoxFamily.Text = dt.Rows[0][2].ToString();
        textBoxMobile.Text = dt.Rows[0][3].ToString();
        dateTimePickerBirthData.Value = DateTime.Parse(dt.Rows[0][4].ToString());
      }
    }

    bool ValidateInput()
    {
      if (textBoxName.Text == "")
      {
        MessageBox.Show("اطلاعات فیلد را به درستی تکمیل کنید", "نام مشتری خالی است", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return false;
      }
      else if (textBoxFamily.Text == "")
      {
        MessageBox.Show("اطلاعات فیلد را به درستی تکمیل کنید", "نام خانوادگی مشتری خالی", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return false;
      }
      else if (textBoxMobile.Text == "")
      {
        MessageBox.Show("اطلاعات فیلد را به درستی تکمیل کنید", "شماره موبایل مشتری خالی است", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return false;
      }
      return true;
    }

    private void buttonSubmitAddOrEdit_Click(object sender, System.EventArgs e)
    {
      if (ValidateInput())
      {
        bool isSuccess = true;
        if (contact_id == 0)
        {
          isSuccess = repository.InsertContacts(textBoxName.Text, textBoxFamily.Text, textBoxMobile.Text, dateTimePickerBirthData.Value);
        }
        else
        {
          isSuccess = repository.UpdateContacts(contact_id, textBoxName.Text, textBoxFamily.Text, textBoxMobile.Text, dateTimePickerBirthData.Value);
        }
        if (isSuccess)
        {
          MessageBox.Show("مشخصات مشتری جدید ثبت شد", "اطلاعات ثبت شد", MessageBoxButtons.OK, MessageBoxIcon.Information);
          DialogResult = DialogResult.OK;
        }
        else
        {
          MessageBox.Show("مشخصات مشتری جدید ثبت نشد", "اطلاعات ثبت نشد", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
      else
      {

      }
    }
  }
}
