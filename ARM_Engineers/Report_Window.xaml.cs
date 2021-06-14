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
    /// Логика взаимодействия для Report_Window.xaml
    /// </summary>
    public partial class Report_Window : Window
    {
        public Report_Window()
        {
            InitializeComponent();
            /*FirstReport firstReport = new FirstReport();
            firstReport.Load(@"FirstReport.rep");
            Event_Log_ReportViewer.ViewerCore.ReportSource = firstReport;*/

        }

        private void Close_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Selected_Report_Combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch(Selected_Report_Combobox.SelectedIndex)
            {
                case 0: All_Devices_Report all_Devices_Report = new All_Devices_Report();
                    all_Devices_Report.Load(@"All_Devices_Report.rep");
                    View_ReportViewer.ViewerCore.ReportSource = all_Devices_Report;
                    break;
                case 1: 
                    Event_Log_Report event_Log_Report = new Event_Log_Report();
                    event_Log_Report.Load(@"Event_Log_Report.rep");
                    View_ReportViewer.ViewerCore.ReportSource = event_Log_Report; 
                    break;
                default: MessageBox.Show("Ошибка!");break;
            }
        }
    }
}
