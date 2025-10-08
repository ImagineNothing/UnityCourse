using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //GameObject Ball;
    }

    public class FollowPlayer : MonoBehaviour
    {
        public Transform player; public float speed = 5.0f; private void Update()
        {
            if (player != null) { transform.position = Vector3.MoveTowards(transform.position, player.position, speed); }
        }
    }

}
