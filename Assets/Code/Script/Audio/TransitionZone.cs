using UnityEngine;

public class TransitionZone : MonoBehaviour
{
    private bool _isEnterVillage;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 7)
        {
            if (!_isEnterVillage)
            {
                FonduMusique.Instance.PlayVillageMusic();
                _isEnterVillage = true;
                NameZone.Instance.PrintNameZone("Village de Nordhir");
                return;
            }
            if(_isEnterVillage)
            {
                FonduMusique.Instance.PlayValleeMusic();
                _isEnterVillage = false;
                NameZone.Instance.PrintNameZone("Plaine de Nyvaris");
                return;
            }

        }
    }
}
