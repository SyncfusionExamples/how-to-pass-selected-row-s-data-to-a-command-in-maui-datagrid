using Syncfusion.Maui.DataGrid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DataGridMAUI
{
// ViewModel
public class ViewModel
{
    private ICommand selectionCommand;
    public ICommand SelectionCommand
    {
        get { return selectionCommand; }
        set { selectionCommand = value; }
    }
    public ViewModel()
    {
        selectionCommand = new Command<DataGridSelectionChangedEventArgs>(OnSelectionChanged);
        OrderInfoRepository orderInfoRepository = new OrderInfoRepository();
        orderInfo = orderInfoRepository.GetOrderDetails(30);
    }
    private ObservableCollection<OrderInfo> orderInfo;

    public ObservableCollection<OrderInfo> OrderInfo
    {
        get { return orderInfo; }
        set { this.orderInfo = value; }
    }
    internal void GenerateItemsSource(int count)
    {
        OrderInfoRepository order = new OrderInfoRepository();
        orderInfo = order.GetOrderDetails(count);
    }
    private void OnSelectionChanged(DataGridSelectionChangedEventArgs e)
    {
        var SelectedItem = e.AddedRows;            
    }
}
}
