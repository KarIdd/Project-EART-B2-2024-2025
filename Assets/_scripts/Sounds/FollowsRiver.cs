using UnityEngine;

public class FollowsRiver : MonoBehaviour
{
    [SerializeField] BezierCurve _lacurve;
    [SerializeField] Transform _audioListener;

    private void Awake()
    {
        _audioListener = FindObjectOfType<AudioListener>().transform;
    }
    private void Update()
    {
        transform.position = _lacurve.GetClosestPoint(_audioListener.position);
    }
}
