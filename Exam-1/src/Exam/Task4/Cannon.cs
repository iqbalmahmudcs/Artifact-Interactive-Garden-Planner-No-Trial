using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task4;

namespace Task4
{
    public class Cannon : Camera
    {
        public string Model { get; set; }
        public string Color { get; set; }

        public Cannon()
        {
            Model = "Canon55";
            Color = "Black";
        }

        public Cannon(string model) : this()
        {
            Model = model;
        }

        public Cannon(string model, string color) : this(model)
        {
            Color = color;
        }

        public void TakePhoto(int width, int height)
        {
            Console.WriteLine("Photo Details");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color {Color}");
            Console.WriteLine($"Photo size: {width}x{height}");
        }

        public void RecordVideo(int duration)
        {
            Console.WriteLine("\nVideo Details");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color {Color}");
            Console.WriteLine($"Video of duration: {duration} seconds");
        }

        void Camera.Takephoto(int width, int height)
        {
        }

        void Camera.RecordVideo(int duration)
        {
        }
    }
}


