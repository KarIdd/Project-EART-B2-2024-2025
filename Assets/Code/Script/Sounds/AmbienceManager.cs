using System.Collections;
using UnityEngine;

public class AmbienceManager : MonoBehaviour
{

    [SerializeField] float _sphereSize, _minTime, _maxTime;
    private void Start()
    {
        StartCoroutine(PlayDayAmbience());
    }

    

    IEnumerator PlayDayAmbience()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(_minTime, _maxTime));
            AudioSource currentSource = AudioManager.Instance.PlaySFXClipAtPosition(Sounds.Ambience, SelectRandomSoundSpot(),false,1,1f);
            print("ambient sound");
        }
    }


    Vector3 SelectRandomSoundSpot()
    {
        Vector3 spot = Random.insideUnitSphere * _sphereSize;
        return transform.position + spot;
    }






}
