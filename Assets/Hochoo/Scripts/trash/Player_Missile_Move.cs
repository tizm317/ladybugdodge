using UnityEngine;

public class Player_Missile_Move : MonoBehaviour
{
    public float MoveSpeed;     // 미사일이 날라가는 속도
    public float DestroyYPos;   // 미사일이 사라지는 지점
    public GameObject player;
    float LifeTime = 5f;
    GameObject firePosition;
    public GameObject bullet;
    Rigidbody2D rb2D;

    void Start()
    {
        player = GameObject.Find("Character");

        rb2D = this.GetComponent<Rigidbody2D>();

        Debug.Log(player.transform.rotation);
    }

    private void OnEnable()
    {
        transform.rotation = player.transform.rotation;
        transform.position = player.transform.position;
    }

    void Update()
    {
       
        if (rb2D)
            rb2D.AddRelativeForce(transform.right * MoveSpeed * Time.deltaTime);
        LifeTime -= Time.deltaTime;

        // 매 프레임마다 미사일이 MoveSpeed 만큼 up방향(Y축 +방향)으로 날라갑니다.
        //transform.Translate(Vector2.up * MoveSpeed * Time.deltaTime);

        // 만약에 미사일의 위치가 DestroyYPos를 넘어서면
        if (LifeTime <= 0f)
        {
            // 미사일을 제거
            //Destroy(gameObject);
            GetComponent<Collider2D>().enabled = false;
            LifeTime = 5f;

        }
    }
}


