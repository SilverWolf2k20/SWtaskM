//-----------------------------------------------------------------------------
// <copyright file="MainButtonHandle.cs" company="SW Okolo IT">
//  Copyright (c) SW Okolo IT. All rights reserved.
// </copyright>
// <summary> 
// Обработка нажатий кнопок в окне.
// </summary> 
//-----------------------------------------------------------------------------
using System.Windows;
using System.Windows.Controls;

namespace SWtaskM.WPF.UI.Controls
{
    /// <summary>
    /// Логика взаимодействия для MainControl.xaml
    /// </summary>
    public partial class MainControl : UserControl
    {
        /// <summary>
        /// Нажата кнопка "Сохранить".
        /// </summary>
        private void ButtonSaveClick(object sender, RoutedEventArgs e)
            => timelessEntriesManager.Save();

        /// <summary>
        /// Нажата кнопка "Добавить".
        /// </summary>
        private void ButtonAddClick(object sender, RoutedEventArgs e)
            => timelessEntriesManager.AddItem(taskList, textBlockStandatrTask.Text);

        /// <summary>
        /// Нажата кнопка "Удалить".
        /// </summary>
        private void ButtonDeleteClick(object sender, RoutedEventArgs e)
            => timelessEntriesManager.DeleteItem(taskList);
    }
}
