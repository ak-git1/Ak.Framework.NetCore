using System;
using System.Collections.Generic;
using System.Linq;

namespace Ak.Framework.Core.Converters
{
    /// <summary>
    /// Обобщенный конвертер чисел
    /// </summary>
    public class GenericNumberConverter
    {
        #region Переменные

        /// <summary>
        /// Разрядность
        /// </summary>
        private readonly int _bitness;

        /// <summary>
        /// Список символов
        /// </summary>
        private readonly string _charList;

        #endregion

        #region Конструктор

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="bitness">Разрядность</param>
        /// <param name="charList">Список символов</param>
        public GenericNumberConverter(int bitness, string charList)
        {
            _bitness = bitness;
            _charList = charList;
        }

        #endregion

        #region Публичные методы

        /// <summary>
        /// Кодирование
        /// </summary>
        /// <param name="value">Значение</param>
        /// <returns></returns>
        public string Encode(long value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Input value can not be negative.");

            char[] array = _charList.ToCharArray();
            Stack<char> result = new Stack<char>();
            while (value != 0)
            {
                result.Push(array[value % _bitness]);
                value /= _bitness;
            }
            return new string(result.ToArray());
        }

        /// <summary>
        /// Декодирование
        /// </summary>
        /// <param name="input">Значение</param>
        /// <returns></returns>
        public long Decode(string input)
        {
            IEnumerable<char> reversed = input.ToLower().Reverse();
            long result = 0;
            int pos = 0;
            foreach (char c in reversed)
            {
                result += _charList.IndexOf(c) * (long)Math.Pow(_bitness, pos);
                pos++;
            }
            return result;
        }

        #endregion
    }
}
