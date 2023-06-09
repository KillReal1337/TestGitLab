using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{

    internal static class CacheManager
    {
       /// <summary>
       /// Ключ - порядковый номер.
       /// Значение- одно из чисел последовательности фибоначчи
       /// </summary>
       static Dictionary<int, int> _cache = new Dictionary<int, int>() { {1, 1}, {2, 2} };

       static internal int GetOrCreate(int serialNumber)
       {
           if (!_cache.ContainsKey(serialNumber))
           {
                CreateElement(serialNumber);
           }
           return _cache[serialNumber];
       }
       static private void CreateElement(int serialNumber)
       {
            _cache.Add(serialNumber, _cache[serialNumber - 2] + _cache[serialNumber - 1]);
       }

    }


}
