namespace ConsoleApp_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task1");
            int[] numbers = { 10, 20, 30, 40 };

           
            int validResult = GetElementByIndex(numbers, 2);
            Console.WriteLine($"Returned value: {validResult}");

            
            int invalidResult = GetElementByIndex(numbers, 10);
            Console.WriteLine($"Returned value: {invalidResult}");


            Console.WriteLine("\n---------------------\n");


            
            Console.WriteLine("task2");
            string normalText = "Hello C#";
            string nullText = null;

            
            int normalLength = GetStringLength(normalText);
            Console.WriteLine($"Length: {normalLength}");

            
            int nullLength = GetStringLength(nullText);
            Console.WriteLine($"Length: {nullLength}");

            
            Console.ReadLine();
        }

        
        public static int GetElementByIndex(int[] array, int index)
        {
            try
            {
                return array[index];
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("error: wrong index!");
                return -1;
            }
        }

       
        public static int GetStringLength(string text)
        {
            try
            {
                return text.Length;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("მიუთითეთ ტექსტი");
                return 0;
            }
        }
    }
}

