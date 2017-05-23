﻿using CRM.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

namespace CRM
{
    /// <summary>
    /// Логика взаимодействия для Change.xaml
    /// </summary>
    public partial class Change_Manager : Window
    {
        public BD.Managers del_manager = null;
        public Change_Manager(BD.Managers manager)
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
                tb_name.Text = manager.Name;
                tb_login.Text = manager.Login;
                cb_position.SelectedItem = manager.Position;
                cb_group.SelectedItem = manager.Group;
                tb_address.Text = manager.Address;
                tb_phone.Text = manager.Phone;
                tb_passport.Text = manager.Passport;
                d_dateofbirth.SelectedDate = manager.DateOfBirth;
                d_daterecruitment.SelectedDate = manager.DateRecruitment;
                tb_email.Text = manager.Email;
                tb_info.Text = manager.Info;
                del_manager = manager;
            }
            

        }
        

        private void button_Click(object sender, RoutedEventArgs e)
        {
            using (CRMContext dbContext = new CRMContext())
            {
                var manager = new BD.Managers();
                manager.Name = tb_name.Text;
                manager.Login = tb_login.Text;
                if (tb_password.Text!=null) manager.Password = Hash.EncryptPassword(tb_login.Text, tb_password.Text);
                manager.Position = cb_position.SelectedItem.ToString();
                manager.Group = cb_group.SelectedItem.ToString();
                manager.Address = tb_address.Text;
                manager.Phone = tb_phone.Text;
                manager.Passport = tb_passport.Text;
                manager.DateOfBirth = d_dateofbirth.SelectedDate;
                manager.DateRecruitment = d_daterecruitment.SelectedDate;
                manager.Email = tb_email.Text;
                manager.Info = tb_info.Text;
                dbContext.Entry(del_manager).State = System.Data.Entity.EntityState.Deleted;

                var results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
                var context = new ValidationContext(manager);
                if (!Validator.TryValidateObject(manager, context, results, true))
                {
                    foreach (var error in results)
                    {
                        MessageBox.Show(error.ErrorMessage);
                    }
                }
                else
                {
                    dbContext.Managers.Add(manager);
                    dbContext.SaveChanges();
                }
                if (Validator.TryValidateObject(manager, context, results, true))
                {
                    this.Close();
                }
            }
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}