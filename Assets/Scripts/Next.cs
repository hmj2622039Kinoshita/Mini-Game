using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    public void NextButton()
    {
        bool judge1 = GameData.answer1 == PlayerAnswer.select1 && GameData.answer2 == PlayerAnswer.select2;
        bool judge2 = GameData.answer1 == PlayerAnswer.select2 && GameData.answer2 == PlayerAnswer.select1;

        if(judge1 || judge2)
        {
            SceneManager.LoadScene("Result1");
            Debug.Log("正解");
        }
        else
        {
            SceneManager.LoadScene("Result2");
            Debug.Log("不正解");
        }
    }
}
