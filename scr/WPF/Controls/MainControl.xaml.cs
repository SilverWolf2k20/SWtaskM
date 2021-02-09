﻿//-----------------------------------------------------------------------------
// <auto-generated/>
// <summary> 
// Объекты и конструктор класса главного окна.
// </summary> 
//-----------------------------------------------------------------------------
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using ViewModel.Core.Widgets.Weather;

namespace SWtaskM.WPF.UI.Controls
{
    /// <summary>
    /// Логика взаимодействия для MainControl.xaml
    /// </summary>
    public partial class MainControl : UserControl
    {
        private WeatherWidgetManager weatherWidgetManager;

        public MainControl()
        {
            InitializeComponent();

            weatherWidgetManager = new WeatherWidgetManager();
        }
        /// <summary>
        /// Нажата кнопка "Сохранить".
        /// </summary>
        private void ButtonSaveClick(object sender, RoutedEventArgs e) { }
           // => timelessEntriesManager.Save();

        /// <summary>
        /// Нажата кнопка "Добавить".
        /// </summary>
        private void ButtonAddClick(object sender, RoutedEventArgs e) { }
        //=> timelessEntriesManager.AddItem(taskList, textBlockStandatrTask.Text);

        /// <summary>
        /// Нажата кнопка "Удалить".
        /// </summary>
        private void ButtonDeleteClick(object sender, RoutedEventArgs e) { }
            //=> timelessEntriesManager.DeleteItem(taskList);

        /// <summary>
        /// Загрузка домашнего окна.
        /// </summary>
        private void UserControlLoaded(object sender, RoutedEventArgs e)
        {
            weatherWidgetManager.LoadData();
            textBlockTemperature.Text = weatherWidgetManager.GetTemperature() +
                                       " °C";
            textBlockWeather.Text = weatherWidgetManager.GetState();
        }

        private void LoadWeatherInformation()
        {

        }

        /// <summary>
        /// Обратывает нажатие клавишь клавиатуры.
        /// </summary>
        private void UserControlKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
        }
    }
}