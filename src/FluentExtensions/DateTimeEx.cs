using System;

namespace FluentExtensions
{
    public static class DateTimeEx
    {
        /// <summary>
        /// Gets the day after given date.
        /// </summary>
        /// <param name="current">Date to check.</param>
        /// <returns>The Day after given date.</returns>
        public static DateTime Tomorrow(this DateTime current)
        {
            return current.AddDays(1);
        }
        
        /// <summary>
        /// Gets the day before given date.
        /// </summary>
        /// <param name="current">Date to check.</param>
        /// <returns>The Day before given date.</returns>
        public static DateTime Yesterday(this DateTime current)
        {
            return current.AddDays(-1);
        }
        
        /// <summary>
        /// Gets an hour after the given date.
        /// </summary>
        /// <param name="current">Date to check.</param>
        /// <returns>An Hour after the given date.</returns>
        public static DateTime NextHour(this DateTime current)
        {
            return current.AddHours(1);
        }
        
        /// <summary>
        /// Gets an hour before the given date.
        /// </summary>
        /// <param name="current">Date to check.</param>
        /// <returns>An Hour before the given date.</returns>
        public static DateTime LastHour(this DateTime current)
        {
            return current.AddHours(-1);
        }
        
        /// <summary>
        /// Gets a week after the given date.
        /// </summary>
        /// <param name="current">Date to get week from.</param>
        /// <returns>A Week after the given date.</returns>
        public static DateTime NextWeek(this DateTime current)
        {
            return current.AddDays(7);
        }
         
        /// <summary>
        /// Gets a week before the given date.
        /// </summary>
        /// <param name="current">Date to get week from.</param>
        /// <returns>A Week before the given date.</returns>
        public static DateTime LastWeek(this DateTime current)
        {
            return current.AddDays(-7);
        }
         
        /// <summary>
        /// Gets a month before the given date.
        /// </summary>
        /// <param name="current">Date to get month from.</param>
        /// <returns>A Month before the given date.</returns>
        public static DateTime PreviousMonth(this DateTime current)
        {
            return current.AddMonths(-1);
        }
        
        /// <summary>
        /// Gets a month after the given date.
        /// </summary>
        /// <param name="current">Date to get month from.</param>
        /// <returns>A Month after the given date.</returns>
        public static DateTime NextMonth(this DateTime current)
        {
            return current.AddMonths(1);
        } 
        
        /// <summary>
        /// Gets a year before the given date.
        /// </summary>
        /// <param name="current">Date to get year from.</param>
        /// <returns>A Year before the given date.</returns>
        public static DateTime LastYear(this DateTime current)
        {
            return current.AddMonths(-1);
        }
        
        /// <summary>
        /// Gets a year after the given date.
        /// </summary>
        /// <param name="current">Date to get year from.</param>
        /// <returns>A Year after the given date.</returns>
        public static DateTime NextYear(this DateTime current)
        {
            return current.AddYears(1);
        }
        
        /// <summary>
        /// Gets the number of days prior to the given date.
        /// </summary>
        /// <param name="source">Date to get days from.</param>
        /// <param name="days">Number of days to get.</param>
        /// <returns>The Number of days prior to the given date.</returns>
        public static DateTime DaysAgo(this DateTime source, int days)
        {
            return source.AddDays(-days);
        }

        /// <summary>
        /// Gets the number of days after the given date.
        /// </summary>
        /// <param name="source">Date to get days from.</param>
        /// <param name="days">Number of days to get.</param>
        /// <returns>The Number of days after the given date.</returns>
        public static DateTime DaysAfter(this DateTime source, int days)
        {
            return source.AddDays(days);
        }

        /// <summary>
        /// Gets the number of weeks prior the given date.
        /// </summary>
        /// <param name="source">Date to get weeks from.</param>
        /// <param name="weeks">Number of weeks to get.</param>
        /// <returns>The Number of weeks prior the given date.</returns>
        public static DateTime WeeksAgo(this DateTime source, int weeks)
        {
            var days = weeks * 7;
            return source.AddDays(-days);
        }

        /// <summary>
        /// Gets the number of weeks after the given date.
        /// </summary>
        /// <param name="source">Date to get weeks from.</param>
        /// <param name="weeks">Number of weeks to get.</param>
        /// <returns>The Number of weeks after the given date.</returns>
        public static DateTime WeeksAfter(this DateTime source, int weeks)
        {
            var days = weeks * 7;
            return source.AddDays(days);
        }

        /// <summary>
        /// Gets the number of months prior the given date.
        /// </summary>
        /// <param name="source">Date to get months from.</param>
        /// <param name="months">Number of months to get.</param>
        /// <returns>The Number of months prior the given date.</returns>
        public static DateTime MonthsAgo(this DateTime source, int months)
        {
            return source.AddMonths(-months);
        }

        /// <summary>
        /// Gets the number of months after the given date.
        /// </summary>
        /// <param name="source">Date to get months from.</param>
        /// <param name="months">Number of months to get.</param>
        /// <returns>The Number of months after the given date.</returns>
        public static DateTime MonthsAfter(this DateTime source, int months)
        {
            return source.AddMonths(months);
        }
        
