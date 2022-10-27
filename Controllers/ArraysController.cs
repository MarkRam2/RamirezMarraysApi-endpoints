using Microsoft.AspNetCore.Mvc;

namespace arrays_api.Controllers;

[ApiController]
[Route("[controller]")]
public class ArraysController : ControllerBase
{
    // declare an array with random numbers
    int [] myNumbers = {2,4,5,6,8,44,33,16,9};

    [HttpGet]
    [Route("even")]

    public int[] getEvenNumbers()
    {
        // we are pre filling this array with even numbers 

        int[] evenNumbers = new int[myNumbers.Length];

        for(int i = 0; i < myNumbers.Length; i++)
        {
            if(myNumbers[i] % 2 == 0)
            {
                // we want to add even numbers to even numbers array
                evenNumbers[i] = myNumbers[i]; 
            }
            ;
        }
        return evenNumbers;
    }

    [HttpGet]
    [Route("evenList")]

    public List<int> GetEvenNumbersByList()
    {
        List<int> evenList = new List<int>();
        for(int i = 0; i < myNumbers.Length; i++)
        {
            if(myNumbers[i] % 2 ==0)
            {
                // the number is even 
                // add the number to the even list
                evenList.Add(myNumbers[i]);
            }
        }
        return evenList;
    }
}
