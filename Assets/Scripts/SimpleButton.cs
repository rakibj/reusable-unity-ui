using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class SimpleButton : MonoBehaviour
{
    [SerializeField] private AnimationUIBase animationUI;
    [SerializeField] private float duration = 0.2f;
    private Button _button;
    private Image _buttonImage;

    private void Awake()
    {
        _button = GetComponent<Button>();
        _buttonImage = GetComponent<Image>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(OnClick);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnClick);
    }

    private void OnClick()
    {
        animationUI.Animate(_buttonImage, duration);
    }
}
