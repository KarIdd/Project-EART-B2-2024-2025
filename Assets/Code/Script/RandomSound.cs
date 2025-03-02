using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSound : MonoBehaviour
{
    [SerializeField] private AudioSource m_AudioSource;
    [SerializeField] private List<AudioClip> m_Clip;

    private void Start()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        int i = Random.Range(0, m_Clip.Count);
        m_AudioSource.clip = m_Clip[i];
        m_AudioSource.Play();
        yield return new WaitForSeconds(Random.Range(10, 15));
        StartCoroutine(Wait());
    }
}
