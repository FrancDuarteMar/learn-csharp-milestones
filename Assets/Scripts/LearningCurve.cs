using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{

    /*
     * My initial decalartion of variables. 
     * They all currently have my own information. 
     */
    public int StudentAge;//My initial starting age! 
    public string StudentName;
    public bool Student;
    private int YearsOfCollege = 4;
    public int YearsAtCollege;
    public bool Worker;

    [SerializeField] string CollegeName = "Davidson College";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(StudentDebug(Student,StudentName, StudentAge,Worker));
        Debug.Log(string.Format("I have {0} year/s left of college.", YearsUntilGraduation(YearsAtCollege)));
    }


    /// <summary>
    /// Prints the students name, age and whether they are a studnet at
    /// Davidson College.
    /// </summary>
    /// <param name="isStudent"> Boolean representing if the person is a student
    /// at davidson college</param>
    /// <param name="Age"> Integer representing the age of the student</param>
    /// <param name="Name">String representing thename of the student</param>
    /// <returns>A statement describing the student.</returns>
    string StudentDebug(bool isStudent, string Name, int Age, bool IsWorker)
    {
        string Statement;
        Statement = string.Format("My name is {0}. I am {1} years old", Name, Age);

        if (isStudent)
        {
            if (!IsWorker)
            {
                Statement += " and I am a student at " + CollegeName + " !";

            }
            else
            {
                Statement += " and I am a student at " + CollegeName + "and a worker!";

            }

        }
        else if (IsWorker)
        {
            Statement += " and I am a worker!";
        }
        else
        {
            Statement += " and I am NOT a student at " + CollegeName + " !";
        }


        return (Statement);
    }

    /// <summary>
    /// Gives the amount of years remaining for a student in a traditional 4 year college.
    /// </summary>
    /// <param name="YearsInCollege">Integer representing the total amount of years a student has been in college</param>
    /// <returns>The amount of years left in college</returns>

    int YearsUntilGraduation(int YearsInCollege)
    {
        int YearsLeft = YearsOfCollege - YearsInCollege;
        

        return YearsLeft;
    }



     

    // Update is called once per frame
    void Update()
    {
        
    }
}
