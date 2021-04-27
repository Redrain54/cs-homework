using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp {

  /**
   **/
  public class OrderDetail {

    public uint Index { get; set; } //序号

    public Commodity CommodityItem { get; set; }

    public String CommodityName { get => CommodityItem!=null? this.CommodityItem.Name:""; }

    public double UnitPrice { get => CommodityItem != null ? this.CommodityItem.Price : 0.0; }


    public uint Quantity { get; set; }

    public OrderDetail() { }

    public OrderDetail(uint index, Commodity Commodity, uint quantity) {
      this.Index = index;
      this.CommodityItem = Commodity;
      this.Quantity = quantity;
    }

    public double TotalPrice {
      get => CommodityItem==null?0.0: CommodityItem.Price * Quantity;
    }

    public override string ToString() {
      return $"[No.:{Index},Commodity:{CommodityName},quantity:{Quantity},totalPrice:{TotalPrice}]";
    }

    public override bool Equals(object obj) {
      var item = obj as OrderDetail;
      return item != null &&
             CommodityName == item.CommodityName;
    }

    public override int GetHashCode() {
      var hashCode = -2127770830;
      hashCode = hashCode * -1521134295 + Index.GetHashCode();
      hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CommodityName);
      hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
      return hashCode;
    }
  }
}
