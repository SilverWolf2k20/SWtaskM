//-----------------------------------------------------------------------------
// <copyright file="IParser.cs" company="SW Okolo IT">
//  Copyright (c) SW Okolo IT. All rights reserved.
// </copyright>
// <summary> 
// Интерфейс парсера.
// </summary> 
//-----------------------------------------------------------------------------
using AngleSharp.Html.Dom;

namespace Parser.Base
{
    /// <summary>
    /// Интерфейс парсера.
    /// </summary>
    /// <typeparam name="T">Тип данных для хранения данных.</typeparam>
    public interface IParser<T> where T : class
    {
        T Parshe(IHtmlDocument document);
        string URL { get; }
    }
}
