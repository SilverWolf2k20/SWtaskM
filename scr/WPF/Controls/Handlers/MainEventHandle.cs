//-----------------------------------------------------------------------------
// <copyright file="MainEventHandle.cs" company="SW Okolo IT">
//  Copyright (c) SW Okolo IT. All rights reserved.
// </copyright>
// <summary> 
// Обработка событий в окне.
// </summary> 
//-----------------------------------------------------------------------------
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace SWtaskM.WPF.UI.Controls
{
    /// <summary>
    /// Логика взаимодействия для MainControl.xaml
    /// </summary>
    public partial class MainControl : UserControl
    {
        /// <summary>
        /// Загрузка главного окна.
        /// </summary>
        private void UserControlLoaded(object sender, RoutedEventArgs e)
        {
            timelessEntriesManager.DataOutput(taskList);
            widgetManager.LoadData();

            textTemperature.Text  = widgetManager.GetTemperature() + " °C";
            textBlockWeather.Text = widgetManager.GetState();

            imageWeather.Source = new BitmapImage(widgetManager.GetPathImg());
        }
    }
}
