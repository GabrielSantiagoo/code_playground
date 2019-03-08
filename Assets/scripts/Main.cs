using System;
using UnityEngine;

public class Main : MonoBehaviour 
{
    public int a = 1;
    public int b = 8;
    public int c = -9;

    private void Start()
    {
        equacao2grau();
    }

    private void equacao2grau(int delta = 0, double baska = 0, double baska2 = 0)
    {
        delta = (b * b) - (4 * a * c);
        baska = (-b + Math.Sqrt(delta)) / (2 * a);
        baska2 = (-b - Math.Sqrt(delta)) / (2 * a);
        Debug.Log(baska);
        Debug.Log(baska2);
    }

}
