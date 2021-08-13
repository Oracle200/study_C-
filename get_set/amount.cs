using System;

namespace get_set
{
    class amount
    {
        private byte wheels = 5;

        public byte Wheels
        {
            get
            {
                System.Console.WriteLine("количетво колёс: " + this.wheels);
                return this.wheels;
            }
        }
    }
}