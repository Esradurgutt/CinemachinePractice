using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = Input.GetKey(KeyCode.W);
        animator.SetBool("IsWalking", isWalking);

        bool isRunning = Input.GetKey(KeyCode.LeftShift) && isWalking;
        animator.SetBool("IsRunning", isRunning);
    }
}