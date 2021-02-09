//-----------------------------------------------------------------------------
// <copyright file="IParser.cs" company="SW Okolo IT">
//  Copyright (c) SW Okolo IT. All rights reserved.
// </copyright>
// <summary> 
// Реализация класса для парсинга на сайте Gismeteo.
// </summary> 
//-----------------------------------------------------------------------------
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using Parser.Base;
using System.Collections.Generic;
using System.Linq;

namespace ViewModel.Core.Widgets.Weather.Resourses
{
    /// <summary>
    /// Парсер для сайта Gismeteo.
    /// </summary>
    internal class GismeteoParser : IParser<string[]>
    {
        readonly string BASE_URL;
        string filter;

        /// <summary>
        /// Создает экземпляр класса GismeteoParser.
        /// </summary>
        /// <param name="settings">
        /// Текущие настройки страницы для парсинга.
        /// </param>
        public GismeteoParser()
        {
            this.filter = default;
            BASE_URL = "https://www.gismeteo.ru/weather-fryazino-12648/now/";
        }

        /// <summary>
        /// Передаёт адрес страницы.
        /// </summary>
        public string URL {
            get => BASE_URL;
        }

        /// <summary>
        /// Ищет данные по фильтру.
        /// </summary>
        /// <param name="document">Код страницы.</param>
        /// <returns>Данные со страницы.</returns>
        public string[] Parshe(IHtmlDocument document)
        {
            List<string> list = new List<string>();

            filter = "js_value tab-weather__value_l";
            LookingForDataFromClassByFilter(document, "span", ref list);
            filter = "tip _top _center";
            LookingForDataFromClassByFilter(document, "span", ref list);

            return list.ToArray();
        }

        /// <summary>
        /// Добавляет данные в коллекцию.
        /// </summary>
        /// <param name="items">Перечислитель.</param>
        /// <param name="list">Список для записи данных.</param>
        private void DataLoader(IEnumerable<IElement> items, ref List<string> list)
        {
            foreach (var item in items)
                list.Add(item.TextContent);
        }

        /// <summary>
        /// Поиск данных изз класса по филитру и загружает их в список.
        /// </summary>
        /// <param name="document">Код страницы.</param>
        /// <param name="className">Имя CSS абзаца.</param>
        /// <param name="list">Список для записи данных.</param>
        private void LookingForDataFromClassByFilter(IHtmlDocument document,
                                                     string className,
                                                     ref List<string> list)
        {
            IEnumerable<IElement> items = document.QuerySelectorAll(className)
                    .Where(item => item.ClassName != null &&
                     item.ClassName.Contains(filter));
            DataLoader(items, ref list);
        }
    }
}
