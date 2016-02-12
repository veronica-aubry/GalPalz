using System.Collections.Generic;

namespace Contacts.Objects

{

  //contact variables//

    public class Contact
  {
      private string _name;
      private string _number;
      private string _address;
      private int _id;
      private static List<Contact> _instances = new List<Contact> {};

//Contact construtor//

  public Contact(string contactName, string contactNumber, string contactAddress)
   {
     _name = contactName;
     _number = contactNumber;
     _address = contactAddress;
     _instances.Add(this);
     _id = _instances.Count;
   }


//getters and setters for all Contact properties//

      public string GetName()
      {
      return _name;
      }

      public void SetName(string newName)
      {
        _name = newName;
      }

      public string GetNumber()
      {
      return _number;
      }

      public void SetNumber(string newNumber)
      {
        _number = newNumber;
      }

      public string GetAddress()
      {
      return _address;
      }

      public void SetAddress(string newAddress)
      {
        _address = newAddress;
      }

      public int GetId()
    {
      return _id;
    }

    public static Contact Find(string searchName)
    {
      return _instances.Find(x => x._name.Contains(searchName));
    }

    public static void ClearContact(Contact selected)
   {
      _instances.Remove(selected);

   }

//methods for all Contact objects//

     public static List<Contact> GetAllContacts()
     {
       return _instances;
     }

     public static void ClearAllContacts()
    {
      _instances.Clear();
    }

  }
}
