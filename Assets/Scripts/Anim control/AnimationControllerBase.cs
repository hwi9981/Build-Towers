using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;

public class AnimationControllerBase : MonoBehaviour
{
    [SerializeField] protected SkeletonAnimation anim;

    protected string currentAnim = "";

    protected void PlayAnimation(string animName, bool isLoop = true, float timeScale = 1)
    {
        if (currentAnim != animName)
        {
            currentAnim = animName;
            anim.AnimationState.SetAnimation(0, animName, isLoop).TimeScale = timeScale;
        }
    }
}
