using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleSelector : StateMachineBehaviour
{
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetInteger("IdleSelector", ClipNumber());
    }

    int ClipNumber()
    {
        float percentage = Random.Range(0.0f, 1.0f);
        int num;
        if(percentage < 0.7f)
        {
            num = 0;
        }
        else if(percentage < 0.9f)
        {
            num = 1;
        }
        else
        {
            num = 2;
        }
        return num;
    }
}
