using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class P2toSe : MonoBehaviour
{
    private float time = 0.0f;
    public float timeLimit = 1.5f;

    void Update()
    {
        time += Time.deltaTime;

        if (time > timeLimit) // ‚PD‚T•bŒã‚É‘I‘ğ‰æ–Ê‚É‘JˆÚ
        {
            SceneManager.LoadScene("Select");
        }
    }
}
