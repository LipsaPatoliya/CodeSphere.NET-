using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDemoTask
{
    abstract class person 
    {
        public string firstname;
        public string lastname;
        public int age;
        public long phonenumber;

        public abstract void printDetails(); 
       

    }
    class student : person
    {
        public int RollNo;
        public int fees;

        public override void printDetails()
        {
            string  name =this.firstname + " " + this.lastname;
            Console.WriteLine("Student Name :{0}",name);
            Console.WriteLine("student age :{0}",this.age);
            Console.WriteLine("Student phone number :{0}",this.phonenumber);
            Console.WriteLine("student Rollnum :{0}",this.RollNo);
            Console.WriteLine("student fees :{0}",this.fees);
        }
    }
    class teacher :person 
    {
        public string qulification;
        public int salary;
        public override void printDetails()
        {
            string name = this.firstname + " " + this.lastname;
            Console.WriteLine("teacher Name :{0}", name);
            Console.WriteLine("teache age :{0}", this.age);
            Console.WriteLine("teacher phone number :{0}", this.phonenumber);
            Console.WriteLine("teacher qulification :{0}", this.qulification);
            Console.WriteLine("teacher salar :{0}",this.salary);

        }

    }
    internal class AbstractClassDemo
    {
        static void Main() 
        { 
            student st=new student();
            st.firstname = "Aliyana";
            st.lastname = "sharma";
            st.age = 23;
            st.fees = 200000;
            st.phonenumber = 2346688754643;
            st.RollNo = 32;
            st.printDetails();
            Console.WriteLine("------------------------");

            teacher tec=new teacher();
            tec.firstname = "Ramiya";
            tec.lastname = "Shastri";
            tec.age = 40;
            tec.salary = 2000000;
            tec.phonenumber = 46384639234;
            tec.qulification = "Masters in computer sciences";
            tec.printDetails();
           
            st.printDetails();

        }
    }
}
