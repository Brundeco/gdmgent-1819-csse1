using System;

namespace _3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a shape: square, circle, rectangle, parallelogram");
            string type = Console.ReadLine();
            Shape obj = CreateShape.getobject(type);
            Console.WriteLine(obj.Draw());
            Console.ReadLine();
        }

        public class CreateShape 
        {
            public static Shape getobject(string objshape)
            {
                Shape obj = null;

                switch(objshape) {
                    case "square" : return new Square();
                    case "circle" : return new Circle();
                    case "rectangle" : return new Rectangle();
                    case "parallelogram" : return new Parallelogram();
                }
            return obj;
                
            }
        }

        public interface Shape
        {
            string Draw();
        }
        class Circle: Shape{
            public virtual string Draw(){
                return "A circle";
                
            }
        }
        class Square: Shape{
            public virtual string Draw(){
                return "A square";
            }
        }
        class Rectangle: Shape{
            public virtual string Draw(){
                return "A rectangle";
            }
        }
        class Parallelogram: Shape{
            public virtual string Draw(){
                return "A Parallelogram";
            }
        }
    }
}
