using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HomeButton : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(rt);
    }
    private void rt()
    {
        SceneManager.LoadScene("Title");
    }
}
