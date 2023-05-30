// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string Back(int num)  //нашли перевернутое число
{
    if (num<0)
    {
        num=num*-1;
    }
    int i=0;
    int back=0;
    string sum=String.Empty;
    while (num>0)
    {
        back=num%10;
        num=num/10;
        i++;
        sum=sum+back;
     }
  return sum;
}


void Palindrome(int n)
{
    if (n<0)
    {
        n=n*-1;
    }
    string result=String.Empty;
    if ((n>9999 && n<100000) | (n>-100000 && n<-9999))
    {
    string palindrome=Back(n);
    result = palindrome == Convert.ToString(n)
                ? $"Число {n} является палиндромом {palindrome}" 
                : $"Число {n} не является палиндромом {palindrome}";
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine("Должно быть пятизначное число!!!!");
    }
    
}

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());


Palindrome(number);

