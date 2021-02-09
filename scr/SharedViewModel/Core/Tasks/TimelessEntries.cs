//-----------------------------------------------------------------------------
// <copyright file="TimelessEntries.cs" company="SW Okolo IT">
//  Copyright (c) SW Okolo IT. All rights reserved.
// </copyright>
// <summary> 
// Файл с реализацией класса TimelessEntries.
// </summary> 
//-----------------------------------------------------------------------------
using System;

namespace ViewModel.Core.Tasks
{
    /// <summary>
    /// Класс простой записи, не имеющей время существования.
    /// </summary>
    public class TimelessEntries : INote
    {
        /// <summary>
        /// Заметка.
        /// </summary>
        string note;

        /// <summary>
        /// Создает экземпляр класса TimelessEntries.
        /// </summary>
        public TimelessEntries()
        {
            note = default;
        }

        /// <summary>
        /// Создает экземпляр класса TimelessEntries.
        /// </summary>
        /// <param name="note">Текст заметки.</param>
        public TimelessEntries(string note)
        {
            this.note = note;
        }

        /// <summary>
        /// Возвращает текст заметки.
        /// </summary>
        /// <returns>Текст заметки.</returns>
        public string GetNote()
        {
            if (note == null)
                return "";
            return note;
        }

        /// <summary>
        /// Ищет запись в заметке.
        /// </summary>
        /// <param name="substring">И скомая запись.</param>
        /// <returns>
        /// Состояние поиска: true - найденна, false - не найденна.
        /// </returns>
        public bool Search(string substring)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Устанавливает заметку.
        /// </summary>
        /// <param name="note"></param>
        public void SetNote(string note)
        {
            if (this.note == note)
                return;
            this.note = note;
        }
    }
}
