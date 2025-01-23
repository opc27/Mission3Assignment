namespace Mission3Assignment;

public class FoodItem
{
    // storing the properties of added food items
    public string Name {get; set;}
    public string Category {get; set;}
    public int Quantity {get; set;}
    public DateTime ExpirationDate {get; set;}
    
    // constructor for the added food items
    public FoodItem(string name, string category, int quantity, DateTime expirationDate)
    {
        // Make sure quantity is not negative
        if (quantity < 0)
        {
            Console.WriteLine("Please enter a positive number for quantity. Setting quantity to 0.");
            quantity = 0; // Set default to 0 if quantity is negative
        }
        
        Name = name;
        Category = category;
        Quantity = quantity;
        ExpirationDate = expirationDate;
    }
    
    // override tostring to display food item details
    public override string ToString()
    {
        return $"Name: {Name}, Category: {Category}, Quantity: {Quantity}, Expires: {ExpirationDate}";
    }
}