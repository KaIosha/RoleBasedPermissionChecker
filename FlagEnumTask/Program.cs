using System.Security;

namespace FlagEnumTask
{
    internal class Program
    {
        static String UserName;
        [Flags]
        enum Permissions
        { 
            Read=1,
            Insert=2,
            Update=4,
            Delete=8,

        }
        static void Main(string[] args)
        {
            Console.Write("Enter UserName:");
            UserName= Console.ReadLine();
            Console.Write("Enter Password:");
            String Password = Console.ReadLine();
            Permissions perm= CheckPermesssions(UserName, Password);
           
            Check_For_Reading_Number(perm,UserName);
        }


        static Permissions CheckPermesssions(String username, String Password) 
        {
            Console.Clear();
            Permissions permissions = Permissions.Read;
            if (username== "manager" && Password== "manager2025")
            {
                permissions |= Permissions.Insert | Permissions.Update | Permissions.Delete;
               
            }
            else if (username == "admin" && Password == "admin2025")
            {
                permissions |= Permissions.Insert | Permissions.Update;
                
            }
            else if (username == "supervise" && Password == "supervise2025")
            {
                permissions |= Permissions.Insert ;
               
            }
           
             
            Permission_Menu();
            return permissions;
        }

    
        static void Permission_Menu() 
        {
            Console.Clear();
            if (UserName=="manager"|| UserName== "admin" || UserName == "supervise")
            {
                Console.WriteLine($"\t\t>>> {UserName.ToUpper()} ACCOUNT <<<");
            }
            else
            {
                Console.WriteLine("\t\t>>> GUEST ACCOUNT <<<");
            }
                 
            Console.WriteLine("\n-------------------------------------------------\nPermission Menu:" +
                "\n1. Read\n2. Insert\n3. Update\n4. Delete\nE. Exit");
        }
        static void CleanScreen() 
        {
            Console.ResetColor();
            Console.ReadKey();
            
            Console.Clear();
            Permission_Menu();
        }

         
        static void Check_For_Reading_Number(Permissions permissions,string Username)
        {
            String number;
             
            do
            {
                


               Console.WriteLine("Choose a permission to check: ");
                  number = Console.ReadLine();


                if (number == "1")
                {
                    if ((permissions & Permissions.Read) == Permissions.Read)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have permission to: Read\r\n");
                         
                        CleanScreen();
                    }

                }    

                if (number == "2")
                {
                        if ((permissions & Permissions.Insert) == Permissions.Insert)
                        {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have permission to: Insert\r\n");
                             CleanScreen();
                         }
                        else
                        {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You do not have permission to: Insert\r\n");
                             CleanScreen();
                         }
                }

                if (number == "3")
                {
                    if ((permissions & Permissions.Update) == Permissions.Update)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have permission to: Update\r\n");
                        CleanScreen();
                    }
                   else
                   {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You do not have permission to: Update\r\n");
                        CleanScreen();
                    }
                }

                if (number == "4")
                {
                    if ((permissions & Permissions.Delete) == Permissions.Delete)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You have permission to: Delete\r\n");
                        CleanScreen();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You do not have permission to: Delete\r\n");
                         CleanScreen();
                    }
                }
            } while (!number.Equals("E", StringComparison.OrdinalIgnoreCase));
        }

    }
}
