
using Nancy;
using Contacts.Objects;
using System.Collections.Generic;

namespace Project
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View ["index.cshtml"];
      //loads index view at root//

      Get["/add_contact"] = _ => {
      return View["addContact.cshtml"];
      };

      //takes user to contact form//

      Post["/contact_created"] = _ => {
      var newContact = new Contact(Request.Form["contact-name"], Request.Form["contact-number"], Request.Form["contact-address"] );
      return View["contactCreated.cshtml", newContact];
    };

    //creates new contact and uses it as model for contact added page//

    Get["/view_contacts"] = _ => {
    var allContacts = Contact.GetAllContacts();
    return View["viewContacts.cshtml", allContacts];
    };

    //gathers all contacts and uses list as model for page that lists all added contacts//

    Get["/contacts_cleared"] = _ => {
    Contact.ClearAllContacts();
    return View["contactsCleared.cshtml"];
    };

    //clears al contact objects//

    }

  }
}
