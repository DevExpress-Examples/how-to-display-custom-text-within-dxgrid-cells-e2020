<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128649966/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2020)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Data Grid - How to display custom text within data cells

This example shows how to display custom text in data cells. In this example, the [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl) adds the `(SALE)` string to the **Product Name** if a value in the **Discount** column is greater than 20.

<!-- default file list -->

## Files to Look At

### Code Behind Technique

- [MainWindow.xaml](./CS/DisplayCustomText_CodeBehind/MainWindow.xaml) ([MainWindow.xaml](./VB/DisplayCustomText_CodeBehind/MainWindow.xaml))
- [MainWindow.xaml.cs](./CS/DisplayCustomText_CodeBehind/MainWindow.xaml.cs#L20-L26) ([MainWindow.xaml.vb](./VB/DisplayCustomText_CodeBehind/MainWindow.xaml.vb#L22-L29))

### MVVM Technique

- [MainWindow.xaml](./CS/DisplayCustomText_MVVM/MainWindow.xaml) ([MainWindow.xaml](./VB/DisplayCustomText_MVVM/MainWindow.xaml))
- [MainViewModel.cs](./CS/DisplayCustomText_MVVM/MainViewModel.cs#L32-L40) ([MainViewModel.vb](./VB/DisplayCustomText_MVVM/MainViewModel.vb#L76-L84))

<!-- default file list end -->

## Documentation

- [Format Cell Values](https://docs.devexpress.com/WPF/400449/controls-and-libraries/data-grid/appearance-customization/format-cell-values)
- [GridControl.CustomColumnDisplayText](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.CustomColumnDisplayText)
- [TreeListView.CustomColumnDisplayText](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.CustomColumnDisplayText)
- [GridControl.CustomColumnDisplayTextCommand](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.CustomColumnDisplayTextCommand)
- [TreeListView.CustomColumnDisplayTextCommand](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.CustomColumnDisplayTextCommand)

## More Examples

- [How to Display custom text within data cells and groups](https://github.com/DevExpress-Examples/how-to-display-custom-text-within-data-cells-and-groups-t327301)
- [How to Apply Custom Rules to Group Rows](https://github.com/DevExpress-Examples/how-to-implement-custom-grouping-e1530)
