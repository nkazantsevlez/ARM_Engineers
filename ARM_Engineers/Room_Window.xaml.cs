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
using System.Windows.Shapes;

namespace ARM_Engineers
{
    /// <summary>
    /// Логика взаимодействия для Room_Window.xaml
    /// </summary>
    public partial class Room_Window : Window
    {
        arm_engineersEntities context = new arm_engineersEntities();
        public Room_Window()
        {
            InitializeComponent();

            var FilterRoom = from b in context.room where b.Name_Room != "Spisanie" select b;
            RoomList_PCRoom_ComboBox.ItemsSource = FilterRoom.ToList();
            RoomList_PeripheralsRoom_ComboBox.ItemsSource = FilterRoom.ToList();
            RoomList_PrintersRoom_ComboBox.ItemsSource = FilterRoom.ToList();
            RoomList_NetworkRoom_ComboBox.ItemsSource = FilterRoom.ToList();
            RoomList_OtherRoom_ComboBox.ItemsSource = FilterRoom.ToList();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Close_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
