// Программа на вход число, а на выходе передает количество цифр в этом числе
/*
int NumofDigits(int num)                          //тип и название метода
{
    int count=0;       //переменная, которая собирает результат, желательно создавать заранее
                       // пока наше число не равно нулю
    if(num==0) count=1; //если число равно 0, то к-во цифр 1
    while (num!=0)    
    {
       count++;       //мы будем добавлять +1 число  
       num/=10; //num=num/10 //и делить его на 10, пока не останется 0 чисел 
    }
    return count;
}

Console.Write("Input a number:   ");            //запрос у пользователь определенного
int number=Convert.ToInt32(Console.ReadLine());   // числа

int result=NumofDigits(number);               //делаем расчет, т.е указываем, что есть result метода
Console.WriteLine($"number of digits in {number} is {result}");
*/

// Программа генерирующая случайные элементы массива
/*
int[] CreateRandomArray (int size, int minValue, int maxValue)
//где int[] это тип метода, который возвращается, далее название метода, далее
//в скобках это пременная метода, где min и max определяют диапозон
{
    int[] array = new int[size];  //new это сколько памяти будет выделенно под переменную

    for(int i = 0; i<size; i++)     //i-индекс, в массиве начинается с 0
    
    array[i] = new Random().Next(minValue, maxValue+1);
     //при этом чтобы последнее число диапозона массива вошло в диапозон делаем к max +1
    
    return array;  //возврат массива происходит без каких либо скобок и др. знаков
}

void ShowArray(int[] array)
{
    for(int i=0; i<array.Length; i++) //где length указывает кол-во чисел массива
    {
        Console.WriteLine($"array[{i+1}] is {array[i]}");
    }
}

Console.Write("Input a number of elements:  ");
int size=Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value:  ");
int min=Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible value:  ");
int max=Convert.ToInt32(Console.ReadLine());

int[] myArray= CreateRandomArray(size, min, max);
ShowArray(myArray);
*/