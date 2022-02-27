using System.Collections.Generic;

namespace BakeryVendor.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public int Id { get;}

    public string Description { get; set; }
    public List<Order> Orders { get; set; } 

    public Vendor(string vendorName)
    {
      Name = vendorName;
      Id = _instances.Count;
      _instances.Add(this);
      Orders = new List<Order>{};
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
    public static Vendor Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
