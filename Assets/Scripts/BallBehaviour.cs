using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    Rigidbody rb;
    public float ballSpeed = 5f;
    Vector3 pos;


    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        rb = GetComponent<Rigidbody>();
        resetBall();
    }

    public void resetBall()
    {
        rb.velocity = new Vector3(0f, 0f, 0f);
        transform.position = new Vector3(pos.x - Random.Range(-3.0f,3.0f), pos.y, pos.z);
        rb.velocity = new Vector3(14f, 14f, 0f);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            resetBall();
        }
    }
}
