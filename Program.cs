using System;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace ConsoleCallForm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Going to start the WinForm");
            Form1 myForm = new Form1();            
            Application.Run(myForm);
        }
    }
}
