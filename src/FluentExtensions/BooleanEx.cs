using System;

namespace FluentExtensions
{
    public static class BooleanEx
    {
        /// <summary>
        /// Converts boolean value to either "yes" or "No".
        /// </summary>
        /// <param name="source">Boolean to check.</param>
        /// <returns>Either "Yes" or "No" based on given boolean value.</returns>
        public static string ToYesNo(this bool source)
        {
            return source ? "Yes" : "No";
        }

        /// <summary>
        /// Converts boolean value to either "yes" or "No".
        /// </summary>
        /// <param name="source">Boolean to check.</param>
        /// <param name="pattern">Pattern for Yes or No, for example in german language: "Ja|Nein" </param>
        /// <returns>Either "Yes" or "No" based on given boolean value.</returns>
        /// <example>French implementation will be like<code>"Oui|Non"</code></example>
        public static string ToYesNo(this bool source, string pattern)
        {
            var patternArray = pattern.Split('|');
            return source ? patternArray[0] : patternArray[1];
        }

        /// <summary>
        /// Executes an action while the given boolean value is equal to target value.
        /// </summary>
        /// <param name="source">boolean value to check against.</param>
        /// <param name="result">target value to check into.</param>
        /// <param name="execute">The Action to execute when the condition is met.</param>
        public static void DoOn(this bool source, bool result, Action execute)
        {
            if (source != result)
                return;

            execute.Invoke();
        }
    }
}