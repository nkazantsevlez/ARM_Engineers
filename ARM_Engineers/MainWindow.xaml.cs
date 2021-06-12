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
    }
}
