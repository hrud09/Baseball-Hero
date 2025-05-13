using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animator;
 
    public void Strike()
    {
        animator.SetTrigger("Hit");
    }
}