        /// <summary>
        /// Gets the number of years prior the given date.
        /// </summary>
        /// <param name="source">Date to get years from.</param>
        /// <param name="years">Number of years to get.</param>
        /// <returns>The Number of years prior the given date.</returns>
        public static DateTime YearsAgo(this DateTime source, int years)
        {
            return source.AddYears(-years);
        }

        /// <summary>
        /// Gets the number of years after the given date.
        /// </summary>
        /// <param name="source">Date to get years from.</param>
        /// <param name="years">Number of years to get.</param>
        /// <returns>The Number of years after the given date.</returns>
        public static DateTime YearsAfter(this DateTime source, int years)
        {
            return source.AddYears(years);
        }

        /// <summary>
        /// Gets the first day of month.
        /// </summary>
        /// <param name="date">Date to check.</param>
        /// <returns>The first day of month.</returns>
        public static DateTime FirstDayOfMonth(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }

        /// <summary>
        /// Gets the number of days left to the target date.
        /// </summary>
        /// <param name="source">Date to check.</param>
        /// <param name="target">Date to check against.</param>
        /// <returns>The Number of days left to the target date.</returns>
        public static double DaysLeft(this DateTime source, DateTime target)
        {
            return (target.Date - source.Date).TotalDays;
        }
        
        /// <summary>
        /// Gets the last day of month.
        /// </summary>
        /// <param name="date">Date to check.</param>
        /// <returns>The Last day of month.</returns>
        public static DateTime LastDayOfMonth(this DateTime date)
        {
            return date.FirstDayOfMonth().NextMonth().Yesterday();
        }

        /// <summary>
        /// Gets the number of the days of the given date month.
        /// </summary>
        /// <param name="date">Date to check.</param>
        /// <returns>Number of days of the given date month.</returns>
        public static int DaysInMonth(this DateTime date)
        {
            return DateTime.DaysInMonth(date.Year, date.Month);
        }

        /// <summary>
        /// Determines whether the given date is between the two given dates.
        /// </summary>
        /// <param name="dateToCompare">Date to check.</param>
        /// <param name="startDate">Start of date</param>
        /// <param name="endDate">End of date.</param>
        /// <returns>Whether the given date is between the two given dates.</returns>
        public static bool IsBetween(this DateTime dateToCompare, 
            DateTime startDate, DateTime endDate)
        {
            return dateToCompare >= startDate && dateToCompare <= endDate;
        }

        /// <summary>
        /// Determines whether the given date is before the target one.
        /// </summary>
        /// <param name="dateToCompare">Date to check.</param>
        /// <param name="target">Target date to check against.</param>
        /// <returns>Whether the given date is before the target one.</returns>
        public static bool IsBefore(this DateTime dateToCompare, DateTime target)
        {
            return dateToCompare < target;
        }
        
        /// <summary>
        /// Determines whether the given date is already passed the target one.
        /// </summary>
        /// <param name="dateToCompare">Date to check.</param>
        /// <param name="target">Target date to check against.</param>
        /// <returns>Whether the given date is passed the target.</returns>
        public static bool IsAfter(this DateTime dateToCompare, DateTime target)
        {
            return dateToCompare > target;
        }
       
        /// <summary>
        /// Determines whether the given date is a leap year.
        /// </summary>
        /// <param name="date">Date to check for.</param>
        /// <returns>Whether the given date is a leap year.</returns>
        public static bool IsYearLeap(this DateTime date)
        {
            return DateTime.IsLeapYear(date.Year);
        }

        /// <summary>
        /// Gets the Next leap year based on the given date.
        /// </summary>
        /// <param name="date">Date to check.</param>
        /// <returns>The Next leap year based on the given date.</returns>
        public static DateTime NextLeapYear(this DateTime date)
        {
            var year = date.Year;
            while (!year.IsLeapYear())
                year++;
            return new DateTime(year, 2 ,29);
        }
        
        /// <summary>
        /// Gets the previous leap year based on the given date.
        /// </summary>
        /// <param name="date">Date to check.</param>
        /// <returns>The Previous leap year based on the given date.</returns>
        public static DateTime PreviousLeapYear(this DateTime date)
        {
            var year = date.Year;
            while (!year.IsLeapYear())
                year--;

            return new DateTime(year, 2, 29);
        }
        
        /// <summary>
        /// Calculates age based on given date.
        /// </summary>
        /// <param name="date">Date to get age from.</param>
        /// <returns>The Age based on given date.</returns>
        public static int GetAge(this DateTime date)
        {
            return DateTime.Now.Year - date.Year;
        }
        
        /// <summary>
        /// Gets the name of the given date time.
        /// </summary>
        /// <param name="current">The Date to get the day name.</param>
        /// <returns>The Day name of the given date.</returns>
        public static string DayName(this DateTime current)
        {
            return current.DayOfWeek.ToString();
        }
        
        
    }
}