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
        /// page or html - страница, страницЫ или место в html файле
        /// </summary>
        public string Place { get; set; } = String.Empty;


        /// <summary>
        /// 1 добавили вывод одной цитаты
        /// </summary>
        /// <returns>строковое представление цитаты с источником</returns>
        public override string ToString()
        {
            /// выбран вариант со StringBuilder
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{nameof(Name)}: {Name})");
            sb.AppendLine($"{nameof(Description)}: {Description}, {nameof(Comment)}: {Comment}");
            sb.AppendLine($"{nameof(Text)}: {Text}, {nameof(Place)}: {Place})");
            /// обратите внимание: источник цитаты преобразовывается в строку неявно
            /// можно было также вызвать Source.ToString() во второй фигурной скобке
            sb.AppendLine($"{nameof(Source)}: {Source}");

           return sb.ToString();
        }
    }
}
