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

namespace Chat_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void usernameText_MouseEnter(object sender, MouseEventArgs e)
        {
            if (usernameText.Text == "Search")
            {
                usernameText.Text = " ";
            }
        }

        private void usernameText_MouseLeave(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(usernameText.Text) || string.IsNullOrWhiteSpace(usernameText.Text))
            {
                usernameText.Text = "Search";
            }
        }

        private void TextBoxCH_MouseEnter(object sender, MouseEventArgs e)
        {
            if (TextBoxCH.Text == "Write a message...")
            {
                TextBoxCH.Text = " ";
            }
            else if (TextBoxCH.Text == "")
            {
                TextBoxCH.Text = "Write a message...";
            }
        }

        private void TextBoxCH_MouseLeave(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxCH.Text) || string.IsNullOrWhiteSpace(TextBoxCH.Text))
            {
                TextBoxCH.Text = "Write a message...";
            }
        }
    }
}
