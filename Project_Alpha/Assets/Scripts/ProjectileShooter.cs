using System.Runtime.ConstrainedExecution;
using UnityEditor;
using UnityEngine;


public class ProjectileShooter : MonoBehaviour
{
    public float projectileSpeed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    
    void Update()
    {

       transform.Translate(Vector3.forward * Time.deltaTime * projectileSpeed);

    }


    void Shoot()
    {


    }
    }
