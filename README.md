# Описание программы


+ Программа  состоит из двух методов - **`Main`** и **`GetShortStrings`**. В методе **`Main`** пользователю предлагается ввести элементы массива через запятую. Затем введенная строка разделяется на элементы массива с помощью метода **`Split`**, и эти элементы сохраняются в переменной **`array`**.

+ Далее вызывается метод **`GetShortStrings`**, который принимает массив `array` и возвращает новый массив, содержащий только те элементы, длина которых меньше или равна 3 символам. Вначале метод подсчитывает количество таких элементов с помощью переменной **`count`**. Затем создается новый массив **`resultArray`** размером **`count`**. Далее происходит перебор элементов исходного массива. Если длина элемента меньше или равна 3, он добавляется в новый массив.

+ В конце метод **`GetShortStrings`** возвращает новый массив **`resultArray`**.

+ В методе **`Main`** выводится на экран новый массив, используя цикл ***foreach***.
