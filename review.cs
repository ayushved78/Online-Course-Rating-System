using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rating
{
    class review
    {
        public review(string firstname, string lastname, string email, string rev)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.rev = rev;
        }

        public string firstname {get;set;}
        public string lastname {get;set;}
        public string email {get;set;}
        public string rev {get;set;}

        public override string ToString()
        {
            return "FirstName: " + firstname + "Lastname: " + lastname + "email: " + email + "review: "+rev;
        }
    }
}