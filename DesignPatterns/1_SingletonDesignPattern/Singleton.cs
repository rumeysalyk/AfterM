using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T>: MonoBehaviour where T : Singleton<T>
{
    /*
        In c#, the **lock** keyword is useful to acquire the mutual-exclusion of lock for the specified block of code to make sure that at a time, only one thread can execute it.

        If any other thread wants to execute the same piece of code, then it should wait until the thread that holds the lock finishes its execution.

        Generally, the `lock` keyword is useful while working with [multithreading](https://www.tutlane.com/tutorial/csharp/multithreading-in-csharp) applications to make sure that at a time, the only thread can access the particular piece of code.
        Source :https://www.tutlane.com/
    */
    private static volatile T instance;

    public static T Instance
    {
        get
        {
            if (instance is null)
                instance = FindObjectOfType( typeof(T)) as T;
            return instance;
        }
    } 

}
