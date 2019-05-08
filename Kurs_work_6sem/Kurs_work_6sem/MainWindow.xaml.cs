using Kurs_work_6sem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Kurs_work_6sem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static SystemInfo SystemInfo = new SystemInfo();

        public MainWindow()
        {
            PCStatus.ShowSystemInfo();
            InitializeComponent();
            PcProcessorView.DataContext = SystemInfo;
            VideoCard1View.DataContext = SystemInfo.VideoCard[0];
            //PCList.DataContext = SystemInfo;
        }

        private void Button_Power_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GirdHeader_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ListBoxItemPCViewShow(object sender, RoutedEventArgs e)
        {

        }
        private void ListBoxItemDiskViewShow(object sender, RoutedEventArgs e)
        {

        }
        private void ListBoxItemNetworkViewShow(object sender, RoutedEventArgs e)
        {

        }
    }
}
