//-----------------------------------------------------------------------------
// <copyright file="WeatherWidgetManager.cs" company="SW Okolo IT">
//  Copyright (c) SW Okolo IT. All rights reserved.
// </copyright>
// <summary> 
// Файл с реализацией класса WeatherWidgetManager.
// </summary> 
//-----------------------------------------------------------------------------
using Parser;
using System;
using ViewModel.Core.Widgets.Weather.Resourses;

namespace ViewModel.Core.Widgets.Weather
{
    /// <summary>
    /// Управление виджетом погоды.
    /// </summary>
    public sealed class WeatherWidgetManager
    {
        string temperature;
        string weatherStatus;
        string weatherPictureName;

        /// <summary>
        /// Создает экземпляр класса WeatherWidgetManager.
        /// </summary>
        public WeatherWidgetManager()
        {
            temperature = default;
            weatherStatus = default;
            //weatherPictureName = "Textures/";
        }

        /// <summary>
        /// Обновляет состояние о погоде.
        /// </summary>
        /// <param name="data">Данные о погоде.</param>
        private void ParserWorkerOnNewData(string[] data)
        {
            if (data.Length > 2) {
                temperature   = data[0].Trim();
                weatherStatus = data[2].Trim();
                //ConditionAnalysis();
            }
            else {
                temperature = "Нет данных.";
                weatherStatus = "Неполадки с подключением.";
            }
        }

        /// <summary>
        /// Анализ состояния для выбора изображения на спрайт.
        /// </summary>
        /*private void ConditionAnalysis()
        {
            if (weatherStatus == null)
                throw new ArgumentNullException("weatherStatus == null");

            if (weatherStatus.Contains("снег"))
                weatherPictureName += "snow.png";
            else
                weatherPictureName += "cloudy.png";
        }*/

        /// <summary>
        /// Загружает данные о погоде.
        /// </summary>
        public void LoadData()
        {
            var parserWorker = new ParserWorker<string[]>(new GismeteoParser());
            parserWorker.OnNewData += ParserWorkerOnNewData;
            parserWorker.Start();
        }

        /// <summary>
        /// Возвращает температуру.
        /// </summary>
        /// <returns>Температура.</returns>
        public string GetTemperature() => temperature;

        /// <summary>
        /// Возвращает статус погоды.
        /// </summary>
        /// <returns>Статус погоды.</returns>
        public string GetState() => weatherStatus;

        /// <summary>
        /// Возвращает путь к файлу спрайта.
        /// </summary>
        /// <returns>Путь к файлу спрайта.</returns>
        public string GetPathImage() => weatherPictureName;
    }
}
