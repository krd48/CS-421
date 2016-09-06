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
Members should always be private.
Members should only be modified by the methods of the class.


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

Properties can be used to provide access member variables.
Properties can exectute code i.e. do calculations.

```
class Circle 
{
	private double _radius

	public double Radius {
	{
		get { return _radius; } 
	}
	
	public double Circumfrence 
	{
		get { return 2 * _radius * Math.PI; }
	}

	public double Circumfrence 
	{
		get { return _radius * _radius * Math.PI; }
	}
}
```


