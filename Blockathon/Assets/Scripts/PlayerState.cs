using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    public List<string> currentState = new List<string>();
    public string[] statuses = new string[] {
        "dead", "frozen", "slowed", "hurt"
    };

    private bool check(string s) {
        for (int i = 0; i < statuses.Length; i++) {
            if (Equals(s, statuses[i])) {
                return true;
            }
        }
        return false;
    }

    public void addStatus(string s)
    {
        if (check(s) && !currentState.Contains(s))
        {
            currentState.Add(s);
        }
    }

    public void removeStatus(string s)
    {
        if (check(s))
        {
            currentState.Remove(s);
        }
    }

}
