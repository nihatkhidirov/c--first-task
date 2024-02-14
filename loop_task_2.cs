#region Task_1
//1.Verilmiş n və m (n<m) ədədləri arasında neçə tək ədəd olduğunu tapın.
//int n = 100;
//int m = 200;
//int count = 0;
//for (int i = n; i < m; i++)
//{
//    if (i % 2 == 1)
//    {
//        count++;
//    }
//}
//Console.WriteLine("Tek Ededlerin sayi:" + (count));
#endregion
#region Task_2
//2.Verilmiş n tam ədədinin sadə və ya mürəkkəb ədəd olduğunu tapın.

//int eded = 100;
//int count = 0;
//for(int i = 1;i <= eded; i++)
//{
//    if (eded % i == 0)
//    {
//        count++;


//    }

//}
//if (count > 2)
//{
//    Console.WriteLine("Ededin " + count + " boleni oldugu ucun murekkebdir");
//}
//else
//{
//    Console.WriteLine("Eded Sadedir");
//}
#endregion
#region Task_3
//3.a ədədi b ədədinə tam bölünürsə , ekrana çap edilsin : tam bölünür əks halda bölünmür.

//int a = 200;
//int b = 200;
//if (a % b == 0)
//{
//    Console.WriteLine("Tam Bolunur");
//}
//else
//{
//    Console.WriteLine("Tam Bolunmur");
//}
#endregion
#region Task_4
//using System.Diagnostics.CodeAnalysis;

//int product_price1 = 160;
//int product_price2 = 150;
//int product_price3 = 80;
//if (product_price1 > product_price2)
//{
//    if (product_price1 > product_price3)
//    {
//        if (product_price2 > product_price3)
//        {
//            Console.WriteLine("Cem:" + (product_price1 + product_price2));
//        }
//        else
//        {
//            Console.WriteLine("Cem:" + (product_price1 + product_price3));
//        }
//    }
//}
//if (product_price2 > product_price3)
//{
//    if (product_price2 > product_price1)
//    {
//        if (product_price3 > product_price1)
//        {
//            Console.WriteLine("Cem:" + (product_price2 + product_price3));
//        }
//        else
//        {
//            Console.WriteLine("Cem:" + (product_price1 + product_price2));
//        }
//    }
//}
//if (product_price3 > product_price2)
//{
//    if (product_price3 > product_price1)
//    {
//        if (product_price2 > product_price1)
//        {
//            Console.WriteLine("Cem:" + (product_price3 + product_price2));
//        }
//        else
//        {
//            Console.WriteLine("Cem:" + (product_price3 + product_price1));
//        }
//    }
//}
#endregion
#region Task_5
//Verilmis M ededinden N ededinedek olan ededlerin cemini tapan alqoritm yaz
//int m = 1;
//int n = 5;
//int sum = 0;
//for (int i = m; i <= n; i++)
//{
//    sum=sum+i;
//}
//Console.WriteLine(sum);
#endregion
#region Task_6
//1-den M-dek ededler icerisinde 15-e bolunen ededlerin sayini tapan algorithm

//int m = 16;
//int count = 0;
//for (int i = 1; i < m; i++)
//{
//    if (i % 15 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine("15-e bolunenlerin sayi: "+ (count));
#endregion
#region Task_7
// 1-den M-dek ededler icerisinde 21-e bolunen ededlerin ededi ortasin tap
//int m = 200;
//double count = 0;
//double sum = 0;
//for (int i = 1; i < m; i++)
//{
//    if (i % 21 == 0)
//    {
//        count++;
//        sum = sum + i;
//    }
//}
//double edediorta = sum / count;
//Console.WriteLine("21-e bolunen ededlerin ededi ortasi: "+(edediorta));
#endregion
#region Task_8
//Verilmis N ededinin reqemlerinin cemini tapan algorithm ( eded 3 ve ya daha cox reqemli ola biler)
int n = 102229; // 1 0 2 2 2 
int qaliq = n%10;
;
for (int i = 1; i <100 ; i++)
{
    n = n / 10; //1022 102 10 1
    qaliq =qaliq+( n % 10); //2 
    
    if ((n / 10) < 0)
    {
        break;
        
    }

}
Console.WriteLine("reqemlerin cemi: " + (qaliq));

#endregion