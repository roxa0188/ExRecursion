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
        }

        public void Solve()
        {
            Move(Tower1, Tower2);
        }

        private bool Move(Stack<int> TowerA, Stack<int> TowerB)
        {
            int diskA;
            int diskB;

            try
            {
                diskA = TowerA.Peek();
            } catch
            {
                diskA = 0;
            }

            try
            {
                diskB = TowerB.Peek();
            }catch
            {
                diskB = 0;
            }


            if (diskA < diskB || diskB == 0)
            {
                TowerB.Push(TowerA.Pop());
                return true;
            }
            else return false;
        }



    }
}
