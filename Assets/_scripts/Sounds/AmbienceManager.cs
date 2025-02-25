using System.Collections;
using UnityEngine;

public class AmbienceManager : MonoBehaviour
{

    [SerializeField] float _sphereSize, _minTime, _maxTime;
    private void Start()
    {

    }

    

    IEnumerator PlayDayAmbience()
    {
        while (true)
        {
            //yield return new WaitForSeconds(Random.Range(_minTime, _maxTime));
            //SFXManager.Instance.PlaySFXClip(_dayAmbientEventSounds, SelectRandomSoundSpot(), _dayAmbientEventVolume);
        }
    }


    Vector3 SelectRandomSoundSpot()
    {
        Vector3 spot = Random.insideUnitSphere * _sphereSize;
        Mathf.Abs(spot.y);
        return transform.position + spot;
    }






}
