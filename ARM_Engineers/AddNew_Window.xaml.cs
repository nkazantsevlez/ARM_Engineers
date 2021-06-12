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
    /// Логика взаимодействия для AddNew_Window.xaml
    /// </summary>
    
    
    public partial class AddNew_Window : Window
    {
        public AddNew_Window()
        {
            InitializeComponent();

            PC_Add_Groupbox.Visibility = Visibility.Collapsed;
            CPU_Add_Groupbox.Visibility = Visibility.Collapsed;
            RAM_Add_Groupbox.Visibility = Visibility.Collapsed;
            Peripherals_Add_Groupbox.Visibility = Visibility.Collapsed;
            Printers_Add_Groupbox.Visibility = Visibility.Collapsed;
            Cartrige_Add_Groupbox.Visibility = Visibility.Collapsed;
            NetworkDevices_Add_Groupbox.Visibility = Visibility.Collapsed;
            OtherDevices_Add_Groupbox.Visibility = Visibility.Collapsed;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Close_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SelectNew_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (SelectNew_ComboBox.SelectedIndex)
            {
                case 0:
                    PC_Add_Groupbox.Visibility = Visibility.Visible;
                    CPU_Add_Groupbox.Visibility = Visibility.Collapsed;
                    RAM_Add_Groupbox.Visibility = Visibility.Collapsed;
                    Peripherals_Add_Groupbox.Visibility = Visibility.Collapsed;
                    Printers_Add_Groupbox.Visibility = Visibility.Collapsed;
                    Cartrige_Add_Groupbox.Visibility = Visibility.Collapsed;
                    NetworkDevices_Add_Groupbox.Visibility = Visibility.Collapsed;
                    OtherDevices_Add_Groupbox.Visibility = Visibility.Collapsed; break;
                case 1:
                    PC_Add_Groupbox.Visibility = Visibility.Collapsed;
                    CPU_Add_Groupbox.Visibility = Visibility.Visible;
                    RAM_Add_Groupbox.Visibility = Visibility.Collapsed;
                    Peripherals_Add_Groupbox.Visibility = Visibility.Collapsed;
                    Printers_Add_Groupbox.Visibility = Visibility.Collapsed;
                    Cartrige_Add_Groupbox.Visibility = Visibility.Collapsed;
                    NetworkDevices_Add_Groupbox.Visibility = Visibility.Collapsed;
                    OtherDevices_Add_Groupbox.Visibility = Visibility.Collapsed; break;
                case 2:
                    PC_Add_Groupbox.Visibility = Visibility.Collapsed;
                    CPU_Add_Groupbox.Visibility = Visibility.Collapsed;
                    RAM_Add_Groupbox.Visibility = Visibility.Visible;
                    Peripherals_Add_Groupbox.Visibility = Visibility.Collapsed;
                    Printers_Add_Groupbox.Visibility = Visibility.Collapsed;
                    Cartrige_Add_Groupbox.Visibility = Visibility.Collapsed;
                    NetworkDevices_Add_Groupbox.Visibility = Visibility.Collapsed;
                    OtherDevices_Add_Groupbox.Visibility = Visibility.Collapsed; break;
                case 3:
                    PC_Add_Groupbox.Visibility = Visibility.Collapsed;
                    CPU_Add_Groupbox.Visibility = Visibility.Collapsed;
                    RAM_Add_Groupbox.Visibility = Visibility.Collapsed;
                    Peripherals_Add_Groupbox.Visibility = Visibility.Visible;
                    Printers_Add_Groupbox.Visibility = Visibility.Collapsed;
                    Cartrige_Add_Groupbox.Visibility = Visibility.Collapsed;
                    NetworkDevices_Add_Groupbox.Visibility = Visibility.Collapsed;
                    OtherDevices_Add_Groupbox.Visibility = Visibility.Collapsed; break;
                case 4:
                    PC_Add_Groupbox.Visibility = Visibility.Collapsed;
                    CPU_Add_Groupbox.Visibility = Visibility.Collapsed;
                    RAM_Add_Groupbox.Visibility = Visibility.Collapsed;
                    Peripherals_Add_Groupbox.Visibility = Visibility.Collapsed;
                    Printers_Add_Groupbox.Visibility = Visibility.Visible;
                    Cartrige_Add_Groupbox.Visibility = Visibility.Collapsed;
                    NetworkDevices_Add_Groupbox.Visibility = Visibility.Collapsed;
                    OtherDevices_Add_Groupbox.Visibility = Visibility.Collapsed; break;
                case 5:
                    PC_Add_Groupbox.Visibility = Visibility.Collapsed;
                    CPU_Add_Groupbox.Visibility = Visibility.Collapsed;
                    RAM_Add_Groupbox.Visibility = Visibility.Collapsed;
                    Peripherals_Add_Groupbox.Visibility = Visibility.Collapsed;
                    Printers_Add_Groupbox.Visibility = Visibility.Collapsed;
                    Cartrige_Add_Groupbox.Visibility = Visibility.Visible;
                    NetworkDevices_Add_Groupbox.Visibility = Visibility.Collapsed;
                    OtherDevices_Add_Groupbox.Visibility = Visibility.Collapsed; break;
                case 6:
                    PC_Add_Groupbox.Visibility = Visibility.Collapsed;
                    CPU_Add_Groupbox.Visibility = Visibility.Collapsed;
                    RAM_Add_Groupbox.Visibility = Visibility.Collapsed;
                    Peripherals_Add_Groupbox.Visibility = Visibility.Collapsed;
                    Printers_Add_Groupbox.Visibility = Visibility.Collapsed;
                    Cartrige_Add_Groupbox.Visibility = Visibility.Collapsed;
                    NetworkDevices_Add_Groupbox.Visibility = Visibility.Visible;
                    OtherDevices_Add_Groupbox.Visibility = Visibility.Collapsed; break;
                case 7:
                    PC_Add_Groupbox.Visibility = Visibility.Visible;
                    CPU_Add_Groupbox.Visibility = Visibility.Collapsed;
                    RAM_Add_Groupbox.Visibility = Visibility.Collapsed;
                    Peripherals_Add_Groupbox.Visibility = Visibility.Collapsed;
                    Printers_Add_Groupbox.Visibility = Visibility.Collapsed;
                    Cartrige_Add_Groupbox.Visibility = Visibility.Collapsed;
                    NetworkDevices_Add_Groupbox.Visibility = Visibility.Collapsed;
                    OtherDevices_Add_Groupbox.Visibility = Visibility.Visible; break;

                default: MessageBox.Show("Ошибка!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error); break;
            }

        }

        private void AddNew_Button_Click(object sender, RoutedEventArgs e)
        {
            switch (SelectNew_ComboBox.SelectedIndex)
            {
                case 0: break;
                case 1: 
                    using (var context = new arm_engineersEntities())
                    {
                        var NewCPU = new cpu()
                        {
                            Inventory_Number_CPU = Convert.ToInt32( AddCPU_InventoryNumber_TextBox.Text),
                            Name = AddCPU_Name_TextBox.Text,
                            Socket = AddCPU_Socket_TextBox.Text,
                            Clock_Frequency = AddCPU_ClockFrequency_TextBox.Text,
                            ID_Room = 1,
                            Description = AddCPU_Description_TextBox.Text
                        };
                        context.cpu.Add(NewCPU);
                        context.SaveChanges();

                        var Event_Log_Entry = new event_log()
                        {
                            ID_Users = UserProgram.ID,
                            DateTime = DateTime.Now.ToString(),
                            Event = "Adding a processor"
                        };
                        context.event_log.Add(Event_Log_Entry);
                        context.SaveChanges();
                        MessageBox.Show("Устройство успешно добавлено");

                        AddCPU_InventoryNumber_TextBox.Text = "";
                        AddCPU_Name_TextBox.Text = "";
                        AddCPU_Socket_TextBox.Text = "";
                        AddCPU_ClockFrequency_TextBox.Text = "";
                        AddCPU_Description_TextBox.Text = "";
                    }
                     break;
                case 2:
                    using (var context = new arm_engineersEntities())
                    {
                        var NewRAM = new ram()
                        {
                            Inventory_Number_RAM = Convert.ToInt32(AddRAM_InventoryNumber_TextBox.Text),
                            Name = AddRAM_Name_TextBox.Text,
                            Type = AddRAM_Type_TextBox.Text,
                            Memory_Size = Convert.ToInt32( AddRAM_MemorySize_TextBox.Text),
                            Operating_Freequency = Convert.ToInt32(AddRAM_OperatingFreequency_TextBox.Text),
                            ID_Room = 1,
                            Description = AddRAM_Description_TextBox.Text
                        };
                        context.ram.Add(NewRAM);
                        context.SaveChanges();

                        var Event_Log_Entry = new event_log()
                        {
                            ID_Users = UserProgram.ID,
                            DateTime = DateTime.Now.ToString(),
                            Event = "Adding a RAM"
                        };
                        context.event_log.Add(Event_Log_Entry);
                        context.SaveChanges();
                        MessageBox.Show("Устройство успешно добавлено");

                        AddRAM_InventoryNumber_TextBox.Text = "";
                        AddRAM_Name_TextBox.Text = "";
                        AddRAM_Type_TextBox.Text = "";
                        AddRAM_MemorySize_TextBox.Text = "";
                        AddRAM_OperatingFreequency_TextBox.Text = "";
                        AddRAM_Description_TextBox.Text = "";

                    }
                    break;
                case 3:
                    using (var context = new arm_engineersEntities())
                    {
                        var NewPeripherals = new peripherals()
                        {
                            Inventory_Number = Convert.ToInt32(AddPeripherals_InventoryNumber_TextBox.Text),
                            Name = AddPeripherals_Name_TextBox.Text,
                            ID_Room = 1,
                            Description = AddPrinters_Description_TextBox.Text
                        };
                        context.peripherals.Add(NewPeripherals);
                        context.SaveChanges();
                        var Event_Log_Entry = new event_log()
                        {
                            ID_Users = UserProgram.ID,
                            DateTime = DateTime.Now.ToString(),
                            Event = "Adding a Periphery"
                        };
                        context.event_log.Add(Event_Log_Entry);
                        context.SaveChanges();
                        MessageBox.Show("Устройство успешно добавлено");

                        AddPeripherals_InventoryNumber_TextBox.Text = "";
                        AddPeripherals_Name_TextBox.Text = "";
                        AddPrinters_Description_TextBox.Text = "";

                    }
                    break;
                case 4: break;
                case 5:
                    using (var context = new arm_engineersEntities())
                    {
                        var NewCartridge = new cartridge()
                        {
                            Inventory_Number = Convert.ToInt32(AddCartrige_InventoryNumber_TextBox.Text),
                            Name_Cartinge = AddCartrige_Name_TextBox.Text,
                            ID_Room = 1,
                            Description = AddCartrige_Description_TextBox.Text
                        };
                        context.cartridge.Add(NewCartridge);
                        context.SaveChanges();

                        var Event_Log_Entry = new event_log()
                        {
                            ID_Users = UserProgram.ID,
                            DateTime = DateTime.Now.ToString(),
                            Event = "Adding a Cartridge"
                        };
                        context.event_log.Add(Event_Log_Entry);
                        context.SaveChanges();
                        MessageBox.Show("Устройство успешно добавлено");

                    }

                    AddCartrige_InventoryNumber_TextBox.Text = "";
                    AddCartrige_Name_TextBox.Text = "";
                    AddCartrige_Description_TextBox.Text = "";

                    break;
                case 6:
                    using (var context = new arm_engineersEntities())
                    {
                        var NewNetworkDevice = new network_devices()
                        {
                            Inventory_Number = Convert.ToInt32(AddNetworkDevices_InventoryNumber_TextBox.Text),
                            Name = AddNetworkDevices_Name_TextBox.Text,
                            ID_Room = 1,
                            Description = AddNetworkDevices_Description_TextBox.Text
                        };
                        context.network_devices.Add(NewNetworkDevice);
                        context.SaveChanges();

                        var Event_Log_Entry = new event_log()
                        {
                            ID_Users = UserProgram.ID,
                            DateTime = DateTime.Now.ToString(),
                            Event = "Adding a Network device"
                        };
                        context.event_log.Add(Event_Log_Entry);
                        context.SaveChanges();
                        MessageBox.Show("Устройство успешно добавлено");

                        AddNetworkDevices_InventoryNumber_TextBox.Text = "";
                        AddNetworkDevices_Name_TextBox.Text = "";
                        AddNetworkDevices_Description_TextBox.Text = "";
                    }
                    break;
                case 7: 
                    using (var context = new arm_engineersEntities())
                    {
                        var NewOtherDevice = new other_devices()
                        {
                            Inventory_Number = Convert.ToInt32(AddOtherDevices_InventoryNumber_TextBox.Text),
                            Name = AddOtherDevices_Name_TextBox.Text,
                            ID_Room = 1,
                            Description = AddOtherDevices_Description_TextBox.Text
                        };
                        context.other_devices.Add(NewOtherDevice);
                        context.SaveChanges();

                        var Event_Log_Entry = new event_log()
                        {
                            ID_Users = UserProgram.ID,
                            DateTime = DateTime.Now.ToString(),
                            Event = "Adding a Other device"
                        };
                        context.event_log.Add(Event_Log_Entry);
                        context.SaveChanges();
                        MessageBox.Show("Устройство успешно добавлено");

                        AddOtherDevices_InventoryNumber_TextBox.Text = "";
                        AddOtherDevices_Name_TextBox.Text = "";
                        AddOtherDevices_Description_TextBox.Text = "";
                    }
                    break;

                default: MessageBox.Show("Ошибка!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error); break;
            }

        }
    }
}
