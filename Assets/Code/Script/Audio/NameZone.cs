using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NameZone : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Animation _anim;

    public static NameZone Instance;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        PrintNameZone("Plaine de Nyvaris");
    }

    public void PrintNameZone(string ZoneName)
    {
        _text.text = ZoneName;
        _anim.Play();
    }
}
