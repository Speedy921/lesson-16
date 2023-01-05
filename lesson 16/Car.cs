using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_16
{

    //простой базовый класс
    class Car
    {
        public readonly int MaxSpeed;
        private int _currSpeed;
        public Car(int max)
        {
            MaxSpeed = max;
        }

        public Car()
        {
            MaxSpeed = 55;
        }

        public int Speed
        {
            get { return _currSpeed; }
            set
            {
                _currSpeed = value;
                if (_currSpeed > MaxSpeed)
                {
                    _currSpeed = MaxSpeed;
                }
            }
        }
    }
}
