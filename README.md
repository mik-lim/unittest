# unittest

This is an example about unittest using .NET and **Xunit**.

There is a Controller named **CalcController** which has a method named **CalculateSum**.
That method returns a sum of to integers.

You can call the Controller like https://.../api/calc/5/6

And then the response should be {'sum' : 11}

The test is written in file UnitTest1.cs

You can run the test with the command **dotnet test**

In order to use **Xunit** you have to include below lines to **csproj**
<pre>
&lt;ItemGroup&gt;
    &lt;PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.1.0" /&gt;
    &lt;PackageReference Include="xunit" Version="2.4.1" /&gt;
    &lt;PackageReference Include="xunit.runner.visualstudio" Version="2.4.3"&gt;
      &lt;IncludeAssets&gt;runtime; build; native; contentfiles; analyzers; buildtransitive&lt;/IncludeAssets&gt;
      &lt;PrivateAssets&gt;all&lt;/PrivateAssets&gt;
    &lt;/PackageReference&gt;
    &lt;PackageReference Include="coverlet.collector" Version="3.1.2"&gt;
      &lt;IncludeAssets&gt;runtime; build; native; contentfiles; analyzers; buildtransitive&lt;/IncludeAssets&gt;
      &lt;PrivateAssets&gt;all&lt;/PrivateAssets&gt;
    &lt;/PackageReference&gt;
 &lt;/ItemGroup&gt;
</pre>

  ## Heroku and GitHub 

  You can enable the option "Wait for CI to pass before deploy in Heroku.
  And then in GitHub inside your repo click **Actions** and choose the .NET
  and click Configure.

  And then every time you push to GitHub, it runs the test and if the tests fails, Heroku application is not updated.