using System.Collections;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Alarm : MonoBehaviour
{
    [SerializeField] private AudioSource _sound;
    [SerializeField][Range(0.2f, 1f)] private float _speed;

    private Coroutine _coroutine;
    private int _targetVolume;

    private void Start()
    {
        _sound.volume = 0;
    }

    public void PlaySiren()
    {
        _targetVolume = 1;
        _sound.volume = 0;

        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }

        _coroutine = StartCoroutine(ChangeVolume(_targetVolume));
    }

    public void TurnOffSiren()
    {
        _targetVolume = 0;

        StopCoroutine(_coroutine);
        _coroutine = StartCoroutine(ChangeVolume(_targetVolume));
    }

    private IEnumerator ChangeVolume(float necessaryVolume)
    {
        while (_sound.volume != necessaryVolume)
        {
            _sound.volume = Mathf.MoveTowards(_sound.volume, necessaryVolume, _speed * Time.deltaTime);
            yield return null;
        }
    }
}
