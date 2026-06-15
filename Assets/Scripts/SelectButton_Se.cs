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
}