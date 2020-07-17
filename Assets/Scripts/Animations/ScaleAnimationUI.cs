using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "UIAnimation/ Scale", fileName = "ScaleAnim")]
public class ScaleAnimationUI : AnimationUIBase
{
    public float scaleFactor = 1.2f;
    public override void Animate(Image image, float duration, Action onCompleteEvent = null)
    {
        var sequence = DOTween.Sequence();
        var tween = image.transform.DOScale(scaleFactor, duration).SetLoops(2, LoopType.Yoyo);

        sequence.Append(tween);

        tween.OnComplete(() => { onCompleteEvent?.Invoke(); });
    }
}
