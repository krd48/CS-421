Exceptions
==========

Exceptions are the preferred method of raising and handling errors.

If something goes wrong in your program, throw an exception.

```
if (string.IsNullOrEmpty(name))
{
	throw new InvalidArgumentException();
}
```

When the program reaches the throw, the program jumps to the first exception handler, or if none is defined, the program terminates.


Handling Exceptions
-------------------

Exceptions can be caught and handled in a try-catch block.

```
try 
{
	// Excecute some code that will throw an exception.
}
catch (Exception ex)
{
	// Handle the error.
}
```

If an exception is thrown inside the try scope, execution will resume insided the catch block. 


Types of Exceptions
-------------------

There are lots of different types of exceptions - maybe 200 or so in the .NET Framework.

Conceptually, you should think of exceptions in 3 categories:

1. Fatal Errors - These are errors over which you have no control, and which should result in the termination of your program.
	There are only a handful of exceptions that fall into this category.  OutOfMemory and StackOverflow are two of them.  They cannot be properly handled.
2. Logic Errors - These are bugs in your program.  These should also result in the termination of your pogram, because you can't fix your bugs when the program is running.
3. Runtime Erros - These are errors that occur during the normal execution of your program.  These should be caught and handled early.

When To Throw?
-------------------

1.	In normal methods: Always.
2.	In constructors: Always.
3.	In destructors: Never.





