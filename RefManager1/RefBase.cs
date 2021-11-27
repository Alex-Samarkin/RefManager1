using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefManager1
{
    /// <summary>
    /// ссылка (цитата)
    /// </summary>
    public class RefBase
    {
        public Source Source { get; set; } = new Source();
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;

        public string Text { get; set; } = String.Empty;

        /// <summary>
        /// page or html
        /// </summary>
        public string Place { get; set; } = String.Empty;
    }
}
