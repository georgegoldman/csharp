namespace Acme.Collections;
public class Stack<T>{
    Entry _top;
    public void Push(T data){
        _top = new Entry(_top, data);
    }

    public T Pop() {
        if (_top == null){
            throw new InvalidOperationException();
        }
        T result = _top.Data;
        _top = _top.Next;
        return result;
    }

    class Entry{
        public Entry Next {get; set;}
        public T Data { get; set;}

        public Entry(Entry next, T data){
            Next = next;
            Data = data;
        }
    }
}



public class Pair<TFirst, TSecond>{
    public TFirst First { get; }
    public TSecond Second { get; }

    public Pair(TFirst first, TSecond second) => 
        (First, Second) = (first, second);
}

public class Point3D {
    public int Z {get; set;}
    public int X{ get; set;}
    public int Y {get; set;}
    public Point3D(int x, int y, int z) =>
    (X, Y, Z) = (x, y, z);
}

public struct Point{
    public double X { get; }
    public double Y{ get; } 

    public Point(double x, double y) => (X, Y) = (x, y);
}

interface IControl
{
    void Paint();
}

interface ITextBox : IControl{
    void SetText(String text);
}
interface IListBox : IControl
{
    void SetItems(string[] items);
}

interface IComboBox : ITextBox, IListBox {}
public enum SomeRootVegatable
{
    HorseRadish,
    Radish,
    Turnip
}

[Flags]
public enum Seasons
{
    none=0,
    Summer = 1,
    Autumn = 2,
    Winter = 4,
    Spring = 8,
    All = Summer | Autumn | Winter | Spring
}

public class Color
{
    public static readonly Color Black = new(0, 0, 0);
    public static readonly Color White = new(255, 255, 255);
    public static readonly Color Red = new(255, 0, 0);
    public static readonly Color Green = new(0, 255, 0);
    public static readonly Color Blue = new(0, 0, 255);

    public byte R;
    public byte G;
    public byte B;

    public Color(byte r, byte g, byte b)
    {
        R = r;
        G = g;
        B = b;
    }
}
class Squares
{
    public void WriteSquares()
    {
        int i = 0;
        int j;
        while (i < 10)
        {
            j = i * i;
            Console.WriteLine($"{i} x {j} = {j}");
            i++;
        }
    }
}

class Entity
{
    static int s_nextSerialNo;
    int _serialNo;

    public Entity()
    {
        _serialNo = s_nextSerialNo++;
    }

    public int GetSerialNo()
    {
        return _serialNo;
    }

    public static int GetNextSerialNo()
    {
        return s_nextSerialNo;
    }

    public static void SetNextSerialNo(int value)
    {
        s_nextSerialNo = value;
    }

}

public abstract class Expression
{
    public abstract double Evaluate(Dictionary<string, object> vars);
}
public class Constant: Expression
{
    double _value;
    public Constant(double value)
    {
        _value = value;
    }
    public override double Evaluate(Dictionary<string, object> vars)
    {
        return _value;
    }
}
public class VariableReference: Expression
{
    string _name;
    public VariableReference(string name)
    {
        _name = name;
    }
    public override double Evaluate(Dictionary<string, object> vars)
    {
        object value = vars[_name] ?? throw new Exception($"Unknown variable: {_name}");
        return Convert.ToDouble(value);
    }
}
public class Operation: Expression
{
    Expression _left;
    char _op;
    Expression _right;

    public Operation(Expression left, char op, Expression right)
    {
        _left = left;
        _op = op;
        _right = right;
    }

    public override double Evaluate(Dictionary<string, object> vars)
    {
        double x = _left.Evaluate(vars);
        double y = _right.Evaluate(vars);
        switch (_op)
        {
            case '+': return x + y;
            case '-': return x - y;
            case '*': return x * y;
            case '/': return x / y;
            default: throw new Exception("Unknown Opertion");
        }
    }
}

class OverloadingExample
{
    public void F() => Console.WriteLine("F()");
    public void F(object x) => Console.WriteLine("F(object)");
    public void F(int x) => Console.WriteLine("F(double)");
    public void F<T>(T x) => Console.WriteLine("F<T>(T)");
    public void F(double x, double y) => Console.WriteLine("F(double, double)");
}

class MyList<T>
{
    const int DefaultCapacity = 4;
    T[] _items;
    int _count;

    public MyList(int capacity = DefaultCapacity)
    {
        _items = new T[capacity];
    }

    public int Count => _count;

    public int Capacity
    {
        get => _items.Length;
        set
        {
            if (value < _count ) value = _count;
            if (value != _items.Length)
            {
                T[] newItems = new T[value];
                Array.Copy(_items, 0, newItems, 0, _count);
                _items = newItems;
            }
        }
    }
    public T this[int index]
    {
        get => _items[index];
        set
        {
            _items[index] = value;
            OnChanged();
        }
    }

