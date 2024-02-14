using DG.Tweening;
using UnityEngine;

public class Painter : MonoBehaviour
{
    [SerializeField] private Color _targetColor;
    [SerializeField] private float _duration = 2;
    [SerializeField] private int _repeats = -1;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _easeType;
    [SerializeField] private Material _material;

    private Color _startColor;

    private void Start()
    {
        _startColor = _material.color;

        _material.DOColor(_targetColor, _duration)
            .SetLoops(_repeats, _loopType).SetEase(_easeType);
    }

    private void OnDisable() => _material.color = _startColor;
}