using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
public class SelectButton_Se : MonoBehaviour
{
    public void SelectButton1()
    {
        switch (transform.name)
        {
            case "ButtonAlien":
                .sprite = Resources.Load<Sprite>("Image/apple1");
                break;
        }

    }

    //[SerializeField]Image Select1;
    //[SerializeField]Image Select2;
    //[SerializeField] Sprite[] Apple;
    //Image img;

    //public void SelectButon1()
    //{
    //    img = Select1;
    //}
    //public void SelectButon2()
    //{
    //    img = Select2;
    //}


    //    public void ButtonAlien()
    //    {
    //        img.sprite = Resources.Load<Sprite>("Image/apple1");
    //    }
    //    public void ButtonEarth()
    //    {
    //        img.sprite = Resources.Load<Sprite>("Image/apple2");
    //    }
    //    public void ButtonGolden()
    //    {
    //        img.sprite = Resources.Load<Sprite>("Image/apple3");
    //    }
    //    public void ButtonIce()
    //    {
    //        img.sprite = Resources.Load<Sprite>("Image/apple4");
    //    }
    //    public void ButtonIron()
    //    {
    //        img.sprite = Resources.Load<Sprite>("Image/apple5");
    //    }
    //    public void ButtonMirror()
    //    {
    //        img.sprite = Resources.Load<Sprite>("Image/apple6");
    //    }
    //    public void ButtonRainbow()
    //    {
    //        img.sprite = Resources.Load<Sprite>("Image/apple7");
    //    }
    //    public void ButtonRed()
    //    {
    //        img.sprite = Resources.Load<Sprite>("Image/apple8");
    //    }
    //    public void ButtonSilver()
    //    {
    //        img.sprite = Resources.Load<Sprite>("Image/apple9");
    //    }
    //    public void ButtonStone()
    //    {
    //        img.sprite = Resources.Load<Sprite>("Image/apple10");
    //    }
}