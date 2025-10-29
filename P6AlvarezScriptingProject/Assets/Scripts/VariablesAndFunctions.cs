using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{

    //create an integer variable 
   public int myInt = 5;

    // Start is called before the first frame update
    void Start()
    {
        //run the variable throughg my function
        myInt = MultiplyByTwo(myInt);

        //disply the result in the console
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    //Creating my Function
    int MultiplyByTwo (int number)
    {
        //creating a results varible
        int result;
        result = number * 2;
        
        //return the results
        return result;
    }
}
