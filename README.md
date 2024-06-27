using System;
using System.Drawing;
using System.IO;
using System.Text;
string path = Path.GetTempFileName();
FileInfo fi1 = new FileInfo(path);
string color = "Purple";
string name = "car1";
int fuel=100;
int capacity=100;
int consumption = 100;
string typ ="typ1";
string baza1 =name+" "+ color+" "+fuel + " " + capacity + " " + consumption+" "+";";
string text = baza1 + baza1;
string nocolor = "Purple";
string notyp = "typ2";
int pathhome = 1;
using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
{
    byte[] buffer = Encoding.Default.GetBytes(text);
    await fstream.WriteAsync(buffer, 0, buffer.Length);
    Console.WriteLine("Текст записан в файл");
}
using (FileStream fstream = File.OpenRead(path))
{
    byte[] buffer = new byte[fstream.Length];
    await fstream.ReadAsync(buffer, 0, buffer.Length);
    string textFromFile = Encoding.Default.GetString(buffer);
    int moment=0;
    string color1=null;
    string name1 = null;
    int fuel1 = 0;
    int capacity1 = 0;
    int consumption1=0;
    int fullfuel = 0;
    for (int i = 0; i < textFromFile.Length; i++) {
        if (textFromFile[i] == ';') {
            moment = 0;
            moment = 0;
            color1 = null;
            name1 = null;
            fuel1 = 0;
            capacity1 = 0;
            consumption1 = 0;
            if (color == nocolor||typ==notyp) {

                Console.WriteLine($"{name} will remain");
            }
            else
            {

                if (fuel >= consumption * pathhome)
                {
                    fullfuel += consumption * pathhome;
                    Console.WriteLine($"{name} go tohome");
                    Console.WriteLine(fullfuel);
                }
                else { 
                    Console.WriteLine($"{name}no go tohome");
                    fullfuel += fuel1;
                    Console.WriteLine(fullfuel);
                }
            }
        }

        else
        {
            if (textFromFile[i] == ' ') { moment++; }
            if (moment == 0) { name1 += textFromFile[i]; }
            if (moment == 1) { color1 += textFromFile[i]; }
            if (moment == 2) { fuel1 += textFromFile[i]; }
            if (moment == 3) { capacity1 += textFromFile[i]; }
            if (moment == 4) { consumption1 += textFromFile[i]; }
        }
    }
    Console.WriteLine($"Текст из файла: {textFromFile}");
}
