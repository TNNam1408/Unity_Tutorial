using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{
    private int _playerHealth = 100;
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

    public string DisplayHealthPercentage
    {
        get
        {
            return _playerHealth.ToString() + "%";
        }
    }

    //public int PlayerHealth { get; set; }

    private void Start()
    {
        //Debug with Debug.Log console.
        TakeDamage(49);
        Debug.Log("TakeDamage: " + PlayerHealth);
        Debug.Log("ShowDamage: " + ShowDamage());
    }

    void TakeDamage(int dama)
    {
        PlayerHealth -= dama;
    }

    bool ShowDamage()
    {

        PlayerHealth -= 10;
        return true;
    }
}
