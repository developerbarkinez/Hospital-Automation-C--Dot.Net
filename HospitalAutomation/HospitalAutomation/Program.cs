using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation
{
    class Program
    {
        
       public static void LoginSection()
        {
            try
            {
                Console.WriteLine("****************Welcome To Hospital Automation V1*******************");
                ConsoleSpinner spinner = new ConsoleSpinner();
                spinner.Delay=50;
                int time = 150;
                while (true)
                {
                    
                    spinner.Turn(displayMsg: "Connected to the System.Please Wait!", sequenceCode: 3);
                    time -= 5;
                    if (time == 0)
                    {

                        WelcomeSection();
                       
                    }
                }
                void WelcomeSection()
                {
                    Console.Clear();
                    Console.WriteLine("Choose an Employee Type:");
                    Console.WriteLine("1)Admin **Press W**");
                    Console.WriteLine("2)Doctor **Press A**");
                    Console.WriteLine("3)Nurse  **Press S**");
                    Console.Write("\r\nSelect an option: ");
                    ConsoleKey choice;
                    do
                    {
                        choice = Console.ReadKey(true).Key;
                        switch (choice)
                        {
                            // 1.tuş=W
                            case ConsoleKey.W:
                                AdminManager adm_manager = new AdminManager();
                                Console.Clear();
                                Console.WriteLine("Admin's Username:");
                                string admin_username = Console.ReadLine();
                                Console.WriteLine("Admin's Password:");
                                string admin_password = Console.ReadLine();
                                adm_manager.Auth(admin_username,admin_password);
                               continue;
                            //2.tuş=A
                            case ConsoleKey.A:
                                DoctorManager doctor_manager = new DoctorManager();
                                Console.Clear();
                                Console.WriteLine("Doctor's Username:");
                                string doctor_username = Console.ReadLine();
                                Console.WriteLine("Doctor's Password:");
                                string doctor_password = Console.ReadLine();
                                doctor_manager.Auth(doctor_username, doctor_password);
                                
                                continue;
                            //2.tuş=S
                            case ConsoleKey.S:
                                NurseManager nurse_manager = new NurseManager();
                                Console.Clear();
                                Console.WriteLine("Nurse's Username");
                                string nurse_username = Console.ReadLine();
                                Console.WriteLine("Nurse's Password:");
                                string nurse_password = Console.ReadLine();
                                nurse_manager.Auth(nurse_username, nurse_password);
                                continue;
                        }
                    } while (choice != ConsoleKey.W && choice != ConsoleKey.A && choice != ConsoleKey.S);

                }
                



            }
            
            catch (ArgumentNullException)
            {
                Console.WriteLine("Boş değer girdiniz.");
            }



        }
        static void Main(string[] args)
        {

            LoginSection();
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        public static bool MainMenu()
        {
            

            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) List of Employees");
            Console.WriteLine("2) List of Employees+Dutie");
            Console.WriteLine("3) Show Single User");
            Console.WriteLine("4)List of Duties of Current Month ");
            Console.WriteLine("5)Add User ");
            Console.WriteLine("6)Modify User ");
            Console.WriteLine("8)Delete User");
            Console.WriteLine("9)Exit");


            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ListOfEmployees();
                    return true;
                case "2":
                    ListOfEmployeesDutie();
                    return true;
                case "3":
                    ShowSingleUser();
                    return true;
                case "4":
                    DutiesCurrentMonth();
                    return true;
                case "5":
                    AddUser();
                    return true;
                case "6":
                    ModifyUser();
                    return true;
                case "8":
                    DeleteUser();
                    return true;
                case "9":
                    Console.WriteLine("Exiting.. Good Bye");
                    return false;

                default:
                    return true;
            }
        }

        public static string ListOfEmployees()
        {
            AdminManager adminmanager = new AdminManager();
            NurseManager nursemanager = new NurseManager();
            DoctorManager doctormanager = new DoctorManager();
            Console.WriteLine("******All Admins on the system:*******");
            adminmanager.ListAdminWithoutDuties();
            Console.WriteLine("******All Nurses on the system:*******");
            nursemanager.ListNurseWithoutDuties();
            Console.WriteLine("******All Doctors on the system:*******");
            doctormanager.ListDoctorsWithoutDuties();
            return Console.ReadLine();
        }
        
        public static string ListOfEmployeesDutie()
        {
            AdminManager adminmanager = new AdminManager();
            NurseManager nursemanager = new NurseManager();
            DoctorManager doctormanager = new DoctorManager();
            Console.WriteLine("******All Admins on the system:*******");
            adminmanager.ListAdminWithDuties();
            Console.WriteLine("******All Nurses on the system:*******");
            nursemanager.ListNurseWithDuties();
            Console.WriteLine("******All Doctors on the system:*******");
            doctormanager.ListDoctorsWithDuties();
            return Console.ReadLine();
        }

        public static void ShowSingleUser()
         {
            Console.Clear();
            Console.WriteLine("Show single user the Choose Employee Type:");
            Console.WriteLine("1)Admin **Press A**");
            Console.WriteLine("2)Doctor **Press D**");
            Console.WriteLine("3)Nurse  **Press N**");
            Console.Write("\r\nSelect an option: ");
            ConsoleKey choice;
            do
            {
                choice = Console.ReadKey(true).Key;
                switch (choice)
                {
                    // 1.tuş=A
                    case ConsoleKey.A:
                        AdminManager adm_manager = new AdminManager();
                        Console.Clear();
                        Console.WriteLine("Admin's ID:");
                        string admin_id = Console.ReadLine();
                        Console.WriteLine("Admin's Username:");
                        string admin_usrname = Console.ReadLine();
                        adm_manager.ShowSingleUser(admin_id,admin_usrname);

                        continue;
                    //2.tuş=D
                    case ConsoleKey.D:
                        DoctorManager doctor_manager = new DoctorManager();
                        Console.Clear();
                        Console.WriteLine("Doctor's ID:");
                        string doctor_id = Console.ReadLine();
                        Console.WriteLine("Doctor's Username:");
                        string doctor_usrname = Console.ReadLine();
                        doctor_manager.ShowSingleUser(doctor_id, doctor_usrname);


                        continue;
                    //2.tuş=N
                    case ConsoleKey.N:
                        NurseManager nurse_manager = new NurseManager();
                        Console.Clear();
                        Console.WriteLine("Nurse's ID:");
                        string nurse_id = Console.ReadLine();
                        Console.WriteLine("Doctor's Username:");
                        string nurse_usrname = Console.ReadLine();
                        nurse_manager.ShowSingleUser(nurse_id, nurse_usrname);
                        continue;
                }
            } while (choice != ConsoleKey.A && choice != ConsoleKey.D && choice != ConsoleKey.N);
        }
        public static void DutiesCurrentMonth()
        {
            Console.Clear();
            Console.WriteLine("Duties the Choose Employee Type:");
            Console.WriteLine("1)Admin's Dutie **Press A**");
            Console.WriteLine("2)Doctor's Dutie **Press D**");
            Console.WriteLine("3)Nurse's Dutie  **Press N**");
            Console.Write("\r\nSelect an option: ");
            ConsoleKey choice;
            do
            {
                choice = Console.ReadKey(true).Key;
                switch (choice)
                {
                    // 1.tuş=D
                    case ConsoleKey.A:
                        AdminManager adm_manager = new AdminManager();
                        Console.Clear();
                        Console.WriteLine("Admin's Year:");
                        int admin_year = int.Parse(Console.ReadLine());
                        Console.WriteLine("Admin's Month :");
                        int admin_month = int.Parse(Console.ReadLine());
                        Console.WriteLine("Admin's Day:");
                        int admin_day = int.Parse(Console.ReadLine());
                        DateTime dateadmin = new DateTime(admin_year, admin_month, admin_day);
                        adm_manager.CurrentMonthDuties(dateadmin);

                        continue;
                    //2.tuş=A
                    case ConsoleKey.D:
                        DoctorManager doctor_manager = new DoctorManager();
                        Console.Clear();
                        Console.WriteLine("Doctor's Year:");
                        int doctor_year = int.Parse(Console.ReadLine());
                        Console.WriteLine("Doctor's Month :");
                        int doctor_month = int.Parse(Console.ReadLine());
                        Console.WriteLine("Doctor's Day:");
                        int doctor_day = int.Parse(Console.ReadLine());
                        DateTime datedoctor = new DateTime(doctor_year, doctor_month, doctor_day);
                        doctor_manager.CurrentMonthDuties(datedoctor);
                        continue;
                    //2.tuş=S
                    case ConsoleKey.N:
                        NurseManager nurse_manager = new NurseManager();
                        Console.Clear();
                        Console.WriteLine("Nurse's Year:");
                        int nurse_year = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nurse's Month :");
                        int nurse_month = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nurse's Day:");
                        int nurse_day = int.Parse(Console.ReadLine());
                        DateTime datenurse = new DateTime(nurse_year, nurse_month, nurse_day);
                        nurse_manager.CurrentMonthDuties(datenurse);
                        continue;
                }
            } while (choice != ConsoleKey.A && choice != ConsoleKey.D && choice != ConsoleKey.N);
        }
        public static void AddUser()
        {
            Console.Clear();
            Console.WriteLine("Search the Choose Employee Type:");
            Console.WriteLine("1)Admin Adding Management **Press A**");
            Console.WriteLine("2)Doctor Adding Management **Press D**");
            Console.WriteLine("3)Nurse Adding Management  **Press N**");
            Console.Write("\r\nSelect an option: ");
            ConsoleKey choice;
            do
            {
                choice = Console.ReadKey(true).Key;
                switch (choice)
                {
                    // 1.tuş=D
                    case ConsoleKey.A:
                        AdminManager adm_manager = new AdminManager();
                        Console.Clear();
                        Console.WriteLine(" Current Admin's ID:");
                        string admin_id= Console.ReadLine();
                        Console.WriteLine(" Current Admin's Name:");
                        string admin_name = Console.ReadLine();
                        Console.WriteLine("Current Admin's LastName:");
                        string admin_lastName = Console.ReadLine();
                        Console.WriteLine("Current Admin's UserName:");
                        string admin_Username = Console.ReadLine();
                        Console.WriteLine("Current Admin's Pesel:");
                        string admin_pesel = Console.ReadLine();
                        Console.WriteLine("Current Admin's Pass:");
                        string admin_Pass = Console.ReadLine();
                        Console.WriteLine("Current Admin's Year:");
                        int admin_year = int.Parse(Console.ReadLine());
                        Console.WriteLine("Current Admin's Month :");
                        int admin_month = int.Parse(Console.ReadLine());
                        Console.WriteLine("Current Admin's Day:");
                        int admin_day = int.Parse(Console.ReadLine());
                        DateTime dateadmin = new DateTime(admin_year, admin_month, admin_day);
                        adm_manager.AddUser(admin_id,admin_name,admin_lastName,admin_Username,admin_pesel,admin_Pass,dateadmin);

                        continue;
                    //2.tuş=A
                    case ConsoleKey.D:
                        DoctorManager doctor_manager = new DoctorManager();
                        Console.Clear();
                        Console.WriteLine(" Current Doctor's ID:");
                        string doctor_id = Console.ReadLine();
                        Console.WriteLine(" Current Doctor's Name:");
                        string doctor_name = Console.ReadLine();
                        Console.WriteLine("Current Doctor's LastName:");
                        string doctor_lastName = Console.ReadLine();
                        Console.WriteLine("Current Doctor's UserName:");
                        string doctor_Username = Console.ReadLine();
                        Console.WriteLine("Current Doctor's Pesel:");
                        string doctor_pesel = Console.ReadLine();
                        Console.WriteLine("Current Doctor's Pass:");
                        string doctor_Pass = Console.ReadLine();
                        Console.WriteLine("Current Doctor's Year:");
                        int doctor_year = int.Parse(Console.ReadLine());
                        Console.WriteLine("Current Doctor's Month :");
                        int doctor_month = int.Parse(Console.ReadLine());
                        Console.WriteLine("Current Doctor's Day:");
                        int doctor_day = int.Parse(Console.ReadLine());
                        DateTime datedoctor = new DateTime(doctor_year, doctor_month, doctor_day);
                        doctor_manager.AddUser(doctor_id, doctor_name, doctor_lastName, doctor_Username, doctor_pesel, doctor_Pass, datedoctor);



                        continue;
                    //2.tuş=S
                    case ConsoleKey.N:
                        NurseManager nurse_manager = new NurseManager();
                        Console.Clear();
                        Console.WriteLine(" Current Nurse's ID:");
                        string nurse_id = Console.ReadLine();
                        Console.WriteLine(" Current Nurse's Name:");
                        string nurse_name = Console.ReadLine();
                        Console.WriteLine("Current Nurse's LastName:");
                        string nurse_lastName = Console.ReadLine();
                        Console.WriteLine("Current Nurse's UserName:");
                        string nurse_Username = Console.ReadLine();
                        Console.WriteLine("Current Nurse's Pesel:");
                        string nurse_pesel = Console.ReadLine();
                        Console.WriteLine("Current Nurse's Pass:");
                        string nurse_Pass = Console.ReadLine();
                        Console.WriteLine("Current Nurse's Year:");
                        int nurse_year = int.Parse(Console.ReadLine());
                        Console.WriteLine("Current Nurse's Month :");
                        int nurse_month = int.Parse(Console.ReadLine());
                        Console.WriteLine("Current Nurse's Day:");
                        int nurse_day = int.Parse(Console.ReadLine());
                        DateTime datenurse = new DateTime(nurse_year, nurse_month, nurse_day);
                        nurse_manager.AddUser(nurse_id, nurse_name, nurse_lastName, nurse_Username, nurse_pesel, nurse_Pass, datenurse);


                        continue;
                }
            } while (choice != ConsoleKey.A && choice != ConsoleKey.D && choice != ConsoleKey.N);
        }
        public static void ModifyUser()
        {
            Console.Clear();
            Console.WriteLine("Search the Choose Employee Type:");
            Console.WriteLine("1)Admin Modify Management **Press A**");
            Console.WriteLine("2)Doctor Modify Management **Press D**");
            Console.WriteLine("3)Nurse Modify Management  **Press N**");
            Console.Write("\r\nSelect an option: ");
            ConsoleKey choice;
            do
            {
                choice = Console.ReadKey(true).Key;
                switch (choice)
                {
                    // 1.tuş=D
                    case ConsoleKey.A:
                        AdminManager adm_manager = new AdminManager();
                        Console.Clear();
                        Console.WriteLine(" Current Admin's ID:");
                        string admin_id = Console.ReadLine();
                        Console.WriteLine(" Current Admin's Name:");
                        string admin_name = Console.ReadLine();
                        Console.WriteLine("Current Admin's LastName:");
                        string admin_lastName = Console.ReadLine();
                        Console.WriteLine("Current Admin's UserName:");
                        string admin_Username = Console.ReadLine();
                        Console.WriteLine("Current Admin's Pesel:");
                        string admin_pesel = Console.ReadLine();
                        Console.WriteLine("Current Admin's Pass:");
                        string admin_Pass = Console.ReadLine();
                        Console.WriteLine("Current Admin's Year:");
                        int admin_year = int.Parse(Console.ReadLine());
                        Console.WriteLine("Current Admin's Month :");
                        int admin_month = int.Parse(Console.ReadLine());
                        Console.WriteLine("Current Admin's Day:");
                        int admin_day = int.Parse(Console.ReadLine());
                        DateTime dateadmin = new DateTime(admin_year, admin_month, admin_day);
                        adm_manager.ModifyUser(admin_id, admin_name, admin_lastName, admin_Username, admin_pesel, admin_Pass, dateadmin);

                        continue;
                    //2.tuş=A
                    case ConsoleKey.D:
                        DoctorManager doctor_manager = new DoctorManager();
                        Console.Clear();
                        Console.WriteLine(" Current Doctor's ID:");
                        string doctor_id = Console.ReadLine();
                        Console.WriteLine(" Current Doctor's Name:");
                        string doctor_name = Console.ReadLine();
                        Console.WriteLine("Current Doctor's LastName:");
                        string doctor_lastName = Console.ReadLine();
                        Console.WriteLine("Current Doctor's UserName:");
                        string doctor_Username = Console.ReadLine();
                        Console.WriteLine("Current Doctor's Pesel:");
                        string doctor_pesel = Console.ReadLine();
                        Console.WriteLine("Current Doctor's Pass:");
                        string doctor_Pass = Console.ReadLine();
                        Console.WriteLine("Current Doctor's Year:");
                        int doctor_year = int.Parse(Console.ReadLine());
                        Console.WriteLine("Current Doctor's Month :");
                        int doctor_month = int.Parse(Console.ReadLine());
                        Console.WriteLine("Current Doctor's Day:");
                        int doctor_day = int.Parse(Console.ReadLine());
                        DateTime datedoctor = new DateTime(doctor_year, doctor_month, doctor_day);
                        doctor_manager.ModifyUser(doctor_id, doctor_name, doctor_lastName,doctor_Username, doctor_pesel, doctor_Pass, datedoctor);



                        continue;
                    //2.tuş=S
                    case ConsoleKey.N:
                        NurseManager nurse_manager = new NurseManager();
                        Console.Clear();
                        Console.WriteLine(" Current Nurse's ID:");
                        string nurse_id = Console.ReadLine();
                        Console.WriteLine(" Current Nurse's Name:");
                        string nurse_name = Console.ReadLine();
                        Console.WriteLine("Current Nurse's LastName:");
                        string nurse_lastName = Console.ReadLine();
                        Console.WriteLine("Current Nurse's UserName:");
                        string nurse_Username = Console.ReadLine();
                        Console.WriteLine("Current Nurse's Pesel:");
                        string nurse_pesel = Console.ReadLine();
                        Console.WriteLine("Current Nurse's Pass:");
                        string nurse_Pass = Console.ReadLine();
                        Console.WriteLine("Current Nurse's Year:");
                        int nurse_year = int.Parse(Console.ReadLine());
                        Console.WriteLine("Current Nurse's Month :");
                        int nurse_month = int.Parse(Console.ReadLine());
                        Console.WriteLine("Current Nurse's Day:");
                        int nurse_day = int.Parse(Console.ReadLine());
                        DateTime datenurse = new DateTime(nurse_year, nurse_month,nurse_day);
                        nurse_manager.ModifyUser(nurse_id, nurse_name, nurse_lastName, nurse_Username, nurse_pesel, nurse_Pass, datenurse);

                        continue;
                }
            } while (choice != ConsoleKey.A && choice != ConsoleKey.D && choice != ConsoleKey.N);
        }
        public static void DeleteUser()
        {
            Console.Clear();
            Console.WriteLine("Search the Choose Employee Type:");
            Console.WriteLine("1)Admin Modify Management **Press A**");
            Console.WriteLine("2)Doctor Modify Management **Press D**");
            Console.WriteLine("3)Nurse Modify Management  **Press N**");
            Console.Write("\r\nSelect an option: ");
            ConsoleKey choice;
            do
            {
                choice = Console.ReadKey(true).Key;
                switch (choice)
                {
                    // 1.tuş=D
                    case ConsoleKey.A:
                        AdminManager adm_manager = new AdminManager();
                        Console.Clear();
                        Console.WriteLine(" Current Admin's ID:");
                        string admin_id = Console.ReadLine();
                        adm_manager.DeleteUser(admin_id);

                        continue;
                    //2.tuş=A
                    case ConsoleKey.D:
                        DoctorManager doctor_manager = new DoctorManager();
                        Console.Clear();

                        Console.WriteLine("Doctor's ID:");
                        string doctor_id = Console.ReadLine();
                        doctor_manager.DeleteUser(doctor_id);


                        continue;
                    //2.tuş=S
                    case ConsoleKey.N:
                        NurseManager nurse_manager = new NurseManager();
                        Console.Clear();

                        Console.WriteLine("Nurse's ID:");
                        string nurse_id = Console.ReadLine();
                        nurse_manager.DeleteUser(nurse_id);

                        continue;
                }
            } while (choice != ConsoleKey.A && choice != ConsoleKey.D && choice != ConsoleKey.N);
        }



    }
}
