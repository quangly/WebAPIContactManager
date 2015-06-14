using System;
using System.Data.Entity;

namespace ContactManager.Models
{   
    //public class ContactManagerDatabaseInitializer : DropCreateDatabaseAlways <ContactManagerContext>
    public class ContactManagerDatabaseInitializer : DropCreateDatabaseIfModelChanges <ContactManagerContext>
    {
        protected override void Seed(ContactManagerContext context)
        {
            base.Seed(context);

            foreach (var contact in SampleData.Contacts)
            {
                context.Contacts.Add(contact);
            }

        }
    }
}
