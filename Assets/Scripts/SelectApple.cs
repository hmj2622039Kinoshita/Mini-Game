using UnityEngine;

public class SelectApple : MonoBehaviour
{
    public Sprite Apple;
    public int appleeNum;

    public void ChooseApple()
    {
        if(SelectButton_Se.SelectButton != null)
        {
            SelectButton_Se.SelectButton.sprite = Apple;
        }

        if(SelectButton_Se.SelectButton.name =="SelectButton1")
        {
            PlayerAnswer.select1 = appleeNum;
        }
        else
        {
            PlayerAnswer.select2 = appleeNum;
        }
    }
}
