namespace Ak.Framework.Core.Converters
{
    /// <summary>
    /// Конвертер в Base32
    /// (RFC 4648 Base32)
    /// </summary>
    public sealed class Base32Converter
    {
        #region Константы

        /// <summary>
        /// Разрядность
        /// </summary>
        private const int Bitness = 32;

        /// <summary>
        /// Список символов
        /// </summary>
        private const string CharList = "abcdefghijklmnopqrstuwxz234567";

        #endregion

        #region Публичные методы

        /// <summary>
        /// Кодирование
        /// </summary>
        /// <param name="value">Значение</param>
        /// <returns></returns>
        public static string Encode(long value)
        {
            return new GenericNumberConverter(Bitness, CharList).Encode(value);
        }

        /// <summary>
        /// Декодирование
        /// </summary>
        /// <param name="value">Значение</param>
        /// <returns></returns>
        public static long Decode(string value)
        {
            return new GenericNumberConverter(Bitness, CharList).Decode(value);
        }

        #endregion
    }
}
