using UnityEngine;
using TMPro;


public class ArrowBlink : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI arrow;
    [SerializeField] float blink = 0.7f;

    private void Update()
    {
        float text = Mathf.PingPong(Time.time * blink,1f);
        arrow.alpha = text;
    }
}
