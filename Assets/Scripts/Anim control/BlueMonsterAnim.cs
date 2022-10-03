using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;
using DG.Tweening;

public class BlueMonsterAnim : AnimationControllerBase
{
    [SerializeField,SpineAnimation] protected string strIdle;
    [SerializeField, SpineAnimation] protected string strRun_1;
    [SerializeField, SpineAnimation] protected string strRun_2;
    [SerializeField, SpineAnimation] protected string strSit;
    [SerializeField, SpineAnimation] protected string strAngry;
    [SerializeField, SpineAnimation] protected string strBurn;
    [SerializeField, SpineAnimation] protected string strElectricShock;
    [SerializeField, SpineAnimation] protected string strFall;
    [SerializeField, SpineAnimation] protected string strCatchMiss;
    [SerializeField, SpineAnimation] protected string strCatchPlayer;
    void Start()
    {
        //Physics2D.IgnoreLayerCollision(13, 11);
        //Physics2D.IgnoreLayerCollision(13, 11, false);
    }

    public void PlayHuggyRun_1()
    {
        PlayAnimation(strRun_1);
    }
    public void PlayHuggyRun_2()
    {
        PlayAnimation(strRun_2);
    }
    public void PlayIdle()
    {
        PlayAnimation(strIdle);
    }
    public void PlaySit()
    {
        PlayAnimation(strSit);
    }
    public void PlayAngry()
    {
        PlayAnimation(strAngry);
    }
    public void PlayBurn()
    {
        PlayAnimation(strBurn);
    }
    public void PlayElectricShock()
    {
        PlayAnimation(strElectricShock);
        StartCoroutine(FadeOut());
    }
    public void PlayFall()
    {
        PlayAnimation(strFall);
    }
    public void PlayCatchMiss()
    {
        PlayAnimation(strCatchMiss);
    }
    public void PlayCatchPlayer()
    {
        PlayAnimation(strCatchPlayer);
    }
    public void PlayFadeIn()
    {
        StartCoroutine(FadeIn());
    }
    IEnumerator FadeOut()
    {
        yield return new WaitForSeconds(2);
        SkeletonAnimation anim = GetComponent<SkeletonAnimation>();
        while (anim.skeleton.A > 0)
        {
            anim.skeleton.A -= 2 * Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        gameObject.SetActive(false);
        
    }
    IEnumerator FadeIn()
    {
        SkeletonAnimation anim = GetComponent<SkeletonAnimation>();
        anim.skeleton.A = 0;
        gameObject.SetActive(true);
        
        while (anim.skeleton.A < 1)
        {
            anim.skeleton.A += 2 * Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }       
    }
}
