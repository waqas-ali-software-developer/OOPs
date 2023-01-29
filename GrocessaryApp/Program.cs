using GrocessaryApp.AssociationAgregationExmp;
using GrocessaryApp.MySQL;
using GrocessaryApp.ExceptionHandlingClass;
//Exception
/*
 * try - catch
 */
//throw

try
{
    Customer customer = new Customer();
     customer.GetCustomerName();
}
catch(Exception ex)
{
    Console.WriteLine(ex.StackTrace);
}








//Employee employee1 = null;
//try
//{
//    if (employee1 == null)
//    {
//        throw new Exception("Employee is null");
//    }
//    Employee employee2 = new Employee(employee1);

//    Console.WriteLine($"Employee 1 {employee1._age} {employee1._name}");
//    Console.WriteLine($"Employee 1 {employee2._age} {employee2._name}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
Console.ReadLine();





/*
try
{
    int[] arr = new int[2];
    arr[0] = 33;
    arr[1] = 44;


    //Console.WriteLine("****************************************");
    //Console.Write("Please enter a number: ");
    //int num = Convert.ToInt32(Console.ReadLine());// Read from UI
    //int number1 = 3 / num;
    //Console.WriteLine(number1);

    Dictionary<int, int> student = new Dictionary<int, int>();
    student.Add(1, 34);
    student.Add(2,34);

    Console.WriteLine(student[3]);

}
catch (IndexOutOfRangeException indexOutOfRangeException)
{
    //when an exception occurs in try block then code will go to the catch block
    Console.WriteLine("IndexOutOfRangeException Excection:" + indexOutOfRangeException);
    //Logs(exception) 
}
catch (KeyNotFoundException keyNotFoundException)
{
    Console.WriteLine("keyNotFoundException Excection:" + keyNotFoundException);
}
catch (DivideByZeroException divideByZeroException)
{
    Console.WriteLine("DivideByZeroException: " + divideByZeroException);
}
catch (Exception exception)
{
    Console.WriteLine("This is General Exception");
}



int number2 = 4 / 2;
Console.WriteLine(number2);
Console.WriteLine("--------------*88888************8-----------------");
Console.ReadLine();
*/