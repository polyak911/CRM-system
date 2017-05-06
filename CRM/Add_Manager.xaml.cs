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
using CRM.BD;

namespace CRM
{
    /// <summary>
    /// Логика взаимодействия для Change.xaml
    /// </summary>
    public partial class Add_Manager: Window
    {
        public Add_Manager()
        {
            InitializeComponent();
            using (CRMContext dbContext = new CRMContext())
            {
                foreach (var item in dbContext.CatalogPositions)
                {
                    cb_position.Items.Add(item.Position);
                }
                foreach (var item in dbContext.CatalogGroupManagers)
                {
                    cb_group.Items.Add(item.Group);
                }
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            using (CRMContext dbContext = new CRMContext())
            {
                var manager = new BD.Managers();
                manager.Name = tb_name.Text;
                manager.Login = tb_login.Text;
                manager.Password = tb_password.Text;
                manager.Position = cb_position.SelectedItem.ToString();
                manager.Group = cb_group.SelectedItem.ToString();
                manager.Address = tb_address.Text;
                manager.Phone = tb_phone.Text;
                manager.Passport = tb_passport.Text;
                manager.DateOfBirth = d_dateofbirth.SelectedDate;
                manager.DateRecruitment = d_daterecruitment.SelectedDate;
                manager.Email = tb_email.Text;
                manager.Info = tb_info.Text;
                dbContext.Managers.Add(manager);
                dbContext.SaveChanges();
            }
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}