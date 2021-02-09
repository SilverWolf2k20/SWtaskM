//-----------------------------------------------------------------------------
// <copyright file="TimelessEntriesCollection.cs" company="SW Okolo IT">
//  Copyright (c) SW Okolo IT. All rights reserved.
// </copyright>
// <summary> 
// Реализация класса TimelessEntriesCollection.
// </summary> 
//-----------------------------------------------------------------------------
using System.Collections.Generic;

namespace ViewModel.Core.Tasks.TaskCollection
{
    /// <summary>
    /// Класс коллекции заметок.
    /// </summary>
    public class TimelessEntriesCollection
    {
        /// <summary>
        /// Список заметок.
        /// </summary>
        List<TimelessEntries> timeLesses;

        /// <summary>
        /// Создает экземпляр класса TimelessEntriesCollection.
        /// </summary>
        public TimelessEntriesCollection()
        {
            timeLesses = new List<TimelessEntries>();
        }

        /// <summary>
        /// Количество элементов.
        /// </summary>
        public int Size { get; private set; } = default;

        /// <summary>
        /// Возвращает заметку по индексу.
        /// </summary>
        /// <param name="index">Индекс.</param>
        public string GetTask(int index) => timeLesses[index].GetNote();

        /// <summary>
        /// Добавляет заметку.
        /// </summary>
        /// <param name="note">Текст заметки.</param>
        public void AddTask(string note)
        {
            timeLesses.Add(new TimelessEntries(note));
            Size++;
        }

        /// <summary>
        /// Удаляет заметку по индексу.
        /// </summary>
        /// <param name="index">Индекс.</param>
        public void DeleteTask(int index)
        {
            timeLesses.RemoveAt(index);
            Size--;
        }

        /// <summary>
        /// Изменяет заметку по индексу.
        /// </summary>
        /// <param name="index">Индекс.</param>
        /// <param name="note">Текст заметки.</param>
        public void EditTask(int index, string note)
            => timeLesses[index].SetNote(note);

        /// <summary>
        /// Ищет заметку по записи.
        /// </summary>
        /// <param name="substring">Запись.</param>
        /// <returns>
        /// Состояние поиска: true - найденна, false - не найденна.
        /// </returns>
        public bool SearchTask(string substring)
        {
            var isFound = false;
            for (var index = 0; index < timeLesses.Count && !isFound; index++)
                isFound = timeLesses[index].Search(substring);
            return isFound;
        }
    }
}
