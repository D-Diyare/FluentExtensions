<p  align="center">
  <a href="https://github.com/D-Diyare/FluentExtensions">
    <img alt="FluentExtensions" width="600" heigth="100" src="https://github.com/D-Diyare/FluentExtensions/blob/master/docs/FluentExtensionsLogo.png">
  </a>
</p >
<br/>

# FluentExtensions

Fluent Extensions is a set of more than 100 .NET extensions, it especially made for helping developers to focus on the main tasks rather than get distracted by writing the same code again and again for simple actions, FluentExtensions akso increases readability.

### Install FluentExtensions via NuGet

If you want to include FluentExtensions in your project, you can [install it directly from NuGet](https://www.nuget.org/packages/FluentExtensions.NET)

To install FluentExtensions, run the following command in the Package Manager Console

```
PM> Install-Package FluentExtensions.NET

```

### Documentations

> [Docs](https://d-diyare.github.io/FluentExtensions/)

### Extensions

#### Extensions to booleans

```c#
// Converts boolean value to either "yes" or "No".
string ToYesNo(this bool source);

// Executes an action while the given boolean value is equal to target value.
void DoOn(this bool source, bool result, Action execute);

// Converts boolean value to either "yes" or "No".
string ToYesNo(this bool source, string pattern);
```

#### Extensions to Numbers

```c#
// Determines whether the given target is even.
bool IsEven(this int source);

// Determines whether the given target is odd.
bool IsOdd(this int source);

// Determines whether the current number is greater than the target one.
bool IsGreaterThan(this int source, int target);

// Determines whether the current number is less than the target one.
bool IsLessThan(this int source, int target);

// Determines whether the current number is equal to the target one.
bool IsEqualTo(this int source, int target);

// Gets the date time in past from given number of days.
DateTime DaysAgo(this int days);

// Gets the date time in future from given number of days.
DateTime DaysAfter(this int days);

// Gets the date time in past from given number of weeks.
DateTime WeeksAgo(this int weeks);

// Gets the date time in future from given number of weeks.
DateTime WeeksAfter(this int weeks);

// Converts the given number into days.
DateTime Days(this int num);

// Gets the date time in future from given number of months.
DateTime MonthsAfter(this int months);

// Gets the date time in past from given number of months.
DateTime MonthsAgo(this int months);

// Gets the date time in past from given number of years.
DateTime YearsAgo(this int years);

// Gets the date time in future from given number of years.
DateTime YearsAfter(this int years);

// Determines whether the given year is a leap year.
bool IsLeapYear(this int year);

// Gets the next leap year based on the given year.
int NextLeapYear(this int year);

// Gets the previous leap year based on the given year.
int PreviousLeapYear(this int year);

// Converts byte array to base64 string.
string FromByeArrayToBase64(this byte[] source, Base64FormattingOptions options = Base64FormattingOptions.None);

// Separates every 3 number by comma.
string SeparateThousandsByComma(this int source);

// Separates every 3 number by comma.
string SeparateThousandsByComma(this int source, CultureInfo culture);

// Generating Random Numbers.
string RandomDigits(this int length);

// Generating Random Numbers.
string GenerateRandomString(this int length, bool isUpperCase = false, bool containNumbers = false);

// Converts given number to kilobytes.
double ToKB(this int number, DigitalStorage from = DigitalStorage.KB);

// Converts given number to megabytes.
double ToMB(this int number, DigitalStorage from = DigitalStorage.MB);

// Converts the given number to gigabytes.
double ToGB(this int number, DigitalStorage from = DigitalStorage.GB);

// Converts the given number to terabytes.
double ToTB(this int number, DigitalStorage from = DigitalStorage.TB)

// Converts given number to kilobytes.
double ToKB(this long number, DigitalStorage from = DigitalStorage.KB);

// Converts given number to megabytes.
double ToMB(this long number, DigitalStorage from = DigitalStorage.MB);

// Converts the given number to gigabytes.
double ToGB(this long number, DigitalStorage from = DigitalStorage.GB);

// Converts the given number to terabytes.
double ToTB(this long number, DigitalStorage from = DigitalStorage.TB)


```

#### Extensions to Strings

```c#
// Determines whether the given string is Integer.
bool IsInt(this string source);

// Determines whether the given string is Double.
bool IsDouble(this string source);

// Determines whether the given string is Decimal.
bool IsDecimal(this string source);

// Determines whether the given string is Boolean.
bool IsBoolean(this string source);

// Determines whether the given string is Date.
bool IsDate(this string source);

// Gets string between two strings.
// Credits: https://stackoverflow.com/a/28723216/12352466
string GetInBetween(this string source, string start, string end);

// Converts given text into title case text.
string ToTitleCase(this string source);

// Converts given text into title case text.
string ToTitleCase(this string source, CultureInfo culture);

// Converts string type (True | False) to boolean.
bool ToBoolean(this string source);

// Determines whether the given string contains digit(s).
bool IsContainDigits(this string source);

// Determines whether the given string contains letter(s).
bool IsContainLetters(this string source);

// Determines whether all characters of the given text are digits.
bool AreAllDigits(this string source);

// Determines whether all characters of the given text are letters.
bool AreAllLetters(this string source);

// Converts back base64 string to byte array;
byte[] FromBase64ToByteArray(this string source);

// Converts string to byte array.
byte[] GetBytes(this string source);

// Converts string to byte array.
byte[] GetBytes(this string source, EncodingType encodingType);

// Determines whether the given text is null or whitespace or empty.
bool IsEmpty(this string source);

// Gets the extension of the file.
string GetFileExtension(this string filePath);

// Determines whether the file exists.
bool FileExists(this string filePath);

// Gets the content of the text file.
void ToFileInDisk(this string source, string path);

// Gets the content of the text file asynchronously.
Task ToFileInDiskAsync(this string source, string path);

// Gets the content of the text file.
string ReadFromDisk(this string path);

// Gets the content of the text file asynchronously.
Task<string> ReadFromDiskAsync(this string path);

// Adds text to end of another text.
string AddToEnd(this string text, string textToAdd, bool addSpaceBeforeAddition = true);

// Adds text to start of another text.
string AddToStart(this string text, string textToAdd, bool addSpaceAfterAddition = true);

// Gets portion of string based on given characters and position to get.
string Take(this string source, int characters, Position from = Position.Start);

// Replaces multiple values inside a string with one value.
string ReplaceMultipleWithOne(this string source, string[] values, string value);

// Gets the free space of the given drive in gigabytes.
string DriveFreeSpace(this string driveLetter);

// Gets the total size of the given drive in gigabytes.
string DriveTotalSize(this string driveLetter);

// Gets the total size of the given drive in gigabytes.
string DriveTotalSize(this string driveLetter);

// Gets the format of the given drive.
string DriveFormat(this string driveLetter);

// Gets the type of the given drive.
DriveType DriveType(this string driveLetter);

// Delete the given file from disk.
void DeleteFile(this string filePath);

// Hides the given file from disk.
void HideFile(this string filePath);

// Shows the given file from the disk (if it's already hidden).
void ShowFile(this string filePath);

// Gets the date and time when this given file was created.
DateTime CreatedDate(this string filePath);

// Copies the file to the given destination (overwrites it if it already exists).
void CopyFile(this string filePath, string destination);

// Moves the file to the given destination (overwrites it if it already exists).
void MoveFile(this string filePath, string destination);

// Gets the file size in kilobytes.
double FileSizeInKB(this string filePath);

// Gets the file size in megabytes.
double FileSizeInMB(this string filePath);

// Reads the file content as array of bytes.
byte[] ReadBytesFromDisk(this string filePath);

// Reads the file content as array of bytes asynchronously.
Task<byte[]> ReadBytesFromDiskAsync(this string filePath)

// Reads xml content file as generic type.
T FromXml<T>(this string path);

// Generate a new guid and returns it as a string.
static string FromGuid(this string empty);
```

#### Extensions to DateTime

```c#
// Gets the day after given date.
DateTime Tomorrow(this DateTime current);

// Gets the day before given date.
DateTime Yesterday(this DateTime current);

// Gets an hour after the given date.
DateTime NextHour(this DateTime current);

// Gets an hour before the given date.
DateTime LastHour(this DateTime current);

// Gets a week after the given date.
DateTime NextWeek(this DateTime current);

// Gets a week before the given date.
DateTime LastWeek(this DateTime current);

// Gets a month before the given date.
static DateTime LastMonth(this DateTime current);

// Gets a month after the given date.
DateTime NextMonth(this DateTime current);

// Gets a year before the given date.
DateTime LastYear(this DateTime current);

// Gets a year after the given date.
DateTime NextYear(this DateTime current);

// Gets the number of days prior to the given date.
DateTime DaysAgo(this DateTime source, int days);

// Gets the number of days after the given date.
DateTime DaysAfter(this DateTime source, int days);

// Gets the number of weeks prior the given date.
DateTime WeeksAgo(this DateTime source, int weeks);

// Gets the number of weeks after the given date.
DateTime WeeksAfter(this DateTime source, int weeks);

// Gets the number of months prior the given date.
DateTime MonthsAgo(this DateTime source, int months);

// Gets the number of months after the given date.
DateTime MonthsAfter(this DateTime source, int months);

// Gets the number of years prior the given date.
DateTime YearsAgo(this DateTime source, int years);

// Gets the number of years after the given date.
static DateTime YearsAfter(this DateTime source, int years);

// Gets the first day of month.
DateTime FirstDayOfMonth(this DateTime date);

// Gets the last day of month.
DateTime LastDayOfMonth(this DateTime date);

// Gets the number of days left to the target date.
double DaysLeft(this DateTime source, DateTime target);

// Gets the number of the days of the given date month.
int DaysInMonth(this DateTime date);

// Determines whether the given date is between the two given dates.
bool IsBetween(this DateTime dateToCompare, DateTime startDate, DateTime endDate);

// Determines whether the given date is before the target one.
bool IsBefore(this DateTime dateToCompare, DateTime target);

// Determines whether the given date is already passed the target one.
bool IsAfter(this DateTime dateToCompare, DateTime target);

// Determines whether the given date is a leap year.
bool IsYearLeap(this DateTime date);

// Gets the Next leap year based on the given date.
DateTime NextLeapYear(this DateTime date);

// Gets the previous leap year based on the given date.
DateTime PreviousLeapYear(this DateTime date);

// Calculates age based on given date.
int GetAge(this DateTime date);

// Gets the name of the given date time.
string DayName(this DateTime current);
```

#### Extensions to Generics

```c#
// Converts generic type to xml content file.
void ToXml<T>(this T entity, string path;

// Converts generic type to xml content file.
void ToXml<T>(this T entity, string path, Encoding encoding);

// Converts generic type to xml content file.
void ToXml<T>(this T entity, string path, Formatting formatting, int indentation = 4);

// Converts generic type to xml content file.
void ToXml<T>(this T entity, string path, Encoding encoding, Formatting formatting, int indentation = 4);

// Converts Generic type into CSV file.
void ToCSV<T>(this T entity, string path, bool append = false);

// Converts Generic type into CSV file asynchronously
Task ToCSVAsync<T>(this T entity, string path, bool append = false);

```

#### Extensions to Lists

```c#
// Changes a list from mutable (Changeable) to immutable(Not changeable).
IEnumerable<T> ToImmutableList<T>(this IEnumerable<T> sourceList);

// Replaces a list items with another ones items.
static IEnumerable<T> ReplaceWith<T>(this IList<T> sourceList, IEnumerable<T> targetList);

// Picks one item through the list randomly.
T PickRandomItem<T>(this IList<T> sourceList);

// Joins string array into a single string separated via delimiter.
string Join(this IEnumerable<string> texts, string delimiter);

// Converts IEnumerable to list, if it is already a List it returns the list itself.
IList<T> AsList<T>(IEnumerable<T> sourceList);

// Converts Generic list type into CSV file.
void ToCSV<T>(IEnumerable<T> entities, string path, bool append = false);

// Converts Generic list type into CSV file asynchrnously.
Task ToCSVAsync<T>(IEnumerable<T> entities, string path, bool append = false);
```
