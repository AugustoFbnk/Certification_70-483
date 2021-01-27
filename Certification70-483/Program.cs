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
            //_02_CreateAndUseTypes.CreateTypes.Example01.Start();

            //Creating a custom struct
            //_02_CreateAndUseTypes.CreateTypes.Example02.Start();

            //Calling a method
            //_02_CreateAndUseTypes.CreateTypes.Example03.Start();

            //Creating a method
            //_02_CreateAndUseTypes.CreateTypes.Example04.Start(2, 2);

            //Passing a complete customer to a method
            //_02_CreateAndUseTypes.CreateTypes.Example05.Start();

            //Passing only an address to a method
            //_02_CreateAndUseTypes.CreateTypes.Example06.Start();

            //Using named and optional arguments
            //_02_CreateAndUseTypes.CreateTypes.Example07.Start();

            //Returning data from a method
            //_02_CreateAndUseTypes.CreateTypes.Example08.Start();

            //Declaring and using a field
            //_02_CreateAndUseTypes.CreateTypes.Example09.Start();

            //Creating a collection such as a Deck class
            //_02_CreateAndUseTypes.CreateTypes.Example10.Start();

            //Adding a constructor to your type
            //_02_CreateAndUseTypes.CreateTypes.Example11.Start();

            //Chaining constructors
            //_02_CreateAndUseTypes.CreateTypes.Example12.Start();

            //Generic Nullable<T> implementation
            //_02_CreateAndUseTypes.CreateTypes.Example13.Start();

            //Using a where clause on a class definition
            //_02_CreateAndUseTypes.CreateTypes.Example14.Start();

            //Using default(T) with a generic type parameter
            //_02_CreateAndUseTypes.CreateTypes.Example15.Start();

            //Creating an extension method
            //_02_CreateAndUseTypes.CreateTypes.Example16.Start();

            //Overriding a virtual method
            //_02_CreateAndUseTypes.CreateTypes.Example17.Start();

            //Using the sealed keyword on a method
            _02_CreateAndUseTypes.CreateTypes.Example18.Start();

            #endregion
        }
    }
}
