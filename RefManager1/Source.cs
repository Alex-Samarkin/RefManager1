using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RefManager1
{
    /// <summary>
    /// источник ссылки - книга, статья или адрес в интернете
    /// </summary>
    public class Source
    {
        public Author MainAuthor { get; set; } = new Author();
        public List<Author> Authors { get; set; } = new List<Author>() { };

        public string Title { get; set; } = String.Empty;
        public string SubTitle { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string Comment { get; set; } = String.Empty;

        public string URL { get; set; } = String.Empty;

        public string FullPathToFile { get; set; } = String.Empty;

        private PropertyInfo[] _PropertyInfos = null;

        public override string ToString()
        {
            if (_PropertyInfos == null)
                _PropertyInfos = this.GetType().GetProperties();

            var sb = new StringBuilder();

            foreach (var info in _PropertyInfos)
            {
                var value = info.GetValue(this, null) ?? "(null)";
                sb.AppendLine(info.Name + ": " + value.ToString());
            }

            return sb.ToString();
        }
    }
}