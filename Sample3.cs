public class Sample3{

    public static void Main(string[] args){

        string PersonName;
        int age;

        // Find the person is eligible for getting Driving License or not (18 or above)
        // Complete the program and push into Github and Bitbucket

        /*
          if(age )
          Console.WriteLine("");
          else
          Console.WriteLine("");
        */
        
        Console.WriteLine("Enter your name: ");
        PersonName=Console.ReadLine();
        //laevi code
        Console.WriteLine("Enter the Age : ");
        age=Convert.ToInt32(Console.ReadLine());
        //Nithya

        //checking the eligible for getting Driving License or not (18 or above)
        if(age>18){
          //Checking above 18
          Console.WriteLine(PersonName+" is eligible for applying the driving licences");
        }

    }
}