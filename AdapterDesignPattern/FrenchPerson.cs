using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterDesignPattern
{
    /// <summary>
    /// #Motivation
    /// When a specific implementation is needed with a class that requires a different interface, but not the one that you require.
    /// On your way to creating reusable code and you don't want to tie it tightly to an implementation.
    /// 
    /// #Structure
    /// An Adapter interface with the needed operation that has the interface the Client expects.
    /// 
    /// #Sample Problem
    /// I want a summary of the data of some people. Unfortunately, they all have a different citizenship and therefore they do not share the same properties.
    /// I could write a lot of functions and print the details for each type of citizen according to their citizenship, but that would require a lot of unneeded repeating.
    /// 
    /// #Solution
    ///     1. I will create an Adapter interface with the needed properties for a Person
    ///     2. Create [AT LEAST ONE] Adapter class which implements the Adapter interface from #1
    ///     3. Now I can 'transform' a specific implementation of Person as if it were just a regular Person => can be used in PersonService!
    /// </summary>
    public class FrenchPerson :  IFrenchPerson
    {
        public string Nom { get; set; }
    }
}
