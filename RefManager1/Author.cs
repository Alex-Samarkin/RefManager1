using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefManager1
{
    /// <summary>
    /// автор публикации
    /// </summary>
    public class Author
    {
        /// <summary>
        /// имя автора
        /// </summary>
        public string Name { get; set; } = String.Empty;
        /// <summary>
        /// отчество
        /// </summary>
        public string MiddleName { get; set; } = String.Empty;
        /// <summary>
        /// фамилия
        /// </summary>
        public string LastName { get; set; } = String.Empty;
        /// <summary>
        /// описание (если требуется)
        /// </summary>
        public string Description { get; set; } = String.Empty;
        /// <summary>
        /// комментарий (если требуется)
        /// </summary>
        public string Comment { get; set; } = String.Empty;

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(MiddleName)}={MiddleName}, {nameof(LastName)}={LastName}, {nameof(Description)}={Description}, {nameof(Comment)}={Comment}}}";
        }
    }
}
