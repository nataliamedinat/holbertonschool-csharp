using System;
using System.Collections.Generic;

    /// <summary> Class object </summary>
    class Obj
    {
        /// <summary>  Method that returns true if an obj is int, otherwise false</summary>
        public static bool IsOfTypeInt(object obj)
        {
            if (obj is int)
                return true;
            else
                return false;
        }
    }

