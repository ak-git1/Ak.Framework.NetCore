using System.Linq;

namespace Ak.Framework.Morphology.Helpers
{
    /// <summary>
    /// Класс для получения окончания к обращению
    /// </summary>
    public static class GendersAccostsEndingHelper
    {
        /// <summary>
        /// Мужское окончание к обращению
        /// </summary>
        private const string MaleAccostsEnding = "ый";

        /// <summary>
        /// Женское окончание к обращению
        /// </summary>
        private const string FemaleAccostsEnding = "ая";

        /// <summary>
        /// Неопределенное окончание к обращению
        /// </summary>
        public const string NotSpecifiedAccostsEnding = "ый(ая)";

        /// <summary>
        /// Возвращает окончание к слову "Уважаемый(ая)" 
        /// в зависимости от пола/отчества пользователя
        /// </summary>
        public static string GendersAccostsEnding(int? genderId, string middleName)
        {
            if (genderId.HasValue)
                return genderId == 1
                    ? MaleAccostsEnding
                    : FemaleAccostsEnding;

            if (string.IsNullOrEmpty(middleName))
                return NotSpecifiedAccostsEnding;

            if (middleName.EndsWith("ич", ignoreCase: true, culture: null) ||
                middleName.EndsWith("оглы", ignoreCase: true, culture: null))
            {
                return MaleAccostsEnding;
            }

            if (middleName.EndsWith("на", ignoreCase: true, culture: null) ||
                middleName.EndsWith("кызы", ignoreCase: true, culture: null))
            {
                return FemaleAccostsEnding;
            }

            return NotSpecifiedAccostsEnding;
        }

        /// <summary>
        /// Возвращает окончание к слову "Уважаемый(ая)" 
        /// в зависимости от ФИО пользователя для случаев, когда нет 
        /// определения пола и отдельных полей имени и отчества
        /// </summary>
        public static string GendersAccostsEnding(string fio)
        {
            string[] fioParts = fio.Split(' ');

            if (fioParts.Length < 3)
                return NotSpecifiedAccostsEnding;

            return GendersAccostsEnding(null, fioParts.Last());
        }
    }

}
