using Contancts.Repository;
using Contancts.Services;
using System;
using System.Windows.Forms;

namespace Contancts
{
  public partial class FormContacts : Form
  {
    IContactsRepository repository;
    public FormContacts()
    {
      InitializeComponent();
      repository = new ContactsRepository();
    }

    private void FormContacts_Load(object sender, EventArgs e)
    {
      BindGrid();
    }

    private void BindGrid()
    {
      dataGridViewContacts.AutoGenerateColumns = false;
      dataGridViewContacts.DataSource = repository.SelectAll();
    }

    private void ToolStripMenuItemInsertCustomer_Click(object sender, EventArgs e)
    {
      FormAddOrEditContact frm = new FormAddOrEditContact();
      frm.ShowDialog();
      if (frm.DialogResult == DialogResult.OK)
      {
        BindGrid();
      }
    }

    private void buttonDeleteCustomer_Click(object sender, EventArgs e)
    {
      if (dataGridViewContacts.CurrentRow != null)
      {
        string customer_id = dataGridViewContacts.CurrentRow.Cells[0].Value.ToString();
        string name = dataGridViewContacts.CurrentRow.Cells[1].Value.ToString();
        string family = dataGridViewContacts.CurrentRow.Cells[2].Value.ToString();
        string fullName = name + " " + family;
        if (MessageBox.Show($"آیا از حذف مشتری {fullName} مطمئن هستید ؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          repository.DeleteContacts(int.Parse(customer_id));
          BindGrid();
        }
      }
    }

    private void buttonUpdateCustomer_Click(object sender, EventArgs e)
    {
      if (dataGridViewContacts.CurrentRow != null)
      {
        FormAddOrEditContact frm = new FormAddOrEditContact();
        frm.contact_id = int.Parse(dataGridViewContacts.CurrentRow.Cells[0].Value.ToString());
        frm.ShowDialog();
        if (frm.DialogResult == DialogResult.OK)
        {
          BindGrid();
        }
      }
    }
  }
}
