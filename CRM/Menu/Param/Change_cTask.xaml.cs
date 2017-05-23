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
    /// Логика взаимодействия для Add_cGroup.xaml
    /// </summary>
    public partial class Change_cTask : Window
    {
        BD.CatalogTasks task;
        public Change_cTask(BD.CatalogTasks rt)
        {
            InitializeComponent();
            using (CRMContext dbContext = new CRMContext())
            {
                task = dbContext.CatalogTasks.Find(rt.Task);
                l_id.Text = task.Task.ToString();
                l_id_Copy.Text = task.Group.ToString();

            }
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            using (CRMContext dbContext = new CRMContext())
            {
                task.Task = l_id.Text;
                task.Group = l_id_Copy.Text;
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