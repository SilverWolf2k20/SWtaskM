﻿//-----------------------------------------------------------------------------
// <auto-generated/>
// <summary> 
// Объекты и конструктор класса главного окна.
// </summary> 
//-----------------------------------------------------------------------------
using SWtaskM.WPF.UI.Controls;
using System;
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

namespace SWtaskM.WPF.UI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainControl mainControl;
        public MainWindow()
        {
            InitializeComponent();
            mainControl = new MainControl();
        }

        /// <summary>
        /// Загрузка окна приложения.
        /// </summary>
        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            gridDirector.Children.Add(mainControl);
        }

        private void ButtonExitClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ListViewMenuSelectionChanged(object sender,
                                                  SelectionChangedEventArgs e)
        {
            gridDirector.Children.Clear();
            gridDirector.Children.Add(mainControl);
        }

        private void GridMouseLeftButtonDown(object sender, 
                                             MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
//component/controls/Textures/Weather/snow.png