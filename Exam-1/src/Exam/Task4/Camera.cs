using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public interface Camera
    {
        void Takephoto(int width , int height);
        void RecordVideo(int duration);
    }
}
