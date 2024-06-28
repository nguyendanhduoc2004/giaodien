/*public class Class1
{
    public void DoiChoThamTri (int a, int b)
    {
        int tg = a;
        a = b;
        b = tg;
    }
    public void DoiChoThamChieu(ref int a, ref int b)
    {
        int tg = a;
        a = b;
        b = tg;
    }
}*/

/*Console.WriteLine("{0} + {1} = {2}", 5, 7, 12);

string str = "";
Console.WriteLine("Nhap vao mot chuoi");
str = Console.ReadLine();
Console.WriteLine("str=" + str);*/

/*int x;
Console.Write("moi nhap vao so thu nhat: x=");
x = int.Parse(Console.ReadLine());

int y;
Console.Write("moi nhap vao so thu hai: y=");
y = int.Parse(Console.ReadLine());

int z = x + y;

Console.WriteLine("Tong hai so la: x+y="+z);*/

/*int[] cia = new int[] { 1, 2, 3, 4, 5 };
string[] names = { "phong", "hoa", "lac", "long" };
Console.WriteLine(names.Length);

int[,] A =
{
    {3, 4, 2, 1, 4},
    {1, 5, 1, 2, 5},
    {1, 5, 2, 6, 7}
};

//in ra mang A
for (int i = 0; i < A.GetLength; i++)
{
    Console.Write("\t{");
    for (int j = 0; j < A.GetLength(1); j++)
    {
        Console.WriteLine(A[i, j]);
        if(j != A.GetLength(1)-1)
        {
            Console.Write([",");
        }
    }
    Console.WriteLine("},");
    if (i != A.GetLength(0) - 1)
    {

    }
}*/

String[][] companies = new string[3][];

companies[0] = new string[] { "Intel", "AMD", "Atom"};
companies[1] = new string[] { "IBM", "Microef", "Sun", "FAce" };
companies[2] = new string[] { "Hp", "Dell", "Asus", "Samsung", "Lexmrk" };

//duyet mang
for (int i = 0; i < companies.Length; i++)
{
    Console.WriteLine("Nhom cong ty {0}", i + 1);
    for (int j = 0; j < companies[i].GetLength(0); j++)
    {
        Console.Write(companies[i][j] + ",");
    }
    Console.WriteLine();
}