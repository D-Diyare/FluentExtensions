using FluentExtensions.Enumerators;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentExtensions
{
    public static class StringEx
    {
        /// <summary>
        /// Determines whether the given string is Integer.
        /// </summary>  
        /// <param name="source">string to check.</param>
        /// <returns>Whether this given string is Integer.</returns>
        public static bool IsInt(this string source)
        {
            return int.TryParse(source, out _);
        }

        /// <summary>
        /// Determines whether the given string is Double.
        /// </summary>  
        /// <param name="source">string to check.</param>
        /// <returns>Whether this given string is Double.</returns>
        public static bool IsDouble(this string source)
        {
            return double.TryParse(source, out _);
        }

        /// <summary>
        /// Determines whether the given string is Decimal.
        /// </summary>  
        /// <param name="source">string to check.</param>
        /// <returns>Whether this given string is Decimal.</returns>
        public static bool IsDecimal(this string source)
        {
            return decimal.TryParse(source, out _);
        }

        /// <summary>
        /// Determines whether the given string is Boolean.
        /// </summary>  
        /// <param name="source">string to check.</param>
        /// <returns>Whether this given string is Boolean.</returns>
        public static bool IsBoolean(this string source)
        {
            return bool.TryParse(source, out _);
        }

        /// <summary>
        /// Determines whether the given string is Date.
        /// </summary>  
        /// <param name="source">string to check.</param>
        /// <returns>Whether this given string is Boolean.</returns>
        public static bool IsDate(this string source)
        {
            return DateTime.TryParse(source, out _);
        }


        /// <summary>
        /// Gets string between two strings.
        /// Credits: https://stackoverflow.com/a/28723216/12352466
        /// </summary>
        /// <param name="source">source to check</param>
        /// <param name="start">Start point of string to start from.</param>
        /// <param name="end">End point of string to end.</param>
        /// <returns>The String between the start and end.</returns>
        public static string GetInBetween(this string source, string start, string end)
        {
            var lastChar = start[start.Length - 1];
            var firstChar = end[end.Length - 1];
            var result = new string(source
                .SkipWhile(c => c != lastChar)
                .Skip(1)
                .TakeWhile(c => c != firstChar)
                .ToArray()).Trim();
            return result;
        }

        /// <summary>
        /// Converts given text into title case text.
        /// </summary>
        /// <param name="source">Text to convert to title case.</param>
        /// <returns>Title case text based on given text.</returns>
        public static string ToTitleCase(this string source)
        {
            var textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(source);
        }

        /// <summary>
        /// Converts given text into title case text.
        /// </summary>
        /// <param name="source">Text to convert to title case.</param>
        /// <param name="culture">Culture base.</param>
        /// <returns>Title case text based on given text.</returns>
        public static string ToTitleCase(this string source, CultureInfo culture)
        {
            var textInfo = culture.TextInfo;
            return textInfo.ToTitleCase(source);
        }

        /// <summary>
        /// Converts string type (True | False) to boolean. 
        /// </summary>
        /// <param name="source">source to convert.</param>
        /// <returns>Boolean based on given string.</returns>
        /// <exception cref="Exception">Wrong given string.</exception>
        public static bool ToBoolean(this string source)
        {
            if (!source.IsBoolean())
                throw new Exception("the given string is not boolean type.");

            return Convert.ToBoolean(source);
        }

        /// <summary>
        /// Determines whether the given string contains digit(s).
        /// </summary>
        /// <param name="source">Text to check.</param>
        /// <returns>Whether the given text contains any digits.</returns>
        public static bool IsContainDigits(this string source)
        {
            return source.Any(char.IsDigit);
        }

        /// <summary>
        /// Determines whether the given string contains letter(s).
        /// </summary>
        /// <param name="source">Text to check.</param>
        /// <returns>Whether the given text contains any letters.</returns>
        public static bool IsContainLetters(this string source)
        {
            return source.Any(char.IsLetter);
        }

        /// <summary>
        /// Determines whether all characters of the given text are digits.
        /// </summary>
        /// <param name="source">Text to check.</param>
        /// <returns>Whether all characters of the given text are digits</returns>
        public static bool AreAllDigits(this string source)
        {
            return source.All(char.IsDigit);
        }

        /// <summary>
        /// Determines whether all characters of the given text are letters.
        /// </summary>
        /// <param name="source">Text to check.</param>
        /// <returns>Whether all characters of the given text are letters</returns>
        public static bool AreAllLetters(this string source)
        {
            return source.All(char.IsLetter);
        }

        /// <summary>
        /// Converts back base64 string to byte array;
        /// </summary>
        /// <param name="source">Base64 string.</param>
        /// <returns>Byte array from base64 string.</returns>
        public static byte[] FromBase64ToByteArray(this string source)
        {
            return Convert.FromBase64String(source);
        }

        /// <summary>
        /// Converts string to byte array.
        /// </summary>
        /// <param name="source">text to convert</param>
        /// <returns>Byte array from given text.</returns>
        public static byte[] GetBytes(this string source)
        {
            return Encoding.Default.GetBytes(source);
        }

        /// <summary>
        /// Converts string to byte array.
        /// </summary>
        /// <param name="source">text to convert</param>
        /// <param name="encodingType">Encoding type to convert.</param>
        /// <returns>Byte array from given text.</returns>
        public static byte[] GetBytes(this string source, EncodingType encodingType)
        {
            switch (encodingType)
            {
                case EncodingType.UTF7:
                    return Encoding.UTF7.GetBytes(source);
                case EncodingType.UTF8:
                    return Encoding.UTF8.GetBytes(source);
                case EncodingType.Unicode:
                    return Encoding.Unicode.GetBytes(source);
                case EncodingType.BigEndianUnicode:
                    return Encoding.Unicode.GetBytes(source);
                case EncodingType.UTF32:
                    return Encoding.Unicode.GetBytes(source);
                case EncodingType.ASCII:
                    return Encoding.Unicode.GetBytes(source);
                case EncodingType.Default:
                default:
                    return Encoding.Default.GetBytes(source);
            }
        }

        /// <summary>
        /// Determines whether the given text is null or whitespace or empty.
        /// </summary>
        /// <param name="source">Text to check.</param>
        /// <returns>Whether the given text is null or empty</returns>
        public static bool IsEmpty(this string source)
        {
            return string.IsNullOrEmpty(source) || string.IsNullOrWhiteSpace(source);
        }

        /// <summary>
        /// Gets the extension of the file.
        /// </summary>
        /// <param name="filePath">The Path of the file.</param>
        /// <returns>The Extension of the given file.</returns>
        /// <exception cref="Exception"></exception>
        public static string GetFileExtension(this string filePath)
        {
            if (!Path.HasExtension(filePath))
                throw new Exception("Invalid file path.");

            return Path.GetExtension(filePath);
        }

        /// <summary>
        /// Determines whether the file exists.
        /// </summary>
        /// <param name="filePath">The Path of the file.</param>
        /// <returns>Whether the file exists.</returns>
        /// <exception cref="Exception"></exception>
        public static bool FileExists(this string filePath)
        {
            if (filePath.IsEmpty())
                throw new Exception("The given path must not be empty");
            return File.Exists(filePath);
        }

        /// <summary>
        /// Create a text file based on the given text.
        /// </summary>
        /// <param name="source">Content of the text file.</param>
        /// <param name="path">Target for the file in disk.</param>
        /// <exception cref="Exception"></exception>
        public static void ToFileInDisk(this string source, string path)
        {
            if (path.IsEmpty() || source.IsEmpty())
                throw new Exception("Either given string or path are empty");

            File.WriteAllText(path, source);
        }

        /// <summary>
        /// Create a text file asynchronously based on the given text.
        /// </summary>
        /// <param name="source">Content of the text file.</param>
        /// <param name="path">Target for the file in disk.</param>
        /// <exception cref="Exception"></exception>
        public static async Task ToFileInDiskAsync(this string source, string path)
        {
            if (path.IsEmpty() || source.IsEmpty())
                throw new Exception("Either given string or path are empty");

            using (var outputFile = new StreamWriter(path))
                await outputFile.WriteAsync(source).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the content of the text file.
        /// </summary>
        /// <param name="path">Path of the file to read.</param>
        /// <returns>Content of the file.</returns>
        /// <exception cref="Exception"></exception>
        public static string ReadFromDisk(this string path)
        {
            if (path.IsEmpty())
                throw new Exception("The given path is empty");

            return File.ReadAllText(path);
        }

        /// <summary>
        /// Gets the content of the text file asynchronously.
        /// </summary>
        /// <param name="path">Path of the file to read.</param>
        /// <returns>Content of the file.</returns>
        /// <exception cref="Exception"></exception>
        public static async Task<string> ReadFromDiskAsync(this string path)
        {
            if (path.IsEmpty())
                throw new Exception("The given path is empty");

            using (var outputFile = File.OpenText(path))
                return await outputFile.ReadToEndAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// Adds text to end of another text.
        /// </summary>
        /// <param name="text">Source text.</param>
        /// <param name="textToAdd">Text to add.</param>
        /// <param name="addSpaceBeforeAddition">Whether to add space before the addition.</param>
        /// <returns>A Combined string of the old and new text.</returns>
        public static string AddToEnd(this string text, string textToAdd, bool addSpaceBeforeAddition = true)
        {
            var additionText = addSpaceBeforeAddition ? string.Concat(" ", textToAdd) : textToAdd;
            return string.Concat(text, additionText);
        }

        /// <summary>
        /// Adds text to start of another text.
        /// </summary>
        /// <param name="text">Source text.</param>
        /// <param name="textToAdd">Text to add.</param>
        /// <param name="addSpaceAfterAddition">Whether to add space after the addition.</param>
        /// <returns>A Combined string of the old and new text.</returns>
        public static string AddToStart(this string text, string textToAdd, bool addSpaceAfterAddition = true)
        {
            var additionText = addSpaceAfterAddition ? string.Concat(textToAdd, " ") : textToAdd;
            return string.Concat(additionText, text);
        }

        /// <summary>
        /// Gets portion of string based on given characters and position to get. 
        /// </summary>
        /// <param name="source">Text to take the portion from.</param>
        /// <param name="characters">Number of characters to get.</param>
        /// <param name="from">Whether to take the portion for the start or from the end.</param>
        /// <returns>A portion of string based on given characters and position to get.</returns>
        public static string Take(this string source, int characters, Position from = Position.Start)
        {
            var position = from == Position.Start ? 0 : source.Length;
            var startIndex = from == Position.End ? (position - characters) : position;
            return source.Substring(startIndex, characters);
        }

        /// <summary>
        /// Replaces multiple values inside a string with one value.
        /// </summary>
        /// <param name="source">Text to apply replaces.</param>
        /// <param name="values">Values to replace.</param>
        /// <param name="value">value to replace values with.</param>
        /// <returns>A Text based on replaced values.</returns>
        public static string ReplaceMultipleWithOne(this string source, string[] values, string value)
        {
            string result = source;
            foreach (var val in values)
                result = result.Replace(val, value);

            return result;
        }
    }
}