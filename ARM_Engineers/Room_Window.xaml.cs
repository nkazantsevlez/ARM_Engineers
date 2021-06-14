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

            var FilterPCRoom = from b in context.pc_viewsearch where b.Name_Room == RoomData.Name_Room select b;
            var FilterPeripheralsRoom = from b in context.peripherals_view where b.Name_Room == RoomData.Name_Room select b;
            var FilterPrinersRoom = from b in context.printer_view where b.Name_Room == RoomData.Name_Room select b;
            var FilterNetworkDevicesRoom = from b in context.network_devices_view where b.Name_Room == RoomData.Name_Room select b;
            var FilterOtherDevicesRoom = from b in context.other_devices_view where b.Name_Room == RoomData.Name_Room select b;

            PC_Room_DataGrid.ItemsSource = FilterPCRoom.ToList();
            Peripherals_Room_DataGrid.ItemsSource = FilterPeripheralsRoom.ToList();
            Printers_Room_DataGrid.ItemsSource = FilterPrinersRoom.ToList();
            NetworkDevices_Room_DataGrid.ItemsSource = FilterNetworkDevicesRoom.ToList();
            OtherDevices_Room_DataGrid.ItemsSource = FilterOtherDevicesRoom.ToList();

            Heading.Text = RoomData.Name_Room;
            NumberInfo.Content = RoomData.Number_Room;
            EmployeeInfo.Content = RoomData.Surname_Employee;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Close_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void RoomList_PCRoom_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cellInfo = PC_Room_DataGrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);
            MovingDeviceData.ID_Room_Move = Convert.ToInt32(RoomList_PCRoom_ComboBox.SelectedValue.ToString());

            context.moving_pc(MovingDeviceData.Inventory_Number_Move, MovingDeviceData.ID_Room_Move);
            context.SaveChanges();

            var Event_Log_Entry = new event_log()
            {
                ID_Users = UserProgram.ID,
                DateTime = DateTime.Now.ToString(),
                Event = "Moving PC"
            };
            context.event_log.Add(Event_Log_Entry);
            context.SaveChanges();

            MessageBox.Show("Устройство успешно перемещено");

            var FilterPCRoom = from b in context.pc_viewsearch where b.Name_Room == RoomData.Name_Room select b;
            PC_Room_DataGrid.ItemsSource = FilterPCRoom.ToList();

        }

        private void RoomList_PeripheralsRoom_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cellInfo = Peripherals_Room_DataGrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);
            MovingDeviceData.ID_Room_Move = Convert.ToInt32(RoomList_PeripheralsRoom_ComboBox.SelectedValue.ToString());

            context.Moving_Peripherals(MovingDeviceData.Inventory_Number_Move, MovingDeviceData.ID_Room_Move);
            context.SaveChanges();

            var Event_Log_Entry = new event_log()
            {
                ID_Users = UserProgram.ID,
                DateTime = DateTime.Now.ToString(),
                Event = "Moving Periphery device"
            };
            context.event_log.Add(Event_Log_Entry);
            context.SaveChanges();

            MessageBox.Show("Устройство успешно перемещено");

            var FilterPeripheralsRoom = from b in context.peripherals_view where b.Name_Room == RoomData.Name_Room select b;
            Peripherals_Room_DataGrid.ItemsSource = FilterPeripheralsRoom.ToList();
        }

        private void RoomList_PrintersRoom_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cellInfo = Printers_Room_DataGrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);
            MovingDeviceData.ID_Room_Move = Convert.ToInt32(RoomList_PrintersRoom_ComboBox.SelectedValue.ToString());

            context.moving_printer(MovingDeviceData.Inventory_Number_Move, MovingDeviceData.ID_Room_Move);
            context.SaveChanges();

            var Event_Log_Entry = new event_log()
            {
                ID_Users = UserProgram.ID,
                DateTime = DateTime.Now.ToString(),
                Event = "Moving Printer"
            };
            context.event_log.Add(Event_Log_Entry);
            context.SaveChanges();

            MessageBox.Show("Устройство успешно перемещено");

            var FilterPrinersRoom = from b in context.printer_view where b.Name_Room == RoomData.Name_Room select b;
            Printers_Room_DataGrid.ItemsSource = FilterPrinersRoom.ToList();
        }

        private void RoomList_NetworkRoom_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cellInfo = NetworkDevices_Room_DataGrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);
            MovingDeviceData.ID_Room_Move = Convert.ToInt32(RoomList_NetworkRoom_ComboBox.SelectedValue.ToString());

            context.moving_NetworkDevices(MovingDeviceData.Inventory_Number_Move, MovingDeviceData.ID_Room_Move);
            context.SaveChanges();

            var Event_Log_Entry = new event_log()
            {
                ID_Users = UserProgram.ID,
                DateTime = DateTime.Now.ToString(),
                Event = "Moving Network Device"
            };
            context.event_log.Add(Event_Log_Entry);
            context.SaveChanges();

            MessageBox.Show("Устройство успешно перемещено");
            
            var FilterNetworkDevicesRoom = from b in context.network_devices_view where b.Name_Room == RoomData.Name_Room select b;    
            NetworkDevices_Room_DataGrid.ItemsSource = FilterNetworkDevicesRoom.ToList();
         }

        private void RoomList_OtherRoom_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cellInfo = OtherDevices_Room_DataGrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);
            MovingDeviceData.ID_Room_Move = Convert.ToInt32(RoomList_OtherRoom_ComboBox.SelectedValue.ToString());

            context.moving_OtherDevices(MovingDeviceData.Inventory_Number_Move, MovingDeviceData.ID_Room_Move);
            context.SaveChanges();

            var Event_Log_Entry = new event_log()
            {
                ID_Users = UserProgram.ID,
                DateTime = DateTime.Now.ToString(),
                Event = "Moving Other Device"
            };
            context.event_log.Add(Event_Log_Entry);
            context.SaveChanges();

            MessageBox.Show("Устройство успешно перемещено");

           var FilterOtherDevicesRoom = from b in context.other_devices_view where b.Name_Room == RoomData.Name_Room select b;
            OtherDevices_Room_DataGrid.ItemsSource = FilterOtherDevicesRoom.ToList();
        }

        private void PC_Sklad_Spisanie_Click(object sender, RoutedEventArgs e)
        {
            var cellInfo = PC_Room_DataGrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;
            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);

            context.moving_pc(MovingDeviceData.Inventory_Number_Move, 13);
            context.SaveChanges();

            var Event_Log_Entry = new event_log()
            {
                ID_Users = UserProgram.ID,
                DateTime = DateTime.Now.ToString(),
                Event = "PC write-off"
            };
            context.event_log.Add(Event_Log_Entry);
            context.SaveChanges();

            MessageBox.Show("Устройство успешно списано");
            var FilterPCRoom = from b in context.pc_viewsearch where b.Name_Room == RoomData.Name_Room select b;
            PC_Room_DataGrid.ItemsSource = FilterPCRoom.ToList();
        }

        private void Periphery_Room_Spisanie_Click(object sender, RoutedEventArgs e)
        {
            var cellInfo = Peripherals_Room_DataGrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);

            context.Moving_Peripherals(MovingDeviceData.Inventory_Number_Move, 13);
            context.SaveChanges();

            var Event_Log_Entry = new event_log()
            {
                ID_Users = UserProgram.ID,
                DateTime = DateTime.Now.ToString(),
                Event = "Periphery device write-off"
            };
            context.event_log.Add(Event_Log_Entry);
            context.SaveChanges();

            MessageBox.Show("Устройство успешно списано");
            var FilterPeripheralsRoom = from b in context.peripherals_view where b.Name_Room == RoomData.Name_Room select b;
            Peripherals_Room_DataGrid.ItemsSource = FilterPeripheralsRoom.ToList();
        }

        private void Printers_Room_Spisanie_Click(object sender, RoutedEventArgs e)
        {
            var cellInfo = Printers_Room_DataGrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);

            context.moving_printer(MovingDeviceData.Inventory_Number_Move, 13);
            context.SaveChanges();

            var Event_Log_Entry = new event_log()
            {
                ID_Users = UserProgram.ID,
                DateTime = DateTime.Now.ToString(),
                Event = "Printer write_off"
            };
            context.event_log.Add(Event_Log_Entry);
            context.SaveChanges();

            MessageBox.Show("Устройство успешно списано");
            var FilterPrinersRoom = from b in context.printer_view where b.Name_Room == RoomData.Name_Room select b;
            Printers_Room_DataGrid.ItemsSource = FilterPrinersRoom.ToList();
        }

        private void Network_Room_Spisanie_Click(object sender, RoutedEventArgs e)
        {
            var cellInfo = NetworkDevices_Room_DataGrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;
            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);

            context.moving_OtherDevices(MovingDeviceData.Inventory_Number_Move, 13);
            context.SaveChanges();

            var Event_Log_Entry = new event_log()
            {
                ID_Users = UserProgram.ID,
                DateTime = DateTime.Now.ToString(),
                Event = "Other Device write-off"
            };
            context.event_log.Add(Event_Log_Entry);
            context.SaveChanges();

            MessageBox.Show("Устройство успешно списано");
            var FilterNetworkDevicesRoom = from b in context.network_devices_view where b.Name_Room == RoomData.Name_Room select b;
            NetworkDevices_Room_DataGrid.ItemsSource = FilterNetworkDevicesRoom.ToList();
        }

        private void Other_Room_Spisanie_Click(object sender, RoutedEventArgs e)
        {
            var cellInfo = OtherDevices_Room_DataGrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);

            context.moving_OtherDevices(MovingDeviceData.Inventory_Number_Move, 13);
            context.SaveChanges();

            var Event_Log_Entry = new event_log()
            {
                ID_Users = UserProgram.ID,
                DateTime = DateTime.Now.ToString(),
                Event = "Other Device write-off"
            };
            context.event_log.Add(Event_Log_Entry);
            context.SaveChanges();

            MessageBox.Show("Устройство успешно списано");
            var FilterOtherDevicesRoom = from b in context.other_devices_view where b.Name_Room == RoomData.Name_Room select b;
            OtherDevices_Room_DataGrid.ItemsSource = FilterOtherDevicesRoom.ToList();
        }
    }
}
