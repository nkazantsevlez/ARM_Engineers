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

namespace ARM_Engineers
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        arm_engineersEntities context = new arm_engineersEntities();


        public MainWindow()
        {
            InitializeComponent();

            var FilterRoom = from b in context.room where b.Name_Room != "Spisanie" select b;

            RoomList_PCSklad_ComboBox.ItemsSource = FilterRoom.ToList();
            RoomList_CPUSklad_ComboBox.ItemsSource = FilterRoom.ToList();
            RoomList_RAMSklad_ComboBox.ItemsSource = FilterRoom.ToList();
            RoomList_PerpheralsSklad_ComboBox.ItemsSource = FilterRoom.ToList();
            RoomList_PrintersSklad_ComboBox.ItemsSource = FilterRoom.ToList();
            RoomList_CartridgeSklad_ComboBox.ItemsSource = FilterRoom.ToList();
            RoomList_NetworkSklad_ComboBox.ItemsSource = FilterRoom.ToList();
            RoomList_OtherSklad_ComboBox.ItemsSource = FilterRoom.ToList();

            RoomList_PCTechObsluzhivanie_ComboBox.ItemsSource = FilterRoom.ToList();
            RoomList_CPUTechObsluzhivanie_ComboBox.ItemsSource = FilterRoom.ToList();
            RoomList_RAMTechObsluzhivanie_ComboBox.ItemsSource = FilterRoom.ToList();
            RoomList_PeripherapsTechObsluzhivanie_ComboBox.ItemsSource = FilterRoom.ToList();
            RoomList_PrintersTechObsluzhivanie_ComboBox.ItemsSource = FilterRoom.ToList();
            RoomList_CartridgeTechObsluzhivanie_ComboBox.ItemsSource = FilterRoom.ToList();
            RoomList_NetworkTechObsluzhivanie_ComboBox.ItemsSource = FilterRoom.ToList();
            RoomList_OtherTechObsluzhivanie_ComboBox.ItemsSource = FilterRoom.ToList();

            Sklad_GroupBox.Visibility = Visibility.Collapsed;
            var FilterPCSklad = from b in context.pc_viewsearch where b.Name_Room == "Sklad" select b;
            var FilterCPUSklad = from b in context.cpu_view where b.Name_Room == "Sklad" select b;
            var FilterRAMSklad = from b in context.ram_view where b.Name_Room == "Sklad" select b;
            var FilterPeripheralsSklad = from b in context.peripherals_view where b.Name_Room == "Sklad" select b;
            var FilterPrintersSklad = from b in context.printer_view where b.Name_Room == "Sklad" select b;
            var FilterCartridgeSklad = from b in context.cartridge_view where b.Name_Room == "Sklad" select b;
            var FilterNetworkDevicesSklad = from b in context.network_devices_view where b.Name_Room == "Sklad" select b;
            var FilterOtherDevicesSklad = from b in context.other_devices_view where b.Name_Room == "Sklad" select b;

            PC_Sklad_DataGrid.ItemsSource = FilterPCSklad.ToList();
            CPU_Sklad_Datagrid.ItemsSource = FilterCPUSklad.ToList();
            RAM_Sklad_Datagrid.ItemsSource = FilterRAMSklad.ToList();
            Peripherals_Sklad_DataGrid.ItemsSource = FilterPeripheralsSklad.ToList();
            Printers_Sklad_DataGrid.ItemsSource = FilterPrintersSklad.ToList();
            Cartridge_Sklad_DataGrid.ItemsSource = FilterCartridgeSklad.ToList();
            NetworkDevices_Sklad_DataGrid.ItemsSource = FilterNetworkDevicesSklad.ToList();
            OtherDevices_Sklad_DataGrid.ItemsSource = FilterOtherDevicesSklad.ToList();

            Kabinety_GroupBox.Visibility = Visibility.Collapsed;
            Kabinety_DataGrid.ItemsSource = context.room_view.ToList();

            TechObsluzhivanie_GroupBox.Visibility = Visibility.Collapsed;
            var FilterPCTechObsluzhivanie = from b in context.pc_viewsearch where b.Name_Room == "TechObsluzhivanie" select b;
            var FilterCPUTechObsluzhivanie = from b in context.cpu_view where b.Name_Room == "TechObsluzhivanie" select b;
            var FilterRAMTechObsluzhivanie = from b in context.ram_view where b.Name_Room == "TechObsluzhivanie" select b;
            var FilterPeripheralsTechObsluzhivanie = from b in context.peripherals_view where b.Name_Room == "TechObsluzhivanie" select b;
            var FilterPrintersTechObsluzhivanie = from b in context.printer_view where b.Name_Room == "TechObsluzhivanie" select b;
            var FilterCartridgeTechObsluzhivanie = from b in context.cartridge_view where b.Name_Room == "TechObsluzhivanie" select b;
            var FilterNetworkDevicesTechObsluzhivanie = from b in context.network_devices_view where b.Name_Room == "TechObsluzhivanie" select b;
            var FilterOtherDevicesTechObsluzhivanie = from b in context.other_devices_view where b.Name_Room == "TechObsluzhivanie" select b;
            PC_TechObsluzhivanie_DataGrid.ItemsSource = FilterPCTechObsluzhivanie.ToList();
            CPU_TechObsluzhivanie_DataGrid.ItemsSource = FilterCPUTechObsluzhivanie.ToList();
            RAM_TechObsluzhivanie_DataGrid.ItemsSource = FilterRAMTechObsluzhivanie.ToList();
            Peripherals_TechObsluzhivanie_Datagrid.ItemsSource = FilterPeripheralsTechObsluzhivanie.ToList();
            Printers_TechObsluzhivanie_DataGrid.ItemsSource = FilterPrintersTechObsluzhivanie.ToList();
            Cartridge_TechObsluzhivanie_DataGrid.ItemsSource = FilterCartridgeTechObsluzhivanie.ToList();
            NetworkDevice_TechObsluzhivanie_DataGrid.ItemsSource = FilterNetworkDevicesTechObsluzhivanie.ToList();
            OtherDevice_TechObsluzhivanie_DataGrid.ItemsSource = FilterOtherDevicesTechObsluzhivanie.ToList();

            Spisanie_GroupBox.Visibility = Visibility.Collapsed;
            var FilterPCSpisanie = from b in context.pc_viewsearch where b.Name_Room == "Spisanie" select b;
            var FilterCPUSpisanie = from b in context.cpu_view where b.Name_Room == "Spisanie" select b;
            var FilterRAMSpisanie = from b in context.ram_view where b.Name_Room == "Spisanie" select b;
            var FilterPeripheralsSpisanie = from b in context.peripherals_view where b.Name_Room == "Spisanie" select b;
            var FilterPrintersSpisanie = from b in context.printer_view where b.Name_Room == "Spisanie" select b;
            var FilterCartridgeSpisanie = from b in context.cartridge_view where b.Name_Room == "Spisanie" select b;
            var FilterNetworkDevicesSpisanie = from b in context.network_devices_view where b.Name_Room == "Spisanie" select b;
            var FilterOtherDevicesSpisanie = from b in context.other_devices_view where b.Name_Room == "Spisanie" select b;
            PC_Spisanie_DataGrid.ItemsSource = FilterPCSpisanie.ToList();
            CPU_Spisanie_DataGrid.ItemsSource = FilterCPUSpisanie.ToList();
            RAM_Spisanie_DataGrid.ItemsSource = FilterRAMSpisanie.ToList();
            Peripherals_Spisanie_Datagrid.ItemsSource = FilterPeripheralsSpisanie.ToList();
            Printers_Spisanie_DataGrid.ItemsSource = FilterPrintersSpisanie.ToList();
            Cartridge_Spisanie_DataGrid.ItemsSource = FilterCartridgeSpisanie.ToList();
            NetworkDevice_Spisanie_DataGrid.ItemsSource = FilterNetworkDevicesSpisanie.ToList();
            OtherDevice_Spisanie_DataGrid.ItemsSource = FilterOtherDevicesSpisanie.ToList();

            UserName_TextBlock.Text = UserProgram.Name + " " + UserProgram.Surname;
        }

        private void PopUpButton_Quit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void FullScreenButton_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState==WindowState.Normal)
            {                
                WindowState = WindowState.Maximized;
                FullScreenButton.Content = "В окне";
            }
            else
            {
                WindowState = WindowState.Normal;
                FullScreenButton.Content = "На весь экран";
            }
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = MenuListView.SelectedIndex;
            switch (index)
            {
                case 0: 
                    Sklad_GroupBox.Visibility = Visibility.Visible;
                    Kabinety_GroupBox.Visibility = Visibility.Collapsed;
                    TechObsluzhivanie_GroupBox.Visibility = Visibility.Collapsed; 
                    Spisanie_GroupBox.Visibility = Visibility.Collapsed;
                    break;
                case 1: 
                    Kabinety_GroupBox.Visibility = Visibility.Visible;
                    Sklad_GroupBox.Visibility = Visibility.Collapsed;
                    TechObsluzhivanie_GroupBox.Visibility = Visibility.Collapsed;
                    Spisanie_GroupBox.Visibility = Visibility.Collapsed; 
                    break;
                case 2:
                    Sklad_GroupBox.Visibility = Visibility.Collapsed;
                    Kabinety_GroupBox.Visibility = Visibility.Collapsed;
                    TechObsluzhivanie_GroupBox.Visibility = Visibility.Visible;
                    Spisanie_GroupBox.Visibility = Visibility.Collapsed;
                    break;
                case 3:
                    Sklad_GroupBox.Visibility = Visibility.Collapsed;
                    Kabinety_GroupBox.Visibility = Visibility.Collapsed;
                    TechObsluzhivanie_GroupBox.Visibility = Visibility.Collapsed;
                    Spisanie_GroupBox.Visibility = Visibility.Visible;
                    break;
                default:
                    MessageBox.Show("Ошибка!");
                    break;                   
            }

        }

        private void Event_Log_Button_Click(object sender, RoutedEventArgs e)
        {
            Event_Log_Window event_Log_Window = new Event_Log_Window();
            event_Log_Window.Show();
        }

        private void Employee_Button_Click(object sender, RoutedEventArgs e)
        {
            Employee_Window employee_Window = new Employee_Window();
            employee_Window.Show();
        }

        private void Search_Button_Click(object sender, RoutedEventArgs e)
        {
            Search_Window search_Window = new Search_Window();
            search_Window.Show();
        }

        private void AddNew_Button_Click(object sender, RoutedEventArgs e)
        {
            AddNew_Window addNew_Window = new AddNew_Window();
            addNew_Window.Show();
        }

        private void RoomList_PCSklad_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cellInfo = PC_Sklad_DataGrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);
            MovingDeviceData.ID_Room_Move = Convert.ToInt32(RoomList_PCSklad_ComboBox.SelectedValue.ToString());

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

            var FilterPCSklad = from b in context.pc_viewsearch where b.Name_Room == "Sklad" select b;
            var FilterCPUSklad = from b in context.cpu_view where b.Name_Room == "Sklad" select b;
            var FilterRAMSklad = from b in context.ram_view where b.Name_Room == "Sklad" select b;
            PC_Sklad_DataGrid.ItemsSource = FilterPCSklad.ToList();
            CPU_Sklad_Datagrid.ItemsSource = FilterCPUSklad.ToList();
            RAM_Sklad_Datagrid.ItemsSource = FilterRAMSklad.ToList();

        }

        private void RoomList_CPUSklad_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cellInfo = CPU_Sklad_Datagrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);
            MovingDeviceData.ID_Room_Move = Convert.ToInt32(RoomList_CPUSklad_ComboBox.SelectedValue.ToString());

            context.moving_CPU(MovingDeviceData.Inventory_Number_Move, MovingDeviceData.ID_Room_Move);
            context.SaveChanges();

            var Event_Log_Entry = new event_log()
            {
                ID_Users = UserProgram.ID,
                DateTime = DateTime.Now.ToString(),
                Event = "Moving CPU"
            };
            context.event_log.Add(Event_Log_Entry);
            context.SaveChanges();

            MessageBox.Show("Устройство успешно перемещено");

            var FilterCPUSklad = from b in context.cpu_view where b.Name_Room == "Sklad" select b;
            CPU_Sklad_Datagrid.ItemsSource = FilterCPUSklad.ToList();

        }

        private void RoomList_RAMSklad_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cellInfo = RAM_Sklad_Datagrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);
            MovingDeviceData.ID_Room_Move = Convert.ToInt32(RoomList_RAMSklad_ComboBox.SelectedValue.ToString());

            context.moving_RAM(MovingDeviceData.Inventory_Number_Move, MovingDeviceData.ID_Room_Move);
            context.SaveChanges();

            var Event_Log_Entry = new event_log()
            {
                ID_Users = UserProgram.ID,
                DateTime = DateTime.Now.ToString(),
                Event = "Moving RAM"
            };
            context.event_log.Add(Event_Log_Entry);
            context.SaveChanges();

            MessageBox.Show("Устройство успешно перемещено");

            var FilterRAMSklad = from b in context.ram_view where b.Name_Room == "Sklad" select b;
            RAM_Sklad_Datagrid.ItemsSource = FilterRAMSklad.ToList();

        }

        private void RoomList_PerpheralsSklad_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cellInfo = Peripherals_Sklad_DataGrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);
            MovingDeviceData.ID_Room_Move = Convert.ToInt32(RoomList_PerpheralsSklad_ComboBox.SelectedValue.ToString());

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

            var FilterPeripheralsSklad = from b in context.peripherals_view where b.Name_Room == "Sklad" select b;
            Peripherals_Sklad_DataGrid.ItemsSource = FilterPeripheralsSklad.ToList();

        }

        private void RoomList_PrintersSklad_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cellInfo = Printers_Sklad_DataGrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);
            MovingDeviceData.ID_Room_Move = Convert.ToInt32(RoomList_PrintersSklad_ComboBox.SelectedValue.ToString());

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

            var FilterPrintersSklad = from b in context.printer_view where b.Name_Room == "Sklad" select b;
            var FilterCartridgeSklad = from b in context.cartridge_view where b.Name_Room == "Sklad" select b;
            Printers_Sklad_DataGrid.ItemsSource = FilterPrintersSklad.ToList();
            Cartridge_Sklad_DataGrid.ItemsSource = FilterCartridgeSklad.ToList();
        }

        private void RoomList_CartridgeSklad_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cellInfo = Cartridge_Sklad_DataGrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);
            MovingDeviceData.ID_Room_Move = Convert.ToInt32(RoomList_CartridgeSklad_ComboBox.SelectedValue.ToString());

            context.moving_Cartridge(MovingDeviceData.Inventory_Number_Move, MovingDeviceData.ID_Room_Move);
            context.SaveChanges();

            var Event_Log_Entry = new event_log()
            {
                ID_Users = UserProgram.ID,
                DateTime = DateTime.Now.ToString(),
                Event = "Moving Cartridge"
            };
            context.event_log.Add(Event_Log_Entry);
            context.SaveChanges();

            MessageBox.Show("Устройство успешно перемещено");

            var FilterCartridgeSklad = from b in context.cartridge_view where b.Name_Room == "Sklad" select b;
            Cartridge_Sklad_DataGrid.ItemsSource = FilterCartridgeSklad.ToList();

        }

        private void RoomList_NetworkSklad_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cellInfo = NetworkDevices_Sklad_DataGrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);
            MovingDeviceData.ID_Room_Move = Convert.ToInt32(RoomList_NetworkSklad_ComboBox.SelectedValue.ToString());

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

            var FilterNetworkDevicesSklad = from b in context.network_devices_view where b.Name_Room == "Sklad" select b;
            NetworkDevices_Sklad_DataGrid.ItemsSource = FilterNetworkDevicesSklad.ToList();

        }

        private void RoomList_OtherSklad_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cellInfo = OtherDevices_Sklad_DataGrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);
            MovingDeviceData.ID_Room_Move = Convert.ToInt32(RoomList_OtherSklad_ComboBox.SelectedValue.ToString());

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

            var FilterOtherDevicesSklad = from b in context.other_devices_view where b.Name_Room == "Sklad" select b;
            OtherDevices_Sklad_DataGrid.ItemsSource = FilterOtherDevicesSklad.ToList();
        }

        private void PC_Sklad_Spisanie_Click(object sender, RoutedEventArgs e)
        {
            var cellInfo = PC_Sklad_DataGrid.SelectedCells[0];
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

            var FilterPCSklad = from b in context.pc_viewsearch where b.Name_Room == "Sklad" select b;
            var FilterCPUSklad = from b in context.cpu_view where b.Name_Room == "Sklad" select b;
            var FilterRAMSklad = from b in context.ram_view where b.Name_Room == "Sklad" select b;
            PC_Sklad_DataGrid.ItemsSource = FilterPCSklad.ToList();
            CPU_Sklad_Datagrid.ItemsSource = FilterCPUSklad.ToList();
            RAM_Sklad_Datagrid.ItemsSource = FilterRAMSklad.ToList();
        }

        private void CPU_Sklad_Spisanie_Click(object sender, RoutedEventArgs e)
        {
            var cellInfo = CPU_Sklad_Datagrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);

            context.moving_CPU(MovingDeviceData.Inventory_Number_Move, 13);
            context.SaveChanges();

            var Event_Log_Entry = new event_log()
            {
                ID_Users = UserProgram.ID,
                DateTime = DateTime.Now.ToString(),
                Event = "CPU write-off"
            };
            context.event_log.Add(Event_Log_Entry);
            context.SaveChanges();

            MessageBox.Show("Устройство успешно списано");

            var FilterCPUSklad = from b in context.cpu_view where b.Name_Room == "Sklad" select b;
            CPU_Sklad_Datagrid.ItemsSource = FilterCPUSklad.ToList();
        }

        private void RAM_Sklad_Spisanie_Click(object sender, RoutedEventArgs e)
        {
            var cellInfo = RAM_Sklad_Datagrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);

            context.moving_RAM(MovingDeviceData.Inventory_Number_Move, 13);
            context.SaveChanges();

            var Event_Log_Entry = new event_log()
            {
                ID_Users = UserProgram.ID,
                DateTime = DateTime.Now.ToString(),
                Event = "RAM write-off"
            };
            context.event_log.Add(Event_Log_Entry);
            context.SaveChanges();

            MessageBox.Show("Устройство успешно списано");

            var FilterRAMSklad = from b in context.ram_view where b.Name_Room == "Sklad" select b;
            RAM_Sklad_Datagrid.ItemsSource = FilterRAMSklad.ToList();
        }

        private void Periphery_Sklad_Spisanie_Click(object sender, RoutedEventArgs e)
        {
            var cellInfo = Peripherals_Sklad_DataGrid.SelectedCells[0];
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

            var FilterPeripheralsSklad = from b in context.peripherals_view where b.Name_Room == "Sklad" select b;
            Peripherals_Sklad_DataGrid.ItemsSource = FilterPeripheralsSklad.ToList();
        }

        private void Printers_Sklad_Spisanie_Click(object sender, RoutedEventArgs e)
        {
            var cellInfo = Printers_Sklad_DataGrid.SelectedCells[0];
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

            var FilterPrintersSklad = from b in context.printer_view where b.Name_Room == "Sklad" select b;
            var FilterCartridgeSklad = from b in context.cartridge_view where b.Name_Room == "Sklad" select b;
            Printers_Sklad_DataGrid.ItemsSource = FilterPrintersSklad.ToList();
            Cartridge_Sklad_DataGrid.ItemsSource = FilterCartridgeSklad.ToList();
        }

        private void Cartridge_Sklad_Spisanie_Click(object sender, RoutedEventArgs e)
        {
            var cellInfo = Cartridge_Sklad_DataGrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);

            context.moving_Cartridge(MovingDeviceData.Inventory_Number_Move, 13);
            context.SaveChanges();

            var Event_Log_Entry = new event_log()
            {
                ID_Users = UserProgram.ID,
                DateTime = DateTime.Now.ToString(),
                Event = "Cartridge write-off"
            };
            context.event_log.Add(Event_Log_Entry);
            context.SaveChanges();

            MessageBox.Show("Устройство успешно списано");

            var FilterCartridgeSklad = from b in context.cartridge_view where b.Name_Room == "Sklad" select b;
            Cartridge_Sklad_DataGrid.ItemsSource = FilterCartridgeSklad.ToList();
        }

        private void Network_Sklad_Spisanie_Click(object sender, RoutedEventArgs e)
        {
            var cellInfo = OtherDevices_Sklad_DataGrid.SelectedCells[0];
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

            var FilterNetworkDevicesSklad = from b in context.network_devices_view where b.Name_Room == "Sklad" select b;
            NetworkDevices_Sklad_DataGrid.ItemsSource = FilterNetworkDevicesSklad.ToList();
        }

        private void Other_Sklad_Spisanie_Click(object sender, RoutedEventArgs e)
        {
            var cellInfo = OtherDevices_Sklad_DataGrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);

            context.moving_OtherDevices(MovingDeviceData.Inventory_Number_Move,13);
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

            var FilterOtherDevicesSklad = from b in context.other_devices_view where b.Name_Room == "Sklad" select b;
            OtherDevices_Sklad_DataGrid.ItemsSource = FilterOtherDevicesSklad.ToList();
        }

        private void RoomList_CPUTechObsluzhivanie_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cellInfo = CPU_TechObsluzhivanie_DataGrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);
            MovingDeviceData.ID_Room_Move = Convert.ToInt32(RoomList_CPUTechObsluzhivanie_ComboBox.SelectedValue.ToString());

            context.moving_CPU(MovingDeviceData.Inventory_Number_Move, MovingDeviceData.ID_Room_Move);
            context.SaveChanges();

            var Event_Log_Entry = new event_log()
            {
                ID_Users = UserProgram.ID,
                DateTime = DateTime.Now.ToString(),
                Event = "Moving CPU"
            };
            context.event_log.Add(Event_Log_Entry);
            context.SaveChanges();

            MessageBox.Show("Устройство успешно перемещено");

            var FilterCPUTechObsluzhivanie = from b in context.cpu_view where b.Name_Room == "TechObsluzhivanie" select b;
            CPU_TechObsluzhivanie_DataGrid.ItemsSource = FilterCPUTechObsluzhivanie.ToList();
        }

        private void RoomList_PCTechObsluzhivanie_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cellInfo = PC_TechObsluzhivanie_DataGrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);
            MovingDeviceData.ID_Room_Move = Convert.ToInt32(RoomList_PCTechObsluzhivanie_ComboBox.SelectedValue.ToString());

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

            var FilterPCTechObsluzhivanie = from b in context.pc_viewsearch where b.Name_Room == "TechObsluzhivanie" select b;
            var FilterCPUTechObsluzhivanie = from b in context.cpu_view where b.Name_Room == "TechObsluzhivanie" select b;
            var FilterRAMTechObsluzhivanie = from b in context.ram_view where b.Name_Room == "TechObsluzhivanie" select b;
            PC_TechObsluzhivanie_DataGrid.ItemsSource = FilterPCTechObsluzhivanie.ToList();
            CPU_TechObsluzhivanie_DataGrid.ItemsSource = FilterCPUTechObsluzhivanie.ToList();
            RAM_TechObsluzhivanie_DataGrid.ItemsSource = FilterRAMTechObsluzhivanie.ToList();
        }

        private void RoomList_RAMTechObsluzhivanie_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cellInfo = RAM_TechObsluzhivanie_DataGrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);
            MovingDeviceData.ID_Room_Move = Convert.ToInt32(RoomList_RAMTechObsluzhivanie_ComboBox.SelectedValue.ToString());

            context.moving_RAM(MovingDeviceData.Inventory_Number_Move, MovingDeviceData.ID_Room_Move);
            context.SaveChanges();

            var Event_Log_Entry = new event_log()
            {
                ID_Users = UserProgram.ID,
                DateTime = DateTime.Now.ToString(),
                Event = "Moving RAM"
            };
            context.event_log.Add(Event_Log_Entry);
            context.SaveChanges();

            MessageBox.Show("Устройство успешно перемещено");

            var FilterRAMTechObsluzhivanie = from b in context.ram_view where b.Name_Room == "TechObsluzhivanie" select b;
            RAM_TechObsluzhivanie_DataGrid.ItemsSource = FilterRAMTechObsluzhivanie.ToList();

        }

        private void RoomList_PeripherapsTechObsluzhivanie_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cellInfo = Peripherals_TechObsluzhivanie_Datagrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);
            MovingDeviceData.ID_Room_Move = Convert.ToInt32(RoomList_PeripherapsTechObsluzhivanie_ComboBox.SelectedValue.ToString());

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

           var FilterPeripheralsTechObsluzhivanie = from b in context.peripherals_view where b.Name_Room == "TechObsluzhivanie" select b;            
            Peripherals_TechObsluzhivanie_Datagrid.ItemsSource = FilterPeripheralsTechObsluzhivanie.ToList();
           
        }

        private void RoomList_PrintersTechObsluzhivanie_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cellInfo = Printers_TechObsluzhivanie_DataGrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);
            MovingDeviceData.ID_Room_Move = Convert.ToInt32(RoomList_PrintersTechObsluzhivanie_ComboBox.SelectedValue.ToString());

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

           
            var FilterPrintersTechObsluzhivanie = from b in context.printer_view where b.Name_Room == "TechObsluzhivanie" select b;
            var FilterCartridgeTechObsluzhivanie = from b in context.cartridge_view where b.Name_Room == "TechObsluzhivanie" select b;
            Printers_TechObsluzhivanie_DataGrid.ItemsSource = FilterPrintersTechObsluzhivanie.ToList();
            Cartridge_TechObsluzhivanie_DataGrid.ItemsSource = FilterCartridgeTechObsluzhivanie.ToList();

        }

        private void RoomList_CartridgeTechObsluzhivanie_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cellInfo = Cartridge_TechObsluzhivanie_DataGrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);
            MovingDeviceData.ID_Room_Move = Convert.ToInt32(RoomList_CartridgeTechObsluzhivanie_ComboBox.SelectedValue.ToString());

            context.moving_Cartridge(MovingDeviceData.Inventory_Number_Move, MovingDeviceData.ID_Room_Move);
            context.SaveChanges();

            var Event_Log_Entry = new event_log()
            {
                ID_Users = UserProgram.ID,
                DateTime = DateTime.Now.ToString(),
                Event = "Moving Cartridge"
            };
            context.event_log.Add(Event_Log_Entry);
            context.SaveChanges();

            MessageBox.Show("Устройство успешно перемещено");

            var FilterCartridgeTechObsluzhivanie = from b in context.cartridge_view where b.Name_Room == "TechObsluzhivanie" select b;
            Cartridge_TechObsluzhivanie_DataGrid.ItemsSource = FilterCartridgeTechObsluzhivanie.ToList();

        }

        private void RoomList_NetworkTechObsluzhivanie_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cellInfo = NetworkDevice_TechObsluzhivanie_DataGrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);
            MovingDeviceData.ID_Room_Move = Convert.ToInt32(RoomList_NetworkSklad_ComboBox.SelectedValue.ToString());

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
           
            var FilterNetworkDevicesTechObsluzhivanie = from b in context.network_devices_view where b.Name_Room == "TechObsluzhivanie" select b;            
            NetworkDevice_TechObsluzhivanie_DataGrid.ItemsSource = FilterNetworkDevicesTechObsluzhivanie.ToList();
        }

        private void RoomList_OtherTechObsluzhivanie_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var cellInfo = OtherDevice_TechObsluzhivanie_DataGrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);
            MovingDeviceData.ID_Room_Move = Convert.ToInt32(RoomList_OtherSklad_ComboBox.SelectedValue.ToString());

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
           
            var FilterOtherDevicesTechObsluzhivanie = from b in context.other_devices_view where b.Name_Room == "TechObsluzhivanie" select b;           
            OtherDevice_TechObsluzhivanie_DataGrid.ItemsSource = FilterOtherDevicesTechObsluzhivanie.ToList();
        }

        private void PC_TechObsluzhivanie_Spisanie_Click(object sender, RoutedEventArgs e)
        {
            var cellInfo = PC_TechObsluzhivanie_DataGrid.SelectedCells[0];
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

            var FilterPCTechObsluzhivanie = from b in context.pc_viewsearch where b.Name_Room == "TechObsluzhivanie" select b;
            var FilterCPUTechObsluzhivanie = from b in context.cpu_view where b.Name_Room == "TechObsluzhivanie" select b;
            var FilterRAMTechObsluzhivanie = from b in context.ram_view where b.Name_Room == "TechObsluzhivanie" select b;
            PC_TechObsluzhivanie_DataGrid.ItemsSource = FilterPCTechObsluzhivanie.ToList();
            CPU_TechObsluzhivanie_DataGrid.ItemsSource = FilterCPUTechObsluzhivanie.ToList();
            RAM_TechObsluzhivanie_DataGrid.ItemsSource = FilterRAMTechObsluzhivanie.ToList();
        }

        private void CPU_TechObsluzhivanie_Spisanie_Click(object sender, RoutedEventArgs e)
        {
            var cellInfo = CPU_TechObsluzhivanie_DataGrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);

            context.moving_CPU(MovingDeviceData.Inventory_Number_Move, 13);
            context.SaveChanges();

            var Event_Log_Entry = new event_log()
            {
                ID_Users = UserProgram.ID,
                DateTime = DateTime.Now.ToString(),
                Event = "CPU write-off"
            };
            context.event_log.Add(Event_Log_Entry);
            context.SaveChanges();

            MessageBox.Show("Устройство успешно списано");

            var FilterCPUTechObsluzhivanie = from b in context.cpu_view where b.Name_Room == "TechObsluzhivanie" select b;
            CPU_TechObsluzhivanie_DataGrid.ItemsSource = FilterCPUTechObsluzhivanie.ToList();
        }

        private void RAM_TechObsluzhivanie_Spisanie_Click(object sender, RoutedEventArgs e)
        {
            var cellInfo = RAM_TechObsluzhivanie_DataGrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);

            context.moving_RAM(MovingDeviceData.Inventory_Number_Move, 13);
            context.SaveChanges();

            var Event_Log_Entry = new event_log()
            {
                ID_Users = UserProgram.ID,
                DateTime = DateTime.Now.ToString(),
                Event = "RAM write-off"
            };
            context.event_log.Add(Event_Log_Entry);
            context.SaveChanges();

            MessageBox.Show("Устройство успешно списано");

            var FilterRAMTechObsluzhivanie = from b in context.ram_view where b.Name_Room == "TechObsluzhivanie" select b;            
            RAM_TechObsluzhivanie_DataGrid.ItemsSource = FilterRAMTechObsluzhivanie.ToList();
        }

        private void Peripferals_TechObsluzhivanie_Spisanie_Click(object sender, RoutedEventArgs e)
        {
            var cellInfo = Peripherals_TechObsluzhivanie_Datagrid.SelectedCells[0];
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

            var FilterPeripheralsTechObsluzhivanie = from b in context.peripherals_view where b.Name_Room == "TechObsluzhivanie" select b;
            Peripherals_TechObsluzhivanie_Datagrid.ItemsSource = FilterPeripheralsTechObsluzhivanie.ToList();
        }

        private void Printers_TechObsluzhivanie_Spisanie_Click(object sender, RoutedEventArgs e)
        {
            var cellInfo = Printers_TechObsluzhivanie_DataGrid.SelectedCells[0];
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

            var FilterPrintersTechObsluzhivanie = from b in context.printer_view where b.Name_Room == "TechObsluzhivanie" select b;
            var FilterCartridgeTechObsluzhivanie = from b in context.cartridge_view where b.Name_Room == "TechObsluzhivanie" select b;
            Printers_TechObsluzhivanie_DataGrid.ItemsSource = FilterPrintersTechObsluzhivanie.ToList();
            Cartridge_TechObsluzhivanie_DataGrid.ItemsSource = FilterCartridgeTechObsluzhivanie.ToList();
        }

        private void Cartridge_TechObsluzhivanie_Spisanie_Click(object sender, RoutedEventArgs e)
        {
            var cellInfo = Cartridge_TechObsluzhivanie_DataGrid.SelectedCells[0];
            var content = (cellInfo.Column.GetCellContent(cellInfo.Item) as TextBlock).Text;

            MovingDeviceData.Inventory_Number_Move = Convert.ToInt32(content);

            context.moving_Cartridge(MovingDeviceData.Inventory_Number_Move, 13);
            context.SaveChanges();

            var Event_Log_Entry = new event_log()
            {
                ID_Users = UserProgram.ID,
                DateTime = DateTime.Now.ToString(),
                Event = "Cartridge write-off"
            };
            context.event_log.Add(Event_Log_Entry);
            context.SaveChanges();

            MessageBox.Show("Устройство успешно списано");

            var FilterCartridgeTechObsluzhivanie = from b in context.cartridge_view where b.Name_Room == "TechObsluzhivanie" select b;
            Cartridge_TechObsluzhivanie_DataGrid.ItemsSource = FilterCartridgeTechObsluzhivanie.ToList();
        }

        private void Network_TechObsluzhivanie_Spisanie_Click(object sender, RoutedEventArgs e)
        {
            var cellInfo = NetworkDevice_TechObsluzhivanie_DataGrid.SelectedCells[0];
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

            var FilterNetworkDevicesTechObsluzhivanie = from b in context.network_devices_view where b.Name_Room == "TechObsluzhivanie" select b;
            NetworkDevice_TechObsluzhivanie_DataGrid.ItemsSource = FilterNetworkDevicesTechObsluzhivanie.ToList();
        }

        private void Other_TechObsluzhivanie_Spisanie_Click(object sender, RoutedEventArgs e)
        {
            var cellInfo = OtherDevice_TechObsluzhivanie_DataGrid.SelectedCells[0];
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

            var FilterOtherDevicesTechObsluzhivanie = from b in context.other_devices_view where b.Name_Room == "TechObsluzhivanie" select b;
            OtherDevice_TechObsluzhivanie_DataGrid.ItemsSource = FilterOtherDevicesTechObsluzhivanie.ToList();
        }

        private void Grid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F5)
            {
                var FilterRoom = from b in context.room where b.Name_Room != "Spisanie" select b;

                RoomList_PCSklad_ComboBox.ItemsSource = FilterRoom.ToList();
                RoomList_CPUSklad_ComboBox.ItemsSource = FilterRoom.ToList();
                RoomList_RAMSklad_ComboBox.ItemsSource = FilterRoom.ToList();
                RoomList_PerpheralsSklad_ComboBox.ItemsSource = FilterRoom.ToList();
                RoomList_PrintersSklad_ComboBox.ItemsSource = FilterRoom.ToList();
                RoomList_CartridgeSklad_ComboBox.ItemsSource = FilterRoom.ToList();
                RoomList_NetworkSklad_ComboBox.ItemsSource = FilterRoom.ToList();
                RoomList_OtherSklad_ComboBox.ItemsSource = FilterRoom.ToList();

                RoomList_PCTechObsluzhivanie_ComboBox.ItemsSource = FilterRoom.ToList();
                RoomList_CPUTechObsluzhivanie_ComboBox.ItemsSource = FilterRoom.ToList();
                RoomList_RAMTechObsluzhivanie_ComboBox.ItemsSource = FilterRoom.ToList();
                RoomList_PeripherapsTechObsluzhivanie_ComboBox.ItemsSource = FilterRoom.ToList();
                RoomList_PrintersTechObsluzhivanie_ComboBox.ItemsSource = FilterRoom.ToList();
                RoomList_CartridgeTechObsluzhivanie_ComboBox.ItemsSource = FilterRoom.ToList();
                RoomList_NetworkTechObsluzhivanie_ComboBox.ItemsSource = FilterRoom.ToList();
                RoomList_OtherTechObsluzhivanie_ComboBox.ItemsSource = FilterRoom.ToList();

                var FilterPCSklad = from b in context.pc_viewsearch where b.Name_Room == "Sklad" select b;
                var FilterCPUSklad = from b in context.cpu_view where b.Name_Room == "Sklad" select b;
                var FilterRAMSklad = from b in context.ram_view where b.Name_Room == "Sklad" select b;
                var FilterPeripheralsSklad = from b in context.peripherals_view where b.Name_Room == "Sklad" select b;
                var FilterPrintersSklad = from b in context.printer_view where b.Name_Room == "Sklad" select b;
                var FilterCartridgeSklad = from b in context.cartridge_view where b.Name_Room == "Sklad" select b;
                var FilterNetworkDevicesSklad = from b in context.network_devices_view where b.Name_Room == "Sklad" select b;
                var FilterOtherDevicesSklad = from b in context.other_devices_view where b.Name_Room == "Sklad" select b;

                PC_Sklad_DataGrid.ItemsSource = FilterPCSklad.ToList();
                CPU_Sklad_Datagrid.ItemsSource = FilterCPUSklad.ToList();
                RAM_Sklad_Datagrid.ItemsSource = FilterRAMSklad.ToList();
                Peripherals_Sklad_DataGrid.ItemsSource = FilterPeripheralsSklad.ToList();
                Printers_Sklad_DataGrid.ItemsSource = FilterPrintersSklad.ToList();
                Cartridge_Sklad_DataGrid.ItemsSource = FilterCartridgeSklad.ToList();
                NetworkDevices_Sklad_DataGrid.ItemsSource = FilterNetworkDevicesSklad.ToList();
                OtherDevices_Sklad_DataGrid.ItemsSource = FilterOtherDevicesSklad.ToList();

                Kabinety_DataGrid.ItemsSource = context.room_view.ToList();

                var FilterPCTechObsluzhivanie = from b in context.pc_viewsearch where b.Name_Room == "TechObsluzhivanie" select b;
                var FilterCPUTechObsluzhivanie = from b in context.cpu_view where b.Name_Room == "TechObsluzhivanie" select b;
                var FilterRAMTechObsluzhivanie = from b in context.ram_view where b.Name_Room == "TechObsluzhivanie" select b;
                var FilterPeripheralsTechObsluzhivanie = from b in context.peripherals_view where b.Name_Room == "TechObsluzhivanie" select b;
                var FilterPrintersTechObsluzhivanie = from b in context.printer_view where b.Name_Room == "TechObsluzhivanie" select b;
                var FilterCartridgeTechObsluzhivanie = from b in context.cartridge_view where b.Name_Room == "TechObsluzhivanie" select b;
                var FilterNetworkDevicesTechObsluzhivanie = from b in context.network_devices_view where b.Name_Room == "TechObsluzhivanie" select b;
                var FilterOtherDevicesTechObsluzhivanie = from b in context.other_devices_view where b.Name_Room == "TechObsluzhivanie" select b;
                PC_TechObsluzhivanie_DataGrid.ItemsSource = FilterPCTechObsluzhivanie.ToList();
                CPU_TechObsluzhivanie_DataGrid.ItemsSource = FilterCPUTechObsluzhivanie.ToList();
                RAM_TechObsluzhivanie_DataGrid.ItemsSource = FilterRAMTechObsluzhivanie.ToList();
                Peripherals_TechObsluzhivanie_Datagrid.ItemsSource = FilterPeripheralsTechObsluzhivanie.ToList();
                Printers_TechObsluzhivanie_DataGrid.ItemsSource = FilterPrintersTechObsluzhivanie.ToList();
                Cartridge_TechObsluzhivanie_DataGrid.ItemsSource = FilterCartridgeTechObsluzhivanie.ToList();
                NetworkDevice_TechObsluzhivanie_DataGrid.ItemsSource = FilterNetworkDevicesTechObsluzhivanie.ToList();
                OtherDevice_TechObsluzhivanie_DataGrid.ItemsSource = FilterOtherDevicesTechObsluzhivanie.ToList();

                var FilterPCSpisanie = from b in context.pc_viewsearch where b.Name_Room == "Spisanie" select b;
                var FilterCPUSpisanie = from b in context.cpu_view where b.Name_Room == "Spisanie" select b;
                var FilterRAMSpisanie = from b in context.ram_view where b.Name_Room == "Spisanie" select b;
                var FilterPeripheralsSpisanie = from b in context.peripherals_view where b.Name_Room == "Spisanie" select b;
                var FilterPrintersSpisanie = from b in context.printer_view where b.Name_Room == "Spisanie" select b;
                var FilterCartridgeSpisanie = from b in context.cartridge_view where b.Name_Room == "Spisanie" select b;
                var FilterNetworkDevicesSpisanie = from b in context.network_devices_view where b.Name_Room == "Spisanie" select b;
                var FilterOtherDevicesSpisanie = from b in context.other_devices_view where b.Name_Room == "Spisanie" select b;
                PC_Spisanie_DataGrid.ItemsSource = FilterPCSpisanie.ToList();
                CPU_Spisanie_DataGrid.ItemsSource = FilterCPUSpisanie.ToList();
                RAM_Spisanie_DataGrid.ItemsSource = FilterRAMSpisanie.ToList();
                Peripherals_Spisanie_Datagrid.ItemsSource = FilterPeripheralsSpisanie.ToList();
                Printers_Spisanie_DataGrid.ItemsSource = FilterPrintersSpisanie.ToList();
                Cartridge_Spisanie_DataGrid.ItemsSource = FilterCartridgeSpisanie.ToList();
                NetworkDevice_Spisanie_DataGrid.ItemsSource = FilterNetworkDevicesSpisanie.ToList();
                OtherDevice_Spisanie_DataGrid.ItemsSource = FilterOtherDevicesSpisanie.ToList();

                MessageBox.Show("Данные успешно обновлены!");
            }
        }
    }
}
