
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

    Post["/contacts_cleared"] = _ => {
    Contact.ClearAllContacts();
    return View["contactsCleared.cshtml"];
    };

    //clears all contact objects//

    Get["/contact/{name}"] = parameters => {
    var selectedContact = Contact.Find(parameters.name);
    return View["contact.cshtml", selectedContact];
    };

  //generates page for specific contacts//

    Get["/contact/{name}/clear"] = parameters => {
    var selectedContact = Contact.Find(parameters.name);
    Contact.ClearContact(selectedContact);
    return View["contactCleared.cshtml"];
    };

  //deletes specific contact//


    }
  }
}
