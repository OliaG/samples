// System.Web.Services.Protocols.HttpGetClientProtocol.HttpGetClientProtocol

/* The following example demonstrates 'Constructor' of 'HttpGetClientProtocol' class
   A variable of type 'HttpGetClientProtocol' is used to set proxy information ,
   client credentials and Url on the proxy class.
*/

/*
// The following example is a proxy class generated by the Wsdl.exe 
// utility for the Math Web service. The proxy class derives from 
// HttpGetClientProtocol, which derives from the abstract 
// HttpSimpleClientProtocol class.

public class MyMath : System.Web.Services.Protocols.HttpGetClientProtocol 
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public MyMath() 
    {
        this.Url = "http://localhost/MyMath.Cs.asmx";
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Web.Services.Protocols.HttpMethodAttribute(
        typeof(System.Web.Services.Protocols.XmlReturnReader), 
        typeof(System.Web.Services.Protocols.UrlParameterWriter))]
    [return: System.Xml.Serialization.XmlRootAttribute("int", 
        Namespace="http://tempuri.org/", IsNullable=false)]
    public int Add(string num1, string num2) 
    {
        return ((int)(this.Invoke("Add", (this.Url + "/Add"), new object[] {
                    num1,
                    num2})));
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public System.IAsyncResult BeginAdd(string num1, string num2, 
        System.AsyncCallback callback, object asyncState) 
    {
        return this.BeginInvoke("Add", (this.Url + "/Add"), new object[] {
                    num1,
                    num2}, callback, asyncState);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    public int EndAdd(System.IAsyncResult asyncResult) 
    {
        return ((int)(this.EndInvoke(asyncResult)));
    }
}
*/

using System;
using System.Net;
using System.Web.Services.Protocols;
using System.Web.Services;

public class Math : HttpGetClientProtocol
{

}


public class HttpGetClientProtocolClass
{
    public static void Main()
    {
// <Snippet1>
        // Math is a proxy class derived from HttpGetClientProtocol.
        HttpGetClientProtocol myHttpGetClientProtocol = new Math();

        // Obtain password from a secure store.
        String SecurelyStoredPassword = String.Empty;

        // Set the client-side credentials using the Credentials property.
        ICredentials credentials = 
            new NetworkCredential("Joe", "mydomain", SecurelyStoredPassword);
        myHttpGetClientProtocol.Credentials = credentials;
        Console.WriteLine("Auto redirect is: "
            + myHttpGetClientProtocol.AllowAutoRedirect);
    }
}

// </Snippet1>