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
using System.Windows.Navigation;
using System.Windows.Shapes;
using CRM.BD;

namespace CRM
{
    /// <summary>
    /// Логика взаимодействия для Search.xaml
    /// </summary>
    public partial class Search : UserControl
    {
        public Search(ref Grid rG)
        {
            InitializeComponent();
            Menu m = new Menu(rG, p_Search);
            G1.Children.Add(m);
            dg_Clients.Visibility = Visibility.Collapsed;
            dg_Tasks.Visibility = Visibility.Collapsed;
            dg_Managers.Visibility = Visibility.Collapsed;
            if (!IAm.isAdmin)
            {
                dg_Managers.Columns.Remove(dgc_address);
                dg_Managers.Columns.Remove(dgc_dateB);
                dg_Managers.Columns.Remove(dgc_dateR);
                dg_Managers.Columns.Remove(dgc_login);
                dg_Managers.Columns.Remove(dgc_pass);
                dg_Managers.Columns.Remove(dgc_passp);
            }
        }

        private void search_task_TextChanged(object sender, TextChangedEventArgs e)
        {
            using (CRMContext dbContext = new CRMContext())
            {
                dg_Tasks.Items.Clear();
                foreach (var item in dbContext.Tasks)
                {
                    string search = Convert.ToString(search_task.Text).ToLower();
                    if (search_task.Text == "")
                    {
                        dg_Tasks.Visibility = Visibility.Collapsed;
                    }
                    else if ((item.Task.ToString().ToLower()).Contains(search) || (item.Id.ToString()).Contains(search) || (item.Client.ToString().ToLower()).Contains(search) || (item.Manager.ToString().ToLower()).Contains(search) || (item.Info.ToString().ToLower()).Contains(search) || (item.DateStart.ToString().ToLower()).Contains(search) || (item.DateComplete.ToString().Contains(search)) || (item.Status.ToString().ToLower()).Contains(search))
                    {
                        dg_Tasks.Visibility = Visibility.Visible;
                        dg_Tasks.Items.Add(item);
                    }
                    else if (dg_Tasks.Items.Count == 0)
                    {
                        dg_Tasks.Visibility = Visibility.Collapsed;
                    }

                }

                
                dg_Clients.Items.Clear();
                foreach (var item in dbContext.Clients)
                {
                    string search = Convert.ToString(search_task.Text).ToLower();
                    if (search_task.Text == "")
                    {
                        dg_Clients.Visibility = Visibility.Collapsed;
                    }
                    else if (item.Name.ToString().ToLower().Contains(search) || (item.Address.ToString().ToLower()).Contains(search) || (item.Phone.ToString().ToLower()).Contains(search) || (item.Email.ToString().ToLower()).Contains(search) || (item.CheckingAccount.ToString().ToLower()).Contains(search) || (item.Bank.ToString().ToLower()).Contains(search) || (item.Director.ToString().ToLower()).Contains(search) || (item.Accountant.ToString().ToLower()).Contains(search)) //|| (item.Info.ToString().ToLower()).Contains(search))
                    {
                        dg_Clients.Visibility = Visibility.Visible;
                        dg_Clients.Items.Add(item);
                    }
                    else if (dg_Clients.Items.Count == 0)
                    {
                        dg_Clients.Visibility = Visibility.Collapsed;
                    }



                }
                dg_Managers.Items.Clear();
                foreach (var item in dbContext.Managers)
                {
                    string search = Convert.ToString(search_task.Text).ToLower();
                    if (search_task.Text == "")
                    {
                        dg_Managers.Visibility = Visibility.Collapsed;
                    }
                    else if (item.Name.ToString().ToLower().Contains(search) || (item.Login.ToString().ToLower()).Contains(search) || (item.Password.ToString().ToLower()).Contains(search) || (item.Position.ToString().ToLower()).Contains(search) || (item.Group.ToString().ToLower()).Contains(search) || (item.Address.ToString().ToLower()).Contains(search) || (item.Phone.ToString().ToLower()).Contains(search) || (item.Passport.ToString().ToLower()).Contains(search) || (item.DateOfBirth.ToString().ToLower()).Contains(search) || (item.DateRecruitment.ToString().ToLower()).Contains(search) || (item.Email.ToString().ToLower()).Contains(search) || (item.Info.ToString().ToLower()).Contains(search))
                    {
                        dg_Managers.Visibility = Visibility.Visible;
                        dg_Managers.Items.Add(item);
                    }
                    else if (dg_Managers.Items.Count == 0) 
                    {
                        dg_Managers.Visibility = Visibility.Collapsed;
                    }             
                }
                
            }
        }
    }
}
    