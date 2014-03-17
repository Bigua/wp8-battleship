using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship.Codes
{
    class Board
    {
        int[,] grid = { { 0,0,0,0,0,0,0,0,0,0}, 
                        { 0,0,0,0,0,0,0,0,0,0}, 
                        { 0,0,0,0,0,0,0,0,0,0}, 
                        { 0,0,0,0,0,0,0,0,0,0}, 
                        { 0,0,0,0,0,0,0,0,0,0}, 
                        { 0,0,0,0,0,0,0,0,0,0}, 
                        { 0,0,0,0,0,0,0,0,0,0}, 
                        { 0,0,0,0,0,0,0,0,0,0}, 
                        { 0,0,0,0,0,0,0,0,0,0}, 
                        { 0,0,0,0,0,0,0,0,0,0}, 
                      };
        Random rnd = new Random();

        public Board()
        {
            this.print();
        }

        public void populate(List<Boat> boats)
        {
            foreach (Boat vessel in boats)
            {
                int x = rnd.Next(0, 10);
                int y = rnd.Next(0, 10);
                while (this.testColision(vessel, x, y))
                {
                    x = rnd.Next(0, 10);
                    y = rnd.Next(0, 10);
                }
                this.insert(vessel, x, y);
            }
        }

        public void insert(Boat vessel, int x, int y)
        {
            this.getPoints(vessel, x, y);
        }

        public Boolean testColision(Boat vessel, int x, int y)
        {
            Boolean colision = this.testPosition(x, y);
            this.getPoints(vessel, x, y);

            return colision;
        }

        private List<int[]> getPoints(Boat vessel, int x, int y)
        {
            List<int[]> lista = new List<int[]>();
            if ((int)vessel.type == 1)
            {
                lista.Add(new int[] { x, y });

            }
            else if ((int)vessel.type == 2)
            {
                lista.Add(new int[] { x, y });
                if (vessel.orientation == 2)
                {
                    lista.Add(new int[] { x, y + 1 });
                }
                else
                {
                    lista.Add(new int[] { x + 1, y });
                }
            }
            else if ((int)vessel.type == 3)
            {
                lista.Add(new int[] { x, y });
                if (vessel.orientation == 2)
                {
                    lista.Add(new int[] { x, y + 1 });
                    lista.Add(new int[] { x, y + 2 });
                }
                else
                {
                    lista.Add(new int[] { x + 1, y });
                    lista.Add(new int[] { x + 2, y });
                }

            }
            else if ((int)vessel.type == 4)
            {
                lista.Add(new int[] { x, y });
                if (vessel.orientation == 2)
                {
                    lista.Add(new int[] { x, y + 1 });
                    lista.Add(new int[] { x, y + 2 });
                    lista.Add(new int[] { x, y + 3 });
                }
                else
                {
                    lista.Add(new int[] { x + 1, y });
                    lista.Add(new int[] { x + 2, y });
                    lista.Add(new int[] { x + 3, y });
                }
            }
            else if ((int)vessel.type == 5)
            {
                lista.Add(new int[] { x, y });
                if (vessel.orientation == 2)
                {
                    lista.Add(new int[] { x, y - 1 });
                    lista.Add(new int[] { x, y + 1 });
                    lista.Add(new int[] { x - 1, y });
                    lista.Add(new int[] { x - 2, y });
                }
                else
                {
                    lista.Add(new int[] { x + 1, y });
                    lista.Add(new int[] { x - 1, y });
                    lista.Add(new int[] { x, y + 1 });
                    lista.Add(new int[] { x, y + 2 });
                }
            }
            return lista;
        }

        public Boolean testPosition(int x, int y)
        {
            Boolean notEmpty = false;
            if ((grid[x, y]) != 0)
            {
                notEmpty = true;
            }
            return notEmpty;
        }

        public void print()
        {
            for (int i = 0; i < 10; i++)
            {
                string line = "";
                for (int j = 0; j < 10; j++)
                {
                    line = line + Convert.ToString(grid[i, j]);
                }
                Debug.WriteLine(line);
            }
        }
    }
}
