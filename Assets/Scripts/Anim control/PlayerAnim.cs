using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;

public class PlayerAnim : AnimationControllerBase
{
    [SerializeField, SpineAnimation] protected string strIdleFrown;
    [SerializeField, SpineAnimation] protected string strIdleFear;
    [SerializeField, SpineAnimation] protected string strIdleHome;   
    [SerializeField, SpineAnimation] protected string strCaught;
    [SerializeField, SpineAnimation] protected string strLostHand;
    [SerializeField, SpineAnimation] protected string strExploded;
    [SerializeField, SpineAnimation] protected string strElectricShock; 
    [SerializeField, SpineAnimation] protected string strDance_1;
    [SerializeField, SpineAnimation] protected string strDance_2;
    [SerializeField, SpineAnimation] protected string strJump;
    [SerializeField, SpineAnimation] protected string strHanging;
    [SerializeField, SpineAnimation] protected string strHoldingItem;
    [SerializeField, SpineAnimation] protected string strGrounding;
    [SerializeField, SpineAnimation] protected string strRunHappy;
    [SerializeField, SpineAnimation] protected string strRunFear;
    [SerializeField, SpineAnimation] protected string strUseItem;
    [SerializeField, SpineAnimation] protected string strWalking;

    //[SerializeField] GameObject handHolder;
    public void PlayPlayerIdleFrown()
    {
        PlayAnimation(strIdleFrown);
    }
    public void PlayPlayerIdleFear()
    {
        PlayAnimation(strIdleFear);
    }
    public void PlayPlayerIdleHome()
    {
        PlayAnimation(strIdleHome);
    }
    public void PlayPlayerCaught()
    {
        PlayAnimation(strCaught);
    }
    public void PlayPlayerLostHand()
    {
        PlayAnimation(strLostHand,false);
    }
    public void PlayPlayerExploded()
    {
        PlayAnimation(strExploded);
        //handHolder.SetActive(false);
    }
    public void PlayPlayerElectricShock()
    {
        PlayAnimation(strElectricShock);
        //SFXManager.Instance.PlayOneTime(SFXManager.Instance.femaleOuch);
        //handHolder.SetActive(false);
    }
    public void PlayPlayerDance_1()
    {
        PlayAnimation(strDance_1);
        //handHolder.SetActive(false);
    }
    public void PlayPlayerDance_2()
    {
        PlayAnimation(strDance_2);
        //handHolder.SetActive(false);
    }
    public void PlayPlayerJump()
    {
        PlayAnimation(strJump);
        //handHolder.SetActive(false);
    }
    public void PlayPlayerHanging()
    {
        PlayAnimation(strHanging);
    }
    public void PlayPlayerHoldingItem()
    {
        PlayAnimation(strHoldingItem,false);
        //handHolder.SetActive(false);
    }
    public void PlayPlayerGrounding(float timeScale = 1)
    {
        PlayAnimation(strGrounding,false,timeScale);
    }
    public void PlayPlayerRunHappy()
    {
        PlayAnimation(strRunHappy);
        //handHolder.SetActive(false);
    }
    public void PlayPlayerRunFear()
    {
        PlayAnimation(strRunFear);
        //handHolder.SetActive(false);
    }
    public void PlayPlayerUseItem()
    {
        PlayAnimation(strUseItem,false);
        //handHolder.SetActive(false);
    }
    public void PlayPlayerWalking()
    {
        PlayAnimation(strWalking);
        //handHolder.SetActive(false);
    }
    public void PlayPlayerFadeOut()
    {
        StartCoroutine(FadeOut(2));
    }
    IEnumerator FadeOut(float fadeSpeed)
    {       
        SkeletonAnimation anim = GetComponent<SkeletonAnimation>();
        while (anim.skeleton.A > 0)
        {
            anim.skeleton.A -=  fadeSpeed * Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        gameObject.SetActive(false);

    }
}
