using Unity.VisualScripting;
using UnityEngine;

public class Tryagain : MonoBehaviour
{
    [SerializeField] GameObject[] apple;
    [SerializeField] Transform Apple1;
    [SerializeField] Transform Apple2;

    int apl1 = PlayerAnswer.select1;
    int apl2 = PlayerAnswer.select2;
    private void Start()
    {

        Instantiate(apple[apl1],Apple1.position, transform.rotation);
        Instantiate(apple[apl2],Apple2.position, transform.rotation);

    }
}
