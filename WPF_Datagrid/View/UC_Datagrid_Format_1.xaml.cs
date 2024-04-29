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

namespace WPF_Datagrid.View
{
    /// <summary>
    /// UC_Datagrid_Format_1.xaml 的交互逻辑
    /// </summary>
    public partial class UC_Datagrid_Format_1 : UserControl
    {
        public UC_Datagrid_Format_1()
        {
            InitializeComponent();

            
            
        }

        class PersonInfo
        {
            public bool IsChecked { get; set; }

            public string Name { get; set; }
            public bool IsEnabled { get; set; }


        }

        List<PersonInfo> Peoples = new List<PersonInfo>();
        private void SetPeopleInfo()
        {
            var nams =new string[] { "张三","小雪","小韩","小红","晶晶","可可"};

            foreach (var item in nams)
            {
                Peoples.Add(new PersonInfo() { Name=item,IsEnabled= Peoples.Count%2==0});
            }

            dg_1.ItemsSource = Peoples;
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            SetPeopleInfo();
        }
    }
}
