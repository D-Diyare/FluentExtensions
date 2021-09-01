<p  align="center">
  <a href="https://github.com/D-Diyare/FluentExtensions">
    <img alt="FluentExtensions" width="600" heigth="100" src="https://github.com/D-Diyare/FluentExtensions/blob/master/docs/FluentExtensionsLogo.png">
  </a>
</p >
<br/>

# FluentExtensions
Fluent Extensions is a set of more than 70 .NET extensions, it especially made for helping developers to focus on the main tasks rather than get distracted by writing the same code again and again.

### Install FluentExtensions via NuGet

If you want to include FluentExtensions in your project, you can [install it directly from NuGet](https://www.nuget.org/packages/FluentExtensions.NET)

To install FluentExtensions, run the following command in the Package Manager Console

```
PM> Install-Package FluentExtensions
```

### Extensions

#### Extensions to Numbers

```c#
bool IsEven(this int source);
bool IsOdd(this int source);
bool IsGreaterThan(this int source, int target);
bool IsLessThan(this int source, int target);
bool IsEqualTo(this int source, int target);
DateTime DaysAgo(this int days);
DateTime DaysAfter(this int days);
DateTime WeeksAgo(this int weeks);
DateTime WeeksAfter(this int weeks);
DateTime Days(this int num);
DateTime MonthsAfter(this int months);
DateTime MonthsAgo(this int months);
DateTime YearsAgo(this int years);
DateTime YearsAfter(this int years);
bool IsLeapYear(this int year);
int NextLeapYear(this int year);
int PreviousLeapYear(this int year);
string FromByeArrayToBase64(this byte[] source, Base64FormattingOptions options = Base64FormattingOptions.None);
string SeparateThousandsByComma(this int source);
string SeparateThousandsByComma(this int source, CultureInfo culture);
string RandomDigits(this int length);
string GenerateRandomString(this int length, bool isUpperCase = false, bool containNumbers = false);
```

#### Extensions to Strings

```c#
bool IsInt(this string source);
bool IsDouble(this string source);
bool IsDecimal(this string source);
IsBoolean(this string source);
bool IsDate(this string source);
string GetInBetween(this string source, string start, string end);
string ToTitleCase(this string source);
string ToTitleCase(this string source, CultureInfo culture);
bool ToBoolean(this string source);
bool IsContainDigits(this string source);
bool IsContainLetters(this string source);
bool AreAllDigits(this string source);
bool AreAllLetters(this string source);
byte[] FromBase64ToByteArray(this string source);
byte[] GetBytes(this string source);
byte[] GetBytes(this string source, EncodingType encodingType);
bool IsEmpty(this string source);
string GetFileExtension(this string filePath);
bool FileExists(this string filePath);
ToFileInDisk(this string source, string path);
Task ToFileInDiskAsync(this string source, string path);
string ReadFromDisk(this string path);
Task<string> ReadFromDiskAsync(this string path);
```

#### Extensions to DateTime

```c#
DateTime Tomorrow(this DateTime current);
DateTime Yesterday(this DateTime current);
DateTime NextHour(this DateTime current);
DateTime LastHour(this DateTime current);
DateTime NextWeek(this DateTime current);
DateTime LastWeek(this DateTime current);
static DateTime LastMonth(this DateTime current);
DateTime NextMonth(this DateTime current);
DateTime LastYear(this DateTime current);
DateTime NextYear(this DateTime current);
DateTime DaysAgo(this DateTime source, int days);
DateTime DaysAfter(this DateTime source, int days);
DateTime WeeksAgo(this DateTime source, int weeks);
DateTime WeeksAfter(this DateTime source, int weeks);
DateTime MonthsAgo(this DateTime source, int months);
DateTime MonthsAfter(this DateTime source, int months);
DateTime YearsAgo(this DateTime source, int years);
static DateTime YearsAfter(this DateTime source, int years);
DateTime FirstDayOfMonth(this DateTime date);
DateTime LastDayOfMonth(this DateTime date);
double DaysLeft(this DateTime source, DateTime target);
int DaysInMonth(this DateTime date);
bool IsBetween(this DateTime dateToCompare,
            DateTime startDate, DateTime endDate);
bool IsBefore(this DateTime dateToCompare, DateTime target);
bool IsAfter(this DateTime dateToCompare, DateTime target);
bool IsYearLeap(this DateTime date);
DateTime NextLeapYear(this DateTime date);
DateTime PreviousLeapYear(this DateTime date);
int GetAge(this DateTime date);
string DayName(this DateTime current);
```

#### Extensions to Lists

```c#
IEnumerable<T> ToImmutableList<T>(this IEnumerable<T> sourceList);
static IEnumerable<T> ReplaceWith<T>(this IList<T> sourceList, IEnumerable<T> targetList);
T PickRandomItem<T>(this IList<T> sourceList);
```
