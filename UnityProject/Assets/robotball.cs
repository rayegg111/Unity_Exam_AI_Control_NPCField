using UnityEngine;

public class robotball : MonoBehaviour
{
    [Header("移動速度")]
    public float speed = 20f;
    [Header("跳躍高度")]
    public float jump = 50f;

    public bool pass = false;
    public bool isGround = false;

    private Rigidbody rig;
    private Transform tra;


    private void Start()
    {
        rig = GetComponent<Rigidbody>();
        tra = GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        Walk();
        Jump();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGround = true;
        Debug.Log("碰到" + collision.gameObject);
    }

    /// <summary>
    /// 走路
    /// </summary>
    void Walk()
    {
        rig.AddForce(new Vector3(-speed * (Input.GetAxis("Vertical")), 0,speed*(Input.GetAxis("Horizontal"))));
    }
    /// <summary>
    /// 跳躍
    /// </summary>
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
        {
            isGround = false;
            rig.AddForce(new Vector3(0, jump, 0));
        }
    }
}
