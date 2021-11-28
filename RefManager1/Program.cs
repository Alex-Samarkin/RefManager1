using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefManager1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author();
            Console.WriteLine(author);
            Console.ReadKey();

            Source source = new Source();
            Console.WriteLine(source);
            Console.ReadKey();

            /// менеджер
            RefManager manager = new RefManager()
            {
                Id = 1, BaseFolder = "Мои проекты",
                MainTheme = "Медицина катастроф",
                User = "Student",
                Projects = new List<RefProject>() // не обязательно, так как список будет создан
            };

            /// Проект
            RefProject project = new RefProject()
            {
                Author = new Author()
                {
                    Name = "Иван",
                    MiddleName = "Иванович",
                    LastName = "Иванов"
                },
                ProjectName = "Катастрофы в сельском хозяйстве",
                Description = "Как вывести кротов с дачного участка"
            };

            /// Добавляем проект в менеджер
            manager.Projects.Add(project);

            /// ссылка на источник
            RefBase refBase = new RefBase()
            {
                Name = "О роли кротов в китайской литературе",
                Description = "Китайцы о котах и кротах",
                Text = "В 12 году правления императора Цы в провинции Шань расплодились кроты невероятных размеров",
                Source = new Source()
                {
                    MainAuthor = new Author()
                    {
                        LastName = "Ло",
                        MiddleName = "ван",
                        Name = "Го"
                    },
                    Title = "Заметки путешественника",
                    SubTitle = "о чудесном",
                    Description = "Малоизвестный сборник заметок чиновника"
                },
                Comment = "Добавить к введению"
            };

            /// ссылка добавлена в проект, а проект уже добавлен в менеджер
            /// manager-
            ///    projects-
            ///        references -
            ///             content ---------- source
            ///               |- сама цитата    |- откуда взято
            project.RefList.Add(refBase);

            /// 1 Об улучшениях
            /// а) напрашивается выделить содержимое ссылки в отдельный класс - content
            /// по аналогии с классом Source
            /// b) в большинстве классов есть что-то вроде Name / Description / Comment -
            /// логично также выделить эту часть в отдельный класс и сделать этот класс либо
            /// новым свойством, либо БАЗОВЫМ классом

            Console.ReadKey();
        }
    }
}
