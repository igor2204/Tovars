# Информационная система «Приложение для составления покупок»
Данное программное обеспечение разработано для добавления, удаления товара и удаления всех товаров.

## Содержание
- [Технологии](#технологии)
- [Использование](#использование)
- [Разработка](#разработка)
- [Тестирование](#тестирование)
- [Contributing](#contributing)
- [FAQ](#faq)
- [To do](#to-do)
- [Команда проекта](#команда-проекта)
- [Источники](#источники)

## Технологии
- [VisualStudio 2022](https://visualstudio.microsoft.com/ru/)
- [C#](https://learn.microsoft.com/ru-ru/dotnet/csharp/tour-of-csharp/)
- [.NET 6.0](https://learn.microsoft.com/ru-ru/dotnet/welcome)

## Использование
Для работы с приложением необходимо следующее программное обеспечение:

Microsoft Visual Studio Community 2022

Перед началом работы с Информационной средой «Приложение для составления покупок» на рабочем месте пользователя необходимо выполнить следующие действия:
1. Открыть программу Microsoft Visual Studio Community 2022.
2. Найти программу «ShoppingList».
3. Открыть ее.
4. Нажать на кнопку запуска

### Задача: «Добавление, удаление выбранного товара и удаление всех товаров»

Ввести данные и нажать на кнопку «Добавить»
   
![image](https://github.com/igor2204/Tovars/assets/117898131/67f98c56-e404-442f-af72-33d038cd45c6)

Выбрать нужную строку в таблице и нажать кнопку «Удалить товар»

![image](https://github.com/igor2204/Tovars/assets/117898131/5b4d7739-afb2-4aa2-b72b-d5bd1346cc52)

Для удаления всех товаров следует нажать на кнопку «Удалить все»

![image](https://github.com/igor2204/Tovars/assets/117898131/9682e2c8-e675-4499-9f4b-8c62ef5967fd)

### Задача: «Открытие файла и сохранение файла»

Нажать на кнопку «Открыть файл»

![image](https://github.com/igor2204/Tovars/assets/117898131/ffef5634-2cbe-43f4-b563-de5ea7873b7f)

Выбрать нужный текстовый файл и нажать кнопку «Открыть»

![image](https://github.com/igor2204/Tovars/assets/117898131/f3f29c7e-c128-41a9-b604-e3e542292c15)

Набрать данные и нажать на кнопку «Сохранить файл»

![image](https://github.com/igor2204/Tovars/assets/117898131/545c85a0-503e-47c0-9248-b51dc180f480)

Выбрать место для сохранения, назвать файл и нажать на кнопку «Сохранить»

![image](https://github.com/igor2204/Tovars/assets/117898131/5436e1c2-0be2-4087-ab85-dcb2b6a7781d)

## Разработка

### Требования
Для установки и запуска проекта, необходим [VisualStudio 2022](https://visualstudio.microsoft.com/ru/)

## Тестирование
В проекте использовались следующие виды тестирования: Интеграционное

Итоги тестирования:

### Интеграционное тестирование

![image](https://github.com/igor2204/Tovars/assets/117898131/7778a36e-33a4-4077-b074-bca0beff7137)

### Тестовые пути:

Т1: 1 – 3 – 4 – 7 – 8

T2: 1 – 3 – 5 – 7 – 8

Т3: 1 – 3 – 6 – 7 – 8

T4: 1 – 2 – 3 – 4 – 7 – 8

T5: 1 – 2 – 3 – 5 – 7 – 8

T6: 1 – 2 – 3 – 6 – 7 – 8

T7: 1 – 8

### Пути: 

Путь 1: Запуск приложения, набор данных, добавление данных товара, сохранение файла, закрытие приложения

Путь 2: Запуск приложения, набор данных, удаление данных одного товара, сохранение файла, закрытие приложения

Путь 3: Запуск приложения, набор данных, удаление данных всех товаров, сохранение файла, закрытие приложения

Путь 4: Запуск приложения, открытие файла, набор данных, добавление данных товара, сохранение файла, закрытие приложения

Путь 5: Запуск приложения, открытие файла, набор данных, удаление данных одного товара, сохранение файла, закрытие приложения

Путь 6: Запуск приложения, открытие файла, набор данных, удаление данных всех товаров, сохранение файла, закрытие приложения

Путь 7: Запуск приложения,  закрытие приложения

### Тест-кейсы

Таблица 1. Тест-кейс добавления данных товара

![image](https://github.com/igor2204/Tovars/assets/117898131/9fda110f-1b97-4d56-ab01-21627062c105)

Таблица 2. Тест-кейс удаления данных одного товара

![image](https://github.com/igor2204/Tovars/assets/117898131/79060a96-2e0b-4fff-b4d9-82fcbce5f072)

Таблица 3. Тест-кейс удаления данных всех товаров

![image](https://github.com/igor2204/Tovars/assets/117898131/6b88b141-5d5f-409b-a2b1-ed884c8da4d1)

Таблица 4. Тест-кейс открытия файла

![image](https://github.com/igor2204/Tovars/assets/117898131/ecaeeec0-2fa0-4bbc-8b1b-f96e496d7b16)

Таблица 5. Тест-кейс сохранения файла

![image](https://github.com/igor2204/Tovars/assets/117898131/ccc1c52b-e1a9-46fb-bc31-305930c06e66)

## Contributing
Сообщения о багах и ошибках присылать на почту: igorcomkalov@gmail.com

## FAQ 
### Где можно установить Visual Studio?
- [На официальном сайте Microsoft](https://visualstudio.microsoft.com/ru/)
### Как найти кнопку "Сохранить в файл"?
- Она находится в левой нижней части главного окна.

## To do

- [x] Добавить товар: пользователь может добавлять данные в таблицу.
- [x] Удалить товар: пользователь может удалить 1 товар из списка.
- [x] Удалить все: пользователь может удалить все товары из списка.
- [x] Открыть файл: пользователи должны иметь возможность открывать файл с поддержкой различных форматов, таких как .txt, .pdf или .docx.
- [x] Сохранить файл: приложение должно предоставлять функциональность сохранения файлов.
## Команда проекта
- [Цомкалов Игорь](https://vk.com/id194250284) — Главный разработчик, программист, тестировщик, дизайнер

## Источники
https://metanit.com/sharp/

https://metanit.com/sharp/windowsforms/




