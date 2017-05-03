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
    public partial class Add : Window
    {
        public Add()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            using (CRMContext dbContext = new CRMContext())
            {
                var task = new BD.Tasks();
                task.Id = Convert.ToInt32(l_id.Text);
                task.Client = l_client.Text;
                task.Manager = l_manager.Text;
                task.Task = l_task.Text;
                task.Info = l_info.Text;
                task.Status = l_status.Text;
                task.DateStart = d_start.SelectedDate;
                task.DateComplete = d_complete.SelectedDate;
                dbContext.Tasks.Add(task);
                dbContext.SaveChanges();
            }
        }
    }
}
