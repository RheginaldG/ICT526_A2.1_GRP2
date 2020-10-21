using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT526_A2._1_GRP2
{
    /* ID: 1814248
     Author: Yungyeom Hwang
    Description:  Set permissions according to user .*/

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

        } //Setting Constructor of User

    }

    class Staff : User
    {

        public Staff(string ID, string PW, string title) : base (ID, PW, title)
        {

        } //Setting Constructor of Staff which User inherited

        public void Openstaffmain() 
        {
            Salesstaffmain sstaff = new Salesstaffmain();
            sstaff.ShowDialog();
        }//When this method called, "Sales staff main" Form appears 

    }

    class Admin : User
    {
        public Admin(string ID, string PW, string title) : base(ID, PW, title)
        {

        } //Setting Constructor of Admin which User inherited


        public void OpenadminMain() 
        {
            AdminFunc astaff = new AdminFunc();
            astaff.ShowDialog();
        }//When this method called, "Admin staff main" Form appears 


    }



}
