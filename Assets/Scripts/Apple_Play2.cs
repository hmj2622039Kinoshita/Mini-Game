using UnityEngine;
using System.Collections;
using System.Globalization;

public class Apple_Play2 : MonoBehaviour
{
    [SerializeField] int answer;
    [SerializeField] GameObject[] Apple;
    [SerializeField] Transform rangeA;
    [SerializeField] Transform rangeB;
    [SerializeField] float Y = 6.3f;
    float X;
    int number;

    private void Start()
    {
        number = Random.Range(0,Apple.Length);
        if(answer == 1)
        {
            GameData.answer1 = number;
        }
        else
        {
            GameData.answer2 = number;
        }
        // range‚Ì”ÍˆÍ‚ÅêŠ‚©‚¦‚é(rand,Y)
        X = Random.Range(rangeA.position.x, rangeB.position.x);

        GameObject apple = Instantiate(Apple[number], new Vector2(X, Y), transform.rotation);
    }

}
