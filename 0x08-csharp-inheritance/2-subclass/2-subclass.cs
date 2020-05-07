using System;

    /// <summary> Object class</summary>
    class Obj
    {
        /// <summary> Check if an obj is an instance of a class</summary>
        public static bool IsOnlyASubclass(Type derivedType, Type baseType)
        {
            return derivedType.IsSubclassOf(baseType);
        }
    }
