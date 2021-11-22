using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation
{
    class AdminManager
    {
        List<Employee> admin = new List<Employee>();
        
           

        public void AddEmployees()
        {
            admin.Add(new Employee()
            {
                ID = "1",
                Name = "Admin",
                PESEL = "1234567",
                LastName = "Admin",
                Username = "Admin",
                Pass = "1234567",
                date=new DateTime(2021,08,04)

            });
        }
        public void ListAdminWithoutDuties()
        {


            AddEmployees();
           
                

            


            Console.WriteLine("Registered Admins:" + admin.Count());
            admin.ForEach(employee_ex => Console.WriteLine("Admin's name:" + employee_ex.Name));
            admin.ForEach(employee_ex => Console.WriteLine("Admin's Pesel:" + employee_ex.PESEL));
            admin.ForEach(employee_ex => Console.WriteLine("Admin's Lastname:" + employee_ex.LastName));
            admin.ForEach(employee_ex => Console.WriteLine("Admin's Username:" + employee_ex.Username));
            admin.ForEach(employee_ex => Console.WriteLine("Admin's Pass:" + employee_ex.Pass));
            //Program.LoginSection();





        }
        public void ListAdminWithDuties()
        {
            AddEmployees();







            Console.WriteLine("Registered Admins:" + admin.Count());
            admin.ForEach(employee_ex => Console.WriteLine("Admin's name:" + employee_ex.Name));
            admin.ForEach(employee_ex => Console.WriteLine("Admin's Pesel:" + employee_ex.PESEL));
            admin.ForEach(employee_ex => Console.WriteLine("Admin's Lastname:" + employee_ex.LastName));
            admin.ForEach(employee_ex => Console.WriteLine("Admin's Username:" + employee_ex.Username));
            admin.ForEach(employee_ex => Console.WriteLine("Admin's Pass:" + employee_ex.Pass));
            admin.ForEach(employee_ex => Console.WriteLine("Admin's Date:" + employee_ex.date));
            //Program.LoginSection();






        }
        public void Auth(string a,string b)

        {

            AddEmployees();


            foreach (Employee admins in admin)
            {
                if (admins.Username == a && admins.Pass == b) {
                    Program.MainMenu();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Bad Credentials!");
                    Program.LoginSection();
                }
                


            }
        }

        public void ShowSingleUser(string id,string usrname)
        {
            
            AddEmployees();
            
            if (admin.Exists(x => x.ID == id) == true)
            {
                Console.WriteLine("Found in the " + id + " .ID!"+"and Username is:"+usrname);
                Program.LoginSection();


            }
            else
            {
                Console.WriteLine("Your ID not found our systems.");
                Program.LoginSection();
            }
        }
        public void CurrentMonthDuties(DateTime date)
        {

            AddEmployees();
            if (admin.Exists(x => x.date == date) == true)
            {
                Console.WriteLine("Dutie Found!"+date);
                Program.LoginSection();


            }
            else
            {
                Console.WriteLine("Your registered dutie not found our systems.");
                Program.LoginSection();
            }
        }
        public void AddUser(string admin_id, string admin_name, string admin_lastName, string admin_Username,string admin_pesel, string admin_Pass,DateTime admin_date)
        {

            AddEmployees();
            admin.Add(new Employee()
            {
                ID = admin_id,
                Name = admin_name,
                PESEL = admin_pesel,
                LastName = admin_lastName,
                Username = admin_Username,
                Pass = admin_Pass,
                date = admin_date
            });
            Console.WriteLine(admin_Username+"User Added!");
            ListAdminWithDuties();
            

        }
        public void ModifyUser(string admin_id, string admin_name, string admin_lastName, string admin_Username, string admin_pesel, string admin_Pass, DateTime admin_date)
        {
            AddEmployees();
            if (admin.Exists(x => x.ID == admin_id) == true)
            {
                Console.WriteLine("Found the Old ID" + admin_id);
                Console.WriteLine("New Admin ID:");
                string newAdminId = Console.ReadLine();
                int x = admin.FindIndex(m => m.ID == admin_id);
                if (x >= 0)
                    admin[x].ID = newAdminId;

            }
           if (admin.Exists(x => x.Name == admin_name) == true)
            {
                Console.WriteLine("Found the Old Admin Name" + admin_name);
                Console.WriteLine("New Admin Name:");
                string newAdminName = Console.ReadLine();
                int x = admin.FindIndex(m => m.Name == admin_name);
                if (x >= 0)
                    admin[x].Name = newAdminName;

            }
            if (admin.Exists(x => x.LastName == admin_lastName) == true)
            {
                Console.WriteLine("Found the Old Last Name" + admin_lastName);
                Console.WriteLine("New Admin Last Name:");
                string newAdminLastName = Console.ReadLine();
                int x = admin.FindIndex(m => m.LastName== admin_lastName);
                if (x >= 0)
                    admin[x].LastName = newAdminLastName;

            }
            if (admin.Exists(x => x.Username == admin_Username) == true)
            {
                Console.WriteLine("Found the Old Username" + admin_Username);
                Console.WriteLine("New Admin Username:");
                string newAdminUsername = Console.ReadLine();
                int x = admin.FindIndex(m => m.Username== admin_Username);
                if (x >= 0)
                    admin[x].Username = newAdminUsername;

            }
            if (admin.Exists(x => x.PESEL == admin_pesel) == true)
            {
                Console.WriteLine("Found the Old Pesel" +admin_pesel );
                Console.WriteLine("New Admin Pesel:");
                string newAdminPesel = Console.ReadLine();
                int x = admin.FindIndex(m => m.PESEL== admin_pesel);
                if (x >= 0)
                    admin[x].PESEL = newAdminPesel;

            }
            if (admin.Exists(x => x.Pass == admin_Pass) == true)
            {
                Console.WriteLine("Found the Old Pass" + admin_pesel);
                Console.WriteLine("New Admin Pass:");
                string newAdminPass = Console.ReadLine();
                int x = admin.FindIndex(m => m.Pass == admin_Pass);
                if (x >= 0)
                    admin[x].Pass = newAdminPass;

            }
            if (admin.Exists(x => x.date == admin_date) == true)
            {
                Console.WriteLine("Found the Old Dating" + admin_date);
                Console.WriteLine("New Admin Date:");
                DateTime newAdminDate = DateTime.Parse(Console.ReadLine());
                int x = admin.FindIndex(m => m.date == admin_date);
                if (x >= 0)
                    admin[x].date = newAdminDate;

            }
            ListAdminWithDuties();


        }
        public void DeleteUser(string admin_id)
        {
            AddEmployees();
            if (admin.Exists(x => x.ID == admin_id) == true)
            {
                Console.WriteLine("Deleted user for ID!" + admin_id);
                string DeleteString = "";
                int x = admin.FindIndex(m => m.ID == admin_id);
                if (x >= 0) {
                    admin[x].ID = DeleteString;
                    admin[x].LastName = DeleteString;
                    admin[x].Name = DeleteString;
                    admin[x].Pass = DeleteString;
                    admin[x].PESEL = DeleteString;
                    admin[x].Specializations= DeleteString;
                    admin[x].Username = DeleteString;
              }
              ListAdminWithDuties();

            }
            
        }






    }

}

