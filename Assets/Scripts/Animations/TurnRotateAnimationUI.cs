using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "UIAnimation/ Turn Rotate", fileName = "TurnRotateAnim")]
public class TurnRotateAnimationUI : AnimationUIBase
{
    [SerializeField] private float angle = -30f;

    public override void Animate(Image image, float duration, Action onCompleteEvent = null)
    {
        var sequence = DOTween.Sequence();
        
        Tween tween = image.transform.DORotate(Vector3.forward * angle, duration/2f)
            .SetLoops(2, LoopType.Yoyo);
        
        sequence.Append(tween);
        sequence.OnComplete(() =>
        {
            image.transform.rotation = Quaternion.identity;
            onCompleteEvent?.Invoke();
        });
    }
}
