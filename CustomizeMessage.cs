using System.Text.RegularExpressions;

namespace SerachAndSortAlogrithms
{
    public class CustomizeMessage
    {
        public static void Customize()
        {
            var message = "Hello <<name>>, We have your fullname as <<full name>> in our system. Your contact number is 91-xxxxxxxxxx. Please, let us know in case of any clarification Thank you BridgeLabz 01/01/2016.";

            Console.WriteLine("Template : {0}",message);

            Console.Write("\nEnter Your First Name : "); var firstName = Console.ReadLine();
            Console.Write("Enter Your Last Name : "); var fullName = string.Format("{0} {1}",firstName,Console.ReadLine());
            Console.Write("Enter Your Contact Number : "); var contactNumber = Console.ReadLine();

            string[] regexSearch = { ".<name>.", ".<full name>.", "xxxxxxxxxx", "\\d\\d/\\d\\d/\\d\\d\\d\\d" };
            string[] replacements = { firstName, fullName, contactNumber, DateTime.Today.ToShortDateString() };

            for (var i =0; i < regexSearch.Length; i++)
                message = Regex.Replace(message,regexSearch[i], replacements[i]);
            
            Console.WriteLine("\nModified : {0}",message);
        }
    }
}