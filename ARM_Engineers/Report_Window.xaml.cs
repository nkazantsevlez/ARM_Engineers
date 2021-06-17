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
using ClosedXML.Excel;

namespace ARM_Engineers
{
    /// <summary>
    /// Логика взаимодействия для Report_Window.xaml
    /// </summary>
    public partial class Report_Window : Window
    {
        arm_engineersEntities context = new arm_engineersEntities();
        public Report_Window()
        {
            InitializeComponent();
        }

        private void Close_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void GenerateReport_Button_Click(object sender, RoutedEventArgs e)
        {
            switch (Selected_Report_Combobox.SelectedIndex)
            {
                case 0:
                    using (var workbook = new XLWorkbook())
                    {
                        var PCworksheet = workbook.Worksheets.Add("PС");
                        var CPUworksheet = workbook.Worksheets.Add("CPU");
                        var RAMworksheet = workbook.Worksheets.Add("RAM");
                        var Peripheralsworksheet = workbook.Worksheets.Add("Peripherals");
                        var Printersworksheet = workbook.Worksheets.Add("Printers");
                        var Cartridgeworksheet = workbook.Worksheets.Add("Сartridge");
                        var NetworkDevicesworksheet = workbook.Worksheets.Add("Network devices");
                        var OtherDevicesworksheet = workbook.Worksheets.Add("Other devices");
                        var currentRow = 1;

                        #region header
                        #region PC
                        PCworksheet.Cell(currentRow, 1).Value = "Дата создания отчета:";
                        PCworksheet.Cell(currentRow, 2).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        currentRow++;
                        PCworksheet.Cell(currentRow, 1).Value = "Инвентарный номер";
                        PCworksheet.Cell(currentRow, 2).Value = "Наименование";
                        PCworksheet.Cell(currentRow, 3).Value = "Кабинет";
                        PCworksheet.Cell(currentRow, 4).Value = "Ответственный";
                        #endregion
                        #region CPU
                        currentRow = 1;
                        CPUworksheet.Cell(currentRow, 1).Value = "Дата создания отчета:";
                        CPUworksheet.Cell(currentRow, 2).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        currentRow++;
                        CPUworksheet.Cell(currentRow, 1).Value = "Инвентарный номер";
                        CPUworksheet.Cell(currentRow, 2).Value = "Наименование";
                        CPUworksheet.Cell(currentRow, 3).Value = "Сокет";
                        CPUworksheet.Cell(currentRow, 4).Value = "Тактовая частота";
                        CPUworksheet.Cell(currentRow, 4).Value = "Кабинет";
                        #endregion
                        #region RAM
                        currentRow = 1;
                        RAMworksheet.Cell(currentRow, 1).Value = "Дата создания отчета:";
                        RAMworksheet.Cell(currentRow, 2).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        currentRow++;
                        RAMworksheet.Cell(currentRow, 1).Value = "Инвентарный номер";
                        RAMworksheet.Cell(currentRow, 2).Value = "Наименование";
                        RAMworksheet.Cell(currentRow, 3).Value = "Тип";
                        RAMworksheet.Cell(currentRow, 4).Value = "Объем памяти";
                        RAMworksheet.Cell(currentRow, 5).Value = "Рабочая частота";
                        RAMworksheet.Cell(currentRow, 6).Value = "Кабинет";
                        #endregion
                        #region Peripherals
                        currentRow = 1;
                        Peripheralsworksheet.Cell(currentRow, 1).Value = "Дата создания отчета:";
                        Peripheralsworksheet.Cell(currentRow, 2).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        currentRow++;
                        Peripheralsworksheet.Cell(currentRow, 1).Value = "Инвентарный номер";
                        Peripheralsworksheet.Cell(currentRow, 2).Value = "Наименование";
                        Peripheralsworksheet.Cell(currentRow, 3).Value = "Кабинет";
                        #endregion
                        #region Printers
                        currentRow = 1;
                        Printersworksheet.Cell(currentRow, 1).Value = "Дата создания отчета:";
                        Printersworksheet.Cell(currentRow, 2).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        currentRow++;
                        Printersworksheet.Cell(currentRow, 1).Value = "Инвентарный номер";
                        Printersworksheet.Cell(currentRow, 2).Value = "Наименование";
                        Printersworksheet.Cell(currentRow, 3).Value = "Кабинет";
                        #endregion
                        #region Cartridge
                        currentRow = 1;
                        Cartridgeworksheet.Cell(currentRow, 1).Value = "Дата создания отчета:";
                        Cartridgeworksheet.Cell(currentRow, 2).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        currentRow++;
                        Cartridgeworksheet.Cell(currentRow, 1).Value = "Инвентарный номер";
                        Cartridgeworksheet.Cell(currentRow, 2).Value = "Наименование";
                        Cartridgeworksheet.Cell(currentRow, 3).Value = "Кабинет";
                        #endregion
                        #region Network devices
                        currentRow = 1;
                        NetworkDevicesworksheet.Cell(currentRow, 1).Value = "Дата создания отчета:";
                        NetworkDevicesworksheet.Cell(currentRow, 2).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        currentRow++;
                        NetworkDevicesworksheet.Cell(currentRow, 1).Value = "Инвентарный номер";
                        NetworkDevicesworksheet.Cell(currentRow, 2).Value = "Наименование";
                        NetworkDevicesworksheet.Cell(currentRow, 3).Value = "Кабинет";
                        #endregion
                        #region Other devices
                        currentRow = 1;
                        OtherDevicesworksheet.Cell(currentRow, 1).Value = "Дата создания отчета:";
                        OtherDevicesworksheet.Cell(currentRow, 2).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        currentRow++;
                        OtherDevicesworksheet.Cell(currentRow, 1).Value = "Инвентарный номер";
                        OtherDevicesworksheet.Cell(currentRow, 2).Value = "Наименование";
                        OtherDevicesworksheet.Cell(currentRow, 3).Value = "Кабинет";
                        #endregion
                        #endregion

                        #region Body
                        #region PC
                        var FilterPC = from b in context.pc_viewsearch where b.Name_Room != "Spisanie" select b;
                        currentRow = 2;
                        foreach (var data in FilterPC)
                        {
                            currentRow++;
                            PCworksheet.Cell(currentRow, 1).Value = data.Inventory_Number;
                            PCworksheet.Cell(currentRow, 2).Value = data.Name;
                            PCworksheet.Cell(currentRow, 3).Value = data.Name_Room;
                            PCworksheet.Cell(currentRow, 4).Value = data.Surname;
                        }
                        #endregion
                        #region CPU
                        var FilterCPU = from b in context.cpu_view where b.Name_Room != "Spisanie" select b;
                        currentRow = 2;
                        foreach (var data in FilterCPU)
                        {
                            currentRow++;
                            CPUworksheet.Cell(currentRow, 1).Value = data.Inventory_Number_CPU;
                            CPUworksheet.Cell(currentRow, 2).Value = data.Name;
                            CPUworksheet.Cell(currentRow, 3).Value = data.Socket;
                            CPUworksheet.Cell(currentRow, 4).Value = data.Clock_Frequency;
                            CPUworksheet.Cell(currentRow, 5).Value = data.Name_Room;
                        }
                        #endregion
                        #region RAM
                        var FilterRAM = from b in context.ram_view where b.Name_Room != "Spisanie" select b;
                        currentRow = 2;
                        foreach (var data in FilterRAM)
                        {
                            currentRow++;
                            RAMworksheet.Cell(currentRow, 1).Value = data.Inventory_Number_RAM;
                            RAMworksheet.Cell(currentRow, 2).Value = data.Name;
                            RAMworksheet.Cell(currentRow, 3).Value = data.Type;
                            RAMworksheet.Cell(currentRow, 4).Value = data.Memory_Size;
                            RAMworksheet.Cell(currentRow, 5).Value = data.Operating_Freequency;
                            RAMworksheet.Cell(currentRow, 6).Value = data.Name_Room;
                        }
                        #endregion
                        #region Peripherals
                        var FilterPeripherals = from b in context.peripherals_view where b.Name_Room != "Spisanie" select b;
                        currentRow = 2;
                        foreach (var data in FilterPeripherals)
                        {
                            currentRow++;
                            Peripheralsworksheet.Cell(currentRow, 1).Value = data.Inventory_Number;
                            Peripheralsworksheet.Cell(currentRow, 2).Value = data.Name;
                            Peripheralsworksheet.Cell(currentRow, 3).Value = data.Name_Room;
                        }
                        #endregion
                        #region Printers
                        var FilterPrinters = from b in context.printer_view where b.Name_Room != "Spisanie" select b;
                        currentRow = 2;
                        foreach (var data in FilterPrinters)
                        {
                            currentRow++;
                            Printersworksheet.Cell(currentRow, 1).Value = data.Inventory_Number;
                            Printersworksheet.Cell(currentRow, 2).Value = data.Name;
                            Printersworksheet.Cell(currentRow, 3).Value = data.Name_Room;
                        }
                        #endregion
                        #region Cartridge
                        var FilterCartridge = from b in context.cartridge_view where b.Name_Room != "Spisanie" select b;
                        currentRow = 2;
                        foreach (var data in FilterCartridge)
                        {
                            currentRow++;
                            Cartridgeworksheet.Cell(currentRow, 1).Value = data.Inventory_Number;
                            Cartridgeworksheet.Cell(currentRow, 2).Value = data.Name_Cartinge;
                            Cartridgeworksheet.Cell(currentRow, 3).Value = data.Name_Room;
                        }
                        #endregion
                        #region Network device
                        var FilterNetworkDevices = from b in context.network_devices_view where b.Name_Room != "Spisanie" select b;
                        currentRow = 2;
                        foreach (var data in FilterNetworkDevices)
                        {
                            currentRow++;
                            NetworkDevicesworksheet.Cell(currentRow, 1).Value = data.Inventory_Number;
                            NetworkDevicesworksheet.Cell(currentRow, 2).Value = data.Name;
                            NetworkDevicesworksheet.Cell(currentRow, 3).Value = data.Name_Room;
                        }
                        #endregion
                        #region Other device
                        var FilterOtherDevice = from b in context.other_devices_view where b.Name_Room != "Spisanie" select b;
                        currentRow = 2;
                        foreach (var data in FilterOtherDevice)
                        {
                            currentRow++;
                            OtherDevicesworksheet.Cell(currentRow, 1).Value = data.Inventory_Number;
                            OtherDevicesworksheet.Cell(currentRow, 2).Value = data.Name;
                            OtherDevicesworksheet.Cell(currentRow, 3).Value = data.Name_Room;
                        }
                        #endregion
                        workbook.SaveAs(@"C:\reports\All_Devices_ " + DateTime.Now.ToString("dd/MM/yyyy_HH/mm/ss") + ".xlsx");
                        #endregion
                    }
                    break;
                case 1:
                    using (var workbook = new XLWorkbook())
                    {
                        var PCworksheet = workbook.Worksheets.Add("PС");
                        var CPUworksheet = workbook.Worksheets.Add("CPU");
                        var RAMworksheet = workbook.Worksheets.Add("RAM");
                        var Peripheralsworksheet = workbook.Worksheets.Add("Peripherals");
                        var Printersworksheet = workbook.Worksheets.Add("Printers");
                        var Cartridgeworksheet = workbook.Worksheets.Add("Сartridge");
                        var NetworkDevicesworksheet = workbook.Worksheets.Add("Network devices");
                        var OtherDevicesworksheet = workbook.Worksheets.Add("Other devices");
                        var currentRow = 1;

                        #region header
                        #region PC
                        PCworksheet.Cell(currentRow, 1).Value = "Дата создания отчета:";
                        PCworksheet.Cell(currentRow, 2).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        currentRow++;
                        PCworksheet.Cell(currentRow, 1).Value = "Инвентарный номер";
                        PCworksheet.Cell(currentRow, 2).Value = "Наименование";
                        PCworksheet.Cell(currentRow, 3).Value = "Кабинет";
                        PCworksheet.Cell(currentRow, 4).Value = "Ответственный";
                        #endregion
                        #region CPU
                        currentRow = 1;
                        CPUworksheet.Cell(currentRow, 1).Value = "Дата создания отчета:";
                        CPUworksheet.Cell(currentRow, 2).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        currentRow++;
                        CPUworksheet.Cell(currentRow, 1).Value = "Инвентарный номер";
                        CPUworksheet.Cell(currentRow, 2).Value = "Наименование";
                        CPUworksheet.Cell(currentRow, 3).Value = "Сокет";
                        CPUworksheet.Cell(currentRow, 4).Value = "Тактовая частота";
                        CPUworksheet.Cell(currentRow, 4).Value = "Кабинет";
                        #endregion
                        #region RAM
                        currentRow = 1;
                        RAMworksheet.Cell(currentRow, 1).Value = "Дата создания отчета:";
                        RAMworksheet.Cell(currentRow, 2).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        currentRow++;
                        RAMworksheet.Cell(currentRow, 1).Value = "Инвентарный номер";
                        RAMworksheet.Cell(currentRow, 2).Value = "Наименование";
                        RAMworksheet.Cell(currentRow, 3).Value = "Тип";
                        RAMworksheet.Cell(currentRow, 4).Value = "Объем памяти";
                        RAMworksheet.Cell(currentRow, 5).Value = "Рабочая частота";
                        RAMworksheet.Cell(currentRow, 6).Value = "Кабинет";
                        #endregion
                        #region Peripherals
                        currentRow = 1;
                        Peripheralsworksheet.Cell(currentRow, 1).Value = "Дата создания отчета:";
                        Peripheralsworksheet.Cell(currentRow, 2).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        currentRow++;
                        Peripheralsworksheet.Cell(currentRow, 1).Value = "Инвентарный номер";
                        Peripheralsworksheet.Cell(currentRow, 2).Value = "Наименование";
                        Peripheralsworksheet.Cell(currentRow, 3).Value = "Кабинет";
                        #endregion
                        #region Printers
                        currentRow = 1;
                        Printersworksheet.Cell(currentRow, 1).Value = "Дата создания отчета:";
                        Printersworksheet.Cell(currentRow, 2).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        currentRow++;
                        Printersworksheet.Cell(currentRow, 1).Value = "Инвентарный номер";
                        Printersworksheet.Cell(currentRow, 2).Value = "Наименование";
                        Printersworksheet.Cell(currentRow, 3).Value = "Кабинет";
                        #endregion
                        #region Cartridge
                        currentRow = 1;
                        Cartridgeworksheet.Cell(currentRow, 1).Value = "Дата создания отчета:";
                        Cartridgeworksheet.Cell(currentRow, 2).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        currentRow++;
                        Cartridgeworksheet.Cell(currentRow, 1).Value = "Инвентарный номер";
                        Cartridgeworksheet.Cell(currentRow, 2).Value = "Наименование";
                        Cartridgeworksheet.Cell(currentRow, 3).Value = "Кабинет";
                        #endregion
                        #region Network devices
                        currentRow = 1;
                        NetworkDevicesworksheet.Cell(currentRow, 1).Value = "Дата создания отчета:";
                        NetworkDevicesworksheet.Cell(currentRow, 2).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        currentRow++;
                        NetworkDevicesworksheet.Cell(currentRow, 1).Value = "Инвентарный номер";
                        NetworkDevicesworksheet.Cell(currentRow, 2).Value = "Наименование";
                        NetworkDevicesworksheet.Cell(currentRow, 3).Value = "Кабинет";
                        #endregion
                        #region Other devices
                        currentRow = 1;
                        OtherDevicesworksheet.Cell(currentRow, 1).Value = "Дата создания отчета:";
                        OtherDevicesworksheet.Cell(currentRow, 2).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        currentRow++;
                        OtherDevicesworksheet.Cell(currentRow, 1).Value = "Инвентарный номер";
                        OtherDevicesworksheet.Cell(currentRow, 2).Value = "Наименование";
                        OtherDevicesworksheet.Cell(currentRow, 3).Value = "Кабинет";
                        #endregion
                        #endregion

                        #region Body
                        #region PC
                        var FilterPC = from b in context.pc_viewsearch where b.Name_Room == "TechObsluzhivanie" select b;
                        currentRow = 2;
                        foreach (var data in FilterPC)
                        {
                            currentRow++;
                            PCworksheet.Cell(currentRow, 1).Value = data.Inventory_Number;
                            PCworksheet.Cell(currentRow, 2).Value = data.Name;
                            PCworksheet.Cell(currentRow, 3).Value = data.Name_Room;
                            PCworksheet.Cell(currentRow, 4).Value = data.Surname;
                        }
                        #endregion
                        #region CPU
                        var FilterCPU = from b in context.cpu_view where b.Name_Room == "TechObsluzhivanie" select b;
                        currentRow = 2;
                        foreach (var data in FilterCPU)
                        {
                            currentRow++;
                            CPUworksheet.Cell(currentRow, 1).Value = data.Inventory_Number_CPU;
                            CPUworksheet.Cell(currentRow, 2).Value = data.Name;
                            CPUworksheet.Cell(currentRow, 3).Value = data.Socket;
                            CPUworksheet.Cell(currentRow, 4).Value = data.Clock_Frequency;
                            CPUworksheet.Cell(currentRow, 5).Value = data.Name_Room;
                        }
                        #endregion
                        #region RAM
                        var FilterRAM = from b in context.ram_view where b.Name_Room == "TechObsluzhivanie" select b;
                        currentRow = 2;
                        foreach (var data in FilterRAM)
                        {
                            currentRow++;
                            RAMworksheet.Cell(currentRow, 1).Value = data.Inventory_Number_RAM;
                            RAMworksheet.Cell(currentRow, 2).Value = data.Name;
                            RAMworksheet.Cell(currentRow, 3).Value = data.Type;
                            RAMworksheet.Cell(currentRow, 4).Value = data.Memory_Size;
                            RAMworksheet.Cell(currentRow, 5).Value = data.Operating_Freequency;
                            RAMworksheet.Cell(currentRow, 6).Value = data.Name_Room;
                        }
                        #endregion
                        #region Peripherals
                        var FilterPeripherals = from b in context.peripherals_view where b.Name_Room == "TechObsluzhivanie" select b;
                        currentRow = 2;
                        foreach (var data in FilterPeripherals)
                        {
                            currentRow++;
                            Peripheralsworksheet.Cell(currentRow, 1).Value = data.Inventory_Number;
                            Peripheralsworksheet.Cell(currentRow, 2).Value = data.Name;
                            Peripheralsworksheet.Cell(currentRow, 3).Value = data.Name_Room;
                        }
                        #endregion
                        #region Printers
                        var FilterPrinters = from b in context.printer_view where b.Name_Room == "TechObsluzhivanie" select b;
                        currentRow = 2;
                        foreach (var data in FilterPrinters)
                        {
                            currentRow++;
                            Printersworksheet.Cell(currentRow, 1).Value = data.Inventory_Number;
                            Printersworksheet.Cell(currentRow, 2).Value = data.Name;
                            Printersworksheet.Cell(currentRow, 3).Value = data.Name_Room;
                        }
                        #endregion
                        #region Cartridge
                        var FilterCartridge = from b in context.cartridge_view where b.Name_Room == "TechObsluzhivanie" select b;
                        currentRow = 2;
                        foreach (var data in FilterCartridge)
                        {
                            currentRow++;
                            Cartridgeworksheet.Cell(currentRow, 1).Value = data.Inventory_Number;
                            Cartridgeworksheet.Cell(currentRow, 2).Value = data.Name_Cartinge;
                            Cartridgeworksheet.Cell(currentRow, 3).Value = data.Name_Room;
                        }
                        #endregion
                        #region Network device
                        var FilterNetworkDevices = from b in context.network_devices_view where b.Name_Room == "TechObsluzhivanie" select b;
                        currentRow = 2;
                        foreach (var data in FilterNetworkDevices)
                        {
                            currentRow++;
                            NetworkDevicesworksheet.Cell(currentRow, 1).Value = data.Inventory_Number;
                            NetworkDevicesworksheet.Cell(currentRow, 2).Value = data.Name;
                            NetworkDevicesworksheet.Cell(currentRow, 3).Value = data.Name_Room;
                        }
                        #endregion
                        #region Other device
                        var FilterOtherDevice = from b in context.other_devices_view where b.Name_Room == "TechObsluzhivanie" select b;
                        currentRow = 2;
                        foreach (var data in FilterOtherDevice)
                        {
                            currentRow++;
                            OtherDevicesworksheet.Cell(currentRow, 1).Value = data.Inventory_Number;
                            OtherDevicesworksheet.Cell(currentRow, 2).Value = data.Name;
                            OtherDevicesworksheet.Cell(currentRow, 3).Value = data.Name_Room;
                        }
                        #endregion
                        workbook.SaveAs(@"C:\reports\TechObsluzhivanie_Devices_ " + DateTime.Now.ToString("dd/MM/yyyy_HH/mm/ss") + ".xlsx");
                        #endregion
                    }
                    break;
                
                case 2:
                    using (var workbook = new XLWorkbook())
                    {
                        var PCworksheet = workbook.Worksheets.Add("PС");
                        var CPUworksheet = workbook.Worksheets.Add("CPU");
                        var RAMworksheet = workbook.Worksheets.Add("RAM");
                        var Peripheralsworksheet = workbook.Worksheets.Add("Peripherals");
                        var Printersworksheet = workbook.Worksheets.Add("Printers");
                        var Cartridgeworksheet = workbook.Worksheets.Add("Сartridge");
                        var NetworkDevicesworksheet = workbook.Worksheets.Add("Network devices");
                        var OtherDevicesworksheet = workbook.Worksheets.Add("Other devices");
                        var currentRow = 1;

                        #region header
                        #region PC
                        PCworksheet.Cell(currentRow, 1).Value = "Дата создания отчета:";
                        PCworksheet.Cell(currentRow, 2).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        currentRow++;
                        PCworksheet.Cell(currentRow, 1).Value = "Инвентарный номер";
                        PCworksheet.Cell(currentRow, 2).Value = "Наименование";
                        PCworksheet.Cell(currentRow, 3).Value = "Кабинет";
                        PCworksheet.Cell(currentRow, 4).Value = "Ответственный";
                        #endregion
                        #region CPU
                        currentRow = 1;
                        CPUworksheet.Cell(currentRow, 1).Value = "Дата создания отчета:";
                        CPUworksheet.Cell(currentRow, 2).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        currentRow++;
                        CPUworksheet.Cell(currentRow, 1).Value = "Инвентарный номер";
                        CPUworksheet.Cell(currentRow, 2).Value = "Наименование";
                        CPUworksheet.Cell(currentRow, 3).Value = "Сокет";
                        CPUworksheet.Cell(currentRow, 4).Value = "Тактовая частота";
                        CPUworksheet.Cell(currentRow, 4).Value = "Кабинет";
                        #endregion
                        #region RAM
                        currentRow = 1;
                        RAMworksheet.Cell(currentRow, 1).Value = "Дата создания отчета:";
                        RAMworksheet.Cell(currentRow, 2).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        currentRow++;
                        RAMworksheet.Cell(currentRow, 1).Value = "Инвентарный номер";
                        RAMworksheet.Cell(currentRow, 2).Value = "Наименование";
                        RAMworksheet.Cell(currentRow, 3).Value = "Тип";
                        RAMworksheet.Cell(currentRow, 4).Value = "Объем памяти";
                        RAMworksheet.Cell(currentRow, 5).Value = "Рабочая частота";
                        RAMworksheet.Cell(currentRow, 6).Value = "Кабинет";
                        #endregion
                        #region Peripherals
                        currentRow = 1;
                        Peripheralsworksheet.Cell(currentRow, 1).Value = "Дата создания отчета:";
                        Peripheralsworksheet.Cell(currentRow, 2).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        currentRow++;
                        Peripheralsworksheet.Cell(currentRow, 1).Value = "Инвентарный номер";
                        Peripheralsworksheet.Cell(currentRow, 2).Value = "Наименование";
                        Peripheralsworksheet.Cell(currentRow, 3).Value = "Кабинет";
                        #endregion
                        #region Printers
                        currentRow = 1;
                        Printersworksheet.Cell(currentRow, 1).Value = "Дата создания отчета:";
                        Printersworksheet.Cell(currentRow, 2).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        currentRow++;
                        Printersworksheet.Cell(currentRow, 1).Value = "Инвентарный номер";
                        Printersworksheet.Cell(currentRow, 2).Value = "Наименование";
                        Printersworksheet.Cell(currentRow, 3).Value = "Кабинет";
                        #endregion
                        #region Cartridge
                        currentRow = 1;
                        Cartridgeworksheet.Cell(currentRow, 1).Value = "Дата создания отчета:";
                        Cartridgeworksheet.Cell(currentRow, 2).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        currentRow++;
                        Cartridgeworksheet.Cell(currentRow, 1).Value = "Инвентарный номер";
                        Cartridgeworksheet.Cell(currentRow, 2).Value = "Наименование";
                        Cartridgeworksheet.Cell(currentRow, 3).Value = "Кабинет";
                        #endregion
                        #region Network devices
                        currentRow = 1;
                        NetworkDevicesworksheet.Cell(currentRow, 1).Value = "Дата создания отчета:";
                        NetworkDevicesworksheet.Cell(currentRow, 2).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        currentRow++;
                        NetworkDevicesworksheet.Cell(currentRow, 1).Value = "Инвентарный номер";
                        NetworkDevicesworksheet.Cell(currentRow, 2).Value = "Наименование";
                        NetworkDevicesworksheet.Cell(currentRow, 3).Value = "Кабинет";
                        #endregion
                        #region Other devices
                        currentRow = 1;
                        OtherDevicesworksheet.Cell(currentRow, 1).Value = "Дата создания отчета:";
                        OtherDevicesworksheet.Cell(currentRow, 2).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        currentRow++;
                        OtherDevicesworksheet.Cell(currentRow, 1).Value = "Инвентарный номер";
                        OtherDevicesworksheet.Cell(currentRow, 2).Value = "Наименование";
                        OtherDevicesworksheet.Cell(currentRow, 3).Value = "Кабинет";
                        #endregion
                        #endregion

                        #region Body
                        #region PC
                        var FilterPC = from b in context.pc_viewsearch where b.Name_Room == "Spisanie" select b;
                        currentRow = 2;
                        foreach (var data in FilterPC)
                        {
                            currentRow++;
                            PCworksheet.Cell(currentRow, 1).Value = data.Inventory_Number;
                            PCworksheet.Cell(currentRow, 2).Value = data.Name;
                            PCworksheet.Cell(currentRow, 3).Value = data.Name_Room;
                            PCworksheet.Cell(currentRow, 4).Value = data.Surname;
                        }
                        #endregion
                        #region CPU
                        var FilterCPU = from b in context.cpu_view where b.Name_Room == "Spisanie" select b;
                        currentRow = 2;
                        foreach (var data in FilterCPU)
                        {
                            currentRow++;
                            CPUworksheet.Cell(currentRow, 1).Value = data.Inventory_Number_CPU;
                            CPUworksheet.Cell(currentRow, 2).Value = data.Name;
                            CPUworksheet.Cell(currentRow, 3).Value = data.Socket;
                            CPUworksheet.Cell(currentRow, 4).Value = data.Clock_Frequency;
                            CPUworksheet.Cell(currentRow, 5).Value = data.Name_Room;
                        }
                        #endregion
                        #region RAM
                        var FilterRAM = from b in context.ram_view where b.Name_Room == "Spisanie" select b;
                        currentRow = 2;
                        foreach (var data in FilterRAM)
                        {
                            currentRow++;
                            RAMworksheet.Cell(currentRow, 1).Value = data.Inventory_Number_RAM;
                            RAMworksheet.Cell(currentRow, 2).Value = data.Name;
                            RAMworksheet.Cell(currentRow, 3).Value = data.Type;
                            RAMworksheet.Cell(currentRow, 4).Value = data.Memory_Size;
                            RAMworksheet.Cell(currentRow, 5).Value = data.Operating_Freequency;
                            RAMworksheet.Cell(currentRow, 6).Value = data.Name_Room;
                        }
                        #endregion
                        #region Peripherals
                        var FilterPeripherals = from b in context.peripherals_view where b.Name_Room == "Spisanie" select b;
                        currentRow = 2;
                        foreach (var data in FilterPeripherals)
                        {
                            currentRow++;
                            Peripheralsworksheet.Cell(currentRow, 1).Value = data.Inventory_Number;
                            Peripheralsworksheet.Cell(currentRow, 2).Value = data.Name;
                            Peripheralsworksheet.Cell(currentRow, 3).Value = data.Name_Room;
                        }
                        #endregion
                        #region Printers
                        var FilterPrinters = from b in context.printer_view where b.Name_Room == "Spisanie" select b;
                        currentRow = 2;
                        foreach (var data in FilterPrinters)
                        {
                            currentRow++;
                            Printersworksheet.Cell(currentRow, 1).Value = data.Inventory_Number;
                            Printersworksheet.Cell(currentRow, 2).Value = data.Name;
                            Printersworksheet.Cell(currentRow, 3).Value = data.Name_Room;
                        }
                        #endregion
                        #region Cartridge
                        var FilterCartridge = from b in context.cartridge_view where b.Name_Room == "Spisanie" select b;
                        currentRow = 2;
                        foreach (var data in FilterCartridge)
                        {
                            currentRow++;
                            Cartridgeworksheet.Cell(currentRow, 1).Value = data.Inventory_Number;
                            Cartridgeworksheet.Cell(currentRow, 2).Value = data.Name_Cartinge;
                            Cartridgeworksheet.Cell(currentRow, 3).Value = data.Name_Room;
                        }
                        #endregion
                        #region Network device
                        var FilterNetworkDevices = from b in context.network_devices_view where b.Name_Room == "Spisanie" select b;
                        currentRow = 2;
                        foreach (var data in FilterNetworkDevices)
                        {
                            currentRow++;
                            NetworkDevicesworksheet.Cell(currentRow, 1).Value = data.Inventory_Number;
                            NetworkDevicesworksheet.Cell(currentRow, 2).Value = data.Name;
                            NetworkDevicesworksheet.Cell(currentRow, 3).Value = data.Name_Room;
                        }
                        #endregion
                        #region Other device
                        var FilterOtherDevice = from b in context.other_devices_view where b.Name_Room == "Spisanie" select b;
                        currentRow = 2;
                        foreach (var data in FilterOtherDevice)
                        {
                            currentRow++;
                            OtherDevicesworksheet.Cell(currentRow, 1).Value = data.Inventory_Number;
                            OtherDevicesworksheet.Cell(currentRow, 2).Value = data.Name;
                            OtherDevicesworksheet.Cell(currentRow, 3).Value = data.Name_Room;
                        }
                        #endregion
                        workbook.SaveAs(@"C:\reports\Spisanie_Devices_ " + DateTime.Now.ToString("dd/MM/yyyy_HH/mm/ss") + ".xlsx");
                        #endregion
                    }
                    break;
                case 3:
                    using (var workbook = new XLWorkbook())
                    {
                        var EventLogworksheet = workbook.Worksheets.Add("Event_log");
                        var currentRow = 1;

                        #region header
                        EventLogworksheet.Cell(currentRow, 1).Value = "Дата создания отчета:";
                        EventLogworksheet.Cell(currentRow, 2).Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        currentRow++;
                        EventLogworksheet.Cell(currentRow, 1).Value = "Дата и время";
                        EventLogworksheet.Cell(currentRow, 2).Value = "Фамилия сотрудника";
                        EventLogworksheet.Cell(currentRow, 3).Value = "Событие";
                        #endregion

                        #region Body
                        var FilterEmployeeEventLog = from b in context.event_log_view where b.Surname == UserProgram.Surname select b;
                        foreach (var data in FilterEmployeeEventLog)
                        {
                            currentRow++;
                            EventLogworksheet.Cell(currentRow, 1).Value = data.DateTime;
                            EventLogworksheet.Cell(currentRow, 2).Value = data.Surname;
                            EventLogworksheet.Cell(currentRow, 3).Value = data.Event;
                        }
                        workbook.SaveAs(@"C:\reports\Event_Log_ "+DateTime.Now.ToString("dd/MM/yyyy_HH/mm/ss")+".xlsx");
                        #endregion
                    }
                    break;
                default: MessageBox.Show("Ошибка!"); break;
            }
            MessageBox.Show("Отчет успешно сформирован!");
        }
    }
}
