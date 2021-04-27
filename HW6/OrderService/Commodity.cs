using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp {
  public class Commodity {
    public string ID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public Commodity() {
    }

    public Commodity(string iD, string name, double price) {
      ID = iD;
      Name = name;
      Price = price;
    }

    public override bool Equals(object obj) {
      var Commodity = obj as Commodity;
      return Commodity != null &&
             ID == Commodity.ID &&
             Name == Commodity.Name;
    }

    public override int GetHashCode() {
      var hashCode = 1479869798;
      hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ID);
      hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
      return hashCode;
    }
  }


}
