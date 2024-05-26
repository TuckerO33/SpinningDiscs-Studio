using System;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        private string capacity;

        public string Name {get; set; }
        public int Capacity {get; set; }
        public string Contents {get; set; }
        public string DiscType {get; set; }

    public BaseDisc(string name, int capacity, string contents, string discType)
    {
        name = Name;
        capacity = Capacity;
        contents = Contents;
        discType = DiscType;
    }

        // public void 

    }
}