using System.Collections;
using System.Collections.Generic;

namespace Task1
{
    public class Months : Data
    {
        private List<string> months = new List<string> { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };

        public IEnumerator<string> GetEnumerator()
        {
            return months.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
