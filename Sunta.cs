using System;
using System.Runtime.CompilerServices;

namespace Wood
{
    public class Sunta
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public Sunta(int length, int width)
        {
            Length = length;
            Width= width;
        }

        // Nesne eşitliğini belirlemek için Equals metodunu override ediyoruz.
        public override bool Equals(object? obj)
        {
            // Eğer obj null ise veya türleri uyuşmuyorsa, kesinlikle eşit değillerdir.
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // GetType().GetProperties() yansıma mekanizmasını kullanarak
            // nesnenin tüm özelliklerini alır.
            var properties = GetType().GetProperties();

            // Tüm özellikleri döngü ile gezip, bu nesne ile karşılaştırılan nesnenin
            // aynı isimli özellikleri arasında değer eşitliği kontrolü yapıyoruz.
            foreach (var property in properties)
            {
                var thisValue = property.GetValue(this);
                var otherValue = property.GetValue(obj);

                // Eğer herhangi bir özellikte eşitlik sağlanmıyorsa, nesneler eşit değildir.
                if (!Equals(thisValue, otherValue))
                {
                    return false;
                }
            }

            // Tüm özelliklerin değerleri eşitse, nesneler eşit kabul edilir.
            return true;
        }


        // Nesnenin hash kodunu hesaplamak için GetHashCode metodunu override ediyoruz.
        public override int GetHashCode()
        {
            // İyi bir hash fonksiyonu başlangıcı için 17 sayısını kullanıyoruz.
            int hash = 17;

            // Yine yansımayı kullanarak nesnenin tüm özelliklerini alıyoruz.
            var properties = this.GetType().GetProperties();

            // Tüm özellikleri döngü ile gezip, her bir özelliğin hash kodunu birleştiriyoruz.
            foreach (var prop in properties)
            {
                var value = prop.GetValue(this);

                // null olmayan her değer için, önceki hash değerini 23 ile çarpıp
                // mevcut özelliğin hash kodunu ekliyoruz.
                if (value != null)
                {
                    hash = hash * 23 + value.GetHashCode();
                }
            }

            // Elde edilen son hash değerini döndürüyoruz.
            return hash;
        }
    }
}

