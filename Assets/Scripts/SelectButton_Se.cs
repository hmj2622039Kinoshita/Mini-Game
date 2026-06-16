using UnityEngine;
using UnityEngine.UI;
public class SelectButton_Se : MonoBehaviour
{
    public static Image SelectButton;
    public Image Image;

    public void Select()
    {
        SelectButton = Image;
    }
}