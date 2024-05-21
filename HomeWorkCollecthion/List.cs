using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCollecthion
{
    internal class List
    {
        int count = 0;
        public string[] _list { private get; set; } = new string[0];

        internal string list(int index)
        {
            return _list[index];
        }


        // Методы листа.
        internal void Add(string mean)
        {
            int index = count++;

            string[] new_list = new string[count];

            for (int i = 0; i < _list.Length; i++)
            {
                new_list[i] = _list[i];
            }
            _list = new_list;
            _list[0 + index] = mean;

        }


        internal void Insert(int index, string mean)
        {
            _list[index] = mean;
        }

        internal void Remove(string mean)
        {
            for (int i = 0; i < count; i++)
            {
                int lastPosithion = 0;
                if (_list[i] == mean && count != i)
                {
                    lastPosithion = i;
                    _list[i] = "";
                    while (lastPosithion != count - 1)
                    {
                        _list[lastPosithion] = _list[lastPosithion + 1];
                        lastPosithion++;
                    }
                    _list[count - 1] = "";
                }
                if (_list[i] == mean && count == i)
                {
                    _list[i] = "";
                }
            }
            count--;
            string[] new_list = new string[count];
            for (int i = 0; i < _list.Length - 1; i++)
            {
                new_list[i] = _list[i];
            }
            _list = new_list;

        }

        internal void LenghtMassive()
        {
            Console.WriteLine();
            Console.WriteLine(_list.Length);
        }


        public void IEnumerable()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(_list[i]);
            }
        }
    }
}
