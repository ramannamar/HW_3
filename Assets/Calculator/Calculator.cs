
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    public float FirstNumberSum;
    public float SecondNumberSum;
    [Space]
    public float FirstNumberSub;
    public float SecondNumberSub;
    [Space]
    public float FirstNumberMult;
    public float SecondNumberMult;
    [Space]
    public float FirstNumberDiv;
    public float SecondNumberDiv;

    public void Start()
    {
        Sum();
        Subtraction();
        Multiplication();
        Division();
    }

    public void Sum()
    {
        Debug.Log("Sum result:" + (FirstNumberSum + SecondNumberSum));
    }

    public void Subtraction()
    {
        Debug.Log("Sub result:" + (FirstNumberSub - SecondNumberSub));
    }

    public void Multiplication()
    {
        Debug.Log("Mult result:" + (FirstNumberMult * SecondNumberMult));
    }

    public void Division()
    {
        Debug.Log("Div result:" + (FirstNumberDiv / SecondNumberDiv));
    }

}
