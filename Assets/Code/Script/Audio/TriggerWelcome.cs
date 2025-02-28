using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class TriggerWelcome : MonoBehaviour
{
    [SerializeField] private AudioSource _audioS;

    private async void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 7)
        {
            _audioS.Play();
            await Task.Delay(1000);
            _audioS.Stop();
        }
    }
}
