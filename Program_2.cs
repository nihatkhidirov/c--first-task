#region q1
//Verilmis 3 ededden 10 ve 100 araliginda yerlesenlerin cemini tapan algorithm.
//int num1 = 50;
//int num2 = 75;
//int num3 = 901;
//int mainnum = 0;
//if (num1 > 10 && num1 < 100)
//{
//    mainnum = mainnum + num1;
//}
//else
//{
//    mainnum = mainnum + 0;
//    Console.WriteLine("Eded 10 ve 100 araliginda deyil:" + (num1));

//}
//if (num2 > 10 && num2 < 100)
//{
//    mainnum = mainnum + num2;
//}
//else
//{
//    mainnum = mainnum + 0;
//    Console.WriteLine("Eded 10 ve 100 araliginda deyil:" + (num2));
//}

//if (num3 > 10 && num3 < 100)
//{
//    mainnum = mainnum + num3;
//}
//else
//{
//    mainnum = mainnum + 0;
//    Console.WriteLine("Eded 10 ve 100 araliginda deyil:" + (num3));
//}

//Console.WriteLine("Cem:" + (mainnum));

#endregion
#region q2
//Verilmis ayin ededine gore hansi fesil oldugunu tapan algorithm qurun (misal ucun algorithme 5 deyeri gonderildikde 5-ci ayin hansi fesil oldugunu qaytatsin)
//int EDED = 10;
//if(EDED==12|| EDED==1 || EDED == 2)
//{
//    Console.WriteLine("Fesil:Qis");
//}
//else if(EDED==3 || EDED==4 || EDED == 5)
//{
//    Console.WriteLine("Fesil:Yaz");
//}
//else if(EDED==6 || EDED==7 || EDED == 8)
//{
//    Console.WriteLine("Fesil:Yay");
//}
//else if(EDED==9 || EDED==10 || EDED == 11)
//{
//    Console.WriteLine("Fesil:Payiz");
//}
//else
//{
//    Console.WriteLine("Duzgun Eded Daxil edilmemisdir");
//}
#endregion
#region q3
//int num = 331;
//int num1 = num % 10; //1
//int num2 = num % 100 / 10; //3
//int num3 = num / 100;//2
//Console.WriteLine(num1 * num2 * num3);
#endregion
#region q4
int product_price1 = 160;
int product_price2 = 150;
int product_price3 = 80;
if (product_price1 > product_price2)
{
    if (product_price1 > product_price3)
    {
        if (product_price2 > product_price3)
        {
            Console.WriteLine("Cem:" + (product_price1 + product_price2));
        }
        else
        {
            Console.WriteLine("Cem:" + (product_price1 + product_price3));
        }
    }
}
if (product_price2 > product_price3)
{
    if (product_price2 > product_price1)
    {
        if (product_price3 > product_price1)
        {
            Console.WriteLine("Cem:" + (product_price2 + product_price3));
        }
        else
        {
            Console.WriteLine("Cem:" + (product_price1 + product_price2));
        }
    }
}
if (product_price3 > product_price2)
{
    if (product_price3 > product_price1)
    {
        if (product_price2 > product_price1)
        {
            Console.WriteLine("Cem:" + (product_price3 + product_price2));
        }
        else
        {
            Console.WriteLine("Cem:" + (product_price3 + product_price1));
        }
    }
}

#endregion


