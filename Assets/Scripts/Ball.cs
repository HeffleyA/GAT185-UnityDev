using UnityEngine;
using UnityEngine.UIElements;

public class Ball : MonoBehaviour
{
    [Range(1, 10), Tooltip("change the speed")] public float speed = 2;
    public GameObject prefab;

    private void Awake()
    {
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 postion = transform.position;
        Vector3 velocity = Vector3.zero;
        velocity.x = Input.GetAxis("Horizontal");
        velocity.z = Input.GetAxis("Vertical");
        //if (Input.GetButton("Fire1"))
        //{
        //    postion.y += 1 * Time.deltaTime;
        //}
        transform.position += velocity * speed * Time.deltaTime;

        //create prefab
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position + Vector3.up, Quaternion.identity);
        }
    }
}
