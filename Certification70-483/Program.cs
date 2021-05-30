using Certification70_483._01_ManageProgramFlow._01_MultithreadingAndAsynchronousProcessing;
using Certification70_483._01_ManageProgramFlow._02_ManageMultithreading;
using Certification70_483._01_ManageProgramFlow._03_ImplementProgramFlow;
using Certification70_483._01_ManageProgramFlow._04_CreateAndImplementEventsAndDelegates;
using Certification70_483._01_ManageProgramFlow._05_ImplementExceptionHandling;
using System;

namespace Certification70_483
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Chapter01 - MultithreadingAndAsynchronousProcessing
            //Example01 - thread and Synchronization

            //THREAD CLASS
            //Example01.Start();
            //Console.ReadKey();

            //Example02 - Backgroud and foregroud thread

            //Example02.Start(true);
            //Example02.Start(false);

            //Example03 - Using ParameterizedThreadStart delegate as parameter
            //Example03.Start();

            //Example04 - Stopping a thread by using Shared variable
            //Example04.Start();

            //Example05 - Using the ThreadStaticAttribute
            //Example05.Start();

            //Example06 - Using ThreadLocal<T>
            //Example06.Start();

            //THREAD POOL
            //Example07 - Using ThreadPools
            //Example07.Start();

            //TASKS
            //Example08 - Using tasks
            //Example08.Start();

            //Example09 - using Task<T>
            //Example09.Start();

            //Example10 - using Tasks - ContinueWith
            //Example10.Start();

            //Example11 - using Tasks - Scheduling different continuation tasks
            //Example11.Start();

            //Example12 - using Tasks - Attaching child tasks to a parent task
            //Example12.Start();

            //Example13 - using TaskFactory
            //Example13.Start();

            //Example14 - using Task.WaitAll/WhenAll
            //Example14.Start();

            //Example15 - using Task.WaitAny
            //Example15.Start();

            //PARALLEL CLASS
            //Example16 - Using Parallel.For and Parallel.Foreach
            //Example16.Start();

            //Example17 - Using Parallel.Break/Stop
            //Example17.Start();

            //Example18 - Using Asyc/Await
            //Example18.Start();

            //Example19 - Scalability versus responsiveness
            //Example19.Start();

            //Example20 - Using ConfigureAwait wrong output
            //Example20.Start();

            //Example21 - Continuing on a thread pool instead of the UI thread
            //Example21.Start();

            //Using Parallel Language Integrated Query (PLINQ)

            //Example22 - Using AsParallel
            //Example22.Start();

            //Example23 - !!Are incleded in example 22!!

            //Example24 - Ordered parallel query
            //Example24.Start();

            //Example25
            //Example25.Start();

            //Example26 - Using ForAll
            //Example26.Start();

            //Example27 - Catching AggregateException
            //Example27.Start();

            //Using concurrent collections

            //Example28 - Using BlockingCollection<T>
            //Example28.Start();

            //Example29 - Using GetConsumingEnumerable on a BlockingCollection
            //Example29.Start();

            //Example30 - Using a ConcurrentBag
            //Example30.Start();

            //Example31 - Enumerating a ConcurrentBag
            //Example31.Start();


            //Using a ConcurrentStack
            //Example32.Start();

            //Using ConcurrentQueue
            //Example33.Start();

            //Using ConcurrentDictionary
            //Example34.Start();
            #endregion

            #region Chapter01 - ManageMultithreading
            //Accessing shared data in a multithreaded application
            //Example35.Start();

            //Using the lock keyword
            //Example36.Start();

            //Creating a deadlock
            //Example37.Start();

            //Generated code from a lock statement
            //Example38.Start();

            //A potential problem with multithreaded code
            //Example39.Start();

            //Using the Interlocked class
            //Example40.Start();

            //Compare and exchange as a nonatomic operation
            //Example41.Start();

            //Using a CancellationToken
            //Example42.Start();

            //Throwing OperationCanceledException
            //Example43.Start();

            //Adding a continuation for canceled tasks
            //Example44.Start();

            //Setting a timeout on a task
            //Example45.Start();            
            #endregion

            #region Chapter01 - ImplementProgramFlow
            //Objective 1.3: Implement program flow
            //A better readable nested if statement
            //Example46.Start();

            //Boolean OR operator
            //Example47.Start();

            //Short-circuiting the OR operator
            //Example48.Start();

            //Using the AND operator
            //Example49.Start();

            //Using the AND operator
            //Example50.Start(null);

            //Using the XOR operator
            //Example51.Start();

            //Basic if statement
            //Example52.Start();

            //An if statement with code block
            //Example53.Start();

            //Code blocks and scoping
            //Example54.Start();

            //Using an else statement
            //Example55.Start();

            //Using multiple if/else statements
            //Example56.Start();

            //A more readable nested if statement
            //Example57.Start();

            //The null-coalescing operator
            //Example58.Start();

            //Nesting the null-coalescing operator
            //Example59.Start();

            //The conditional operator
            //Example60.Start(true);

            //A complex if statement
            //Example61.Start('a');

            //A switch statement
            //Example62.Start('a');

            //goto in a switch statement
            //Example63.Start();

            //A basic for loop
            //Example64.Start();

            //A for loop with multiple loop variables
            //Example65.Start();

            //A for loop with a custom increment
            //Example66.Start();

            //A for loop with a break statement
            //Example67.Start();

            //A for loop with a continue statement
            //Example68.Start();

            //A for loop with a continue statement.
            //Example69.Start();

            //do-while loop
            //Example70.Start();

            //foreach loop
            //Example71.Start();

            //Changing items in a foreach
            //Example72.Start();

            //The compiler-generated code for a foreach loop
            //Example73.Start();

            //goto statement with a labe
            //Example74.Start();
            #endregion

            #region Chapter01 - CreateAndImplementEventsAndDelegates
            //Using a delegate
            //Example75.Start();

            //A multicast delegate
            //Example76.Start();

            // Covariance with delegates
            //Example77.Start();

            //Contravariance with delegates
            //Example78.Start();

            //Lambda expression to create a delegate
            //Example79.Start();

            //Creating a lambda expression with multiple statements
            //Example80.Start();

            //Using the Action delegate
            //Example81.Start();

            //Using an Action to expose an event
            //Example82.Start();

            //Using the event keyword
            //Example83.Start();

            //Custom event arguments
            //Example84.Start();

            //Custom event accessor
            //Example85.Start();

            //Exception when raising an event
            //Example86.Start();

            //Manually raising events with exception handling
            //Example87.Start();

            #endregion

            #region Chapter01 - ImplementExceptionHandling
            //Parsing an invalid number
            //Example88.Start();

            //Catching a FormatException
            //Example89.Start();

            //Catching different exception types
            //Example90.Start();

            //Using a finally block
            //Example91.Start();

            //Using Environment.FailFast
            //Example92.Start();

            //Inspecting an exception
            //Example93.Start();

            //Throwing an ArgumentNullException
            //Example94.Start();

            //Rethrowing an exception
            //Example95.Start();

            //Throwing a new exception that points to the original one
            //Example96.Start();

            //Using ExceptionDispatchInfo.Throw
            //Example97.Start();

            //Creating a custom exception
            //Example98.Start();
            #endregion

            #region Chapter02 - CreateTypes

            //Using the FlagAttribute for an enum
            //_02_CreateAndUseTypes._01_CreateTypes.Example01.Start();

            //Creating a custom struct
            //_02_CreateAndUseTypes._01_CreateTypes.Example02.Start();

            //Calling a method
            //_02_CreateAndUseTypes._01_CreateTypes.Example03.Start();

            //Creating a method
            //_02_CreateAndUseTypes._01_CreateTypes.Example04.Start(2, 2);

            //Passing a complete customer to a method
            //_02_CreateAndUseTypes._01_CreateTypes.Example05.Start();

            //Passing only an address to a method
            //_02_CreateAndUseTypes._01_CreateTypes.Example06.Start();

            //Using named and optional arguments
            //_02_CreateAndUseTypes._01_CreateTypes.Example07.Start();

            //Returning data from a method
            //_02_CreateAndUseTypes._01_CreateTypes.Example08.Start();

            //Declaring and using a field
            //_02_CreateAndUseTypes._01_CreateTypes.Example09.Start();

            //Creating a collection such as a Deck class
            //_02_CreateAndUseTypes._01_CreateTypes.Example10.Start();

            //Adding a constructor to your type
            //_02_CreateAndUseTypes._01_CreateTypes.Example11.Start();

            //Chaining constructors
            //_02_CreateAndUseTypes._01_CreateTypes.Example12.Start();

            //Generic Nullable<T> implementation
            //_02_CreateAndUseTypes._01_CreateTypes.Example13.Start();

            //Using a where clause on a class definition
            //_02_CreateAndUseTypes._01_CreateTypes.Example14.Start();

            //Using default(T) with a generic type parameter
            //_02_CreateAndUseTypes._01_CreateTypes.Example15.Start();

            //Creating an extension method
            //_02_CreateAndUseTypes._01_CreateTypes.Example16.Start();

            //Overriding a virtual method
            //_02_CreateAndUseTypes._01_CreateTypes.Example17.Start();

            //Using the sealed keyword on a method
            //_02_CreateAndUseTypes._01_CreateTypes.Example18.Start();

            #endregion

            #region Chapter02 - ConsumeTypes
            //Boxing an integer value
            //_02_CreateAndUseTypes._02_ConsumeTypes.Example19.Start();

            //Implicitly converting an integer to a double
            //_02_CreateAndUseTypes._02_ConsumeTypes.Example20.Start();

            //Implicitly converting an object to a base type
            //_02_CreateAndUseTypes._02_ConsumeTypes.Example21.Start();

            //Casting a double to an int
            //_02_CreateAndUseTypes._02_ConsumeTypes.Example22.Start();

            //Explicitly casting a base type to a derived type
            //_02_CreateAndUseTypes._02_ConsumeTypes.Example23.Start();

            //Implementing an implicit and explicit conversion operator
            //_02_CreateAndUseTypes._02_ConsumeTypes.Example24.Start();

            //Using an implicit and explicit cast operator on a custom type
            //_02_CreateAndUseTypes._02_ConsumeTypes.Example25.Start();

            //Using the built-in Convert and Parse methods
            //_02_CreateAndUseTypes._02_ConsumeTypes.Example26.Start();

            //Using the is and as operators
            //_02_CreateAndUseTypes._02_ConsumeTypes.Example27.Start();

            //Exporting some data to Excel
            //_02_CreateAndUseTypes._02_ConsumeTypes.Example28.Start();

            //Creating a custom DynamicObject
            //_02_CreateAndUseTypes._02_ConsumeTypes.Example29.Start();

            //The dynamic keyword in ASP.NET MVC
            //_02_CreateAndUseTypes._02_ConsumeTypes.Example30.Start();
            #endregion

            #region Chapter02 - EnforceEncapsulation
            //Using access modifiers
            //_02_CreateAndUseTypes._03_EnforceEncapsulation.Example31.Start();

            //Using the private access modifier
            //_02_CreateAndUseTypes._03_EnforceEncapsulation.Example32.Start();

            //Changing a private field without outside users noticing
            //_02_CreateAndUseTypes._03_EnforceEncapsulation.Example33.Start();

            //Using the protected access modifier with inheritance
            //_02_CreateAndUseTypes._03_EnforceEncapsulation.Example34.Start();

            //Using the internal access modifier
            //_02_CreateAndUseTypes._03_EnforceEncapsulation.Example35.Start();

            //Encapsulating a field with custom methods
            //_02_CreateAndUseTypes._03_EnforceEncapsulation.Example36.Start(1);

            //Creating a property
            //_02_CreateAndUseTypes._03_EnforceEncapsulation.Example37.Start();

            //The IObjectContextAdapter interface
            //_02_CreateAndUseTypes._03_EnforceEncapsulation.Example38.Start();

            //Implementing an interface explicitly
            //_02_CreateAndUseTypes._03_EnforceEncapsulation.Example39.Start();

            //Implementing an interface explicitly 2
            //_02_CreateAndUseTypes._03_EnforceEncapsulation.Example40.Start();
            #endregion

            #region Chapter02 - CreateAndImplementClassHierarchy
            //Creating and implementing an interface
            //_02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy.Example41.Start();

            //Adding a set accessor to an implemented interface property
            //_02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy.Example42.Start();

            //Creating an interface with a generic type parameter
            //_02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy.Example43.Start();

            //Instantiating a concrete type that implements an interface
            //_02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy.Example44.Start();

            //Creating a base class
            //_02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy.Example45.Start();

            //Inheriting from a base class
            //_02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy.Example46.Start();

            //Overriding a virtual method
            //_02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy.Example47.Start();

            //Hiding a method with the new keyword
            //_02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy.Example48.Start();

            //Creating an abstract class
            //_02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy.Example49.Start();

            //A Rectangle class with an Area calculation
            //_02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy.Example50.Start();

            //A Square class that inherits from Rectangle
            //_02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy.Example51.Start();

            //Using the Square class
            //_02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy.Example52.Start();

            //IComparable interface
            //_02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy.Example53.Start();

            //Implementing the IComparable interface
            //_02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy.Example54.Start();

            //Syntactic sugar of the foreach statement
            //_02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy.Example55.Start();

            //Implementing IEnumerable<T> on a custom type
            //_02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy.Example56.Start();

            //The IDisposable interface
            _02_CreateAndUseTypes._04_CreateAndImplementClassHierarchy.Example57.Start();
            #endregion

            #region Chapter02 - FindExecuteCreateTypesAtRunTimeUsingReflection
            //Applying an attribute
            //_02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection.Example58.Start();

            //Using multiple attributes
            //_02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection.Example59.Start();

            //Specifying the target of an attribute explicitly
            //_02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection.Example60.Start();

            //Seeing whether an attribute is defined
            //_02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection.Example61.Start();

            //Getting a specific attribute instance
            //_02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection.Example62.Start();

            //Using a category attribute in xUnit
            //_02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection.Example63.Start();

            //Creating a custom attribute
            //_02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection.Example64.Start();

            //Using a custom attribute
            //_02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection.Example65.Start();

            //Defining the targets for a custom attribute
            //_02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection.Example66.Start();

            //Setting the AllowMultiple parameter for a custom attribute
            //_02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection.Example67.Start();

            //Adding properties to a custom attribute
            //_02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection.Example68.Start();

            //Creating an interface that can be found through reflection
            //_02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection.Example69.Start();

            //Creating a custom plug-in class
            //_02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection.Example70.Start();

            //Inspecting an assembly for types that implement a custom interface
            //_02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection.Example71.Start();

            //Getting the value of a field through reflection
            //_02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection.Example72.Start();

            //Executing a method through reflection
            //_02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection.Example73.Start();

            //Generating “Hello World!” with the CodeDOM
            //_02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection.Example74.Start();

            //Generating a source file from a CodeCompileUnit
            //_02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection.Example75.Start();

            //The automatically generated source file
            //_02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection.Example76.Start();

            //Creating a Func type with a lambda
            //_02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection.Example77.Start();

            //Creating “Hello World!” with an expression tree
            //_02_CreateAndUseTypes._05_FindExecuteCreateTypesAtRunTimeUsingReflection.Example78.Start();
            #endregion

            #region Chapter02 - ManageTheObjectLifeCycle
            //Adding a finalizer
            //_02_CreateAndUseTypes._06_ManageTheObjectLifeCycle.Example79.Start();

            //Not closing a file will throw an error
            //_02_CreateAndUseTypes._06_ManageTheObjectLifeCycle.Example80.Start();

            //Forcing a garbage collection
            //_02_CreateAndUseTypes._06_ManageTheObjectLifeCycle.Example81.Start();

            //The IDisposable interface
            //_02_CreateAndUseTypes._06_ManageTheObjectLifeCycle.Example82.Start();

            //Calling Dispose to free unmanaged resources
            //_02_CreateAndUseTypes._06_ManageTheObjectLifeCycle.Example83.Start();

            //Implementing IDisposable and a finalizer
            //_02_CreateAndUseTypes._06_ManageTheObjectLifeCycle.Example84.Start();

            //Using WeakReference
            //_02_CreateAndUseTypes._06_ManageTheObjectLifeCycle.Example85.Start();
            #endregion

            #region Chapter02 - ManageTheObjectLifeCycle
            //Creating a large number of strings
            //_02_CreateAndUseTypes._07_ManipulateStrings.Example86.Start();

            //Changing a character with a StringBuilder
            //_02_CreateAndUseTypes._07_ManipulateStrings.Example87.Start();

            //Using a StringBuilder in a loop
            //_02_CreateAndUseTypes._07_ManipulateStrings.Example88.Start();

            //Using a StringWriter as the output for an XmlWriter
            //_02_CreateAndUseTypes._07_ManipulateStrings.Example89.Start();
            #endregion

            #region Chapter02 - ManipulateStrings
            //Using a StringReader as the input for an XmlReader
            //_02_CreateAndUseTypes._07_ManipulateStrings.Example90.Start();

            //Using IndexOf and LastIndexOf
            //_02_CreateAndUseTypes._07_ManipulateStrings.Example91.Start();

            //Using StartsWith and EndsWith
            //_02_CreateAndUseTypes._07_ManipulateStrings.Example92.Start();

            //Reading a substring
            //_02_CreateAndUseTypes._07_ManipulateStrings.Example93.Start();

            //Changing a string with a regular expression
            //_02_CreateAndUseTypes._07_ManipulateStrings.Example94.Start();

            //Iterating over a string
            //_02_CreateAndUseTypes._07_ManipulateStrings.Example95.Start();

            //Overriding ToString
            //_02_CreateAndUseTypes._07_ManipulateStrings.Example96.Start();

            //Displaying a number with a currency format string
            //_02_CreateAndUseTypes._07_ManipulateStrings.Example97.Start();

            //Displaying a DateTime with different format strings
            //_02_CreateAndUseTypes._07_ManipulateStrings.Example98.Start();

            //Implementing custom formatting on a type
            //_02_CreateAndUseTypes._07_ManipulateStrings.Example99.Start();

            //Creating a composite string formatting
            //_02_CreateAndUseTypes._07_ManipulateStrings.Example100.Start();
            #endregion

            #region Chapter03 - ValidateApplicationInput
            //Customer and Address classes
            //_03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput.Example01.Start();

            //Saving a new customer to the database
            //_03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput.Example02.Start();

            //Running manual validation
            //_03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput.Example03.Start();

            //Using Parse
            //_03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput.Example04.Start();

            //Using TryParse
            //_03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput.Example05.Start();

            //Using configuration options when parsing a number
            //_03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput.Example06.Start();

            //Using Convert with a null value
            //_03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput.Example07.Start();

            //Using Convert to convert from double to int
            //_03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput.Example08.Start();

            //Manually validating a ZIP Code
            //_03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput.Example09.Start();

            //Validate a ZIP Code with a regular expression
            //_03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput.Example10.Start();

            //Validate a ZIP Code with a regular expression
            //_03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput.Example11.Start();

            //Seeing whether a string contains potential JSON data
            //_03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput.Example12.Start();

            //Deserializing an object with the JavaScriptSerializer
            //_03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput.Example13.Start();

            //A sample XML with person data
            //_03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput.Example14.Start();

            //A sample XSD file
            //_03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput.Example15.Start();

            //Validating an XML file with a schema
            //_03_DebugApplicationsAndImplementSecurity._01_ValidateApplicationInput.Example16.Start();

            #endregion

            #region Chapter03 - PerformSymmetricAndAsymmetricEncryption

            //Use a symmetric encryption algorithm
            //_03_DebugApplicationsAndImplementSecurity._02_PerformSymmetricAndAsymmetricEncryption.Example17.Start();

            //Exporting a public key
            //_03_DebugApplicationsAndImplementSecurity._02_PerformSymmetricAndAsymmetricEncryption.Example18.Start();

            //Using a public and private key to encrypt and decrypt data
            //_03_DebugApplicationsAndImplementSecurity._02_PerformSymmetricAndAsymmetricEncryption.Example19.Start();

            //Using a key container for storing an asymmetric key
            //_03_DebugApplicationsAndImplementSecurity._02_PerformSymmetricAndAsymmetricEncryption.Example20.Start();

            //A naïve set implementation
            //_03_DebugApplicationsAndImplementSecurity._02_PerformSymmetricAndAsymmetricEncryption.Example21.Start();

            //A set implementation that uses hashing
            //_03_DebugApplicationsAndImplementSecurity._02_PerformSymmetricAndAsymmetricEncryption.Example22.Start();

            //Using SHA256Managed to calculate a hash code
            //_03_DebugApplicationsAndImplementSecurity._02_PerformSymmetricAndAsymmetricEncryption.Example23.Start();

            //Signing and verifying data with a certificate
            //_03_DebugApplicationsAndImplementSecurity._02_PerformSymmetricAndAsymmetricEncryption.Example24.Start();

            //Declarative CAS
            //_03_DebugApplicationsAndImplementSecurity._02_PerformSymmetricAndAsymmetricEncryption.Example25.Start();

            //Imperative CAS
            //_03_DebugApplicationsAndImplementSecurity._02_PerformSymmetricAndAsymmetricEncryption.Example26.Start();

            //Initializing a SecureString
            //_03_DebugApplicationsAndImplementSecurity._02_PerformSymmetricAndAsymmetricEncryption.Example27.Start();

            //Getting the value of a SecureString
            //_03_DebugApplicationsAndImplementSecurity._02_PerformSymmetricAndAsymmetricEncryption.Example28.Start();

            #endregion

            #region Chapter03 - ManageAssemblies

            //Inspecting the public key of a signed assembly
            //_03_DebugApplicationsAndImplementSecurity._03_ManageAssemblies.Example29.Start();

            //Redirecting assembly bindings to a newer version
            //_03_DebugApplicationsAndImplementSecurity._03_ManageAssemblies.Example30.Start();

            //Specifying additional locations for assemblies
            //_03_DebugApplicationsAndImplementSecurity._03_ManageAssemblies.Example31.Start();

            //Specifying additional locations for assemblies
            //_03_DebugApplicationsAndImplementSecurity._03_ManageAssemblies.Example32.Start();

            #endregion

            #region Chapter03 - DebugAnApplication
            //A simple console application
            //_03_DebugApplicationsAndImplementSecurity._04_DebugAnApplication.Example33.Start();

            //Checking for the debug symbol
            //_03_DebugApplicationsAndImplementSecurity._04_DebugAnApplication.Example34.Start();

            //Defining a custom symbol
            //_03_DebugApplicationsAndImplementSecurity._04_DebugAnApplication.Example35.Start();

            //Using preprocessor directives to target multiple platforms
            //_03_DebugApplicationsAndImplementSecurity._04_DebugAnApplication.Example36.Start();

            //The warning and error directives
            //_03_DebugApplicationsAndImplementSecurity._04_DebugAnApplication.Example37.Start();

            //The line directive
            //_03_DebugApplicationsAndImplementSecurity._04_DebugAnApplication.Example38.Start();

            //The pragma warning directive
            //_03_DebugApplicationsAndImplementSecurity._04_DebugAnApplication.Example39.Start();

            //Disabling and enabling specific warnings
            //_03_DebugApplicationsAndImplementSecurity._04_DebugAnApplication.Example40.Start();

            //Call a method only in a debug build
            //_03_DebugApplicationsAndImplementSecurity._04_DebugAnApplication.Example41.Start();

            //Applying the ConditionalAttribute
            //_03_DebugApplicationsAndImplementSecurity._04_DebugAnApplication.Example42.Start();

            //Applying the DebuggerDisplayAttribute
            //_03_DebugApplicationsAndImplementSecurity._04_DebugAnApplication.Example43.Start();

            //Examining PDB files
            //_03_DebugApplicationsAndImplementSecurity._04_DebugAnApplication.Example44.Start();
            #endregion

            #region Chapter03 - ImplementDiagnosticsInAnApplication

            //Using the Debug class
            //_03_DebugApplicationsAndImplementSecurity._05_ImplementDiagnosticsInAnApplication.Example45.Start();

            //Using the TraceSource class
            //_03_DebugApplicationsAndImplementSecurity._05_ImplementDiagnosticsInAnApplication.Example46.Start();

            //Configuring TraceListener.
            //_03_DebugApplicationsAndImplementSecurity._05_ImplementDiagnosticsInAnApplication.Example47.Start();

            //Using a configuration file for tracin
            //_03_DebugApplicationsAndImplementSecurity._05_ImplementDiagnosticsInAnApplication.Example48.Start();

            //Writing data to the event log
            //_03_DebugApplicationsAndImplementSecurity._05_ImplementDiagnosticsInAnApplication.Example49.Start();

            //Reading data from the event log
            //_03_DebugApplicationsAndImplementSecurity._05_ImplementDiagnosticsInAnApplication.Example50.Start();

            //Writing data to the event log
            //_03_DebugApplicationsAndImplementSecurity._05_ImplementDiagnosticsInAnApplication.Example51.Start();

            //Using the StopWatch class
            //_03_DebugApplicationsAndImplementSecurity._05_ImplementDiagnosticsInAnApplication.Example52.Start();

            //Reading data from a performance counter
            //_03_DebugApplicationsAndImplementSecurity._05_ImplementDiagnosticsInAnApplication.Example53.Start();

            //Reading data from a performance counter
            //_03_DebugApplicationsAndImplementSecurity._05_ImplementDiagnosticsInAnApplication.Example54.Start();
            #endregion

            #region Chapter04 - PerformIOOperations
            //Listing drive information
            //_04_ImplementDataAccess._01_PerformIOOperations.Example01.Start();

            //Creating a new directory
            //_04_ImplementDataAccess._01_PerformIOOperations.Example02.Start();

            //Deleting an existing directory
            //_04_ImplementDataAccess._01_PerformIOOperations.Example03.Start();

            //Setting access control for a directory
            //_04_ImplementDataAccess._01_PerformIOOperations.Example04.Start();

            //Building a directory tree
            //_04_ImplementDataAccess._01_PerformIOOperations.Example05.Start();

            //Moving a directory
            //_04_ImplementDataAccess._01_PerformIOOperations.Example06.Start();

            //Listing all the files in a directory
            //_04_ImplementDataAccess._01_PerformIOOperations.Example07.Start();

            //Deleting a file
            //_04_ImplementDataAccess._01_PerformIOOperations.Example08.Start();

            //Moving a file
            //_04_ImplementDataAccess._01_PerformIOOperations.Example09.Start();

            //Copying a file
            //_04_ImplementDataAccess._01_PerformIOOperations.Example10.Start();

            //Don’t manually concatenate strings to form a file path
            //_04_ImplementDataAccess._01_PerformIOOperations.Example11.Start();

            //Using Path.Combine
            //_04_ImplementDataAccess._01_PerformIOOperations.Example12.Start();

            //Using other Path methods to parse a path
            //_04_ImplementDataAccess._01_PerformIOOperations.Example13.Start();

            //Create and use a FileStream
            //_04_ImplementDataAccess._01_PerformIOOperations.Example14.Start();

            //Using File.CreateText with a StreamWrite
            //_04_ImplementDataAccess._01_PerformIOOperations.Example15.Start();

            //Opening a FileStream and decode the bytes to a string
            //_04_ImplementDataAccess._01_PerformIOOperations.Example16.Start();

            //Opening a TextFile and reading the content
            //_04_ImplementDataAccess._01_PerformIOOperations.Example17.Start();

            //Compressing data with a GZipStream
            //_04_ImplementDataAccess._01_PerformIOOperations.Example18.Start();

            //Using a BufferedStream
            //_04_ImplementDataAccess._01_PerformIOOperations.Example19.Start();

            //Depending on File.Exists when reading file content
            //_04_ImplementDataAccess._01_PerformIOOperations.Example20.Start();

            //Using exception handling when opening a file
            //_04_ImplementDataAccess._01_PerformIOOperations.Example21.Start();

            //Executing a web request
            //_04_ImplementDataAccess._01_PerformIOOperations.Example22.Start();

            // Writing asynchronously to a file
            //_04_ImplementDataAccess._01_PerformIOOperations.Example23.Start();

            //Executing an asynchronous HTTP request
            //_04_ImplementDataAccess._01_PerformIOOperations.Example24.Start();

            //Executing multiple awaits
            //_04_ImplementDataAccess._01_PerformIOOperations.Example25.Start();

            //Executing multiple requests in parallel
            //_04_ImplementDataAccess._01_PerformIOOperations.Example26.Start();
            #endregion

            #region Chapter04 - ConsumeData
            //SqlConnection with a using statement to automatically close it
            //_04_ImplementDataAccess._02_ConsumeData.Example27.Start();

            //Creating a connection string with SqlConnectionStringBuilder
            //_04_ImplementDataAccess._02_ConsumeData.Example28.Start();

            //Putting a connection string in the app.config fil
            //_04_ImplementDataAccess._02_ConsumeData.Example29.Start();

            //Using a connection string from an external configuration file
            //_04_ImplementDataAccess._02_ConsumeData.Example30.Start();

            //Using SQL script to create a table
            //_04_ImplementDataAccess._02_ConsumeData.Example31.Start();

            //Executing a SQL select command
            //_04_ImplementDataAccess._02_ConsumeData.Example32.Start();

            //Executing a SQL query with multiple result sets
            //_04_ImplementDataAccess._02_ConsumeData.Example33.Start();

            //Updating rows with ExecuteNonQuery
            //_04_ImplementDataAccess._02_ConsumeData.Example34.Start();

            //Inserting values with a parameterized query
            //_04_ImplementDataAccess._02_ConsumeData.Example35.Start();

            //Using a TransactionScope
            //_04_ImplementDataAccess._02_ConsumeData.Example36.Start();

            //A simple Person class
            //_04_ImplementDataAccess._02_ConsumeData.Example37.Start();

            // Using Code First to map a class to the database
            //_04_ImplementDataAccess._02_ConsumeData.Example38.Start();

            //A simple WCF web service
            //_04_ImplementDataAccess._02_ConsumeData.Example39.Start();

            //A generated WCF proxy client
            //_04_ImplementDataAccess._02_ConsumeData.Example40.Start();

            //Using a WCF proxy client
            //_04_ImplementDataAccess._02_ConsumeData.Example41.Start();

            //XML file
            //_04_ImplementDataAccess._02_ConsumeData.Example42.Start();

            //Parsing an XML file with an XmlReader
            //_04_ImplementDataAccess._02_ConsumeData.Example43.Start();

            //Creating an XML file with XmlWriter
            //_04_ImplementDataAccess._02_ConsumeData.Example44.Start();

            //Using XmlDocument
            //_04_ImplementDataAccess._02_ConsumeData.Example45.Start();

            //Using an XPath query
            //_04_ImplementDataAccess._02_ConsumeData.Example46.Start();

            //A sample JSON file
            //_04_ImplementDataAccess._02_ConsumeData.Example47.Start();

            //Creating and initializing an object
            //_04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects.Example48.Start();

            //Using an object initializer
            //_04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects.Example49.Start();

            //Using a collection initializer
            //_04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects.Example50.Start();

            // Using an anonymous method
            //_04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects.Example51.Start();

            //Using an extension method
            //_04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects.Example52.Start();

            //Creating an anonymous type
            //_04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects.Example53.Start();
            #endregion


            //var currentPath = Environment.CurrentDirectory.Replace("\\bin\\Debug", string.Empty);
            //new CodeGenerator()
            //    .GenerateDefaultClass(
            //    $"{currentPath}\\04-ImplementDataAccess\\03-QueryAndManipulateDataAndObjects\\Example53.cs",
            //    "Example53",
            //    "Certification70_483._04_ImplementDataAccess._03_QueryAndManipulateDataAndObjects");
        }
    }
}
