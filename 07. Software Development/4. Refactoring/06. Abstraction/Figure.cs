using System;

namespace Abstraction
{
    abstract class IFigure 
    {

        /// <summary>
        /// Лице на фигура
        /// </summary>
        public abstract double Surface();

        /// <summary>
        /// Периметър на фигура
        /// </summary>
        public abstract double Perimeter();

        /// <summary>
        /// Печатаща функция
        /// </summary>
        public abstract void Print();

    }
}
