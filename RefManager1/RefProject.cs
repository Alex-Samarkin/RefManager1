using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace RefManager1
{
    /// <summary>
    /// проект - список цитат по определенной теме или для определенной работы
    /// </summary>
    public class RefProject
    {
        /// <summary>
        /// идентификатор проекта
        /// </summary>
        public int Id { get; set; } = 0;
        /// <summary>
        /// название проекта
        /// </summary>
        public string ProjectName { get; set; } = String.Empty;
        /// <summary>
        /// описание проекта
        /// </summary>
        public string Description { get; set; } = String.Empty;
        /// <summary>
        /// комментарий
        /// </summary>
        public string Comment { get; set; } = String.Empty;

        /// <summary>
        /// автор проекта
        /// </summary>
        public Author Author { get; set; } = new Author();
        
        /// <summary>
        /// список ссылок проекта
        /// </summary>
        public List<RefBase> RefList { get; set; } = new List<RefBase>();
    }
}
