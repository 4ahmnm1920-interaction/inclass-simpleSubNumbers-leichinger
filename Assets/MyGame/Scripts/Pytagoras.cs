using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pytagoras : MonoBehaviour
{
    // Start is called before the first frame update
    public int Number;
    public float a;
    public float b;
   
    void Start()
    {
        //int result = Square(Number) * Square(Number);
       // Debug.Log("result Addition: " + result);
       Pytagoras1(3, 4);
    }

    int Square(int a)
    { 
        Debug.Log( "result Square" + a * a);
        return (a * a); 
    }

    void Pytagoras1(float a, float b)
    {
        float cSquare;
        cSquare = Mathf.Sqrt((a*a) + (b*b));
        Debug.Log ("cSquare" + cSquare);
        {
            
        }
    }
}
