using System.Collections;
using System.Collections.Generic;

namespace Task1
{
    public class WeekDays : Data
    {
        private List<string> days = new List<string> { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресение" };
        public string this[int i]
        {
            get { return days[i]; }
        }

        public IEnumerator GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator<string> IEnumerable<string>.GetEnumerator()
        {
            return days.GetEnumerator();
        }
    }
}
