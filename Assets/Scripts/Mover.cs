using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _distance = Vector3.up;
    [SerializeField] private float _duration = 1;
    [SerializeField] private int _repeats = -1;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _easeType;

    private void Start()
    {
        Vector3 target = transform.position + _distance;
        transform.DOMove(target, _duration)
            .SetLoops(_repeats, _loopType).SetEase(_easeType);
    }
}
