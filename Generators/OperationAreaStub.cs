﻿using System.Collections.Generic;
using DataGenerator.Model.Sql;

namespace DataGenerator.Generators
{
    public static class OperationAreaStub
    {
        public static IList<ObszarDzialalnosci> AreasOfOperation = new List<ObszarDzialalnosci>
        {
            ObszarDzialalnosci.DefaultArea,
            new ObszarDzialalnosci
            {
                Nazwa = "Aglomeracja Śląska",
                PunktCentralny = (50.3126, 18.9595),
                Srednica = 30
            },
            new ObszarDzialalnosci
            {
                Nazwa = "Warszawa",
                PunktCentralny = (52.2474, 21.0306),
                Srednica = 30
            },
            new ObszarDzialalnosci
            {
                Nazwa = "Poznań",
                PunktCentralny = (52.411569, 16.930175),
                Srednica = 10
            },
        };
    }
}