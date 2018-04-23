using System.Windows;
using DevExpress.Xpf.Grid;
using DXExample.DemoData;

namespace DXGrid_DisplayCustomText {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            gridControl1.DataSource = Invoice.GetData();
        }
        private void gridControl1_CustomColumnDisplayText(object sender,
                CustomColumnDisplayTextEventArgs e) {
            if (e.Column != columnProductName) return;
            if ((double)gridControl1.GetCellValue(e.RowHandle, "Discount") > 20)
                e.DisplayText = ((string)e.Value) + " (SALE)";
        }
    }
}
