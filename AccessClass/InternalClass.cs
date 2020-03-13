using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessClass
{
    /// <summary>
    /// internal: класс и члены класса с подобным модификатором доступны из любого места кода в той же сборке, 
    /// однако он недоступен для других программ и сборок (как в случае с модификатором public).    
    /// </summary>
    internal class InternalClass
    {
    }
}
