using System.Collections.Generic;
using UnityEngine;

public class Sea : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private List<Transform> _audioPositions;
    private Transform _currentAudioSource;

    void Update()
    {
        Transform closest = null;
        float minDistance = Mathf.Infinity;

        foreach (Transform empty in _audioPositions)
        {
            float distance = Mathf.Abs(empty.position.x - _player.position.x);
            if (distance < minDistance)
            {
                minDistance = distance;
                closest = empty;
            }
        }

        if (closest != null && closest != _currentAudioSource)
        {
            _currentAudioSource = closest;
            transform.position = _currentAudioSource.position;
        }

        FacePlayer();
    }

    void FacePlayer()
    {
        if (_player == null) return;

        Vector3 direction = _player.position - transform.position;
        if (direction != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(direction);
        }
    }
}
