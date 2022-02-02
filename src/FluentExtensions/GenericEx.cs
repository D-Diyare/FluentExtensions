using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace FluentExtensions
{
    public static class GenericEx
    {
        /// <summary>
        /// Converts generic type to xml content file.
        /// </summary>
        /// <param name="entity">Entity to convert from.</param>
        /// <param name="path">XML output file.</param>
        public static void ToXml<T>(this T entity, string path)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var writer = new XmlTextWriter(path, Encoding.Default)
                       {Formatting = Formatting.Indented, Indentation = 4})
            {
                serializer.Serialize(writer, entity);
            }
        }

        /// <summary>
        /// Converts generic type to xml content file.
        /// </summary>
        /// <param name="entity">Entity to convert from.</param>
        /// <param name="path">XML output file.</param>
        /// <param name="encoding"></param>
        public static void ToXml<T>(this T entity, string path, Encoding encoding)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var writer = new XmlTextWriter(path, encoding) {Formatting = Formatting.Indented, Indentation = 4})
            {
                serializer.Serialize(writer, entity);
            }
        }

        /// <summary>
        /// Converts generic type to xml content file.
        /// </summary>
        /// <param name="entity">Entity to convert from.</param>
        /// <param name="path">XML output file.</param>
        /// <param name="formatting"></param>
        /// <param name="indentation"></param>
        public static void ToXml<T>(this T entity, string path, Formatting formatting, int indentation = 4)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var writer = new XmlTextWriter(path, Encoding.Default)
                       {Formatting = formatting, Indentation = indentation})
            {
                serializer.Serialize(writer, entity);
            }
        }

        /// <summary>
        /// Converts generic type to xml content file.
        /// </summary>
        /// <param name="entity">Entity to convert from.</param>
        /// <param name="path">XML file path.</param>
        /// <param name="formatting">Formatting type.</param>
        /// <param name="encoding">Encoding type.</param>
        /// <param name="indentation">Elements indentation.</param>
        public static void ToXml<T>(this T entity, string path, Encoding encoding, Formatting formatting,
            int indentation = 4)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var writer = new XmlTextWriter(path, encoding) {Formatting = formatting, Indentation = indentation})
            {
                serializer.Serialize(writer, entity);
            }
        }

        /// <summary>
        /// Converts Generic type into CSV file.
        /// </summary>
        /// <param name="entity">Entity to convert.</param>
        /// <param name="path">CSV output path.</param>
        public static void ToCSV<T>(this T entity, string path, bool append = false)
        {
            var text = new StringBuilder();
            var props = entity?.GetType().GetProperties();
            var length = props?.Length;

            for (var i = 0; i < length; i++)
            {
                var val = props?[i].GetValue(entity)?.ToString();
                var delimiter = i == length - 1 ? "" : ",";
                text.Append($"{val}{delimiter}");
            }

            using (var write = new StreamWriter(path, append))
            {
                write.Write(text.ToString());
            }
        }

        /// <summary>
        /// Converts Generic type into CSV file asynchronously.
        /// </summary>
        /// <param name="entity">Entity to convert.</param>
        /// <param name="path">CSV output path.</param>
        public static async Task ToCSVAsync<T>(this T entity, string path, bool append = false)
        {
            var text = new StringBuilder();
            var props = entity?.GetType().GetProperties();
            var length = props?.Length;

            for (var i = 0; i < length; i++)
            {
                var val = props?[i].GetValue(entity)?.ToString();
                var delimiter = i == length - 1 ? "" : ",";
                text.Append($"{val}{delimiter}");
            }

            using (var write = new StreamWriter(path, append))
            {
                await write.WriteAsync(text.ToString());
            }
        }
    }
}