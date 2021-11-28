using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefManager1
{
    /// <summary>
    /// проект - список цитат по определенной теме или для определенной работы
    /// </summary>
    public class RefProject
    {
        /// СНАЧАЛА ПОТРЕНИРУЙТЕСЬ НА RefManager.cs
        /// 
        /// добавьте к проекту свойства
        /// int Id - идентификатор проекта (на случай, если мы будем хранить его в БД)
        /// string ProjectName - имя проекта
        /// string Description
        /// string Comment
        /// Author Author - автор проекта (у нас есть этот класс, так почему бы его не использовать)
        ///
        /// за каждым свойством добавьте инициализатор
        /// = 0;
        /// = String.Empty;
        /// = new Author();
        ///

        /// Добавьте свойства ниже этой строки
        ///
        public int Id { get; set; } = 0;

        public string ProjectName { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string Comment { get; set; } = String.Empty;

        public Author Author { get; set; } = new Author();

        /// ТЕПЕРЬ ВЕРНИТЕСЬ К RefManager и добавьте к нему новое свойство - Projects
        /// это список проектов, за которые отвечает менеджер
        /// как правило, это список, поэтому свойство будет иметь тип
        /// List<RefProject>
        ///
        /// имя Projects
        ///
        /// инициализатор -  = new List<RefProject> () {};
    }
}
