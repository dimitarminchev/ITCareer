using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBufferApp
{
    // Буферирана конзола
    public class BufferedConsole : IDisposable
    {
        // Буфер
        private char[] buffer;
        private int pos;

        // Конструктор
        public BufferedConsole()
        {
            buffer = new char[50];
            pos = 0;
        }

        // Добавяне към буфера
        public void Write(string line)
        {
            bool BufferIsFull = false;

            if (pos + line.Length >= 50)
            {
                line = line.Substring(0, 50 - pos);
                BufferIsFull = true;
            }
 
            var source = line.ToArray<char>();
            Array.Copy(source, 0, buffer, pos, line.Length);
            pos += line.Length;

            if (BufferIsFull) this.Dispose();
        }

        // Освобождаване на паметта
        public void Dispose()
        {
            Console.WriteLine("> [{0}]", new String(buffer));
            buffer = new char[50];
            pos = 0;
        }
    }
}
