//-----------------------------------------------------------------------------
// <copyright file="TimelessEntries.cs" company="SW Okolo IT">
//  Copyright (c) SW Okolo IT. All rights reserved.
// </copyright>
// <summary> 
// Файл с реализацией класса TimelessEntriesManager.
// </summary> 
//-----------------------------------------------------------------------------
using System;
using System.IO;
using System.Windows.Controls;
using ViewModel.Core.Tasks.TaskCollection;

namespace ViewModel.Core.Tasks.Management
{
    /// <summary>
    /// Управление бессрочными задачами.
    /// </summary>
    class TimelessEntriesManager
    {
        /// <summary>
        /// Коллекция бессрочных задач.
        /// </summary>
        TimelessEntriesCollection timelessEntriesCollection;

        /// <summary>
        /// Путь для загрузки и сохранения данных.
        /// </summary>
        private readonly string PATH_DATA;

        /// <summary>
        /// Создает экземпляр класса TimelessEntriesManager.
        /// </summary>
        public TimelessEntriesManager()
        {
            timelessEntriesCollection = new TimelessEntriesCollection();
            PATH_DATA = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                                     "data/tasks/standart_task.dat");
            LoadingDataFromFile();
        }

        /// <summary>
        /// Загружает данные из файла.
        /// </summary>
        private void LoadingDataFromFile()
        {
            string line = default;
            StreamReader file = new StreamReader(PATH_DATA);

            while ((line = file.ReadLine()) != null)
                timelessEntriesCollection.AddTask(line);

            file.Close();
        }

        /// <summary>
        /// Вывод информации на окно.
        /// </summary>
        /// <param name="notes">Список для выгрузки.</param>
        public void DataOutput(ListBox notes)
        {
            notes.Items.Clear();

            for (int i = 0; i < timelessEntriesCollection.Size; i++)
                notes.Items.Add($"{(i + 1).ToString()}. " +
                                timelessEntriesCollection.GetTask(i));
        }

        /// <summary>
        /// Добавляет заметку.
        /// </summary>
        /// <param name="notes">Список для выгрузки.</param>
        /// <param name="note">Текст заметки.</param>
        public void AddItem(ListBox notes, string note)
        {
            timelessEntriesCollection.AddTask(note);
            DataOutput(notes);
        }

        /// <summary>
        /// Удаляет заметку.
        /// </summary>
        /// <param name="notes">Список для выгрузки.</param>
        public void DeleteItem(ListBox notes)
        {
            if (notes.SelectedIndex < 0)
                return;

            timelessEntriesCollection.DeleteTask(notes.SelectedIndex);
            DataOutput(notes);
        }

        /// <summary>
        /// Сохраняет заметки.
        /// </summary>
        public void Save()
        {
            StreamWriter SaveFile = new StreamWriter(PATH_DATA);

            for (int i = 0; i < timelessEntriesCollection.Size; i++)
                SaveFile.WriteLine(timelessEntriesCollection.GetTask(i));

            SaveFile.Close();
        }
    }
}
