using System;

namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        public DVD(string name, int capacity, string contents, string discType) : base(name, capacity, contents, discType)
        {
        }


        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.

        public void Read()
        {

        }

        public void Spin(int speed)
        {
            throw new NotImplementedException();
        }

        public void Write(string data)
        {
            throw new NotImplementedException();
        }
    }
}

