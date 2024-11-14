using System;
using System.Data;

namespace Contancts.Repository
{
  internal interface IContactsRepository
  {
    DataTable SelectAll();
    DataTable SelectById(int contact_id);
    bool InsertContacts(string name, string family, string mobile, DateTime birth_date);
    bool UpdateContacts(int contact_id, string name, string family, string mobile, DateTime birth_date);
    bool DeleteContacts(int contact_id);

  }
}
