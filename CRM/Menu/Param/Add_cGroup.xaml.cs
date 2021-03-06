﻿using System;
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
using CRM.BD;

namespace CRM
{
    /// <summary>
    /// Логика взаимодействия для Add_cGroup.xaml
    /// </summary>
    public partial class Add_cGroup : Window
    {
        public Add_cGroup()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            using (CRMContext dbContext = new CRMContext())
            {
                var group = new BD.CatalogGroupManagers();
                Random rnd = new Random();
                try
                {
                    int i = 1 + rnd.Next(10000);
                    group.Group = l_id.Text;
                    group.Id = i;
                }
                catch (Exception)
                {
                    MessageBox.Show("Повторите попытку");
                }
                var results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
                var context = new ValidationContext(group);
                if (!Validator.TryValidateObject(group, context, results, true))
                {
                    foreach (var error in results)
                    {
                        MessageBox.Show(error.ErrorMessage);
                    }
                }
                else
                {
                    try
                    {
                    dbContext.CatalogGroupManagers.Add(group);
                    dbContext.SaveChanges();
                    }
                    catch 
                    {
                        MessageBox.Show("Ошибка");
                    }
                }
                if (Validator.TryValidateObject(group, context, results, true))
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
