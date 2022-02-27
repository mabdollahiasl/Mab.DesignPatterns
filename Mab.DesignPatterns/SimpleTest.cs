using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mab.DesignPatterns
{
    public class Simple
    {
        readonly string _selectedString;
        public Simple(string selectedString)
        {
            _selectedString = selectedString;
        }
        public string GetInverse()
        {
            if(_selectedString == null)
            {
                return null;
            }
            var selectedStringAsChars= _selectedString.ToCharArray();
            Array.Reverse(selectedStringAsChars);
            return new string(selectedStringAsChars);
        }

    }
}
