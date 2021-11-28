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
        ///СНАЧАЛА СЮДА
        /// 
        /// Добавьте к менеджеру следующие свойства
        /// string User
        /// string BaseFolder
        /// string MainTheme
        ///
        /// для этого:
        /// 1 Наберите в новой строке слово prop
        /// 2 Нажмите клавишу Tab
        /// 3 в шаблоне свойства (он имеет вид public TYPE Type { get; set; })
        /// обратите внимание, что вы можете переходить между рамками клавишей Enter или Tab
        /// 4 заведите тип string вместо TYPE
        /// 5 нажмите Enter для перехода к следующей рамке
        /// 6 введите User и нажмите Enter еще раз
        /// 7 за фигурной скобкой добавьте инициализатор = String.Empty;
        /// итог: public string User { get; set; } = String.Empty;
        /// 

        /// это публичное свойство с именем Id, является целым числом
        /// значение по умолчанию - 0
        /// методы доступа - простые get и set
        public int Id { get; set; } = 0;

        /// Добавьте здесь свойства
        ///
        //prop // в качестве примера, раскомментируйте prop и нажмите за ним клавишу Tab
        

        /// Откройте файл RefProject и доработайте класс проекта
        /// ПОТОМ ВЕРНИТЕСЬ СЮДА
        ///
        /// Добавьте список проектов <Property>Projects</Property> строкой ниже
    }
}
