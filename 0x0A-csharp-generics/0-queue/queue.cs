using System;

    ///<summary>Class queue</summary>
    class Queue<T>
    {
        ///<summary>Check an return T type</summary>
        public  Type CheckType()
        {
            return typeof(T);
        }
    }
