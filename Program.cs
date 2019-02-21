using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Point
    {
        int x;
        int y;
        char sym;

        public void SetX(int x)
        {
            if (x>=0)
                this.x = x;
            else
                this.x = 0;

        }
    public void SetY(int y)
        {
            if (y >= 0)
                this.y = y;
            else
                this.y = 0;
        }
        public void SetSym(char symbol)
        {
            sym = symbol;
        }
        public void Draw ()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

    class Program
        {
            static void Main(string[] args)
            {
                Point line = new Point();
                line.SetX(1);
                line.SetY(1);
                line.SetSym('-');
                line.Draw();

                line.SetX(2);
                line.Draw();

                line.SetX(3);
                line.Draw();

                line.SetX(4);
                line.Draw();

                line.SetX(2);
                line.SetY(2);
                line.SetSym('#');
                line.Draw();

                line.SetX(3);
                line.SetY(2);
                line.SetSym('#');
                line.Draw();

                line.SetX(4);
                line.SetY(2);
                line.SetSym('-');
                line.Draw();

                line.SetX(5);
                line.SetY(2);
                line.SetSym('-');
                line.Draw();

                line.SetX(1);
                line.SetY(3);
                line.SetSym('-');
                line.Draw();

                line.SetX(2);
                line.Draw();

                line.SetX(3);
                line.Draw();

                line.SetX(4);
                line.Draw();

                Console.ReadLine();
            }
        }
    }
}
