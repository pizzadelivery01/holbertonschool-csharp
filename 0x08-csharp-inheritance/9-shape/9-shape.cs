﻿using System;

/// <summary>
/// Represents a class Shape
/// </summary>
class Shape
{
/// <summary>
/// Not implemented method
/// </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
/// <summary>
/// Represents a class Rectangle that inherits from Class Shape
/// </summary>
class Rectangle : Shape 
{
    private int width;
    private int height;
    
    /// <summary>
    /// Gets and sets width of Rectangle
    /// </summary>
    public int Width {
        get { return width; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }

    /// <summary>
    /// Gets and sets height of Rectangle
    /// </summary>
    public int Height {
        get { return height; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            height = value;
        }
    }

    /// <summary>
    /// Returns area of the Rectangle
    /// </summary>
    public new int Area()
    {
        return width * height;
    }

    /// <summary>
    /// Override ToString()
    /// </summary>
    public override string ToString()
    {
        return string.Format("[Rectangle] " + width + ' ' + "/ " + height); 
    } 

}

/// <summary>
/// Represents a class Square that inherits from class Rectangle
/// </summary>
class Square : Rectangle
{
    private int size;

    /// <summary>
    /// Gets and sets size of Square
    /// </summary>
    public int Size
    {
        get { return size;}
        set 
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }           
            size = value;
            Height = value;
            Width = value;
        }
    }

    /// <summary>
    /// Override ToString()
    /// </summary>
    public override string ToString()
    {
        return string.Format("[Square] " + size + ' ' + "/ " + size); 
    }
}