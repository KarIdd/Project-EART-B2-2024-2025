using System.Threading.Tasks;
using UnityEngine;

public class Dog : MonoBehaviour
{
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _bark;
    [SerializeField] private AudioClip _happy;
    [SerializeField] private int _delay;

    private void Start()
    {
        DogMakeSound();
    }
    async void DogMakeSound()
    {
        _source.PlayOneShot(_bark);
        await Task.Delay(2000);
        _source.PlayOneShot(_happy);
        await Task.Delay(_delay * 1000);
        DogMakeSound();
    }
}
