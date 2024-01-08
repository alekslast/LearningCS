int[] temperatures = 
{
    10, 12, 13, 14, 15, 11, 13, 15, 16, 17,
    18, 16, 15, 16, 17, 14,  9,  8, 10, 11,
    12, 14, 15, 15, 16, 15, 13, 12, 12, 11
};

// Span<int> temperaturesSpan = new Span<int>(temperatures);
Span<int> temperaturesSpan = temperatures;

Span<int> firstDecade = temperaturesSpan.Slice(0, 10);  // Starting element's index and the number of elements to be extracted
Span<int> lastDecade = temperaturesSpan.Slice(20, 10);

// Во всех трех случаях мы работаем с тем же массивом temperatures.
// Мы даже можем в одном Span изменить данные, и данные изменятся в другом.


// Ограничения Span:
// Как структура, определенная с модификатором ref, Span имеет ряд ограничений: она не может быть присвоена переменной типа 
// Object, dynamic или переменной типа интерфейса. Она не может быть полем в объекте ссылочного типа (а только внутри ref-структур).
// Она не может использоваться в пределах операций await или yield.