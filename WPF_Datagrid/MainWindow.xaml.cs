using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Datagrid
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void SetData()
        {
            List<UserControlListView> userControls = new List<UserControlListView>();
            userControls.Add(new UserControlListView()
            {
                Header = "样式1",
                Control = new View.UC_Datagrid_Format_1()
            }) ;
            lv_title.ItemsSource = userControls;
            lv_title.DisplayMemberPath = "Header";
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SetData();
        }
    }
}
