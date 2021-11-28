using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RefManager1
{
    /// <summary>
    /// источник ссылки - книга, статья или адрес в интернете
    /// </summary>
    public class Source
    {
        /// <summary>
        /// основной автор
        /// </summary>
        public Author MainAuthor { get; set; } = new Author();
        /// <summary>
        /// остальные авторы (если имеются)
        /// </summary>
        public List<Author> Authors { get; set; } = new List<Author>() { };

        /// <summary>
        /// заголовок - основное название 
        /// </summary>
        public string Title { get; set; } = String.Empty;
        /// <summary>
        /// подзаголовок (если необходимо)
        /// </summary>
        public string SubTitle { get; set; } = String.Empty;
        /// <summary>
        /// описание источника (если необходимо)
        /// </summary>
        public string Description { get; set; } = String.Empty;
        /// <summary>
        /// комментарий (если требуется)
        /// </summary>
        public string Comment { get; set; } = String.Empty;
        /// <summary>
        /// адрес в сети Интернет, если требуется
        /// </summary>
        public string URL { get; set; } = String.Empty;
        /// <summary>
        /// место расположение файла, если имеется локальный файл
        /// </summary>
        public string FullPathToFile { get; set; } = String.Empty;

        /// <summary>
        /// необходимо для автоматической генерации списка свойств - значений
        /// </summary>
        private PropertyInfo[] _PropertyInfos = null;

        /// <summary>
        /// метод, преобразующий все свойства в пары имя - значение
        /// чтобы вывести класс в виде строки
        /// </summary>
        /// <returns>строка, представляющая свойства и значения свойств класса</returns>
        public override string ToString()
        {
            /// заполняем массив свойствами и их текущими значениями
            if (_PropertyInfos == null)
                _PropertyInfos = this.GetType().GetProperties(); // свойства текущего класса

            /// класс для манипуляции строками
            /// более быстрый, чем форматированные строки
            var sb = new StringBuilder();

            /// для каждого свойства в массиве, созданном ранее
            foreach (var info in _PropertyInfos)
            {
                /// получаем значение свойства или ометчаем, что оно null
                /// ?? - оператор слияния с null
                /// если левая часть info.GetValue(this, null) окажется null
                /// то в результат пойдет то, что справа от ??
                /// в нашем случае строка "(null)"
                /// если этого не сделать, то будет выдано исключение, а оно испортит выполнение программы
                /// 
                var value = info.GetValue(this, null) ?? "(null)";
                /// добавлем строку с парой имя свойства - его значение
                sb.AppendLine(info.Name + ": " + value.ToString());
            }

            /// выводим созданный текст в виде строки
            return sb.ToString();
        }
    }
}