using System.Collections;
using System.Collections.Generic;
using System.IO;
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
    Player player;

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
        player = GameManager.Inst.Player;
        ani = GetComponent<Animator>();
        swordLocation = GetComponentInChildren<SwordLocation>().transform;
        swordCollider = swordLocation.GetChild(1).GetComponent<Collider>();
    }

    private void Start()
    {
        Rage = 0;
        maxRage = 100;
        player.onQ_Skill += Q_Skill;
    }

    bool Qing = false;

    void Q_Skill()
    {
        if (!Qing)
        {
            StartCoroutine(qq());
        }
        //Rage += 15;
        //swordCollider.enabled = true;
        //float inputTime = Time.time;
        //float coolTime = 3.0f;

    }

    IEnumerator qq()
    {
        Qing = true;
        ani.SetTrigger("QTrigger");


        yield return new WaitForSeconds(3.0f);

        Qing = false;
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

    void SwordColliderOff()
    {
        swordCollider.enabled = false;
    }
}
