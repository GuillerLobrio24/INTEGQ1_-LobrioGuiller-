using System;


namespace KanbanAppDL
{
    public class Admin
    {
        private string adminuser;
        private string adminpass;
        public Admin(string adminuser, string adminpass)
        {
            this.adminuser = adminuser;
            this.adminpass = adminpass;
        }

        public string UserName
        {
            get { return adminuser; }
            set { adminuser = value; }
        }
        public string PassWord
        {
            get { return adminpass; }
            set { adminpass = value; }
        }
    }
}
