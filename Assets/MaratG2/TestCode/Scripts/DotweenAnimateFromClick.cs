using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using MaratG2.TestCode.Handlers;
using UnityEngine;

namespace MaratG2.TestCode
{
    [RequireComponent(typeof(ClickTargetHandler))]
    public class DotweenAnimateFromClick : MonoBehaviour
    {
        [SerializeField] private DOTweenAnimation _doTweenAnimation;
        private ClickTargetHandler _clickTargetHandler;

        private void Awake()
        {
            _clickTargetHandler = GetComponent<ClickTargetHandler>();
        }

        private void OnEnable()
        {
            _clickTargetHandler.OnClick += _doTweenAnimation.DORewind;
            _clickTargetHandler.OnClick += _doTweenAnimation.DOPlay;
        }
        private void OnDisable()
        {
            _clickTargetHandler.OnClick -= _doTweenAnimation.DORewind;
            _clickTargetHandler.OnClick -= _doTweenAnimation.DOPlay;
        }
    }
}