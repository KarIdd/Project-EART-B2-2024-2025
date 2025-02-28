using UnityEngine;
using UnityEngine.Audio;

public class FonduMusique : MonoBehaviour
{
    [SerializeField] private AudioMixerSnapshot _valleeSnapshot;
    [SerializeField] private AudioMixerSnapshot _villageSnapshot;
    [SerializeField] private float transitionTime = 1.5f;

    public static FonduMusique Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void PlayValleeMusic()
    {
        _valleeSnapshot.TransitionTo(transitionTime);
    }

    public void PlayVillageMusic()
    {
        _villageSnapshot.TransitionTo(transitionTime);
    }
}
