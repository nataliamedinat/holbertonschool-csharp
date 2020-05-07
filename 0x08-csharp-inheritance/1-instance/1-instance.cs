using System;

    /// <summary> Object class </summary>
    class Obj
    {
        /// <summary> Check if an obj is an instance </summary>
        public static bool IsInstanceOfArray(object obj)
        {
            return obj is Array;
        }
    }