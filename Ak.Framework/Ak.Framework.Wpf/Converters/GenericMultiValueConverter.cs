using System;

namespace Ak.Framework.Wpf.Converters
{
    /// <summary>
    /// Конвертер множественного набора значений, возвращающий оригинальный набор значений
    /// </summary>
    /// <seealso cref="Ak.Framework.Wpf.Converters.MultiValueConverterBase" />
    public class GenericMultiValueConverter : MultiValueConverterBase
    {
        /// <summary>
        /// Конвертация значений
        /// </summary>
        /// <param name="values">Значения</param>
        /// <param name="targetType">Целевой тип</param>
        /// <param name="parameter">Параметр конвертации</param>
        /// <param name="culture">Локаль</param>
        /// <returns></returns>
        public override object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return values.Clone();
        }

        /// <summary>
        /// Обратная конвертация
        /// </summary>
        /// <param name="value">Значение</param>
        /// <param name="targetTypes">Целевые типы</param>
        /// <param name="parameter">Параметр конвертации</param>
        /// <param name="culture">Локаль</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public override object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
