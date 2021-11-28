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

            /// После добавления свойств к менеджеру и проекту можно их создать и распечатать
            ///
            
            /// Менеджер проектов
            /// в фигурных скобках - конструкторы полей
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

            /// САМОСТОЯТЕЛЬНО
            /// 1 установите точку отладки на строку manager.Projects.Add(project);
            /// просмотрите содержимое manager
            /// 2 добавьте к классу проекта список ссылок (List<RefBase> RefList {get; set;} = new ...)
            /// пользуйтесь prop <Tab>
            /// 3 создайте ссылку (содержимое - на ваше усмотрение) RefBase refBase = new RefBase(){}
            /// 4 добавьте ссылку к списку ссылок project
            /// project.RefList.Add(refBase)
            /// 5 подумайте, будет ли эта ссылка видна в менеджере
            /// проверьте в отладчике ваше предположение

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

            project.RefList.Add(refBase);

            Console.ReadKey();
        }
    }
}
