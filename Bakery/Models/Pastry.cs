using System;
namespace Bakery.Models
{
  public class Pastry //Class def
  {
    public int Cost { get; } //field
    public int Count { get; set; }

    
    public Pastry(int count)
    {
      Cost = 0;
      Count = count;
    }
    public int calculateCost() 
    { 
      double cost = 0;
      double decCount = Convert.ToDouble(Count);
      if(Count <= 2) 
      {
        cost += 2 * Count;
      }
      // } else if(Count % 3 == 0) 
      // {
      //   cost = Count * 3.33;
      // } else if(Count % 3 == 1) 
      // {
      //   cost = Count * 3.75;
      // } else if(Count % 3 == 2) 
      // {
      //   cost = Count * 4;
      // } 
      else 
      {
        return 0;
      }
      return Convert.ToInt32(cost);
    }
  }
}