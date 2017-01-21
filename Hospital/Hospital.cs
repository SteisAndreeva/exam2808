using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Hospital
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());

            int pregledani = 0;
            int nepregledani = 0;
            int doctor = 7;



            for (int day = 1; day <= days; day++)
            {
                if (day%3==0 && pregledani<nepregledani)
                {
                    doctor++;
                }
                        var pacient = int.Parse(Console.ReadLine());

                        if (pacient <= doctor)
                        {
                            pregledani += pacient;
                        }
                        else
                        {
                            pregledani +=  doctor;
                            nepregledani += (pacient - doctor);
                        }
                    }
            Console.WriteLine("Treated patients: {0}." ,pregledani);
            Console.WriteLine("Untreated patients: {0}." , nepregledani);
        }
    }
}
