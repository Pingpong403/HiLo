using System;

namespace HiLo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static int Main(string[] args)
        {
            Director georgeLucas = new Director();
            georgeLucas.StartGame();
            return 0;
        }
    }
}