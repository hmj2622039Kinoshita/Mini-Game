using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
public class SelectButton_Se : MonoBehaviour
{
    public static Image SelectButton;
    public Image Image;

    public void Select()
    {
        SelectButton = Image;
    }

    //public void OnButtonClick()
    //{
    //    if(SelectButton1 == null)
    //    {
    //        SelectButton1 = Apple;
    //        Debug.Log("ボタン選択");
    //    }
    //    else
    //    {
    //        SelectButton1.sprite = Apple.sprite;
    //        Debug.Log("画像変更");
    //        SelectButton1 = null;
    //    }
    //}

    //public void Start()
    //{
    //    SelectButton1 = GetComponent<Image>();
    //}



    //// [SerializeField] Sprite[] Apple;
    //// Image img;



    //public void ButtonAlien(Button clickedButton)
    //{
    //    Image ButtonAlien = clickedButton.GetComponent<Image>();
    //    SelectButton1.sprite = ButtonAlien.sprite;
    //}
    //public void ButtonEarth()
    //{
    //    img.sprite = Resources.Load<Sprite>("Image/apple2");
    //}
    //public void ButtonGolden()
    //{
    //    img.sprite = Resources.Load<Sprite>("Image/apple3");
    //}
    //public void ButtonIce()
    //{
    //    img.sprite = Resources.Load<Sprite>("Image/apple4");
    //}
    //public void ButtonIron()
    //{
    //    img.sprite = Resources.Load<Sprite>("Image/apple5");
    //}
    //public void ButtonMirror()
    //{
    //    img.sprite = Resources.Load<Sprite>("Image/apple6");
    //}
    //public void ButtonRainbow()
    //{
    //    img.sprite = Resources.Load<Sprite>("Image/apple7");
    //}
    //public void ButtonRed()
    //{
    //    img.sprite = Resources.Load<Sprite>("Image/apple8");
    //}
    //public void ButtonSilver()
    //{
    //    img.sprite = Resources.Load<Sprite>("Image/apple9");
    //}
    //public void ButtonStone()
    //{
    //    img.sprite = Resources.Load<Sprite>("Image/apple10");
    //}
}