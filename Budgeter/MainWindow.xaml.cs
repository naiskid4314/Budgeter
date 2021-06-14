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

namespace Budgeter
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Item.ItemsAdd();
            Item i = new Item();
            label1.DataContext = label2.DataContext = label3.DataContext = Item.items[0];
            listbox.DataContext = i;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Item.items.Add(new Item(nameText.Text, priceText.Text, calendar.SelectedDate));
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
