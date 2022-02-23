using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{

    public bool Chapter4Active = false;
    public bool SelfActive = false;

    public bool hasDungeonKey = false;
    public int CurrentGold = 32;
    //public string weaponType = "Arcane Staff";

    public bool weaponEquipped = true;
    public string weaponType = "Longsword";



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
    public bool active = false;

    [SerializeField] string CollegeName = "Davidson College";

    // Start is called before the first frame update
    void Start()
    {

        if (SelfActive)
        {
            SelfCode();
        }

        if (Chapter4Active)
        {

            Chapter4();
        }
        

    }

    void Chapter4()
    {
        int[] topPlayerScores = { 713, 549, 984 };
        int score = topPlayerScores[1];
        topPlayerScores[1] = 1001;

        List<string> QuestPartyMembers = new List<string>()
        {
            "Grim the Barbarian",
            "Merlin the Wise",
            "Sterling the Knight"
        };

        Dictionary<string, int> ItemInventory = new Dictionary<string, int>()
        {
            {"Potion",5},
            {"Antidote", 7},
            {"Aspirin", 1}
        };

        Thievery();

        if (!hasDungeonKey)
        {
            Debug.Log("You may not enter without the sacred key.");

        }

        if (weaponType != "Longsword")
        {
            Debug.Log("You don't appear to have the right type of weapon...");
        }

        if (weaponEquipped)
        {
            if (weaponType == "Longsword")
            {
                Debug.Log("For the Queen!");

            }

            else
            {
                Debug.Log("Fists aren't going to work against armor...");
            }
        }


        if (weaponEquipped && weaponType == "Longsword")
        {
            Debug.Log("For the Queen!(2)");
        }

        void Thievery()
        {
            if (CurrentGold > 50)
            {
                Debug.Log("You're rolling in it!");

            }

            else if (CurrentGold < 15)
            {
                Debug.Log("Not much there to steal...");

            }

            else
            {
                Debug.Log("Looks like your puse is the sweet spot.");
            }
        }

        Debug.LogFormat("Party Members: {0}", QuestPartyMembers.Count);

        for(int i = 0; i< QuestPartyMembers.Count; i++)
        {
            if(i == 2)
            {
                Debug.Log("Party Member at index " + i.ToString() +" "+ QuestPartyMembers[i]);
            }
        }

        foreach(string member in QuestPartyMembers)
        {
            Debug.LogFormat("{0} - Here!",member);
        }

        foreach (KeyValuePair<string,int> kvp in ItemInventory)
        {
            Debug.LogFormat("Item: {0} - Value {1}", kvp.Key, kvp.Value);
        }

       
    }
    


    public void SelfCode()
    {
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

        void SwitchTest()
        {
            switch (active)
            {

                case true:
                    Debug.Log("Active Switch");
                    break;
                case false:
                    Debug.Log("Inactive Switch");
                    break;
            }


        }

        if (active)
        {
            Debug.Log(StudentDebug(Student, StudentName, StudentAge, Worker));
            Debug.Log(string.Format("I have {0} year/s left of college.", YearsUntilGraduation(YearsAtCollege)));
        }

        SwitchTest();

    }


   



     

    // Update is called once per frame
    void Update()
    {
        
    }
}
