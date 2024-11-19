using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METODuser
{
    public class User
    {
        // Свойства
        public string Имя { get; set; }
        public int Возраст { get; set; }
        public DateTime ДатаРегистрации { get; private set; } // Только для чтения

        // Конструктор
        public User(string имя, int возраст)
        {
            Имя = имя;
            Возраст = возраст;
            ДатаРегистрации = DateTime.Now; // Устанавливается автоматически при создании пользователя
        }

        // Метод для отображения информации о пользователе
        public void ПоказатьПрофиль()
        {
            Console.WriteLine($"Имя: {Имя}\nВозраст: {Возраст}\nДата регистрации: {ДатаРегистрации.ToShortDateString()}");
        }
    }
}
