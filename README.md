Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Алгоритм работы программы следующий:
1) Метод ReadData() считывает пользовательский ввод.Сначала пользователь указывает количество строк в массиве.
Затем, в цикле for пользовательские строки собираются в промежуточный массив строк strArray,который служит выводом этого метода и будет передаваться дальше по программе.
2) Метод TransformData принимает на вход массив строк strArray,полученный в п.1.Далее,в цикле for определяется,какая строка в массиве строк strArray имеет длину меньшую или равную 3.Такая строка записывается в результирующую строку concatenated с пробелом на конце.Далее результирующая строка concatenated разбивается на массив строк по разделителю " " (символ пробела)
3) Метод PrintResult выводит полученный в п.2 итоговый массив строк result на экран