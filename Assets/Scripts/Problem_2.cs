using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem_2 : MonoBehaviour
{
    //Call your function using an int[] array = new int[10]{1,2,3,4,5,6,7,8,9,10};
    //Your return values should be a List<int> that holds {1,3,5,7,9}
    void Start()
    {
        int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> list = OnlyOddOnes(array);

        string output = "[";
        foreach (int i in array)
        {
            output += i;
            output += ", ";
        }
        output = output.Substring(0, output.Length - 2);
        output += "]";

        print("Before function: " + output);

        output = "[";
        foreach (int i in list)
        {
            output += i;
            output += ", ";
        }
        output = output.Substring(0, output.Length - 2);
        output += "]";

        print("After function: " + output);
    }

    //Create a function called OnlyOddOnes that takes in an int array as a parameter and returns 
    //a List of integers that were odd inside the array
    List<int> OnlyOddOnes(int[] array)
    {
        List<int> list = new List<int>();
        foreach (int i in array)
        {
            if (i % 2 == 1)
            {
                list.Add(i);
            }
        }
        return list;
    }

}
