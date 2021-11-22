using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation
{
    class DoctorManager
    {
        List<Employee> doctor = new List<Employee>();



        public void AddEmployees()
        {
            doctor.Add(new Employee()
            {
                ID = "1",
                Name = "Doctor",
                PESEL = "1234567",
                LastName = "Doctor",
                Username = "Doctor",
                Pass = "1234567",
                date = new DateTime(2021, 08, 04)

            });
        }
        public void ListDoctorsWithoutDuties()
        {


            AddEmployees();






            Console.WriteLine("Registered Doctor:" + doctor.Count());
            doctor.ForEach(employee_ex => Console.WriteLine("Doctor's name:" + employee_ex.Name));
            doctor.ForEach(employee_ex => Console.WriteLine("Doctor's Pesel:" + employee_ex.PESEL));
            doctor.ForEach(employee_ex => Console.WriteLine("Doctor's Lastname:" + employee_ex.LastName));
            doctor.ForEach(employee_ex => Console.WriteLine("Doctor's Username:" + employee_ex.Username));
            doctor.ForEach(employee_ex => Console.WriteLine("Doctor's Pass:" + employee_ex.Pass));
            //Program.LoginSection();





        }
        public void ListDoctorsWithDuties()
        {
            AddEmployees();







            Console.WriteLine("Registered Admins:" + doctor.Count());
            doctor.ForEach(employee_ex => Console.WriteLine("Doctor's name:" + employee_ex.Name));
            doctor.ForEach(employee_ex => Console.WriteLine("Doctor's Pesel:" + employee_ex.PESEL));
            doctor.ForEach(employee_ex => Console.WriteLine("Doctor's Lastname:" + employee_ex.LastName));
            doctor.ForEach(employee_ex => Console.WriteLine("Doctor's Username:" + employee_ex.Username));
            doctor.ForEach(employee_ex => Console.WriteLine("Doctor's Pass:" + employee_ex.Pass));
            doctor.ForEach(employee_ex => Console.WriteLine("Doctor's Date:" + employee_ex.date));
            //Program.LoginSection();






        }
        public void Auth(string a, string b)

        {

            AddEmployees();


            foreach (Employee admins in doctor)
            {
                if (admins.Username == a && admins.Pass == b)
                {
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

        public void ShowSingleUser(string id, string usrname)
        {

            AddEmployees();

            if (doctor.Exists(x => x.ID == id) == true)
            {
                Console.WriteLine("Found in the " + id + " .ID!" + "and Username is:" + usrname);
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
            if (doctor.Exists(x => x.date == date) == true)
            {
                Console.WriteLine("Dutie Found!" + date);
                Program.LoginSection();


            }
            else
            {
                Console.WriteLine("Your registered dutie not found our systems.");
                Program.LoginSection();
            }
        }
        public void AddUser(string admin_id, string admin_name, string admin_lastName, string admin_Username, string admin_pesel, string admin_Pass, DateTime admin_date)
        {

            AddEmployees();
            doctor.Add(new Employee()
            {
                ID = admin_id,
                Name = admin_name,
                PESEL = admin_pesel,
                LastName = admin_lastName,
                Username = admin_Username,
                Pass = admin_Pass,
                date = admin_date
            });
            Console.WriteLine(admin_Username + "User Added!");
            ListDoctorsWithDuties();


        }
        public void ModifyUser(string admin_id, string admin_name, string admin_lastName, string admin_Username, string admin_pesel, string admin_Pass, DateTime admin_date)
        {
            AddEmployees();
            if (doctor.Exists(x => x.ID == admin_id) == true)
            {
                Console.WriteLine("Found the Old ID" + admin_id);
                Console.WriteLine("New Admin ID:");
                string newAdminId = Console.ReadLine();
                int x = doctor.FindIndex(m => m.ID == admin_id);
                if (x >= 0)
                    doctor[x].ID = newAdminId;

            }
            if (doctor.Exists(x => x.Name == admin_name) == true)
            {
                Console.WriteLine("Found the Old Admin Name" + admin_name);
                Console.WriteLine("New Admin Name:");
                string newAdminName = Console.ReadLine();
                int x = doctor.FindIndex(m => m.Name == admin_name);
                if (x >= 0)
                    doctor[x].Name = newAdminName;

            }
            if (doctor.Exists(x => x.LastName == admin_lastName) == true)
            {
                Console.WriteLine("Found the Old Last Name" + admin_lastName);
                Console.WriteLine("New Admin Last Name:");
                string newAdminLastName = Console.ReadLine();
                int x = doctor.FindIndex(m => m.LastName == admin_lastName);
                if (x >= 0)
                    doctor[x].LastName = newAdminLastName;

            }
            if (doctor.Exists(x => x.Username == admin_Username) == true)
            {
                Console.WriteLine("Found the Old Username" + admin_Username);
                Console.WriteLine("New Admin Username:");
                string newAdminUsername = Console.ReadLine();
                int x =doctor.FindIndex(m => m.Username == admin_Username);
                if (x >= 0)
                    doctor[x].Username = newAdminUsername;

            }
            if (doctor.Exists(x => x.PESEL == admin_pesel) == true)
            {
                Console.WriteLine("Found the Old Pesel" + admin_pesel);
                Console.WriteLine("New Admin Pesel:");
                string newAdminPesel = Console.ReadLine();
                int x = doctor.FindIndex(m => m.PESEL == admin_pesel);
                if (x >= 0)
                    doctor[x].PESEL = newAdminPesel;

            }
            if (doctor.Exists(x => x.Pass == admin_Pass) == true)
            {
                Console.WriteLine("Found the Old Pass" + admin_pesel);
                Console.WriteLine("New Admin Pass:");
                string newAdminPass = Console.ReadLine();
                int x = doctor.FindIndex(m => m.Pass == admin_Pass);
                if (x >= 0)
                    doctor[x].Pass = newAdminPass;

            }
            if (doctor.Exists(x => x.date == admin_date) == true)
            {
                Console.WriteLine("Found the Old Dating" + admin_date);
                Console.WriteLine("New Admin Date:");
                DateTime newAdminDate = DateTime.Parse(Console.ReadLine());
                int x = doctor.FindIndex(m => m.date == admin_date);
                if (x >= 0)
                    doctor[x].date = newAdminDate;

            }
            ListDoctorsWithDuties();


        }
        public void DeleteUser(string admin_id)
        {
            AddEmployees();
            if (doctor.Exists(x => x.ID == admin_id) == true)
            {
                Console.WriteLine("Deleted user for ID!" + admin_id);
                string DeleteString = "";
                int x = doctor.FindIndex(m => m.ID == admin_id);
                if (x >= 0)
                {
                    doctor[x].ID = DeleteString;
                    doctor[x].LastName = DeleteString;
                    doctor[x].Name = DeleteString;
                    doctor[x].Pass = DeleteString;
                    doctor[x].PESEL = DeleteString;
                    doctor[x].Specializations = DeleteString;
                    doctor[x].Username = DeleteString;
                }
                ListDoctorsWithDuties();

            }

        }

    }
}
