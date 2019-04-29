using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public struct test
{
    public int X;
    
    public test(int x)
    {
        this.X = x;
    }
}

class program
{
    static void Main(string[] args)
    {
        //FileStream fs = new FileStream("test.txt", FileMode.Append, FileAccess.Write);
        //StreamWriter sw = new StreamWriter(fs);

        //sw.WriteLine("Hello world");
        //sw.Close();
        //fs.Close();

        //fs = new FileStream("test.txt", FileMode.Open, FileAccess.Read);
        //StreamReader sr = new StreamReader(fs);
        //string buffer = sr.ReadLine();
        //Console.WriteLine(buffer);

        FileStream fs = new FileStream("test.exe", FileMode.Open, FileAccess.Read);
        StreamReader sr = new StreamReader(fs);
        
     }
    
}
