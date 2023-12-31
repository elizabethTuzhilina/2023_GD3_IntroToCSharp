# 2023 - GD3 - Intro To CSharp

## Overview 
This repository contains code samples used to learn the basics of C# in preparation for the development of the code for this module.

## Useful 
- [Markdown](https://docs.github.com/en/enterprise-cloud@latest/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax) in GitHub
- Add emojis with [gitmoji](https://gitmoji.dev/) to your Git commits to improve readability

## Table of Contents - General 
| Topic | Description | Additional Reading |
| :---------------- | :--------------- | :--------------- | 
| Namespace definition | Defining namespaces  | [Namespace](https://www.tutorialspoint.com/csharp/csharp_namespaces.htm) |
| Value and reference types | Passing by reference and by value | [Value type and Reference type](https://www.tutorialsteacher.com/csharp/csharp-value-type-and-reference-type)
| Keywords (ref, out) | Passing a value type by reference and returning multiple variables using 'out' | [ref](https://www.geeksforgeeks.org/ref-in-c-sharp/), [out](https://www.geeksforgeeks.org/out-parameter-with-examples-in-c-sharp/)
| Class definition | Class, constructor, variables, ToString, GetHashCode |  [Class & Object](https://www.geeksforgeeks.org/c-sharp-class-and-object/) |
| Types (struct, enum) | Passing by value with struct and improving usability and reabability with an enum | [struct](https://www.tutorialsteacher.com/csharp/csharp-struct), [C# Enumeration (or enum)](https://www.geeksforgeeks.org/c-sharp-enumeration-or-enum/) 
| String interpolation | Simplify the formatting and output of strings containing variables and code snippets |  [String interpolation](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated) |
| Constructor chaining | Calling one constructor from another | [Constructor Chaining](https://www.delftstack.com/howto/csharp/constructor-chaining-in-csharp/) |
| Properties | Adding get/set properties | [C# Properties](https://www.geeksforgeeks.org/c-sharp-properties/) |
| Containers (List) | Using a List<T> | [C# List Tutorial](https://www.c-sharpcorner.com/article/c-sharp-list/) |
| Indexer | How to use an indexer to gain access to a List in a class | [Indexers](https://www.tutorialspoint.com/csharp/csharp_indexers.htm) |
| Lambda Expressions | Using a Lambda Expression to find in a List<T> | [Lambda Expressions](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions) |
| Predicate | How to use a Predicate in the List class, how to pass a Predicate as a parameter | [Predicate](https://www.tutorialsteacher.com/csharp/csharp-predicate) |
| Func & Action | Passing functions as a parameter | [Func](https://www.tutorialsteacher.com/csharp/csharp-func-delegate), [Action](https://www.tutorialsteacher.com/csharp/csharp-action-delegate) |
| Static Methods | Creating user-friendly constants (e.g. Vector3.Zero) | [Static Methods](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members) |
| Shallow vs Deep Copy | Creating shared (shallow) or distinct (deep) objects | [Shallow Copy and Deep Copy in C#](https://www.geeksforgeeks.org/shallow-copy-and-deep-copy-in-c-sharp/) |
| Operator overloading | Adding useful arithmetic (e.g. +, *) and logical (e.g. ==) operators | [Operator Overloading](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading) |
| SortedList | Using a SortedList, an enum (PriorityType), and a Strategy pattern to create a sorted upgrade controller | [SortedList](https://www.tutorialspoint.com/csharp/csharp_collections.htm)

## Table of Contents - Design Patterns 
| Topic | Description | Additional Reading |
| :---------------- | :--------------- | :--------------- | 
| Abstract Factory | Using the Abstract Factory pattern to make interchangeable components | [Abstract Factory](https://refactoring.guru/design-patterns/abstract-factory) |
| Strategy | Using the Strategy pattern to separate interchangeable algorithms into components accessed through a context | [Strategy](https://refactoring.guru/design-patterns/strategy) |

### To Do - Week 1
- [x] Add namespace, static demos
- [x] Use 'ref' in a function call (see Program)
- [x] Add demo class(es) (see Vector3, Player, PlayerList)
- [x] Add constructor chaining (see Vector3)
- [x] Add properties (set/get) (see Vector3)
- [x] Add string interpolation demo (see Program, Vector3::ToString)
- [x] Add validation on set properties (see Vector3::X with ternary)
- [x] Add intellisense regions to organise our code (see Vector3)

### To Do - Week 2
- [x] Use 'as' keyword to perform a typecast
- [x] Add demo for Abstract Factory (IGenerateRoute, IUpgradeGameObject)
- [x] Add demo for Strategy (GameObjectUpgradeController)

### To Do - Week 3
- [x] Add demo code for useful collections (Program::DemoCoreCollections)
- [ ] Use IComparer in a collection (List::Sort(IComparer)) demo to indicat how to sort IUpgradeGameObject objects in the GameObjectUpgradeController
- [ ] Add static readonly constants (see Purchase)
- [ ] Add demo for deep/shallow copy using Clone (see Vector3)
- [ ] Add protected on set properties (see Vector3)
- [ ] Use 'out' in a function call (see Program)
- [ ] ...to do...(lambda, func, actio, delegate, readonly etc)