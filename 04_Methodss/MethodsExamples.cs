using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Methodss
{
    [TestClass]
    public class MethodsExamples
    {

        //Acess Modifier...returnType---method Signature(Name and list of parameters)
        public string FullName(String Fname,string Lname)
        {
            string fullname = Fname + ' ' + Lname;
            return fullname;
        }
        [TestMethod]
        public void TestMethod1()
        {
            var x = FullName("Dawit", "Meaza");
            Console.WriteLine(x);
        }
    }
}
