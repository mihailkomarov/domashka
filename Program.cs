// See https://aka.ms/new-console-template for more information

using System.Xml.Linq;

class Person
{
    public static void Main(string[] args) {
        // zd1();
        // zd2();
        zd3();


    }
    static public void zd2()
    {
        Console.Write("Введите число: ");
        string name = Console.ReadLine();
        Console.WriteLine($"{name.Length}");
        if (name.Length%2==0) {
            int leng = name.Length;
            int leng1 = leng-1;
            for (int i = 0; i < leng / 2; i++)
            {
                if (name[i] == name[leng1 - i])
                {
                  
                    Console.WriteLine($"{false}");
                }
                else { return; }
               

            }
            Console.WriteLine($"{true}");

        }
        else
        {
            Console.WriteLine($"{false}");
        }
        
    }
    static public void zd1()
    {
      
        Console.Write("Введите символ: ");
        string? name = Console.ReadLine();
        Console.WriteLine($"{name}");
        Console.Write("Введите размер: ");
        int S = Convert.ToInt32(Console.ReadLine());
        string kb ="";
        for (int i = 0; i < S; i++)
        {
            kb += name;
        }
        for (int i = 0; i < S; i++)
        {
            Console.WriteLine($"{kb}");
        }
    }
    static public int[] zd3()
    {
        
        Console.Write("Введите исходный массив: ");
        var isxod = Console.ReadLine().Split(" ");

        Console.Write("Введите фильтрующий массив: ");
        var filtr = Console.ReadLine().Split(" ");
        int[] res =new int[isxod.Count()];
        for (int i = 0;i<isxod.Length;i++)
        {
            if (!filtr.Contains(isxod[i])) {
                int num;
                if (int.TryParse(isxod[i], out num))
                {
                    res[i] = num;
                    Console.Write($"{num} ");
                }
                else 
                {
                    Console.WriteLine("Data not correct");
                }
            }
        }
        return res; 
    }

}
class web
{
    private string name;
    private string path;
    private string about;
    private string ip;

    public string Name
    {
        get
        {
            return name;    
        }
    }
    public string Path
    {
        get
        {
            return path;
        }
    }
    public string About
    {
        get
        {
            return about;
        }
    }
    public string Ip
    {
        get
        {
            return ip;
        }
    }
    public void vvod()
    {
        Console.Write("Введите имя: ");
        name= Console.ReadLine();
        Console.Write("Введите путь: ");
        path= Console.ReadLine();
        Console.Write("Введите описание: ");
        about= Console.ReadLine();
        Console.Write("Введите ip: ");
        ip = Console.ReadLine();
    }
    public void vivod()
    {
        Console.Write(name);
        Console.Write(path);
        Console.Write(about);
        Console.Write(ip);
    }
}
class journal
{
    private string name;
    private string age;
    private string about;
    private string telephon;
    private string email;

    public string Name
    {
        get
        {
            return name;
        }
    }
    public string Age
    {
        get
        {
            return age;
        }
    }
    public string About
    {
        get
        {
            return about;
        }
    }
    public string Telephon
    {
        get
        {
            return telephon;
        }
    }
    public string Email
    {
        get
        {
            return email;
        }
    }
    public void vvod()
    {
        Console.Write("Введите имя: ");
        name = Console.ReadLine();
        Console.Write("Введите год основания: ");
        age = Console.ReadLine();
        Console.Write("Введите описание: ");
        about = Console.ReadLine();
        Console.Write("Введите телефон: ");
        telephon = Console.ReadLine();
        Console.Write("Введите e-mail: ");
        email = Console.ReadLine();
    }
    public void vivod()
    {
        Console.Write(name);
        Console.Write(age);
        Console.Write(telephon);
        Console.Write(email);
        Console.Write(about);
    }
}
class magazin
{
    private string name;
    private string address;
    private string about;
    private string telephon;
    private string email;

    public string Name
    {
        get
        {
            return name;
        }
    }
    public string Address
    {
        get
        {
            return address;
        }
    }
    public string About
    {
        get
        {
            return about;
        }
    }
    public string Telephon
    {
        get
        {
            return telephon;
        }
    }
    public string Email
    {
        get
        {
            return email;
        }
    }
    public void vvod()
    {
        Console.Write("Введите имя: ");
        name = Console.ReadLine();
        Console.Write("Введите год основания: ");
        address = Console.ReadLine();
        Console.Write("Введите описание: ");
        about = Console.ReadLine();
        Console.Write("Введите телефон: ");
        telephon = Console.ReadLine();
        Console.Write("Введите e-mail: ");
        email = Console.ReadLine();
    }
    public void vivod()
    {
        Console.Write(name);
        Console.Write(address);
        Console.Write(telephon);
        Console.Write(email);
        Console.Write(about);
    }
}

