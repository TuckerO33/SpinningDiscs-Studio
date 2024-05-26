using System;

namespace SpinningDiscs;

public interface IOpticalDisc {
    void Spin(int speed);
    void Write(string data);
    void Read();

    
}
