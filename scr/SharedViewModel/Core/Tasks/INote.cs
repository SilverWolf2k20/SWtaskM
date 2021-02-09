//-----------------------------------------------------------------------------
// <copyright file="INote.cs" company="SW Okolo IT">
//  Copyright (c) SW Okolo IT. All rights reserved.
// </copyright>
// <summary> 
// Интерфейсный класс заметка.
// </summary> 
//-----------------------------------------------------------------------------

namespace ViewModel.Core.Tasks
{
    /// <summary>
    /// Интерфейс заметки.
    /// </summary>
    public interface INote
    {
        string GetNote();
        void SetNote(string note);
        bool Search(string substring);
    }
}