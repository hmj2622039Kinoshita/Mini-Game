using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine. UI;

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
