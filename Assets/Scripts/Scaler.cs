using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleFactor = 2; 
    [SerializeField] private float _duration = 2;
    [SerializeField] private int _repeats = -1;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _easeType;

    private void Start()
    {
        transform.DOScale(_scaleFactor, _duration)
            .SetLoops(_repeats, _loopType).SetEase(_easeType);
    }
}