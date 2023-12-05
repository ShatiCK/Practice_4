using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    public class Array
    {
        private int[] array;
        public int Length => array.Length;

        // Конструктор
        public void IntegerArray(int size)
        {
            if (size < 0)
            {
                throw new ArgumentException("Размер должен быть неотрицательным.");
            }
            array = new int[size];
        }

        // Индексатор
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= array.Length)
                {
                    throw new IndexOutOfRangeException("Индекс вне диапазона.");
                }
                return array[index];
            }
            set
            {
                if (index < 0 || index >= array.Length)
                {
                    throw new IndexOutOfRangeException("Индекс вне диапазона.");
                }
                array[index] = value;
            }
        }
    }
}

