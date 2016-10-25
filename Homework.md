
Homework 1
==========

Define the objects necessary to simulate a game of baseball.
Hint: If you spend more than an hour on this, you're probably over thinking it.

Homework 2 (Due 10/13)
==========

Override the ToString method for the JValue and JsonValue classes in the 
[JSON Example here](https://github.com/tosutton/CS-421/tree/master/Json/2).  
The output should be formatted nicely so it's easy to read.

Additionally, provide an overload of the ToString method that takes a parameter 
which enables or disables formatting. 

Lastly, implement a new class called JsonBlob which contains a byte[] and integrate 
it into the JValue class with the other JsonValue derivatives and provide the same 
overrides of ToString.  The JsonBlob should output base-64 encoded text, which
can be achieved using the System.Convert.ToBase64Sting() method.


Homework 3 (Due ?)
==========

Implement the InsertGameCommand and UpdateGameCommand class in the 
[Baseball project here](https://github.com/tosutton/CS-421/tree/master/Command/Baseball). 

Add transaction support to the database by implementing the Begin/Commit/Rollback Commands in the same project.
This can be accomplished similarly to the [Undo/Redo logic in the DocumentEx class here](https://github.com/tosutton/CS-421/tree/master/Command/Command2). 
