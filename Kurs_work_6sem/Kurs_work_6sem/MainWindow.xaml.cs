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
            VideoCard2View.DataContext = SystemInfo.VideoCard[1];
            SystemInfo.NetworkInfo = NetworkStatus.Show();
            NetworCardkView.DataContext = SystemInfo.NetworkInfo;
            SystemInfo.DisksInfo = DiskStatus.Show();
            Disc1CardView.DataContext = SystemInfo.DisksInfo[0];
            Disc2CardView.DataContext = SystemInfo.DisksInfo[1];
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

            PcView.Visibility = Visibility.Visible;
            DiscView.Visibility = Visibility.Hidden;
            LisboxPCItem.IsSelected = true;

        }
        private void ListBoxItemDiskViewShow(object sender, RoutedEventArgs e)
        {

        }
        private void ListBoxItemNetworkViewShow(object sender, RoutedEventArgs e)
        {
            PcView.Visibility = Visibility.Hidden;
            DiscView.Visibility = Visibility.Visible;
            LisboxDiscItem.IsSelected = true;
        }

        private void Person_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Создано Максимом Спасёновым для курсовой работы по ОСИС 2019\nКарта для доната: 4344-8434-2064-3322","Об авторе");
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Текущая программа позволяет просматривать основные характеристики компьютера, для начала работы нужно запустить программу, что вы уже сделали;)", "О программе");
        }
    }
}
