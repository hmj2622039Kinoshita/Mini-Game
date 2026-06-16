using UnityEngine;
using TMPro;


public class TextColor : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] float blink = 0.5f;
    private float timer;
    private bool colorjudge = true;

    private void Start()
    {
        text.color = Color.yellow;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if(timer >= blink)
        {
        timer = 0f;
            if (colorjudge == true)
            {
                text.color = Color.red;
                colorjudge = false;
            }
            else if(colorjudge == false)
            {
                text.color = Color.yellow;
                colorjudge= true;
            }
        }

    }
}
