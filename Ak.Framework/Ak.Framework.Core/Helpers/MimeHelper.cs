using System;
using System.Collections.Generic;
using System.IO;

namespace Ak.Framework.Core.Helpers
{
    /// <summary>
    /// Класс для определения Mime-типа файлов
    /// </summary>
    public sealed class MimeTypesHelper
    {
        #region Переменные и константы

        /// <summary>
        ///  Стандартный MimeType
        /// </summary>
        private const string ApplicationOctetStream = "application/octet-stream";

        /// <summary>
        /// Кэш с Mime-типами
        /// </summary>
        private static readonly Dictionary<string, string> Cache;

        #endregion

        #region Свойства

        /// <summary>
        /// Словарь mime-типов
        /// </summary>
        private static Dictionary<string, string> MimeTypes
        {
            get
            {
                if (Cache == null)
                    throw new NullReferenceException("Не инициализирована таблица MimeTypes");
                return Cache;
            }
        }

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        static MimeTypesHelper()
        {
            Cache = new Dictionary<string, string>();
            using (StringReader reader = new StringReader(Properties.Resources.mime_types))
            {
                string line;
                char[] tab = { '\t' };
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith("*"))
                        continue;
                    string[] arr = line.Split(tab);
                    if (arr.Length != 2)
                        continue;
                    if (!Cache.ContainsKey(arr[0]))
                        Cache[arr[0]] = arr[1];
                }
            }
        }

        #endregion

        #region Публичные методы

        /// <summary>
        /// Получение mime-типа
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        public static string GetMimeType(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
                throw new ArgumentNullException("fileName");

            string ext = Path.GetExtension(fileName);
            return GetMimeTypeByExtension(ext);
        }

        /// <summary>
        /// Получение mime-типа по расширению
        /// </summary>
        /// <param name="extension">Расширение</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">extension</exception>
        public static string GetMimeTypeByExtension(string extension)
        {
            if (string.IsNullOrEmpty(extension))
                throw new ArgumentNullException("extension");

            if (MimeTypes.ContainsKey(extension))
                return MimeTypes[extension];

            return ApplicationOctetStream;
        }

        #endregion
    }
}
