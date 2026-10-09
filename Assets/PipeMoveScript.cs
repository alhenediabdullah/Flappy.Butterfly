using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    private float deadZone = -70;

    void Start()
    {
        if (GameManager.pipeGap > 0 && transform.childCount >= 2)
        {
            Transform pipe1 = transform.GetChild(0);
            Transform pipe2 = transform.GetChild(1); 

            if (pipe1.localPosition.y > pipe2.localPosition.y)
            {
                pipe1.localPosition -= new Vector3(0, GameManager.pipeGap, 0);
                pipe2.localPosition += new Vector3(0, GameManager.pipeGap, 0);
            }
            else
            {
                pipe2.localPosition -= new Vector3(0, GameManager.pipeGap, 0);
                pipe1.localPosition += new Vector3(0, GameManager.pipeGap, 0);
            }
        }
    }

    void Update()
    {
        transform.position = transform.position + (Vector3.left * GameManager.gameSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
