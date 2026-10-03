/* Introduction to .NET
  
 * 1. What is .NET?
     .NET is a free, open-source, cross-platform development platform developed by Microsoft for building different types of applications.
     - With .NET, you can build:
         Console Applications
         Windows Desktop Applications
         Web Applications
         REST APIs
         Mobile Apps
         Cloud Applications
         Microservices
         Games (Unity uses C#)
         IoT Applications
 
 * 2. Why was .NET created?
    Before .NET (late 1990s), Windows development had several challenges:
        Developers used multiple technologies (COM, Win32, MFC, VB6).
        Memory management was manual and error-prone.
        Language interoperability was poor.
        Reusing code across languages was difficult.
        Security features were limited.
        Deployment often caused "DLL Hell" (conflicting library versions).
    Microsoft created .NET to provide:
        A common runtime
        A unified class library
        Automatic memory management
        Better security
        Multiple language support
        Easier deployment
 
 * 3. What does .NET provide?
    .NET consists of several major components:
                         .NET Platform
                             │
             ┌───────────────┼───────────────┐
             │               │               │
         Runtime          Libraries       SDK & Tools
             │               │               │
         CLR            Base Class      dotnet CLI
                        Library (BCL)   Visual Studio

    Runtime
        Runs your application.
        Responsibilities include:
            Memory management
            Garbage Collection (GC)
            Exception handling
            Security
            Thread management
            Loading assemblies
            Executing compiled code
    Libraries
        .NET provides thousands of ready-to-use classes.
        Examples:
            File handling
            Collections
            Networking
            Database access
            JSON processing
            XML handling
            Encryption
            Logging
    SDK (Software Development Kit)
        The SDK contains tools to build and run applications.
        Example commands:
            dotnet new console
            dotnet build
            dotnet run

* 4. What can we build using .NET?
    Console Application
    Web API
    ASP.NET Core MVC
    Desktop Applications
    Mobile Apps
    Cloud Applications
    Games

* 5. Architecture of .NET
                      Your C# Code
                         │
                         ▼
                C# Compiler (csc)
                         │
                         ▼
              Intermediate Language (IL)
                         │
                         ▼
         Common Language Runtime (CLR)
                         │
                         ▼
              Native Machine Code
                         │
                         ▼
                  Operating System

* 6. .NET Versions
    1. .NET Framework
        Windows only
        Introduced in 2002
        Supports Windows Forms, WPF, ASP.NET (classic)
        Still used in many legacy enterprise applications
        Latest version: 4.8.1
    2. .NET Core
        Cross-platform
        Faster
        Open source
        Better performance
        Cloud-friendly
        Docker support
    3. Modern .NET
        Microsoft unified the platform under the name .NET.
         .NET Framework
                │
                ▼
            .NET Core 1
            .NET Core 2
            .NET Core 3
                │
                ▼
            .NET 5
            .NET 6
            .NET 7
            .NET 8 (LTS)
            .NET 9

* 7. Why is .NET Popular?
    Advantages:
        High performance
        Cross-platform support
        Rich libraries
        Automatic garbage collection
        Strong security features
        Excellent tooling
        Large community
        Strong cloud integration
        Good support for microservices
        Widely used in enterprise software
*/

/* 1.Introduction to C# 
    C# (pronounced “C-Sharp”) is a modern, object-oriented programming language developed by Microsoft for building web, desktop, cloud, mobile, and enterprise applications. It runs primarily on the .NET platform and provides strong typing, automatic memory management, and a rich set of development libraries.
    Features of C#:
        1. Object-Oriented Programming
        2. Cross-Platform Development
        3. Strongly Typed
        4. Automatic Memory Management
        5. Exception Handling
        6. Asynchronous Programming
        7. Rich .NET Libraries
        8. Language Integrated Query (LINQ)
        9. High Performance
 */

/* 2.CLR (Common Language Runtime)
 * 1. What is CLR?
        CLR is the runtime environment of .NET that executes Intermediate Language (IL) code by converting it into native machine code and provides runtime services like memory management, garbage collection, security, and exception handling.
            It is responsible for running .NET applications and providing services such as:
                Memory Management
                Garbage Collection
                Exception Handling
                Security
                Thread Management
                JIT Compilation
                Assembly Loading
                Type Safety
  
            CLR acts as the bridge between your .NET code and the operating system/CPU.
                C# -> Compiler -> IL Code -> CLR -> Machine Code -> CPU
 
 * 2. Why Do We Need CLR?
     
 */

/* 3.CTS
 */
/* 4.CLS
 */
/* 5.MSIL / CIL
 */
/* 6.JIT
 */
/* 7.Assemblies
 */
/* 8.Namespaces
 */
/* 9.Project structure
 */
/* 10. Basic Fundamentals
    1. Identifiers
        In C#, identifiers are the user-defined names given to program elements such as variables, methods, classes, and labels.
    2. Keywords
    3. Variables
    4. DataTypes
    5. Constants and Literals
    6. Type Casting
    7. Comments
    8. Operators
    9. record
    10. Nullable reference
*/
/* 11. Control Structures
    1. Decision Making: If - Else, Switch - Case
    2. Loops: For, While, Do-While
    3. Foreach Loop
*/
/* 12. Functions
    1. Functions
    2. Function Parameters
    3. Return Types
    4. Recursion in
*/
/* 13. Arrays & Strings
    1. Introduction to Arrays
    2. Jagged Arrays
    3. Sorting an Array
    4. Introduction to String
    5. Verbatim String
    6. String vs StringBuilder
*/
/* 14. Object-Oriented Programming (OOP)
    1. Class and Objects
    2. Methods
    3. Constructors & Destructors
    4. Properties
    5. Encapsulation
    6. Inheritance
    7. Polymorphism
    8. Abstraction
    9. Interface
*/
/* 15. Collections Framework
    1. List
    2. ArrayList
    3. SortedList
    4. HashSet
    5. SortedSet
    6. Dictionary
    7. SortedDictionary
    8. Hashtable
    9. Stack
    10. Queue
    11. LinkedList
    12. BitArray Class
*/
/* 16. LINQ (Language Integrated Query)
    1. Introduction
    2. Query Syntax
    3. Method Syntax
    4. LINQ Operators and Methods
*/
/* 17. Generics
    1. Introduction
    2. Generic Classes
    3. Generic Methods
    4. Generic Constraints
    5. Collections with Generics
*/
/* 18. Exception Handling
    1. Exception Handling (Try-catch-finally)
    2. Multiple Catch Clause
    3. Custom Exceptions
*/
/* 19. Multithreading
    1. Introduction
    2. Types of Threads
    3. Creating Threads
    4. Main Thread
    5. Lifecycle and States of Thread
    6. Thread Class
    7. Thread Priority
    8. Thread Synchronization
    9. Thread Safety & Race Conditions
    10. Joining Threads
    11. Terminating a Thread
*/
/* 20. Advanced C#
    1. Delegates
    2. Lambda Expressions
    3. Extension Methods
    4. Events
    5. Pattern Matching
    6. Attributes
*/
/* 21. SOLID Principles
 *  Seperate class for it.
*/
/* 22. Design Patterns
 *  Seperate class for it.
 */