using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace FluentExtensions
{
    public static class ListEx
    {
        /// <summary>
        /// Changes a list from mutable (Changeable) to immutable(Not changeable).
        /// </summary>
        /// <param name="sourceList"></param>
        /// <typeparam name="T">Generic type</typeparam>
        /// <returns>A List which it's item can't be changed.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IEnumerable<T> ToImmutableList<T>(this IEnumerable<T> sourceList)
        {
            if (sourceList == null)
                throw new ArgumentNullException(nameof(sourceList));

            var list = sourceList.AsList();
            return list.AsReadOnly();
        }

        /// <summary>
        /// Replaces a list items with another ones items.
        /// </summary>
        /// <param name="sourceList">List to to replace it's items.</param>
        /// <param name="targetList">List to replace items with.</param>
        /// <typeparam name="T">Generic type</typeparam>
        /// <returns>Same old list but with new items.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IEnumerable<T> ReplaceWith<T>(this IList<T> sourceList, IEnumerable<T> targetList)
        {
            if (sourceList == null)
                throw new ArgumentNullException(nameof(sourceList));

            if (sourceList.Any())
                sourceList.Clear();

            foreach (var item in targetList)
                sourceList.Add(item);

            return sourceList;
        }

        /// <summary>
        /// Picks one item through the list randomly.
        /// </summary>
        /// <param name="sourceList">List to pick item from.</param>
        /// <typeparam name="T">Generic type</typeparam>
        /// <returns>A random item from the list.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static T PickRandomItem<T>(this IList<T> sourceList)
        {
            if (sourceList == null)
                throw new ArgumentNullException(nameof(sourceList));

            if (!sourceList.Any())
                throw new ArgumentNullException($"{nameof(sourceList)} is empty");

            var randomize = new Random();
            return sourceList[randomize.Next(1, sourceList.Count)];
        }

        /// <summary>
        /// Joins string array into a single string separated via delimiter.
        /// </summary>
        /// <param name="texts">string array to join.</param>
        /// <param name="delimiter">delimiter to join strings with (eg: , ).</param>
        /// <returns>A Single string based on given array.</returns>
        public static string Join(this IEnumerable<string> texts, string delimiter)
        {
            var str = new StringBuilder();
            foreach (var text in texts)
            {
                str.Append($"{text}{delimiter}");
            }

            return str.ToString();
        }

        /// <summary>
        /// Converts IEnumerable to list, if it is already a List it returns the list itself. 
        /// </summary>
        /// <param name="sourceList">IEnumerable to convert.</param>
        /// <returns>List from IEnumerable.</returns>
        public static IList<T> AsList<T>(IEnumerable<T> sourceList)
        {
            if (sourceList == null)
                throw new ArgumentNullException(nameof(sourceList));

            return sourceList is List<T> ? sourceList : sourceList.ToList();
        }

        /// <summary>
        /// Converts Generic type into CSV file.
        /// </summary>
        /// <param name="entity">Entity to convert.</param>
        /// <param name="path">CSV output path.</param>
        public static void ToCSV<T>(IEnumerable<T> entities, string path, bool append = false)
        {
            var text = new StringBuilder();

            foreach (var entity in entities)
            {
                var props = entity?.GetType().GetProperties();
                var length = props?.Length;
    
                for (var i = 0; i < length; i++)
                {
                    var val = props?[i].GetValue(entity)?.ToString();
                    var delimiter = i == length - 1 ? "" : ",";
                    text.Append($"{val}{delimiter}");
                }

                text.AppendLine();
            }

            using (var write = new StreamWriter(path, append))
            {
                write.Write(text.ToString());
            }
        }

        /// <summary>
        /// Converts Generic type into CSV file asynchrnously.
        /// </summary>
        /// <param name="entity">Entity to convert.</param>
        /// <param name="path">CSV output path.</param>
        public static async Task ToCSVAsync<T>(IEnumerable<T> entities, string path, bool append = false)
        {
            var text = new StringBuilder();

            foreach (var entity in entities)
            {
                var props = entity?.GetType().GetProperties();
                var length = props?.Length;
    
                for (var i = 0; i < length; i++)
                {
                    var val = props?[i].GetValue(entity)?.ToString();
                    var delimiter = i == length - 1 ? "" : ",";
                    text.Append($"{val}{delimiter}");
                }

                text.AppendLine();
            }

            using (var writer = new StreamWriter(path, append))
            {
                await writer.WriteAsync(text.ToString());
            }
        }

    }
}