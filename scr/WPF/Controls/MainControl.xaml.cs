﻿//-----------------------------------------------------------------------------
// <auto-generated/>
// <summary> 
// Объекты и конструктор класса главного окна.
// </summary> 
//-----------------------------------------------------------------------------
using System.Windows.Controls;
using ViewModel.Core.Tasks.Management;
using ViewModel.Core.Widgets.Weather;

namespace SWtaskM.WPF.UI.Controls
{
    /// <summary>
    /// Логика взаимодействия для MainControl.xaml
    /// </summary>
    public partial class MainControl : UserControl
    {
        WeatherWidgetManager   widgetManager; 
        TimelessEntriesManager timelessEntriesManager;

        public MainControl()
        {
            InitializeComponent();

            timelessEntriesManager = new TimelessEntriesManager();
            widgetManager          = new WeatherWidgetManager();
        }
    }
}