    public void Add(T item)
    {
        if (_count == Capacity) Capacity = _count * 2;
        _items[_count] = item;
        _count++;
        OnChanged();
    }
    protected virtual void OnChanged() =>
        Changed?.Invoke(this, EventArgs.Empty);
    public override bool Equals(object other) =>
        Equals(this, other as MyList<T>);
    static bool Equals(MyList<T> a, MyList<T> b)
    {
        if(Object.ReferenceEquals(a, null)) return Object.ReferenceEquals(b, null);
        if(Object.ReferenceEquals(b, null) || a._count != b._count)
            return false;
        for (int i = 0; i < a._count; i++)
        {
            if (!object.Equals(a._items[i], b._items[i]))
            {
                return false;
            }
        }
        return true;
    }
    public event EventHandler Changed;

    public static bool operator == (MyList<T> a, MyList<T> b) =>
        Equals(a, b);
    
    public static bool operator != (MyList<T> a, MyList<T> b) =>
        !Equals(a, b);
}

class EventExample
{
    static int s_changeCount;

    static void ListChanged(object sender, EventArgs e)
    {
        s_changeCount++;
    }

    public void Usage()
    {
        var names = new MyList<string>();
        names.Changed += new EventHandler(ListChanged);
        names.Add("Liz");
        names.Add("Martha");
        names.Add("Beth");
        Console.WriteLine(s_changeCount);
    }
}

class Example{

    static void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }

    public static void SwapExample()
    {
        int i = 1, j = 2;
        Swap(ref i, ref j);
        Console.WriteLine($"{i} {j}");
    }
    public static void Main(){
        // var s = new Acme.Collections.Stack<int>();
        //s.Push(1);//stack contains 1
        //s.Push(10);//stack contains 1, 10
        // s.Push(100); //stack contains 1, 10, 100
        // Console.WriteLine(s.Pop()); //stack contains 1, 10
        // Console.WriteLine(s.Pop()); //stack contain1 
        // Console.WriteLine(s.Pop()); //stack is empty
        // var p1 = new Point(0, 0);
        // var p2 = new Point(10, 20);
        // var pair = new Pair<int, string>(1, "two");
        // int i = pair.First;
        // string s = pair.Second;
        // Console.WriteLine(i);
        // Console.WriteLine(s);
        // Point a = new(10, 20);
        // Point b = new(10, 20);
        // Console.WriteLine(a.X);
        // Console.WriteLine(b.Y);
        // var turnip = SomeRootVegatable.Turnip;

        // var spring = Seasons.Spring;
        // var startingOnEquinox = Seasons.Spring | Seasons.Autumn;
        // var theYear = Seasons.All;
        // Console.WriteLine(turnip);
        // Console.WriteLine(spring);
        // Console.WriteLine(startingOnEquinox);
        // Console.WriteLine(theYear);

        // int? optionalInt = default;
        // Console.WriteLine("there is nothing there => "+optionalInt+" absolutely");
        // Console.WriteLine("ok Let\'s pass in a value");
        // optionalInt = 5;
        // Console.WriteLine("there is an option after all "+ optionalInt);
        // Console.WriteLine("👹");

        // public override string ToString() => "this is an Object";


        // (int x, string a) = (1, "goldman");
        // Console.WriteLine(a);
        // Color x = new Color(3, 3, 3);
        // Console.WriteLine(x.R);
        // Console.WriteLine(x.G);
        // Console.WriteLine(x.B);
        // SwapExample();

        // int x = 3, y = 4, z = 5;
        // string s = "x={0} y={1} z={2}";
        // Object[] args = new object[3];
        // args[0] = x;
        // args[1] = y;
        // args[2] = z;
        // Console.WriteLine(s, args);

        // Squares x = new Squares();
        // x.WriteSquares();

        // Entity.SetNextSerialNo(100);
        // Entity e1 = new();
        // Entity e2 = new();
        // Console.WriteLine(e1.GetSerialNo());
        // Console.WriteLine(e2.GetSerialNo());
        // Console.WriteLine(Entity.GetNextSerialNo());
        // int x, y, z;
        // x = 3;
        // y = 4;
        // z = 5;
        // Console.WriteLine("x={0}, y={1}, z={2}", x, y, z);

        // Expression e = new Operation(
        //     new VariableReference("x"),
        //     '*',
        //     new Operation(
        //         new VariableReference("y"),
        //         '+',
        //         new Constant(2)
        //     )
        // );
        // Dictionary<string, object> vars = new();
        // vars["x"] = 3;
        // vars["y"] = 5;
        // Console.WriteLine(e.Evaluate(vars));
        // vars["x"] = 1.5;
        // vars["y"] = 9;
        // Console.WriteLine(e.Evaluate(vars));
        // OverloadingExample x = new();
        // x.F();
        // x.F(1);
        // x.F(1.0);
        // x.F("string");
        // x.F((double)1);
        // x.F((object)1);
        // x.F<int>(1);
        // x.F(1, 1);
        // MyList<string> name = new();
        // name.Capacity = 100;
        // int i = name.Count;
        // int j = name.Capacity;
        // Console.WriteLine(i);
        // Console.WriteLine(j);
        // MyList<string> names = new();
        // names.Add("Liz");
        // names.Add("Martha");
        // names.Add("Beth");
        // for (int i = 0; i < names.Count; i++)
        // {
        //     string s = names[i];
        //     names[i] = s.ToUpper();
        //     Console.WriteLine(names[i]);
        // }
        EventExample x = new();
        x.Usage();


    }
}