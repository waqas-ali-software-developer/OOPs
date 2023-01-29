using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using GrocessaryApp.Database;

namespace GrocessaryApp.GenericClass
{
    //Generic Clas
    //Advantages is reusablity
    /*Constriaints:
     * internal class DatawareHouse<DataType> where DataType : class
     * 
     * Generics increase the reusability of the code. You don't need to write code to handle different data types.
Generics are type-safe. You get compile-time errors if you try to use a different data type than the one specified in the definition.
     */
    internal class DatawareHouse<DataType> where DataType: class
    {
        public DataType Data;// public Instructor Data;
        public int Id;
        //public Instructor Data;
        public DataType CustomData{ get; set; } //public Instructor CustomData{ get; set; }
        //public Instructor CustomData

        public void SaveDatawareHouse(DataType anyType)
        {
           
                Console.WriteLine(anyType);
           
            //we can save into database

        }
    }
    internal class DatawareHouseInt
    {
        public int Data;//generic field
        public int Id;
        //public Instructor Data;
        public int CustomData { get; set; }
        //public Instructor CustomData

        public void SaveDatawareHouse(int anyType)
        {
            //we can save into database

        }
    }
    internal class DatawareHouseString
    {
        public string Data;//generic field
        public int Id;
        //public Instructor Data;
        public int CustomData { get; set; }
        //public Instructor CustomData

        public void SaveDatawareHouse(string anyType)
        {
            //we can save into database

        }
    }
    internal class DatawareHouseInstructor
    {
        public Instructor Data;//generic field
        public int Id;
        //public Instructor Data;
        public Instructor CustomData { get; set; }
        //public Instructor CustomData

        public void SaveDatawareHouse(Instructor anyType)
        {
            //we can save into database

        }
    }
    public class GenericExample
    {
        public int id;

        public static void DisplayNumbers(int firstNum, int secondNum)
        {
            Console.WriteLine($"firstNum {firstNum} secondNum {secondNum}");
        }

        public static void DisplayName(string firstName, string secondName)
        {
            Console.WriteLine($"firstNum {firstName} secondNum {firstName}");
        }
        public static void DisplayNameAndNumber(string firstName, int secondNumber)
        {
            Console.WriteLine($"firstName {firstName} secondNumber {secondNumber}");
        }




        public static void Display<GenericDataType>(GenericDataType firstParameter, GenericDataType secondParameter) 
        {
            Console.WriteLine($"FirstParameter is {firstParameter} secondParameter is {secondParameter}");
        }

        public static void DisplayDifferentDataType<T,U>(T firstParameter, U secondParameter)
        {
            Console.WriteLine($"FirstParameter is {firstParameter} secondParameter is {secondParameter}");
        }

        public static void AddGeneric<T>( T lhs,  T rhs)
        {
            Console.WriteLine($"lhs {lhs} rhs {rhs}");
        }

        //public static void AddGeneric2<T, U>(T lhs, T rhs, U thirdParam)  
        //{
        //    Console.WriteLine($"lhs {lhs} rhs {rhs} thirdParam {thirdParam}");
        //}
    }
}