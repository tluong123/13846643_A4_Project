using UnityEngine;

public class BorderAnim: MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        
        animator.SetTrigger("MoveImage");
    }
    
}