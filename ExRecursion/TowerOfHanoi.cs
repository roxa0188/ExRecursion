using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExRecursion
{
    public class TowerOfHanoi
    {
        Stack<int> Tower1 = new Stack<int>();
        Stack<int> Tower2 = new Stack<int>();
        Stack<int> Tower3 = new Stack<int>();

        public TowerOfHanoi(int disk)
        {
            for (int i = disk; i > 0; i--)
            {
                Tower1.Push(i);
            }
            Move(disk, Tower1, Tower2, Tower3);
        }

    

        private void Move(int disk, Stack<int> TowerA, Stack<int> TowerB, Stack<int> TowerC)
        {
           if(disk == 1)
            {
                TowerB.Push(TowerA.Pop());
                return;
            }

            Move(disk - 1, TowerA, TowerC, TowerB);
            TowerB.Push(TowerA.Pop());

            Move(disk - 1, TowerC, TowerB, TowerA);
        }



    }
}
