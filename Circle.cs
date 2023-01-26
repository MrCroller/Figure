using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Figure
{
    public sealed class Circle : IFigure
    {
        #region Properties
        public double Aria { get; private set; }
        public double Perimeter { get; private set; }

        #endregion


        #region Methods

        public Circle (double perimeter)
        {
            Perimeter = perimeter;
            Aria = Math.PI * Math.Pow(Perimeter, 2);
        }

        #endregion
    }
}
