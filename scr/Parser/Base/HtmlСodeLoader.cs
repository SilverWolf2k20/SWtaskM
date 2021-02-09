//-----------------------------------------------------------------------------
// <copyright file="HtmlСodeLoader.cs" company="SW Okolo IT">
//  Copyright (c) SW Okolo IT. All rights reserved.
// </copyright>
// <summary> 
// файл с классом-загрузчиком кода страницы.
// </summary> 
//-----------------------------------------------------------------------------
using System.IO;
using System.Net;

namespace Parser.Base
{
    /// <summary>
    /// Загрузчик кода страницы.
    /// </summary>
    public static class HtmlСodeLoader
    {
        /// <summary>
        /// Скачивает код страницы.
        /// </summary>
        /// <param name="uri">Ссылка на страницу в формате строки.</param>
        /// <returns>Возвращает код страныцы в формате строки.</returns>
        public static string Download(string uri)
        {
            WebClient client = new WebClient();
            Stream dataStream = null;
            StreamReader textReader = null;
            string pageСode = default;
            try {
                dataStream = client.OpenRead(uri);
                textReader = new StreamReader(dataStream);
                pageСode = textReader.ReadToEnd();
            }
            catch (WebException) {
                throw new WebException("Не удалось получить данные по адресу.");
            }
            textReader.Close();
            dataStream.Close();

            return pageСode;
        }
    }
}
