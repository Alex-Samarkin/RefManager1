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

        /// 2 цитаты проекта
        /// в данном случае цитат много (по крайней мере может быть), поэтому сначала
        /// выводим базовую иннформацию о проекте
        /// затем в цикле - все циататы, которые есть
        /// для красоты разделяем начало и конец проекта, а также цитаты строками-разделителями
        ///
        public override string ToString()
        {
            /// конструктор строк
            StringBuilder sb = new StringBuilder();
            /// заголовок
            sb.AppendLine(new string('=', 120));
            sb.AppendLine($"{nameof(Id)}: {Id}, {nameof(ProjectName)}: {ProjectName}");
            sb.AppendLine($"{nameof(Description)}: {Description},\n {nameof(Comment)}: {Comment}");
            /// автор проекта
            sb.AppendLine(new string('-', 60));
            sb.AppendLine($"{nameof(Author)}: {Author}");
            sb.AppendLine(new string('-', 60));
            /// перебираем ссылки
            foreach (var r in RefList)
            {
                sb.AppendLine(new string('*', 90));
                sb.AppendLine(r.ToString());
                sb.AppendLine(new string('*', 90));
            }
            /// закрываем вывод
            sb.AppendLine(new string('=', 120));

            return sb.ToString();
            /// раскомментируйте строку с выводом проекта в консоль
        }
    }
}
