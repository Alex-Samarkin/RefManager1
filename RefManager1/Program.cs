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

            /// 1 Об улучшениях (это пока не надо)
            /// а) напрашивается выделить содержимое ссылки в отдельный класс - content
            /// по аналогии с классом Source
            /// b) в большинстве классов есть что-то вроде Name / Description / Comment -
            /// логично также выделить эту часть в отдельный класс и сделать этот класс либо
            /// новым свойством, либо БАЗОВЫМ классом
            ///
            /// 2 Что нужно добавить:
            /// ко всем классам надо добавть ряд типовых методов
            /// обычно добавляют (если надо):
            /// 
            /// конструктор - деструктор (нам не требуется, потому что наши классы относительно простые
            /// и их свойства инициируются явно
            ///
            /// операторы сравнения и проверок на больше-меньше (для сортировки и участия
            /// в некоторых обобщенных алгоритмах
            ///
            /// метод вывода в строку ToString - если  быть точным, то это
            /// метод ПРЕОБРАЗОВАНИЯ в строку
            /// он позволяет вывести наши классы в консоль
            ///
            /// следующая версия - RefManager6, содержит примеры таких методов
            ///
            ///

            /// печать ссылки
            Console.WriteLine(refBase);
            /// печать проекта
            /// посмотрите файл RefProject, посмотрите, как организзован вывод всех ссылок
            // Console.WriteLine(project);

            Console.ReadKey();
        }
    }
}
