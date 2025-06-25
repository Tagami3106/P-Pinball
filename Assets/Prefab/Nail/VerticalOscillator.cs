using UnityEngine;

public class VerticalOscillator : MonoBehaviour
{

    public float amplitude = 1.0f;

    public float speed = 1.0f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        /*float newY = startPos.y + Mathf.Sin(Time.time * speed) * amplitude;
        transform.position = new Vector3(startPos.x, newY, startPos.z);
        ècóhÇÍ*/

        float newX = startPos.x + Mathf.Sin(Time.time * speed) * amplitude;
        transform.position = new Vector3(newX, startPos.y, startPos.z);
        //â°óhÇÍ
    }
}