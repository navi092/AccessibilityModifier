using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessFields
{
    ///  <summary>
    /// Класс ClassFieldView показывает, как работают модификаторы доступа
    /// </summary>
    public class ClassFieldView
    {
        /// <summary>
        /// Закрытое поле, установленно по умолчанию, т е private, т к поле
        /// </summary>
        int field1;
        /// <summary>
        /// public: публичный, общедоступный класс или член класса. 
        /// Такой член класса доступен из любого места в коде, а также из других программ и сборок.    
        /// </summary>
        public int field2;
        /// <summary>
        /// protected: такой член класса доступен из любого места в текущем классе или в производных классах. 
        /// При этом производные классы могут располагаться в других сборках.     
        /// </summary>
        protected int field3;
        /// <summary>
        /// private: закрытый класс или член класса. Представляет полную противоположность модификатору public.
        /// Такой закрытый класс или член класса доступен только из кода в том же классе или контексте.     
        /// </summary>
        private int field4;
        /// <summary>
        /// internal: класс и члены класса с подобным модификатором доступны из любого места кода в той же сборке,
        /// однако он недоступен для других программ и сборок (как в случае с модификатором public).
        /// </summary>
        internal int field5;
        /// <summary>
        /// protected internal: совмещает функционал двух модификаторов. 
        /// Классы и члены класса с таким модификатором доступны из текущей сборки и из производных классов.     
        /// </summary>
        protected internal int field6;
        /// <summary>
        /// private protected: такой член класса доступен из любого места в текущем классе 
        /// или в производных классах, которые определены в той же сборке.
        /// </summary>
        private protected int field7;
        public ClassFieldView(params int[] _field)
        {
            field1 = _field[0];
            field2 = _field[1];
            field3 = _field[2];
            field4 = _field[3];
            field5 = _field[4];
            field6 = _field[5];
            field7 = _field[6];
        }

    }
}
