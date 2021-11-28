using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefManager1
{
    /// <summary>
    /// менеджер проектов
    /// каждый проект, например, ориентирован на определенную тему или работу
    /// </summary>
    public class RefManager
    {
        /// это публичное свойство с именем Id, является целым числом
        /// значение по умолчанию - 0
        /// методы доступа - простые get и set
        public int Id { get; set; } = 0;

        /// <summary>
        /// пользователь
        /// </summary>
        public string User { get; set; } = String.Empty;
        /// <summary>
        /// папка для сохранения
        /// </summary>
        public string BaseFolder { get; set; } = String.Empty;
        /// <summary>
        /// общая тема проектов в этом менеджере (не обязательно)
        /// </summary>
        public string MainTheme { get; set; } = String.Empty;

        /// <summary>
        /// список проектов с цитатами
        /// </summary>
        public List<RefProject> Projects { get; set; } = new List<RefProject>();
    }
}
