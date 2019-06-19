# C# Patterns & Principles

> Work in progess

Code examples for _Patterns and Principles - are these important anymore?_ training.

Examples are in C# and some have Javascript implementation to show how this could be implemented with using only functions.

Examples try to use more real life cases, but sometimes it is hard to come up with a simple example.

Examples also contain UML class diagram code samples, as Gof Patterns are presented in UML. 

Each file has classes and interfaces for the pattern/principle and tests for executing examples.

## Patterns

### Gang of Four

GoF Pattern class diagrams: [Design Patterns Quick Reference (MCDONALDLAND)](
http://www.mcdonaldland.info/2007/11/28/40/)

#### Behavioral

  * Command
  * Observer
  * Memento
  * Strategy
  * __TODO__
    * State
    * Template Method
  * __TODO MAYBE__
    * Chain of Responsibility
    * Interpreter
    * Iterator
      * Check: 
        * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/iterators
        * https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator?view=netcore-2.2    
    * Mediator

#### Creational

  * Prototype
  * Singleton
  * Object Pool
  * Factory / Factory Method
  * Abstract Factory
  * Builder

#### Structural

  * Adapter
  * Composition
  * Decorator
  * Proxy
  * Facade
  * __TODO MAYBE__
    * Bridge
    * Flyweight

### Other

  * DI
  * Functions instead of DI
  * OOP to Functions ()
  * __TODO__
	* Service Locator
	* Repository
    * Fluent Pattern

## Principles

### SOLID Principles

  * Liskov substitution
  * Interface segregation
  * __TODO__
    * Single responsibility
    * Open/Closed
    * Dependency inversion

### Other
 
  * IoC Container
  * __TODO__
    * Modularity 
    * Coupling
    * Cohesion
    * Command Query separation

## Links

* https://sourcemaking.com/design_patterns
* http://www.mcdonaldland.info/2007/11/28/40/
* https://github.com/Lc5/DesignPatternsCSharp
* https://github.com/abishekaditya/DesignPatterns

#### Differences

* https://softwareengineering.stackexchange.com/questions/178488/lsp-vs-ocp-liskov-substitution-vs-open-close
* https://softwareengineering.stackexchange.com/questions/201397/difference-between-the-adapter-pattern-and-the-proxy-pattern
* https://stackoverflow.com/questions/1658192/what-is-the-difference-between-strategy-design-pattern-and-state-design-pattern
 * https://stackoverflow.com/questions/17937755/what-is-the-difference-between-a-fluent-interface-and-the-builder-pattern*