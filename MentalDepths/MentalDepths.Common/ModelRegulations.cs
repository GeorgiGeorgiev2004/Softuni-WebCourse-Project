using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalDepths.Common
{
    public class ModelRegulations
    {
        public class Specialist
        {
            public const int URLMaxLenght = 2048;
            public const int URLMinLenght = 12;

            public const int MinAge = 21;
            public const int MaxAge = 78;

            public const int AddressMaxLenght = 60;
            public const int AddressMinLenght = 5;

            public const int DescriptionMaxLenght = 400;
            public const int DescriptionMinLenght = 30;
        }
        public class ApplicationUser 
        {
            public const int minvalue = 1;
            public const int maxvalue = int.MaxValue;

            public const int NamesMaxLenght = 30;
            public const int NamesMinLenght = 1;
        }
        public class Specialisation
        {
            public const int NamesMaxLenght = 50;
            public const int NamesMinLenght = 1;
        }

        public class City
        {
            public const int NamesMaxLenght = 40;
            public const int NamesMinLenght = 1;
        }
        public class Apointment 
        {
            public const int AddressMaxLenght = 60;
            public const int AddressMinLenght = 5;
        }

        public class Prescription
        {
            public const int MedicationMaxName = 25;
            public const int MedicationMinName = 3;

            public const int MedicationMaxDescription = 400;
            public const int MedicationMinDescription = 30;
        }
        public class Admin
        {
            public const int MaxName = 300;
            public const int MinName = 1;

            public const int MaxPhone = 10;
            public const int MinPhone = 7;
        }
    }
}
