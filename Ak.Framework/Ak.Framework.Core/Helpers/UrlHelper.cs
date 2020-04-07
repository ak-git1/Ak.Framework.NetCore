using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ak.Framework.Core.Helpers
{
    /// <summary>
    /// Класс для работы с Url
    /// </summary>
    public class UrlHelper
    {
        /// <summary>
        /// Объединение путей
        /// </summary>
        /// <param name="baseUrl">Базовый Url</param>
        /// <param name="relativeUrl">Относительный Url</param>
        /// <returns></returns>
        public static string CombineUrls(string baseUrl, string relativeUrl)
        {
            Uri baseUri = new Uri(baseUrl);
            return new Uri(baseUri, relativeUrl).ToString();
        }

        /// <summary>
        /// Генерация строки аргументов для http-запроса
        /// </summary>
        /// <param name="arguments">Аргументы</param>
        /// <returns></returns>
        public static string GenerateArgumentsString(Dictionary<string, string> arguments)
        {
            return HttpUtility.UrlEncode(string.Join("&", arguments.Select(kvp => $"{kvp.Key}={kvp.Value}")));
        }
    }
}
