using Newtonsoft.Json;

namespace Lab3
{
    public class Vector
    {
        /*
         *      Створити клас с атрибутами та конструктором. У методі main() 
         * ініціалізувати створення екземплярів класу та продемонструвати роботу 
         * його методів згідно умов завдання.
           1.
           Скласти опис класу для вектора, заданого координатами його кінців в
           тривимірному просторі. Забезпечити операції додавання і віднімання
           векторів з отриманням нового вектора (суми або різниці), обчислення
           скалярного добутку двох векторів, довжини вектора, косинуса кута між
           векторами. Зробити властивості класу приватними, а для їх читання
           створити методи-геттери.
         */
        private double xStart, yStart, zStart; // Ньютон не працює з автоматичними get/set
        private double xEnd, yEnd, zEnd;
        private double xVect, yVect, zVect;

        public double XStart { get => xStart; set => xStart = value; }
        public double YStart { get => yStart; set => yStart = value; }
        public double ZStart { get => zStart; set => zStart = value; }
        public double XEnd { get => xEnd; set => xEnd = value; }
        public double YEnd { get => yEnd; set => yEnd = value; }
        public double ZEnd { get => zEnd; set => zEnd = value; }
        public double XVect { get => xVect; set => xVect = value; }
        public double YVect { get => yVect; set => yVect = value; }
        public double ZVect { get => zVect; set => zVect = value; }

        /*public double GetXStart() => XStart;
        public double GetYStart() => YStart;
        public double GetZStart() => ZStart;

        public double GetXEnd() => XEnd;
        public double GetYEnd() => YEnd;
        public double GetZEnd() => ZEnd;

        public double GetXVect() => XVect;
        public double GetYVect() => YVect;
        public double GetZVect() => ZVect;*/

        public Vector() {}

        public Vector(double XStart, double YStart, double ZStart, double XEnd, double YEnd, double ZEnd)
        {
            xStart = XStart;
            yStart = YStart;
            zStart = ZStart;

            xEnd = XEnd;
            yEnd = YEnd;
            zEnd = ZEnd;

            xVect = XEnd - XStart;
            yVect = YEnd - YStart;
            zVect = ZEnd - ZStart;
        }

        public Vector(double XEnd, double YEnd, double ZEnd) // якщо потрібен початок вектора на 0
        {
            xEnd = XEnd;
            yEnd = YEnd;
            zEnd = ZEnd;

            xStart = 0; yStart = 0; zStart = 0;         
            xVect = XEnd; yVect = YEnd; zVect = ZEnd;   
        }

        public void PrintCoords()
        {
            Console.WriteLine($"Start: ({XStart}, {YStart}, {ZStart}), end: ({XEnd}, {YEnd}, {ZEnd})");
        }
        public void PrintVect()
        {
            Console.WriteLine($"Vector: ({XVect}, {YVect}, {ZVect})");
        }

        public static Vector Sum(Vector v1, Vector v2) 
        {
            return new Vector(v1.XStart + v2.XStart, v1.YStart + v2.YStart, v1.ZStart + v2.ZStart, v1.XEnd + v2.XEnd, v1.YEnd + v2.YEnd, v1.ZEnd + v2.ZEnd);
        }
        public static Vector Diff(Vector v1, Vector v2) 
        {
            return new Vector(v1.XStart - v2.XStart, v1.YStart - v2.YStart, v1.ZStart - v2.ZStart, v1.XEnd - v2.XEnd, v1.YEnd - v2.YEnd, v1.ZEnd - v2.ZEnd);
        }

        public static Vector SumVect(Vector v1, Vector v2) // створений вектор переміщається у початок координат
        {
            return new Vector(v1.XVect + v2.XVect, v1.YVect + v2.YVect, v1.ZVect + v2.ZVect);
        }
        public static Vector DiffVect(Vector v1, Vector v2) // створений вектор переміщається у початок координат
        {
            return new Vector(v1.XVect - v2.XVect, v1.YVect - v2.YVect, v1.ZVect - v2.ZVect);
        }

        public void MoveVect(double x, double y, double z)
        {
            xStart += x;
            yStart += y;
            zStart += z;

            xEnd += x;
            yEnd += y;
            zEnd += z;
        }

        public static double ScalarProduct(Vector v1, Vector v2)
        {
            return (v1.XVect * v2.XVect) + (v1.YVect * v2.YVect) + (v1.ZVect * v2.ZVect);
        }

        public static double Length(Vector v)
        {
            return Math.Sqrt((v.XVect * v.XVect) + (v.YVect * v.YVect) + (v.ZVect * v.ZVect));
        }

        public static double Cosine(Vector v1, Vector v2)
        {
            return ScalarProduct(v1, v2) / (Length(v1) * Length(v2)); 
        }

        // Метод 1. Зберігає створений об’єкт класу з Завдання 1 у JSON файл
        // Метод 2. Відкриває JSON файл з даними та створює об’єкт класу з
        //          цими даними для виконання Завдання 1. 

        public void SaveToJson(string path)
        {            
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public static Vector LoadFromJson(string path)
        {
            string json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<Vector>(json);
        }
    }
}