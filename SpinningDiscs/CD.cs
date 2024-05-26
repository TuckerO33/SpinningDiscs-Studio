using System;

namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        public CD(string name, int capacity, string contents, string discType) : base(name, capacity, contents, discType)
        {
        }

        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Spin(int speed)
        {
            Console.WriteLine("we have a spinning disc with speed of " + speed);
        }

        public void Write(string data)
        {
            throw new NotImplementedException();
        }
    }
}

