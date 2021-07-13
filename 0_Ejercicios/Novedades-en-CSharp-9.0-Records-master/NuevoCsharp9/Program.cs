using System;
using System.Text.Json;
using static System.Console;
using System.Collections.Generic;
/*namespace NuevoCsharp9
{
    class Program
    {
        static void Main(string[] args)
        {*/
var p1 = new Person("John", "Doyle");
WriteLine($"{nameof(p1)}:{p1}");
var p2 = p1; // new Person("Juan", "De Arco");
var isEqual = p1 == p2;
WriteLine($"p1 == p2:{isEqual}");

WriteLine($"{nameof(p2)}:{p2}");
var json = JsonSerializer.Serialize(p1);
WriteLine($"json:{json}");
var p3 = JsonSerializer.Deserialize<Person>(json);
WriteLine($"{nameof(p3)}:{p3}");
isEqual = p1 == p3;
if ((p1.FirstName == p3.FirstName) && (p1.LastName == p3.FirstName))
    WriteLine("P1 es igual a p3");
else
    WriteLine("P1 no es igual a p3");

WriteLine($"p1 == p3:{isEqual}");

// Una lista para imprimir los datos

// Implementar tuplas
var (firstName, lastName) = p1;
WriteLine($"{firstName},{lastName}");
List<Person> persons = new List<Person>();
persons.Add(p1);
persons.Add(p2);
persons.Add(p3);

//p1.LastName = "Bome"; "Protegiendo la inmutabilidad"
//p1 = p1 with { LastName = "Bome" };
WriteLine(p1);

WriteLine($"Is {nameof(p2)}: {p2} is chat: {IsInChat(p2)}");
WriteLine($"Is {nameof(p1)}: {p1} is chat: {IsInChat(p1)}");

foreach (var person in persons)
{
    WriteLine(person);
}

/*}
}*/

static bool IsInChat(Person p)
{
    return p switch
    {
        ("John", "Doyle") => true,
        ("Juan", "De Arco") => true,
        _ => false,
    };
}

/*public record Person(string FirstName, string LastName)
{
    public string FirstName { get; init; } = FirstName;
    public string LastName { get; init; } = LastName;
}*/

public class Person : IEquatable<Person>
{
    public string FirstName { get; }
    public string LastName { get; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    // Creacion de un deconstructor
    public void Deconstruct(out string firstName, out string lastName)
    {
        firstName = FirstName;
        lastName = LastName;
    }

    public override string ToString() =>
        $"FirstName:{FirstName}, LastName:{LastName}";

    public bool Equals(Person other)
    {
        //return other is Person && FirstName == other.FirstName &&
        //    LastName == other.LastName;
        return FirstName == other.FirstName &&
            LastName == other.LastName;
    }

    /* public override bool Equals(object obj)
     {
         return obj is Person p && Equals(p);
     }

     public override int GetHashCode()
     {
         return HashCode.Combine(FirstName, LastName);
     }

     public static bool operator ==(Person left, Person right)
     {
         return left is object ? left.Equals(right) : right is null;
     }
     public static bool operator !=(Person left, Person right)
     {
         return !(left == right);
     }*/
}

/*public class otherPerson : IEquatable<otherPerson>
{
    public bool Equals(otherPerson other)
    {
        throw new NotImplementedException();
    }
}*/
//}