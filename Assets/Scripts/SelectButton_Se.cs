using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
public class SelectButton_Se : MonoBehaviour
{
    [SerializeField]Image Select1;
    [SerializeField]Image Select2;
    [SerializeField] Sprite[] Apple;
    Image img;
    int count = 0;

    public void SelectButon1()
    {
        img = Select1;
    }
    public void SelectButon2()
    {
        img = Select2;
    }
   

        public void ButtonAlien()
        {
            count = 1;
            img.sprite = Resources.Load<Sprite>("Image/apple" + count.ToString());
        }
        public void ButtonEarth()
        {
            count = 2;
            img.sprite = Resources.Load<Sprite>("Image/apple" + count.ToString());
        }
        public void ButtonGolden()
        {
            count = 3;
            img.sprite = Resources.Load<Sprite>("Image/apple" + count.ToString());
        }
        public void ButtonIce()
        {
            count = 4;
            img.sprite = Resources.Load<Sprite>("Image/apple" + count.ToString());
        }
        public void ButtonIron()
        {
            count = 5;
            img.sprite = Resources.Load<Sprite>("Image/apple" + count.ToString());
        }
        public void ButtonMirror()
        {
            count = 6;
            img.sprite = Resources.Load<Sprite>("Image/apple" + count.ToString());
        }
        public void ButtonRainbow()
        {
            count = 7;
            img.sprite = Resources.Load<Sprite>("Image/apple" + count.ToString());
        }
        public void ButtonRed()
        {
            count = 8;
            img.sprite = Resources.Load<Sprite>("Image/apple" + count.ToString());
        }
        public void ButtonSilver()
        {
            count = 9;
            img.sprite = Resources.Load<Sprite>("Image/apple" + count.ToString());
        }
        public void ButtonStone()
        {
            count = 10;
            img.sprite = Resources.Load<Sprite>("Image/apple" + count.ToString());
        }
}