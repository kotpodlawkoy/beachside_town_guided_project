using UnityEngine;

public class CharIdle : StateMachineBehaviour
{
    override public void OnStateEnter ( Animator animator, AnimatorStateInfo stateInfo, int layerIndex )
    {
        animator.SetInteger ( "IdleType", Random.Range ( 0 , 2 ) );
    }
}
