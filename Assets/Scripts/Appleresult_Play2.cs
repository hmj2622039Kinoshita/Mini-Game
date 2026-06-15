using UnityEngine;
using UnityEngine.SceneManagement;

public class Appleresult_Play2 : MonoBehaviour
{
    private string AppleName;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        AppleName = gameObject.name;
        Debug.Log(AppleName);
    }
}
