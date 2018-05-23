using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var doctors = 7;
            var treatedPatients = 0;
            var untreatedPatients = 0;

            for (int day = 1; day <= days; day++)
            {
                var patients = int.Parse(Console.ReadLine());

                if ((day % 3 == 0) && (untreatedPatients > treatedPatients))
                {
                    doctors++;
                }
                if (patients > doctors)
                {
                    treatedPatients += doctors;
                    untreatedPatients += patients - doctors;
                }
                else
                {
                    treatedPatients += patients;
                }
            }

            Console.WriteLine("Treated patients: {0}.", treatedPatients);
            Console.WriteLine("Untreated patients: {0}.", untreatedPatients);
        }
    }
}
