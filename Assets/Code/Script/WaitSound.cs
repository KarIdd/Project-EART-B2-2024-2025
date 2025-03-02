using System.Collections;
using UnityEngine;

public class WaitSound : MonoBehaviour
{
    [SerializeField] private AudioSource m_AudioSource;
    [SerializeField] private float _timeMin;
    [SerializeField] private float _timeMax;

    void Start()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        m_AudioSource.Play();
        yield return new WaitForSeconds(Random.Range(_timeMin, _timeMax));
        StartCoroutine(Wait());
    }
}
