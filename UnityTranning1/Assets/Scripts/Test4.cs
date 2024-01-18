using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test4 : MonoBehaviour
{
    private int _playerHealth = 100;
    private int _playerSeild = 50;

    public int PlayerHealth
    {
        get
        {
            return _playerHealth;
        }
        set
        {
            _playerHealth = value;
        }
    }

    public int PlayerSeild
    {
        get
        {
            return _playerSeild;
        }
        set
        {
            _playerSeild = value;
        }
    }

    private void Start()
    {
        Debug.Log("You took " + DamageTaken(80) + " in damage.");
    }

    int DamageTaken(int damage)
    {
        int damageTaken;

        if (damage < PlayerSeild)
        {
            Debug.Log("Seild not destroyed!");
            damageTaken = 0;
        }
        else if (damage == PlayerSeild)
        {
            Debug.Log("Seild destroyed!");
            damageTaken = 0;
        }
        else
        {
            Debug.Log("Seild destroyed and damage taken!");
            damageTaken = damage - PlayerSeild;
        }

        return damageTaken;
    }
}
