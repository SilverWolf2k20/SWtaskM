//-----------------------------------------------------------------------------
// <copyright file="ParserWorker.cs" company="SW Okolo IT">
//  Copyright (c) SW Okolo IT. All rights reserved.
// </copyright>
// <summary> 
// Реализация класса для поиска информации со страницы. 
// </summary> 
//-----------------------------------------------------------------------------
using AngleSharp.Html.Parser;
using Parser.Base;
using System;

namespace Parser
{
    /// <summary>
    /// Ищет информацию на странице.
    /// </summary>
    /// <typeparam name="T">Тип данных для возврата данных.</typeparam>
    public sealed class ParserWorker<T> where T : class
    {
        private T result;
        private IParser<T> parser;

        /// <summary>
        /// Создает экземпляр класса ParserWorker.
        /// </summary>
        /// <param name="parser">Страница для парсинга.</param>
        public ParserWorker(IParser<T> parser)
        {
            this.parser = parser;
            this.result = default;
        }

        public event Action<T> OnNewData;

        /// <summary>
        /// Начинает поиск информации.
        /// </summary>
        public void Start()
        {
            LoadingData();
            OnNewData?.Invoke(result);
        }

        /// <summary>
        /// Загружает код сайта.
        /// </summary>
        public async void LoadingData()
        {
            string source = "";
            try {
                source = HtmlСodeLoader.Download(parser.URL);
            }
            catch (System.Net.WebException) {
                throw new Exception("Не удалось получить данные по адресу " 
                                    + parser.URL);
            }

            var domParser = new HtmlParser();
            var document = await domParser.ParseDocumentAsync(source);
            result = parser.Parshe(document);
        }
    }
}
