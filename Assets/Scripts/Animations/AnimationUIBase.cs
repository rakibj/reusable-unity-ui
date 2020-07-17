using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class AnimationUIBase : ScriptableObject
{
    public abstract void Animate(Image image, float duration, Action onCompleteEvent = null);
}
