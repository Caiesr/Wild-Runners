using UnityEngine;

public class colliderpoints : MonoBehaviour
{
    public object pointGet;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("getPoint"))

        { text.instance.AddPoint(); }
    }
    


}
