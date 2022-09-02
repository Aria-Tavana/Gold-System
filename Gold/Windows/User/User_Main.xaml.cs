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

namespace Gold.Windows.User
{
    public partial class User_Main : Window
    {
        public bool IsFullScreen { get; set; }
        public User_Main()
        {
            InitializeComponent();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void tbtnFullScreen_Click(object sender, RoutedEventArgs e)
        {
            if (IsFullScreen == false)
            {
                WindowState = WindowState.Maximized;
                IsFullScreen = true;
            }
            else
            {
                WindowState = WindowState.Normal;
                IsFullScreen = false;
            }
        }
    }
}
