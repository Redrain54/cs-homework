using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    public class Customer
    {
        private long id;
        private string name;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Customer(string name, long id)
        {
            this.id = id;
            this.name = name;
        }

        public override bool Equals(object obj)
        {
            return obj is Customer customer &&
                   obj != null &&
                   Id == customer.Id;
        }

        public override int GetHashCode()
        {
            return 889810732 + Id.GetHashCode();           
        }

        public override string ToString()
        {
            return $"CustomerId : {this.Id} \t CustomerName : {this.Name}";
        }
    }
}
