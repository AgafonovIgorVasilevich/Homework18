using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _direction = Vector3.up;
    [SerializeField] private float _angle = 360;
    [SerializeField] private float _duration = 2;
    [SerializeField] private int _repeats = -1;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _easeType;

    private void Start()
    {
        transform.DORotate(_direction * _angle, _duration)
            .SetLoops(_repeats, _loopType).SetEase(_easeType);
    }
}