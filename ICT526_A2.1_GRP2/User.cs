using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT526_A2._1_GRP2
{
    abstract class User
    {
        protected string Username;
        protected string Password;
        protected string Title;

        public User(string ID, string PW, string title) 
        {
            Username = ID;
            Password = PW;
            Title = title;
        
        }
              
    }

    class Staff : User
    {

        public Staff(string ID, string PW, string title) : base (ID, PW, title)
        { 
        
        }

        public void Openstaffmain() 
        {
            Salesstaffmain sstaff = new Salesstaffmain();
            sstaff.ShowDialog();
        }
    
    }

    class Admin : User
    {
        public Admin(string ID, string PW, string title) : base(ID, PW, title)
        {

        }


        public void OpenadminMain() 
        {
            AdminFunc astaff = new AdminFunc();
            astaff.ShowDialog();
        }


    }



}
