using System;
using System.Collections.Generic;
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
            var list = sourceList.ToList();
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
            
            if(sourceList.Any())
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
        
    }
}