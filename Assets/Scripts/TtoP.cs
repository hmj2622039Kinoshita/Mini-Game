using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine. UI;
using System.Collections;

public class TtoP : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(tp);
    }
    private void tp()
    {
        SceneManager.LoadScene("Play"); // play‰æ–Ê‚É‘JˆÚ
    }

}
