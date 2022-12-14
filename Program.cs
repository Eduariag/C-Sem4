// Программа на вход число, а на выходе передает количество цифр в этом числе

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
