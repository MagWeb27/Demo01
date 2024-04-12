using MyLibrary;

namespace MyConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MessageWritter MyWritter = new MessageWritter();
            MyWritter.Write("Hello, Writter!");

            FiggleWriter FWriter = new FiggleWriter();
            FWriter.Write("Hello, Figgle!!!");
        }
    }
}
