# AspectOrientedProgramming
A few samples of Aspected Oriented Programming using PostSharp (C#)

    This tutorial is based on the offical written tutorial of Postsharp at
    http://doc.postsharp.net/logging. Please read that first if the code
    or functionality is not obvious.

**Test Console UI**
Start the AspectTestConsoleUI (mark as Startup Project)

**Expected Output in Debug Window**

    'AspectTestConsoleUI.vshost.exe' (CLR v4.0.30319: AspectTestConsoleUI.vshost.exe): Loaded '       
    
    'C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Configuration\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Configuration.dll
    '. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
    
  
    Entering: CustomerRepository.Save(this = {DataAccessLayer.CustomerRepository}, "Eric", "Brunner", "my street", "Vienna")
    
    Leaving: CustomerRepository.Save(this = {DataAccessLayer.CustomerRepository}, "Eric", "Brunner", "my street", "Vienna")     : True

The lines starting with Entering: and Leaving: are the result of the LogAttribute Aspect added to the Save
method. 

**Unit Test**

Please refer to CustomerRepositoryTests.cs in CustomerRepository.Tests and run the test

**Expected Output in Debug Window**

    ------ Run test started ------
    
    ...
    
    Entering: CustomerRepository.Save(this = {DataAccessLayer.CustomerRepository}, "Eric", "Brunner", "my street", "Vienna")
    
    See log entry in Debug->Windows->Output
    
    Leaving: CustomerRepository.Save(this = {DataAccessLayer.CustomerRepository}, "Eric", "Brunner", "my street", "Vienna") : True
    
    NUnit VS Adapter 2.0.0.0 executing tests is finished
    ========== Run test finished: 1 run (0:00:01,2092881) ==========

The lines starting with Entering: and Leaving: are the result of the LogAttribute Aspect added to the Save
method. 
