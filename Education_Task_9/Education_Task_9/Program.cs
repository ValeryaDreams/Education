namespace Education_Task_9
{
        internal class Program
        {
                public static WeakReference weak;

                static void Main(string[] args)
                {
                        CreateObject();                      

                        // Сильная ссылка obj существует => GC не может собрать объект.
                        Console.WriteLine($"Alive: {weak.IsAlive}");

                        // Принудительный запуск GC.
                        // GC Смотрит:
                        // сильной ссылки НЕТ.
                        // слабая ссылка ЕСТЬ, но это не защита объекта => ОБЪЕКТ МОЖЕТ БЫТЬ УДАЛЕН.
                        GC.Collect();

                        Console.WriteLine($"Alive: {weak.IsAlive}");

                        Console.ReadLine();
                }

                public static void CreateObject()
                {
                        // Сильная ссылка.
                        // Пока эта ссылка существует — GC не имеет права удалить объект.
                        var obj = new object();

                        // Слабая ссылка.
                        // WeakReference НЕ удерживает объект в памяти.
                        // То есть объект жив только из-за сильной ссылки obj.
                        weak = new WeakReference(obj);
                }
        }
}
