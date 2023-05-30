namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            var div = a/b;
            var mod = a%b;

            if (a==17 && b==4)
            {
                Console.WriteLine($"{a}/{b} is {div} remainder {mod}"); 
            }        
            
            var r = 20;
            var pi = Math.PI;

            var areaOfCircle = pi * (r * r);

            Console.WriteLine($"The area of a circle with a radius of {r} is {areaOfCircle}");
        }
    }
}
