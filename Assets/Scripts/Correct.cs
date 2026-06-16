using UnityEngine;

public class Correct : MonoBehaviour
{

    [SerializeField] GameObject[] apple;
    [SerializeField] Transform Apple1;
    [SerializeField] Transform Apple2;
    [SerializeField] Transform Apple3;
    [SerializeField] Transform Apple4;
    [SerializeField] Transform Apple5;
    [SerializeField] Transform Apple6;

    int apl1 = PlayerAnswer.select1;
    int apl2 = PlayerAnswer.select2;
    private void Start()
    {

        Instantiate(apple[apl1], Apple1.position, transform.rotation);
        Instantiate(apple[apl2], Apple2.position, transform.rotation);
        Instantiate(apple[apl1], Apple3.position, transform.rotation);
        Instantiate(apple[apl2], Apple4.position, transform.rotation);
        Instantiate(apple[apl1], Apple5.position, transform.rotation);
        Instantiate(apple[apl2], Apple6.position, transform.rotation);

    }
}
