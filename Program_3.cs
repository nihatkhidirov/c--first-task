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
