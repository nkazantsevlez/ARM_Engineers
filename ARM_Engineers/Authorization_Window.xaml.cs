﻿using System;
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
    /// Логика взаимодействия для Authorization_Window.xaml
    /// </summary>
    public partial class Authorization_Window : Window
    {
        public Authorization_Window()
        {
            InitializeComponent();
        }

        private void Autorization_Button_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(Login_TextBox.Text))
            {
                MessageBox.Show("Введите логин","Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
                Login_TextBox.Focus();
                return;
            }

            if (string.IsNullOrEmpty(Password_PasswordBox.Password.ToString()))
            {
                MessageBox.Show("Введите пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                Password_PasswordBox.Focus();
                return;
            }

            using (var context = new arm_engineersEntities())
            {
                var CheckLoginAndPassword = context.Check_Login_And_Password(Login_TextBox.Text, Password_PasswordBox.Password.ToString()).ToList();
                if (CheckLoginAndPassword.Count() == 1)
                {
                    MessageBox.Show("Авторизация выполнена успешно");
                    foreach (users ResultCheck in CheckLoginAndPassword)
                    {
                        UserProgram.ID = ResultCheck.ID;
                        UserProgram.Name = ResultCheck.Name;
                        UserProgram.Surname = ResultCheck.Surname;
                    }

                    var Event_Log_Entry = new event_log()
                    {
                        ID_Users = UserProgram.ID,
                        DateTime=DateTime.Now.ToString(),
                        Event= "Successful authorization"
                    };
                    context.event_log.Add(Event_Log_Entry);
                    context.SaveChanges();

                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Ошибка авторизации");
                }
            }
        }

        private void Close_Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
