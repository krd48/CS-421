Classes
=======

Classes are member variables (or just members) and member functions (or just methods).
Collectively, members and methods are just referred to as members.

Objects are instances of a class.
Each instance of a class has it's own copy of the class's members.

Visibilty
---------

Visibilty is how external clients can view a class.  Members and Methods can be 
*	Private - only methods of the same class can access the member (or method).
	(Different instances of the same class may access the private members of 
*	Public - everyone can access the member or call the method.


Members
-------

Members should be used to represent the internal state of an object.
Members should always be private and mutable (i.e. they can change).
Members should only be modified by the methods of the class.
If a member variable doesn't change (i.e. it's invariant), don't make it a member.  Use a property instead.


Methods
-------

Methods are just functions.  

Consider:

```
File file = ...
Buffer buf = ...
auto bytes = Read(file, buf);
```

Vs.

```
File file = ...
Buffer buf = ...
auto bytes = file.Read(buf);
```

The Read function has 2 parameters: a File object and a Buffer object.
The File object's Read method only has 1 parameter: a Buffer object.
The Read method has an implicit first parameter that is a File object.
Inside the Read method, that implicit parameter is called this.

```
class File 
{
	private int _fp;

	public int Read(Buffer buf)
	{
		C.read(this._fp, ...);
	}
}
```

Although in most cases you can omit the this reference when you access members.


Properties
----------

Properties can be used to provide access member variables (they're often referred to as getters and setters).
Properties can exectute code i.e. do calculations.

```
class Circle 
{
	private double _radius

	public double Radius
	{
		get { return _radius; } 
		set { _radius = value; }
	}
	
	public double Circumfrence 
	{
		get { return 2 * _radius * Math.PI; }
	}

	public double Area 
	{
		get { return _radius * _radius * Math.PI; }
	}
}
```

Notice the implicit value keyword in the Radius setter.

Properties are actually just methods.  The properties on the Circle class are actually compiled as 

```
class Circle 
{
	private double _radius

	public double get_Radius()
	{
		get { return _radius; } 
	}
	
	public void set_Radius(double value)
	{
		_radius = value;
	}
	
	public double get_Circumfrence()
	{
		return 2 * _radius * Math.PI;
	}

	public double get_Area() 
	{
		return _radius * _radius * Math.PI; 
	}
}
```

Interface
----------

The collection of public Members of a class is called its interface.



