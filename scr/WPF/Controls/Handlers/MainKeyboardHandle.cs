//-----------------------------------------------------------------------------
// <copyright file="MainKeyboardHandle.cs" company="SW Okolo IT">
//  Copyright (c) SW Okolo IT. All rights reserved.
// </copyright>
// <summary> 
// Обработка нажатий клавиш в окне.
// </summary> 
//-----------------------------------------------------------------------------
using System.Windows.Controls;
using System.Windows.Input;

namespace SWtaskM.WPF.UI.Controls
{
    /// <summary>
    /// Логика взаимодействия для MainControl.xaml
    /// </summary>
    public partial class MainControl : UserControl
    {
        /// <summary>
        /// Обратывает нажатие клавишь клавиатуры.
        /// </summary>
        private void UserControlKeyDown(object sender, KeyEventArgs e)
        {
            // Сохранить Ctrl + S
            if (e.KeyboardDevice.Modifiers == ModifierKeys.Control &&
               e.Key == Key.S)
                timelessEntriesManager.Save();

            switch (e.Key) {
                case Key.Enter: // Добавить Enter
                    timelessEntriesManager.AddItem(taskList,
                                                   textBlockStandatrTask.Text);
                    break;
                case Key.Delete: // Удалить Delete
                    timelessEntriesManager.DeleteItem(taskList);
                    break;
            }
        }
    }
}
