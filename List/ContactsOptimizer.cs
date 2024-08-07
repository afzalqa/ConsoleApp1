using System;
using System.Collections.Generic;

public class ContactsOptimizer
{
    // Функция OptimizeContacts принимает список строковых контактов и возвращает словарь
    public static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
    {
        // Создаем пустой словарь, где ключ - это строка (первые две буквы имени),
        // а значение - это список строк (email адресов)
        var dictionary = new Dictionary<string, List<string>>();

        // Проходимся по каждому контакту в списке
        foreach (var contact in contacts)
        {
            // Разделяем запись на имя и email с помощью разделителя ':'
            var parts = contact.Split(':');
            if (parts.Length < 2) continue; // Пропускаем некорректные записи, у которых нет двух частей

            // Убираем лишние пробелы в имени и email
            var name = parts[0].Trim();
            var email = parts[1].Trim();

            // Проверяем, что имя имеет хотя бы две буквы
            if (name.Length < 2) continue;

            // Получаем ключ из первых двух букв имени
            var key = name.Substring(0, 2);

            // Проверяем, есть ли уже такой ключ в словаре
            if (!dictionary.ContainsKey(key))
            {
                // Если ключа нет, создаем новый список для хранения email адресов
                dictionary[key] = new List<string>();
            }

            // Добавляем email в список значений для соответствующего ключа
            dictionary[key].Add(email);
        }

        // Возвращаем заполненный словарь
        return dictionary;
    }

    // Основная функция для запуска программы и демонстрации работы OptimizeContacts
    public static void Contacts_Optimizer()
    {
        // Создаем пример списка контактов
        List<string> contacts = new List<string>
        {
            "Sasha:sasha1995@sasha.ru",
            "Alex:alex99@mail.ru",
            "Shurik:shurik2020@google.com",
            "Al:al@example.com",
            "Sveta:sveta@gmail.com",
            "V:singleletter@example.com"
        };

        // Вызываем функцию OptimizeContacts и сохраняем результат
        var optimizedContacts = OptimizeContacts(contacts);

        // Выводим содержимое словаря на экран для проверки результата
        foreach (var key in optimizedContacts.Keys)
        {
            Console.WriteLine($"{key}: {string.Join(", ", optimizedContacts[key])}");
        }
    }
}
