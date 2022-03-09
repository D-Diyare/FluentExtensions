# v.1.6.0

**New Extensions Added:**

```cs
- void ToCSV<T>(this T entity, string path, bool append = false);
- Task ToCSVAsync<T>(this T entity, string path, bool append = false);
- void ToCSV<T>(IEnumerable<T> entities, string path, bool append = false);
- Task ToCSVAsync<T>(IEnumerable<T> entities, string path, bool append = false);
```

# v.1.5.0

**New Extensions Added:**

```cs
- void ToXml<T>(this T entity, string path);
- void ToXml<T>(this T entity, string path, Encoding encoding);
- void ToXml<T>(this T entity, string path, Formatting formatting, int indentation = 4);
- void ToXml<T>(this T entity, string path, Encoding encoding, Formatting formatting, int indentation = 4);
- T FromXml<T>(this string path);
- string FromGuid(this string empty);
- string ToYesNo(this bool source, string pattern);
```

# v.1.4.0

**New Extensions Added:**

```cs
- string Join(this IEnumerable<string> texts, string delimiter);
- byte[] ReadBytesFromDisk(this string filePath);
- Task<byte[]> ReadBytesFromDiskAsync(this string filePath);
- IList<T> AsList<T>(IEnumerable<T> sourceList);
- string ToYesNo(this bool source);
- void DoOn(this bool source, bool result, Action execute);
```

# v.1.3.0

**New Extensions Added:**

```cs
- string DriveFreeSpace(this string driveLetter);
- string DriveTotalSize(this string driveLetter);
- string DriveFormat(this string driveLetter);
- DriveType DriveType(this string driveLetter);
- void DeleteFile(this string filePath);
- void HideFile(this string filePath);
- void ShowFile(this string filePath);
- DateTime CreatedDate(this string filePath);
- void CopyFile(this string filePath, string destination);
- void MoveFile(this string filePath, string destination);
- double FileSizeInKB(this string filePath);
- double FileSizeInMB(this string filePath);
```

**Fixes:**

- Fix digital storage measurements.

# v.1.2.0

**New Extensions Added:**

```cs
- string AddToEnd(this string text, string textToAdd, bool addSpaceBeforeAddition = true);
- string AddToStart(this string text, string textToAdd, bool addSpaceafterAddition = true);
- string ReplaceMultipleWithOne(this string source, string[] values, string value)
- string Take(this string source, int characters, Position from = Position.Start);
- double ToKB(this int number, DigitalStorage from = DigitalStorage.KB);
- double ToMB(this int number, DigitalStorage from = DigitalStorage.MB);
- double ToGB(this int number, DigitalStorage from = DigitalStorage.GB);
- double ToTB(this int number, DigitalStorage from = DigitalStorage.TB);
```

# v.1.1.0

- Fix Misspellings.
- Update icon.

# v.1.0.0

- Initial release.
