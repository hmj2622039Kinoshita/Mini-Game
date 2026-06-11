using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pto2 : MonoBehaviour
{
    private float time = 0.0f;
    public float timeLimit = 1.0f;

    void Update()
    {
        time += Time.deltaTime;

        if (time > timeLimit)@// ˆê•bŒã‚Éplay‚Q‰æ–Ê‚É‘JˆÚ
        {
            SceneManager.LoadScene("Play2");
        }
    }
}
