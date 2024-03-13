using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
                new Computer(){Code=1, Name ="A1", Type = "A", Frequency=1000, RAM=4, HardDriveCapacity=1024, VideoCardMemory=4, Cost=1000, Numbers=4 },
                new Computer(){Code=2, Name ="A2", Type = "A", Frequency=2000, RAM=6, HardDriveCapacity=512, VideoCardMemory=8, Cost=1500, Numbers=2 },
                new Computer(){Code=3, Name ="F2", Type = "F", Frequency=3000, RAM=8, HardDriveCapacity=2048, VideoCardMemory=16, Cost=2000, Numbers=23 },
                new Computer(){Code=4, Name ="B2", Type = "B", Frequency=4000, RAM=12, HardDriveCapacity=256, VideoCardMemory=8, Cost=3500, Numbers=7 },
                new Computer(){Code=5, Name ="S3", Type = "S", Frequency=1000, RAM=16, HardDriveCapacity=1024, VideoCardMemory=32, Cost=2500, Numbers=9 },
                new Computer(){Code=6, Name ="B6", Type = "B", Frequency=2000, RAM=20, HardDriveCapacity=2048, VideoCardMemory=6, Cost=3000, Numbers=2 },
                new Computer(){Code=7, Name ="S9", Type = "S", Frequency=3000, RAM=32, HardDriveCapacity=512, VideoCardMemory=16, Cost=2500, Numbers=98 },
                new Computer(){Code=8, Name ="L5", Type = "L", Frequency=2500, RAM=8, HardDriveCapacity=256, VideoCardMemory=32, Cost=2000, Numbers=5 },
                new Computer(){Code=9, Name ="T3", Type = "T", Frequency=750, RAM=64, HardDriveCapacity=128, VideoCardMemory=8, Cost=1500, Numbers=35 },
                new Computer(){Code=10, Name ="A8", Type = "A", Frequency=1500, RAM=16, HardDriveCapacity=1024, VideoCardMemory=8, Cost=1000, Numbers=5 }
            };
            Console.Write("Введите название процессора:");
            string name = Console.ReadLine();
            List<Computer> computer1 = computers.Where(x => x.Name == name).ToList();
            Print(computer1);

            Console.Write("Введите объем ОЗУ:");
            int ram = Convert.ToInt32(Console.ReadLine());
            List<Computer> computer2 = computers.Where(x => x.RAM >= ram).ToList();
            Print(computer2);

            Console.WriteLine("Список, отсортированный по увеличению стоимости:");
            List<Computer> computer3 = computers.OrderBy(x => x.Cost).ToList();
            Print(computer3);

            Console.WriteLine("Сгруппированный по типу процессора:");
            IEnumerable<IGrouping<string,Computer>> computer4= computers.GroupBy(x => x.Type);
            foreach (IGrouping<string, Computer>tpc in computer4)
            {
                Console.WriteLine(tpc.Key);
                foreach (Computer c in tpc)
                    Console.WriteLine($"Код {c.Code}, название марки {c.Name}, тип {c.Type}, частота {c.Frequency}, ОЗУ {c.RAM}, объем жесткого диска {c.HardDriveCapacity}, объем видеокарты {c.VideoCardMemory}, цена {c.Cost}, количество {c.Numbers}");
            }
            
            Console.WriteLine("Самый дорогой  компьютер:");
            List<Computer> computer5 = computers.OrderByDescending(x => x.Cost).ToList();
            //Вывод самого дорогого варианта
            Console.WriteLine($"Код {computer5.FirstOrDefault().Code}, название марки {computer5.FirstOrDefault().Name}, тип {computer5.FirstOrDefault().Type}, частота {computer5.FirstOrDefault().Frequency}, ОЗУ {computer5.FirstOrDefault().RAM}, объем жесткого диска {computer5.FirstOrDefault().HardDriveCapacity}, объем видеокарты {computer5.FirstOrDefault().VideoCardMemory}, цена {computer5.FirstOrDefault().Cost}, количество {computer5.FirstOrDefault().Numbers}");
            
            Console.WriteLine("Самый бюджетный компьютер:");
            //Вывод самого дешевого варианта
            Console.WriteLine($"Код {computer5.LastOrDefault().Code}, название марки {computer5.LastOrDefault().Name}, тип {computer5.LastOrDefault().Type}, частота {computer5.LastOrDefault().Frequency}, ОЗУ {computer5.LastOrDefault().RAM}, объем жесткого диска {computer5.LastOrDefault().HardDriveCapacity}, объем видеокарты {computer5.LastOrDefault().VideoCardMemory}, цена {computer5.LastOrDefault().Cost}, количество {computer5.LastOrDefault().Numbers}");

            Console.WriteLine("Есть ли хотя бы один компьютер в количестве не менее 30 штук?");
            if (computers.Any(x => x.Numbers > 30))
                Console.WriteLine("Есть");
            else
                Console.WriteLine("Нет");
            Console.ReadKey();
        }
        static void Print(List<Computer> computers)
        {
            foreach (Computer c in computers)
            {
                Console.WriteLine($"Код {c.Code}, название марки {c.Name}, тип {c.Type}, частота {c.Frequency}, ОЗУ {c.RAM}, объем жесткого диска {c.HardDriveCapacity}, объем видеокарты {c.VideoCardMemory}, цена {c.Cost}, количество {c.Numbers}");
            }
        }
    }
}
