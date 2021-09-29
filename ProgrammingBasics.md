# Programming Basics
## Variables
- Placeholder for data
- specific address for data
    - most PLs a variable is an abstracted address
- analogy: empty cup you can pour liquid to (can be water, juice, etc.)
- value can change based on some conditions
- scope: whether an address is something you can reach or not, where does the variable live/die
- encapsulation - related to variable access because you can limit access to variables using access modifiers in some PLs (like C#, Java, VB.Net)
### Best Practices with variables:
- Do have self documenting names for variables 
    - unless it's a counter variable for your for loops, don't just have variables called x, this isn't algebra 
        - student instead of s
        - hasValue instead of x or h or x2 
    - this good for making readable code 
- Do use camel case 
    - this helps in the readability
    - hasValue vs hasvalue
    - getCustomer vs getcustomer
    - thisIsCamelCase - every new word save the first uses upper case in the first letter 
    - ThisIsPascalCase - every new word uses upper case in the first letter
- You can use _ to represent private variables
    - _repo instead of repo
- Follow naming conventions
    - don't be weird
## Operators
- modify variables/data
- process /data 
- perform operations on primitive values
    - Like addition, subtraction etc
- putting data to use 
- conditions in a program 
    - ternary operator ??
- logical operators like && or || for boolean expressions ! that you can utilize with 
- used to compare values like >, <, ==
- used to assign values, = 
- kinda boring on its own, usually used in tandem with control flow statements
## Control flow
- usually used in tandem with boolean expressions
### Conditionals
- if else statements
- if else if
- switch 
- statements in programming that are used to evaluate a variable or two vars for execution
- a way of controlling execution by eveluating one condition (at least) can be with mutliple different kinds of operators, any condition minimum of one
- decision based on a value, like a flowcharts 
- finite executions, predetermined number of execs
### Looping constructs/ Iterations
- while, for, do while, foreach 
```
for (int i = 0; i < associates.Length; i++)
    {
        Console.writeline("Hello " + asssociates[i].name); 
    }
```

``` 
foreach (associate in associates)
{
    Console.WriteLine("Hello" + associate.name);
}
```
```
while(associates still has a next element)
{
    Console.WriteLine("Hello" + associate.Next().name);
}
```

```
do
{
    Console.WriteLine("Hello" + associate.Next().name);
} while(associates still has a next element);
```
- do while loops execute at least once