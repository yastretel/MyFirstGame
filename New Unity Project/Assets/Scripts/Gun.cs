using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject Bullet;
    public Transform ShootPoint;
    void Start()
    {
        
    }

       void Update()
    {
      if (Input.GetMouseButton(0))
    {
        Instantiate(Bullet, ShootPoint.position, Quaternion.identity);
    }  
    }
}
