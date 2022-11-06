using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Warrior : MonoBehaviour
{
    float hp;
    float maxHP;
    int rage;
    int maxRage = 100;

    Animator ani;
    Transform swordLocation;
    Collider swordCollider;

    public int Rage
    {
        get => rage;
        private set
        {
            rage = value;      
            if (rage >= maxRage)
            {
                rage = maxRage;
            }
        }
    }

    private void Awake()
    {
        ani = GetComponent<Animator>();
        swordLocation = GetComponentInChildren<SwordLocation>().transform;
        swordCollider = swordLocation.GetChild(1).GetComponent<Collider>();
    }

    private void Start()
    {
        Rage = 0;
        maxRage = 100;
    }

    public void Q_Skill()
    {
        Rage += 15;
        swordCollider.enabled = true;
        ani.SetTrigger("QTrigger");
    }

    public void W_Skill()
    {
        Debug.Log($"현재 분노는 {Rage}입니다");
    }

    public void E_Skill()
    {

    }

    public void R_Skill()
    {

    }

    public void SwordColliderOff()
    {
        swordCollider.enabled = false;
    }
}
