using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem_1 : MonoBehaviour
{
    //Call your custom functions and print out the returns values of boxes 12,4 and 13.5f by 1.3f.
    //You should have 48 and 17.55 as your return print outs. 
    void Start()
    {
        print("Perimeter of 12 x 4: " + Perimeter(12, 4));
        print("Perimeter of 13.5 x 1.3: " + Perimeter(13.5f, 1.3f));
        print("Area of 12 x 4: " + Area(12, 4));
        print("Area of 13.5 x 1.3: " + Area(13.5f, 1.3f));
    }

    //Part 1: 
    //Create a function called Perimeter that takes in two parameters of int length and int width
    //Calculate the perimeter of the box and return the value as an int.
    int Perimeter(int length, int width)
    {
        return 2 * length + 2 * width;
    }

    int Area(int length, int width)
    {
        return length * width;
    }

    //Part 2: 
    //Overload the function by creating a float version of the same function 
    float Perimeter(float length, float width)
    {
        return 2 * length + 2 * width;
    }

    float Area(float length, float width)
    {
        return length * width;
    }
}
