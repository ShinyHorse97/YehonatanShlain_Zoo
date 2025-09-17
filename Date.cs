using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YehonatanShlain_Zoo
{
    class Date
    {
        public int day;//הגדרת משתנים
        public int month;
        public int year;
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public int GetDay() { return day; }// פעולות get - מחזירות את הימים חודשים או שנים
        public int GetMonth() { return this.month; }
        public int GetYear() { return this.year; }
        public void SetDay(int day) { this.day = day; }// פעולות set - מגדירות את הימים חודשים או שנים מחדש עם הקלט
        public void SetMonth(int month) { this.month = month; }
        public void SetYear(int year) { this.year = year; }
        public override string ToString()// מחזירה מחרוזת מסודרת של כל הנתונים
        {
            return $"{day}/{month}/{year}";
        }
        public bool SameDate(Date date)//הפעולה בודקת אם ההתאריך הנתון בקלט הוא אותו התאריך שעליו הפעולה עובדת
        {
            if (date.day == this.day && date.month == this.month && date.year == this.year)
            {
                return true;
            }
            return false;
        }
        public bool Before(Date date)//הפעולה בודקת אם ההתאריך הנתון בקלט הוא לפני התאריך שעליו הפעולה עובדת
        {
            if (date.day < this.day || date.month < this.month || date.year < this.year)
            {
                return true;
            }
            return false;
        }
        public bool After(Date date)//הפעולה בודקת אם ההתאריך הנתון בקלט הוא אחרי התאריך שעליו הפעולה עובדת
        {
            if (date.day > this.day || date.month > this.month || date.year > this.year)
            {
                return true;
            }
            return false;
        }
        public int CompareDate(Date date)
        {
            if (SameDate(date))
            {
                return 0;
            }
            else if (After(date))
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public void AddDays(int addDays)
        {
            this.day += addDays;
            Console.WriteLine(ToString());
        }
        public Date towmorrow(Date date)
        {
            Date date1 = new Date(date.day + 1, date.month, date.year);
            return date1;
        }
        public Date yesterday(Date date)
        {
            Date date1 = new Date(date.day - 1, date.month, date.year);
            return date1;
        }
    }
}
