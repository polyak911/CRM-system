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
using XMLE;
using System.Xml.Linq;

namespace CRM
{
    /// <summary>
    /// Логика взаимодействия для Tasks.xaml
    /// </summary>
    public partial class Tasks : UserControl
    {
        public Tasks(ref Grid rG)
        {
            InitializeComponent();
            Menu m = new Menu(rG, p_Tasks);
            G1.Children.Add(m);

            using (CRMContext dbContext = new CRMContext())
            {
                foreach (var item in dbContext.Tasks)
                {
                    if (IAm.isAdmin || IAm.myName == item.Manager) dg_Tasks.Items.Add(item);
                }
            }
        }


        private void Button_Add(object sender, RoutedEventArgs e)
        {
            Add add_Zad = new Add();
            add_Zad.Show();
        }

        private void Button_Change(object sender, RoutedEventArgs e)
        {
            if (dg_Tasks.SelectedItem != null)
            {
                if (IAm.isAdmin || IAm.myName == ((BD.Tasks)dg_Tasks.SelectedItem).Manager)
                {
                    Change change_Zad = new Change((BD.Tasks)dg_Tasks.SelectedItem);
                    change_Zad.Show();
                }
                else
                {
                    MessageBox.Show("Вы не имеете прав на изменение этой задачи!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите задачу.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Del(object sender, RoutedEventArgs e)
        {
            if (dg_Tasks.SelectedItem != null)
            {
                if (IAm.isAdmin || IAm.myName == ((BD.Tasks)dg_Tasks.SelectedItem).Manager)
                {
                    Delete delete_Zad = new Delete((BD.Tasks)dg_Tasks.SelectedItem);
                    delete_Zad.Show();
                }
                else
                {
                    MessageBox.Show("Вы не имеете прав на удаление этой задачи!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите задачу.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Save(object sender, RoutedEventArgs e)
        {
            List<BD.Tasks> task = new List<BD.Tasks>();
            using (CRMContext dbContext = new CRMContext())
            {
                foreach (var item in dbContext.Tasks)
                {
                    task.Add(item);
                }
            }
            XMLE.XML.Save_Tasks(task);
        }

        private void Button_Open(object sender, RoutedEventArgs e)
        {
            List<BD.Tasks> client = new List<BD.Tasks>();
            XML.openXml_tasks();
        }
        public void VoiceCNTRL(object sender, KeyEventArgs e)
        {
            string command = "";
            VoiceControl vc = new VoiceControl();

            if (e.Key == Key.G)
            {
                command = vc.VoiceContr(sender, e);

                switch (command)
                {
                    case "добавить":
                        Button_Add(sender, e);
                        break;
                    case "удалить":
                        Button_Del(sender, e);
                        break;
                    case "изменить":
                        Button_Change(sender, e);
                        break;
                    case "сохранить":
                        Button_Add(sender, e);
                        break;
                    case "открыть":
                        Button_Open(sender, e);
                        break;
                    case "":
                        break;
                }
            }
        }
    }

}
