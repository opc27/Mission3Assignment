// Olivia Christensen
// 1/22/25
// Mission #3 Assignment

using System.ComponentModel.Design;
using Mission3Assignment;

Console.WriteLine("Welcome to the Food Bank Inventory System\n");

List<FoodItem> inventory = new List<FoodItem>();

int check = 1;

// while loop to ensure if invalid number is put in that the user is asked again
while (check == 1)
{
    // Ask the user what they would like to do
    Console.WriteLine(
        "Please enter a 1 if you would like to add food items.\nEnter a 2 if you would like to delete food items" +
        "\nEnter a 3 if you would like to print a list of current food items" +
        "\nEnter a 4 if you would like to exit the program");
    
    // store user input
    int userInput = int.Parse(Console.ReadLine());
    
    // if statement to determine what to do with user input
    if (userInput == 1)
    {
        // add food item
        Console.Write("Enter food item name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter food item category: ");
        string category = Console.ReadLine();
        
        Console.Write("Enter food item quantity: ");
        int quantity = int.Parse(Console.ReadLine());
        
        Console.Write("Enter expiration date (mm/dd/yyyy): ");
        DateTime expirationDate = DateTime.Parse(Console.ReadLine());
        
        FoodItem newItem = new FoodItem(name, category, quantity, expirationDate);
        inventory.Add(newItem);
        
        Console.WriteLine("Food Item added!\n");
    }
    else if (userInput == 2)
    {
        // delete item
        Console.Write("Enter the name of the food item to delete: ");
        string name = Console.ReadLine();
        
        // find the food item
        FoodItem itemRemove = inventory.Find(item => item.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        
        if (itemRemove != null)
        {
            inventory.Remove(itemRemove);
            Console.WriteLine("Food Item removed!\n");
        }
        else
        {
            Console.WriteLine("Food item not found\n");
        }
    } 
    else if (userInput == 3)
    {
        // print out list of food items
        // check to make sure there are items in the inventory
        if (inventory.Count == 0)
        {
            Console.WriteLine("There are no items in the inventory.\n");
        }
        else
        {
            Console.WriteLine("\nCurrent Food Items:\n");
            foreach (FoodItem item in inventory)
            {
                Console.WriteLine(item + "\n");
            }
        }
        
    }
    else if (userInput == 4)
    {
        // get out of loop 
        check = 2;
        
        // exit program
        Console.WriteLine("Exiting program. Goodbye!\n");
    }
    else
    {
        Console.Write("Please enter a valid number\n\n");

    }  
}


