using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState
{
    public List<string> currentState = new List<string>();
    public string[] statuses = new string[] {
        "dead", "frozen", "slowed", "hurt"
    };

    private bool Check(string s) {
        for (int i = 0; i < statuses.Length; i++) {
            if (Equals(s, statuses[i])) {
                return true;
            }
        }
        return false;
    }

    public void AddStatus(string s)
    {
        if (Check(s) && !currentState.Contains(s))
        {
            currentState.Add(s);
        }
    }

    public void removeStatus(string s)
    {
        if (Check(s))
        {
            currentState.Remove(s);
        }
    }

}
