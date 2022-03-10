using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript
{
    public string name;
    public int exp = 0;

    public CharacterScript()
    {
        Reset();
        name = "Not Assigned";

    }

    public CharacterScript(string name)
    {
        this.name = name;
    }

    public virtual void PrintStatsInfo()
    {
        Debug.LogFormat("Hero: {0} - {1} EXP", name, exp);

    }

    private void Reset()
    {
        this.name = "Not Assigned";
        this.exp = 0;
    }
}

