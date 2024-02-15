using UnityEngine.UI;
using UnityEngine;
using DG.Tweening;

public class HackerText : MonoBehaviour
{
    private const string word1 = "PASSWORD";
    private const string word2 = "********";

    [SerializeField] private float _duration = 2;
    [SerializeField] private int _repeats = -1;
    [SerializeField] private Text _text;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(word1, _duration, true, ScrambleMode.Uppercase));
        sequence.Insert(0, _text.DOColor(Color.red, _duration));
        sequence.Append(_text.DOText(word2, _duration));
        sequence.Insert(_duration, _text.DOColor(Color.blue, _duration));
        sequence.SetLoops(_repeats);
    }
}
