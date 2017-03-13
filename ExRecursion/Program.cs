using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        private void Run()
        {
            TowerOfHanoi TOH = new TowerOfHanoi(4);
            TOH.Solve();
        }

    }
}
