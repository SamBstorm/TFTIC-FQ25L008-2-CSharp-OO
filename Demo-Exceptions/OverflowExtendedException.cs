using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Exceptions
{
    class OverflowExtendedException : OverflowException
    {
        public object Value { get; set; }
        public Type DestinationType { get; set; }

        public OverflowExtendedException() : base("La valeur introduite est trop grande ou trop petite pour le type défini")
        {
            
        }

        public OverflowExtendedException(object value) : base ($"La valeur \"{value}\" est trop grande ou trop petite pour le type défini")
        {
            Value = value;
        }

        public OverflowExtendedException(object value, Type type) : base($"La valeur \"{value}\" est trop grande ou trop petite pour le type \"{type.Name}\"")
        {
            Value = value;
            DestinationType = type;
        }
    }
}
