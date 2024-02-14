using UnityEngine.UI;
using UnityEngine;
using DG.Tweening;

public class HackerText : MonoBehaviour
{
    [SerializeField] private float _duration = 2;
    [SerializeField] private int _repeats = -1;
    [SerializeField] private Text _text;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("PASSWORD", _duration, true, ScrambleMode.Uppercase));
        sequence.Insert(0, _text.DOColor(Color.red, _duration * 2));
        sequence.Append(_text.DOText("********", _duration));
        sequence.Insert(_duration * 2, _text.DOColor(Color.blue, _duration));
        sequence.SetLoops(_repeats);
    }
}
