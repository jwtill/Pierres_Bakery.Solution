namespace Bakery.Models
{
  public class Bread //Class def
  {
    public int Cost { get; } //fields
    public int Count { get; set; }

    
    
    public Bread(int count)//constructor
    {
      Cost = 0;
      Count = count;
    }
    
     //Calculate cost method
    public int calculateCost() 
    {
      int cost = 0;
      return cost;
    }
   
  }
}