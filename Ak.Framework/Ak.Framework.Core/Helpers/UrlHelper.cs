using System;

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
    }
}
