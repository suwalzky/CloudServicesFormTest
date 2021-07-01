CloudServices - Using Selenium with C#.NET
===============


Attached is a test that is needed for recruiting purposes.

The tests can be executed on three browsers: Firefox, Chrome and Internet Explorer. The driver can be selected using 
the appsetting *DriverToUse* in the app.config file. To run the tests on Internet Explorer 11, the registry must be updated first so that the driver can maintain a connection to the browser. Import the registry file [configure_ie_11_for_selenium_iedriverserver.reg](https://github.com/atosorigin/SeleniumExample/blob/master/configure_ie_11_for_selenium_iedriverserver.reg) to achieve this. 

To run the Selenium test, you need to download the solution and run the NUnit tests. All selenium dependencies are included in the solution. Run the NUnit tests using Resharper ( http://www.jetbrains.com/resharper ), NUnit ( http://www.nunit.org ) or ContinuousTests ( http://continuoustests.com ).


This solution is built on a repository:
https://github.com/alexandervantrijffel/SeleniumExample

Sebastian Suwalski
