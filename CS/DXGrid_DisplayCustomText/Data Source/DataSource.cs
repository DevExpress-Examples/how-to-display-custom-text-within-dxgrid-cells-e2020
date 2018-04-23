using System;
using System.Collections.Generic;

namespace DXExample.DemoData {
    public class Invoice {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public DateTime ShippingDate { get; set; }
        public double Discount { get; set; }
        public bool IsShipped { get; set; }
        static public List<Invoice> GetData() {
            List<Invoice> data = new List<Invoice>();

            data.Add(new Invoice() { ID = 0, ProductName = "Tofu", Price = 235.54, Discount = 9.4, ShippingDate = new DateTime(2010, 3, 12), IsShipped = false});
            data.Add(new Invoice() { ID = 1, ProductName = "Ravioli Angelo", Price = 178.45, Discount = 6.1, ShippingDate = new DateTime(2010, 2, 9), IsShipped = true });
            data.Add(new Invoice() { ID = 2, ProductName = "Geitost", Price = 89.98, Discount = 5.4, ShippingDate = new DateTime(2010, 4, 1), IsShipped = false });
            data.Add(new Invoice() { ID = 3, ProductName = "Chang", Price = 189.33, Discount = 18.2, ShippingDate = new DateTime(2010, 5, 23), IsShipped = true });
            data.Add(new Invoice() { ID = 4, ProductName = "Inlagd Sill", Price = 509.10, Discount = 22.2, ShippingDate = new DateTime(2010, 6, 30), IsShipped = false });
            data.Add(new Invoice() { ID = 5, ProductName = "Alice Mutton", Price = 791.18, Discount = 24.4, ShippingDate = new DateTime(2010, 5, 7), IsShipped = true });

            return data;
        }
    }
}
