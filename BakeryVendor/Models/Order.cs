using System.Collections.Generic;

namespace BakeryVendor.Models
{
  public class Order
  {
    public string Summary { get; set; }
    public string Description { get; set; }
    public string Date { get; set; }
    public string Amount { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string description)
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}

