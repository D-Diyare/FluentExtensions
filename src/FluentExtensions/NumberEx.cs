using FluentExtensions.Enumerators;
using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace FluentExtensions
{
    public static class NumberEx
    {

        /// <summary>
        /// Determines whether the given target is even.
        /// </summary>
        /// <param name="source">integer to check</param>
        /// <returns>Whether the given target is even</returns>
        public static bool IsEven(this int source)
        {
            return source % 2 == 0;
        }

        /// <summary>
        /// Determines whether the given target is odd.
        /// </summary>
        /// <param name="source">integer to check</param>
        /// <returns>Whether the given target is odd</returns>
        public static bool IsOdd(this int source)
        {
            return source % 2 != 0;
        }

        /// <summary>
        /// Determines whether the current number is greater than the target one.
        /// </summary>
        /// <param name="source">Number to check.</param>
        /// <param name="target">Number to check against.</param>
        /// <returns>Whether the current number is greater than the target one.</returns>
        public static bool IsGreaterThan(this int source, int target)
        {
            return source > target;
        }

        /// <summary>
        /// Determines whether the current number is less than the target one.
        /// </summary>
        /// <param name="source">Number to check.</param>
        /// <param name="target">Number to check against.</param>
        /// <returns>Whether the current number is less than the target one.</returns>
        public static bool IsLessThan(this int source, int target)
        {
            return source < target;
        }

        /// <summary>
        /// Determines whether the current number is equal to the target one.
        /// </summary>
        /// <param name="source">Number to check.</param>
        /// <param name="target">Number to check against.</param>
        /// <returns>Whether the current number is equal to the target one.</returns>
        public static bool IsEqualTo(this int source, int target)
        {
            return source == target;
        }

        /// <summary>
        /// Gets the date time in past from given number of days.
        /// </summary>
        /// <param name="days">Number of days you to get in past.</param>
        /// <returns><see cref="days" /> days ago.</returns>
        public static DateTime DaysAgo(this int days)
        {
            return DateTime.Now.AddDays(-days).Date;
        }

        /// <summary>
        /// Gets the date time in future from given number of days.
        /// </summary>
        /// <param name="days">Number of days you to get in future.</param>
        /// <returns><see cref="days" /> days since.</returns>
        public static DateTime DaysAfter(this int days)
        {
            return DateTime.Now.AddDays(days);
        }

        /// <summary>
        /// Gets the date time in past from given number of weeks.
        /// </summary>
        /// <param name="weeks">Number of weeks you to get in past.</param>
        /// <returns><see cref="weeks" /> weeks ago.</returns>
        public static DateTime WeeksAgo(this int weeks)
        {
            var days = weeks * 7;
            return DateTime.Now.AddDays(-days);
        }

        /// <summary>
        /// Gets the date time in future from given number of weeks.
        /// </summary>
        /// <param name="weeks">Number of weeks you to get in future.</param>
        /// <returns><see cref="weeks" /> weeks since.</returns>
        public static DateTime WeeksAfter(this int weeks)
        {
            var days = weeks * 7;
            return DateTime.Now.AddDays(days);
        }

        /// <summary>
        /// Converts the given number into days.
        /// </summary>
        /// <param name="num">Number of days.</param>
        /// <returns>The Days from given number in date time format.</returns>
        public static DateTime Days(this int num)
        {
            return DateTime.MinValue + TimeSpan.FromDays(num);
        }

        /// <summary>
        /// Gets the date time in future from given number of months.
        /// </summary>
        /// <param name="months">Number of months you to get in future.</param>
        /// <returns><see cref="months" /> months since.</returns>
        public static DateTime MonthsAfter(this int months)
        {
            return DateTime.Now.AddMonths(months);
        }

        /// <summary>
        /// Gets the date time in past from given number of months.
        /// </summary>
        /// <param name="months">Number of months you to get in past.</param>
        /// <returns><see cref="months" /> months ago.</returns>
        public static DateTime MonthsAgo(this int months)
        {
            return DateTime.Now.AddMonths(-months);
        }

        /// <summary>
        /// Gets the date time in past from given number of years.
        /// </summary>
        /// <param name="years">Number of years you to get in past.</param>
        /// <returns><see cref="years" /> years ago.</returns>
        public static DateTime YearsAgo(this int years)
        {
            return DateTime.Now.AddYears(-years);
        }

        /// <summary>
        /// Gets the date time in future from given number of years.
        /// </summary>
        /// <param name="years">Number of years you to get in future.</param>
        /// <returns><see cref="years" /> years since.</returns>
        public static DateTime YearsAfter(this int years)
        {
            return DateTime.Now.AddYears(years);
        }

        /// <summary>
        /// Determines whether the given year is a leap year.
        /// </summary>
        /// <param name="year">Year to check for.</param>
        /// <returns>Whether the given year is a leap year.</returns>
        public static bool IsLeapYear(this int year)
        {
            return DateTime.IsLeapYear(year);
        }

        /// <summary>
        /// Gets the next leap year based on the given year.
        /// </summary>
        /// <param name="year">Year to check.</param>
        /// <returns>The Next leap year based on the given year</returns>
        public static int NextLeapYear(this int year)
        {
            while (!year.IsLeapYear())
                year++;
            return year;
        }

        /// <summary>
        /// Gets the previous leap year based on the given year.
        /// </summary>
        /// <param name="year">Year to check.</param>
        /// <returns>The Previous leap year based on the given year</returns>
        public static int PreviousLeapYear(this int year)
        {
            while (!year.IsLeapYear())
                year--;
            return year;
        }

        /// <summary>
        /// Converts byte array to base64 string.
        /// </summary>
        /// <param name="source">Byte array to convert.</param>
        /// <param name="options">Base64 format options.</param>
        /// <returns>Base64 string from given byte array.</returns>
        public static string FromByeArrayToBase64(this byte[] source, Base64FormattingOptions options = Base64FormattingOptions.None)
        {
            return Convert.ToBase64String(source, options);
        }

        /// <summary>
        /// Separates every 3 number by comma.
        /// </summary>
        /// <param name="source">Number to separate.</param>
        /// <returns>Separated number in string format.</returns>
        public static string SeparateThousandsByComma(this int source)
        {
            return source.ToString("n0");
        }

        /// <summary>
        /// Separates every 3 number by comma.
        /// </summary>
        /// <param name="source">Number to separate.</param>
        /// <param name="culture">Culture info.</param>
        /// <returns>Separated number in string format.</returns>
        public static string SeparateThousandsByComma(this int source, CultureInfo culture)
        {
            return source.ToString("N0", culture);
        }

        /// <summary>
        /// Generating Random Numbers.
        /// </summary>
        /// <param name="length">The Length of generated target.</param>
        /// <returns>Random target based on given length.</returns>
        public static string RandomDigits(this int length)
        {
            var str = new StringBuilder();
            var randomize = new Random();

            for (var i = 0; i < length; ++i)
                str.Append(randomize.Next(10));
            return str.ToString();
        }

        /// <summary>
        /// Generating Random Numbers.
        /// </summary>
        /// <param name="length">The Length of generated target.</param>
        /// <param name="isUpperCase"></param>
        /// <param name="containNumbers"></param>
        /// <returns>Random target based on given length.</returns>
        public static string GenerateRandomString(this int length, bool isUpperCase = false, bool containNumbers = false)
        {
            var str = new StringBuilder();
            var randomize = new Random();
            var alphabet = @"abcdefghijklmnopqrstuvwxyz";

            if (isUpperCase)
                alphabet = alphabet.ToUpper();
            if (containNumbers)
                alphabet += "1234567890";

            var iterateLoopLimit = containNumbers ? 36 : 26;

            for (var i = 0; i < length; ++i)
            {
                var random = randomize.Next(iterateLoopLimit);
                str.Append(alphabet.ElementAt(random));
            }
            return str.ToString();
        }

        /// <summary>
        /// Converts given number to kilobytes.
        /// </summary>
        /// <param name="number">Number to convert.</param>
        /// <returns>Kilobytes based on given number.</returns>
        public static double ToKB(this int number, DigitalStorage from = DigitalStorage.KB)
        {
            switch (from)
            {
                case DigitalStorage.MB:
                    return number * 1000;
                case DigitalStorage.GB:
                    return number * 1000000;
                case DigitalStorage.TB:
                    return number * 1000000000;
                case DigitalStorage.KB:
                default:
                    return number;
            }
        }

        /// <summary>
        /// Converts given number to megabytes.
        /// </summary>
        /// <param name="number">Number to convert.</param>
        /// <param name="from">From type.</param>
        /// <returns>Megabytes based on given number and given type to convert from.</returns>
        public static double ToMB(this int number, DigitalStorage from = DigitalStorage.MB)
        {
            switch (from)
            {
                case DigitalStorage.KB:
                    return number * 0.001;
                case DigitalStorage.GB:
                    return number * 1000;
                case DigitalStorage.TB:
                    return number * 1000000;
                case DigitalStorage.MB:
                default:
                    return number;
            }
        }

        /// <summary>
        /// Converts given number to gigabytes.
        /// </summary>
        /// <param name="number">Number to convert.</param>
        /// <param name="from">From type.</param>
        /// <returns>Gigabytes based on given number and given type to convert from.</returns>
        public static double ToGB(this int number, DigitalStorage from = DigitalStorage.GB)
        {
            switch (from)
            {
                case DigitalStorage.KB:
                    return number.ToMB(DigitalStorage.KB) * 0.001;
                case DigitalStorage.MB:
                    return number * 0.001;
                case DigitalStorage.TB:
                    return number * 1000;
                case DigitalStorage.GB:
                default:
                    return number;
            }
        }

        /// <summary>
        /// Converts given number to terabytes.
        /// </summary>
        /// <param name="number">Number to convert.</param>
        /// <param name="from">From type.</param>
        /// <returns>Gigabytes based on given number and given type to convert from.</returns>
        public static double ToTB(this int number, DigitalStorage from = DigitalStorage.TB)
        {
            switch (from)
            {
                case DigitalStorage.KB:
                    return number.ToGB(DigitalStorage.KB) * 0.001;
                case DigitalStorage.MB:
                    return number.ToGB(DigitalStorage.MB) * 0.001;
                case DigitalStorage.GB:
                    return number * 0.001;
                case DigitalStorage.TB:
                default:
                    return number;
            }
        }
    }
}