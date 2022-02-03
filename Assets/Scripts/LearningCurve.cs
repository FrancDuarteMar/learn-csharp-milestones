using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{

    /*
     * My initial decalartion of variables. 
     * They all currently have my own information. 
     */
    public int Age = 21;//My initial starting age! 
    public string Name = "Francisco";
    public bool Student = true;
    // Start is called before the first frame update
    void Start()
    {
        StudentDebug();   
    }
    /// <summary>
    /// Prints the users name, age and whether they're a student
    /// Davidson College or not
    /// </summary>
    void StudentDebug()
    {
        string Statement = " ";
        Statement += "My name is " + Name + ". ";
        Statement += "I am " + Age + " years old. ";

        if (Student)
        {
            Statement += "I am a student at Davidsn College!";

        }
        else
        {
            Statement += "I am NOT a student at Davidson College!";
        }

        Debug.Log(Statement);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
