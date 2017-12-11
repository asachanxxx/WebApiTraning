using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
  

    public class A
    {
        int nonAccisible = 100;
        protected int onliVisibleToDirrivedClasses = 200;
        public int Variable = 10;

        public string Method1()
        {
            Console.WriteLine("nonAccisible" + nonAccisible.ToString());
            return "Class A";
            
        }

        //poly

        public virtual string Dowork() {
            return "Work Complete iside Class A";
        }

        //overide a base class object's ToString method
        public override string ToString()
        {
            return base.ToString() + " Wenas Kala Hitan";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }

    public class B : A
    {

        public int VariableB = 10;

        public B()
        {
            Variable = 20;
            this.VariableB = Variable;
            onliVisibleToDirrivedClasses = 300;
            //nonAccisible = 500 //Compilor Error cannot access due to protection level
        }

        public string MethodB()
        {
            return "Class B";
        }

        //ploy
        public override string Dowork()
        {
            return base.Dowork() + " - Tracked in class B";
        }

        
    }


    public class Example
    {
        public  string ReturnMain()
        {
            B b = new B();
            return b.Method1() + " - " + b.Variable ;
        }

        public string ReturnValues()
        {
            B b = new B();
            return b.MethodB() + " - " + b.VariableB;
        }
    }
}
