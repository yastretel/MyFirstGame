using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject Bullet;
    public Transform ShootPoint;
    public float Force;
    void Start()
    {
        
    }

       void Update()
    {
      if (Input.GetMouseButtonDown(0))
    {
        GameObject insBullet = Instantiate(Bullet, ShootPoint.position, Quaternion.identity);
         insBullet.GetComponent<Rigidbody>().AddForce(ShootPoint.forward * Force);
        
        
        
    }  
    }
}
