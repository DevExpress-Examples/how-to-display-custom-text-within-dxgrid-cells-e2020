using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.Xpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DXGrid_DisplayCustomText_MVVM {
    public class Invoice {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public DateTime ShippingDate { get; set; }
        public double Discount { get; set; }
        public bool IsShipped { get; set; }
    }
    public class MainViewModel : ViewModelBase {
        public ObservableCollection<Invoice> InvoiceList { get; }

        public MainViewModel() {
            InvoiceList = new ObservableCollection<Invoice>(GetData());
        }
        IEnumerable<Invoice> GetData() {
            yield return new Invoice() { ID = 0, ProductName = "Tofu", Price = 235.54, Discount = 9.4, ShippingDate = new DateTime(2020, 3, 12), IsShipped = false };
            yield return new Invoice() { ID = 1, ProductName = "Ravioli Angelo", Price = 178.45, Discount = 6.1, ShippingDate = new DateTime(2020, 2, 9), IsShipped = true };
            yield return new Invoice() { ID = 2, ProductName = "Geitost", Price = 89.98, Discount = 5.4, ShippingDate = new DateTime(2020, 4, 1), IsShipped = false };
            yield return new Invoice() { ID = 3, ProductName = "Chang", Price = 189.33, Discount = 18.2, ShippingDate = new DateTime(2020, 5, 23), IsShipped = true };
            yield return new Invoice() { ID = 4, ProductName = "Inlagd Sill", Price = 509.10, Discount = 22.2, ShippingDate = new DateTime(2020, 6, 30), IsShipped = false };
            yield return new Invoice() { ID = 5, ProductName = "Alice Mutton", Price = 791.18, Discount = 24.4, ShippingDate = new DateTime(2020, 5, 7), IsShipped = true };
        }

        [Command]
        public void CustomColumnDisplayText(ColumnDisplayTextArgs args) {
            if(args.FieldName != nameof(Invoice.ProductName) || args.SourceIndex < 0) {
                return;
            }
            if(InvoiceList[args.SourceIndex].Discount > 20) {
                args.DisplayText += " (SALE)";
            }
        }
    }
}
