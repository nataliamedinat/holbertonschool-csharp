using System;
using System.Collections.Generic;

    /// <summary> Shape class </summary>
    public class Shape
    {
        /// <summary> Represents the area of the shape</summary>
        public virtual int Area()
        {
            throw new NotImplementedException ("Area() is not implemented");
        }
    }

    /// <summary> Rectangles class derived from shape class</summary>
    public class Rectangle : Shape
    {
        private int width;
        private int height;

        /// <summary> Width of the rectangle </summary>
        public int Width
        {
            get {return (width);}
            set { 
                if (value < 0)
                    throw new ArgumentException("Width must be greater than or equal to 0");
                else
                    width = value;
            }
        }

        /// <summary> Height of the rectangle </summary>
        public int Height
        {
            get {return (height);}
            set {
                if (value < 0)
                    throw new ArgumentException("Height must be greater than or equal to 0");
                else
                    height = value;
            }
        }

        /// <summary> Defines the area of the rectangle </summary>
        public new int Area()
        {
            return width * height;
        }

        /// <summary> Return objs into strings</summary>
        public override string ToString()
        {
             return String.Format ($"[Rectangle] {width} / {height}");
        }
    }

        /// <summary> Square class that inherites from rectangle</summary>
        public class Square : Rectangle
        {
            private int size;

            /// <summary> Defines size of the square</summary>
            public int Size
            {
                get{return (size);}
                set {
                    if (value < 0)
                        throw new ArgumentException("Size must be greater than or equal to 0");
                    else
                        size = value;
                        Height = value;
                        Width = value;
                }
            }

        }