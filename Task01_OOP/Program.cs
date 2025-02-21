using System;
namespace Task01_OOP
{
    public class Program
    {
        #region Follow Q01
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        #endregion

        #region Follow Q02
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        #endregion

        #region Follow Q03
        enum Permissions
        {
            None = 0,
            Read = 1,
            Write = 2,
            Delete = 4,
            Execute = 8
        }
        #endregion

        #region Follow Q04
        enum Colors
        {
            Red,
            Green,
            Blue
        }
        #endregion
        static void Main(string[] args)
        {
            #region Q01
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
            #endregion

            #region Q02
            Console.WriteLine("Enter a season name (Spring, Summer, Autumn, Winter):");
            string input = Console.ReadLine();

            if (Enum.TryParse(input, true, out Season season))
            {
                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: From March to May");
                        break;                      
                    case Season.Summer:             
                        Console.WriteLine("Summer: From June to August");
                        break;                      
                    case Season.Autumn:             
                        Console.WriteLine("Autumn: From September to November");
                        break;                      
                    case Season.Winter:             
                        Console.WriteLine("Winter: From December to February");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid season.");
            }
            #endregion

            #region Q03
            Permissions userPermissions = Permissions.Read | Permissions.Write;

            Console.WriteLine("Current Permissions: " + userPermissions);

            // Adding a permission
            userPermissions |= Permissions.Execute;
            Console.WriteLine("Updated Permissions: " + userPermissions);

            // Removing a permission
            userPermissions &= ~Permissions.Write;
            Console.WriteLine("After Removing Write: " + userPermissions);

            // Checking if a permission exists
            if ((userPermissions & Permissions.Read) == Permissions.Read)
            {
                Console.WriteLine("Read permission exists");
            }
            else
            {
                Console.WriteLine("Read permission does not exist");
            }
            #endregion

            #region Q04
            Console.WriteLine("Enter a color name (Red, Green, Blue):");
            string input2 = Console.ReadLine();

            if (Enum.TryParse(input2, true, out Colors color))
            {
                Console.WriteLine($"{color} is a primary color.");
            }
            else
            {
                Console.WriteLine("Invalid color or not a primary color.");
            }
            #endregion
        }
    }
}
