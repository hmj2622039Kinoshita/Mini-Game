using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    private void NextButton()
    {
       
        SceneManager.LoadScene("Result1");
        SceneManager.LoadScene("Result2");
    }
}
