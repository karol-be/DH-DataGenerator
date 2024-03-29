﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using DataGenerator.Model.Json;
using DataGenerator.Model.Sql;

namespace DataGenerator.Model
{
    public class Samochod : IEquatable<Samochod>
    {
        //todo: kolorki
        public string Vin { get; set; }
        public int ModelId { get; set; }
        public DateTime DataZakupu { get; set; }
        public int CenaZakupu { get; set; }
        public string ObszaryDzialalnosciNazwa { get; set; }
        public bool Dostepny { get; set; }
        public bool SkrzyniaAutomatyczna { get; set; }
        public string Kolor { get; set; }
        public DateTime DataProdukcji { get; set; }

        public double LokalizacjaSzerokosc { get; set; }
        public double LokalizacjaWysokosc { get; set; }

        [IgnoreDataMember]
        public ModelSamochodu Model { get; set; }
        [IgnoreDataMember]
        public IList<ServiceDataModel> Services = new List<ServiceDataModel>();

        public bool Equals(Samochod other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(Vin, other.Vin);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Samochod) obj);
        }

        public override int GetHashCode()
        {
            return (Vin != null ? Vin.GetHashCode() : 0);
        }
    }
}
