using System;

namespace DioPooAula2.Models
{
    
    class Log
    {
        private static Log _log; //propriedade privada

        public string PropriedadeLog { get; set; } //propriedade

        private Log() //construtor privado
        {

        }

        public static Log GetInstance()
        {
            if (_log == null)
            {
                _log = new Log();
            }
            return _log;

        }
    }
}
