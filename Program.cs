using System.ComponentModel;

var rectangle = new Rectangle(5, 10);
Console.WriteLine("Circumference: " + rectangle.CalculateCircumference());
Console.WriteLine("Area: " + rectangle.CalculateArea());
Console.WriteLine("Height: " + rectangle.GetHeight());
rectangle.SetHeight(7);
Console.WriteLine("Height: " + rectangle.GetHeight());
Console.WriteLine("Width is: " + rectangle.Width);
Console.WriteLine(rectangle.Description);
Console.WriteLine(Rectangle.DescribeGenerally());
var rectangle1 = new Rectangle(11, 20);
Console.WriteLine("Number of sides " + Rectangle.NumberOfSides);
Console.WriteLine("Count of rectangle is: " + Rectangle.CountOfInstances);



class Rectangle
{
    public static int CountOfInstances { get; private set; }


    public Rectangle(int width, int height)
    {
        Width = 12;
       _height = GetLengthOrDefault(height, nameof(_height));
        CountOfInstances++;
        

    }

    public int Width { get;} //readonly
    //public int Width { get;} = 12 Set

    /* private int _width;
     * public int Width {   
     * get   {return _width; }
     * private set { if(value >0) _width = value;}
     * 
     * }*/

    /* private int _width;
   * public int Width {   
   * get => _width;
   * set => _width => value;
   * 
   * }*/

    private int _height;

    public int GetHeight() => _height;
    public void SetHeight(int value)
    {
        if (value > 0)
        {
            _height = value;
        }
    }
  
    private int GetLengthOrDefault(int length, string name)
    {
        const int DefaultValueIfNonPositive = 1;
        if (length <= 0)
        {
            Console.WriteLine($"{name} must be a positive number.");
            return DefaultValueIfNonPositive;
        }
        return length;
    }

    public int CalculateCircumference() => 2* Width + 2* _height;  
    //represent action: parameterless method

    public int CalculateArea() => Width * _height;

    public string Description => $"A rectangle with Width {Width} " + $"and height {_height}";
    // represent data: computed- property

    public static string DescribeGenerally() => $"A plane figure with four straight sides and four right angles.";
    public const int NumberOfSides = 4; // implicity static, we call it using class name

}