using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_Lists_and_More_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<Models.User>();

            // Specify the data source.
            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" });

            // Define the query expression.
            var badPasswords = from t in users
                               where t.Password == "hello"
                               select t.Name;

            // Execute the query.
            // part 1

            Console.WriteLine("Bad Passwords:\n");
            
            foreach (var pw in badPasswords)
            {
                Console.WriteLine(pw);                
            }

            Console.WriteLine();

            //part 2
            users.RemoveAll(x => x.Password == x.Name.ToLower());

            // part 3          
            users.Remove((from a in users
                               where a.Password == "hello"
                               select a).First());

            Console.WriteLine("User Directory:\n");

            // part 4
            foreach (var a in users)
            {
                Console.WriteLine($"Name: {a.Name} \t Password: {a.Password}");
            }

            Console.ReadLine();
        }
    }
}
