using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    //플레이어 좌우 회전 처리
    public float speed = 200f;

    //회전각도 직접 제어하기
    float angleX = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //회전하기
        Rotate();

    }

    void Rotate()
    {
        float h = Input.GetAxis("Mouse X");
        angleX += h * speed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, angleX, 0);
    }
}
