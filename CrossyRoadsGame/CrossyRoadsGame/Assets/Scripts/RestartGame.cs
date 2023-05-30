using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class RestartGame : MonoBehaviour
{
    private byte G = 135, B = 135, A = 45;
    private byte g = 0, b = 0, a = 0;

    public Image image;
    //public GameObject canvas;

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Update()
    {

        image.GetComponent<Image>().color = new Color32(255, g, b, a);

        if(g < G && b < B && a < A)
        {
            g++;
            b++;
            a++;
            if(a >= A)
            {
                a = A;
            }
        }
    }
}
