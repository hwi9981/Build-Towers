using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimController : MonoBehaviour
{
    [SerializeField] PlayerAnim playerAnim;
    [SerializeField] float groundingSpeed = 2;
    private void OnMouseDown()
    {
        playerAnim.PlayPlayerHanging();
    }
    private void OnMouseUp()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    IEnumerator JumpAnim()
    {
        playerAnim.PlayPlayerJump();
        yield return new WaitForSeconds(0.5f);
        playerAnim.PlayPlayerGrounding(groundingSpeed);
    }
}
