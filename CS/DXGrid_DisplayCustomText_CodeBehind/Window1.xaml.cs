using System;
using System.Collections.Generic;
using System.Windows;
using DevExpress.Xpf.Grid;

namespace DXGrid_DisplayCustomText {
    public class Invoice {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public DateTime ShippingDate { get; set; }
        public double Discount { get; set; }
        public bool IsShipped { get; set; }
    }
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            gridControl1.ItemsSource = new List<Invoice>(GetData());
        }
        private void gridControl1_CustomColumnDisplayText(object sender,
                CustomColumnDisplayTextEventArgs e) {
            if (e.Column != columnProductName) return;
            if ((double)gridControl1.GetCellValue(e.RowHandle, "Discount") > 20)
                e.DisplayText = ((string)e.Value) + " (SALE)";
        }

        IEnumerable<Invoice> GetData() {
            yield return new Invoice() { ID = 0, ProductName = "Tofu", Price = 235.54, Discount = 9.4, ShippingDate = new DateTime(2010, 3, 12), IsShipped = false };
            yield return new Invoice() { ID = 1, ProductName = "Ravioli Angelo", Price = 178.45, Discount = 6.1, ShippingDate = new DateTime(2010, 2, 9), IsShipped = true };
            yield return new Invoice() { ID = 2, ProductName = "Geitost", Price = 89.98, Discount = 5.4, ShippingDate = new DateTime(2010, 4, 1), IsShipped = false };
            yield return new Invoice() { ID = 3, ProductName = "Chang", Price = 189.33, Discount = 18.2, ShippingDate = new DateTime(2010, 5, 23), IsShipped = true };
            yield return new Invoice() { ID = 4, ProductName = "Inlagd Sill", Price = 509.10, Discount = 22.2, ShippingDate = new DateTime(2010, 6, 30), IsShipped = false };
            yield return new Invoice() { ID = 5, ProductName = "Alice Mutton", Price = 791.18, Discount = 24.4, ShippingDate = new DateTime(2010, 5, 7), IsShipped = true };
        }
    }
}
