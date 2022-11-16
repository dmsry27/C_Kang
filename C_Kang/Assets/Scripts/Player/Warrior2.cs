using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Warrior2 : MonoBehaviour
{
    float hp;
    float maxHP;
    int rage;
    int maxRage = 100;

    Animator ani;
    
    Warrior player;

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
        
    }

    private void Start()
    {
        Rage = 0;
        maxRage = 100;
        player.onSkill_Q += Q_Skill;
    }

    bool Qing = false;

    void Q_Skill()
    {
        // 컬라이더 끄고 키기
        // 컬라이더를 플레이어 클래스가 끄면 좋은데 물어봐야함
        // 스킬 쿨 계산
        // 분노도 적이 맞았을때만 차야됨 : 즉 소드클래스에서 onTriggerEnter로 체크해야함
        // 어짜피 Q애니메이션 지속시간 동안은 이 함수가 다시 안켜짐 
        // 


        if (!Qing)
        {
            StartCoroutine(qq());
        }
        //swordCollider.enabled = true;
        //float inputTime = Time.time;
        //float coolTime = 3.0f;

    }

    IEnumerator qq()
    {
        Qing = true;


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

}
