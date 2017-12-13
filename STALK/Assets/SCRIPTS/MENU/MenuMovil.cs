using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMovil : MonoBehaviour
{

    public Transform targetPositionMenu1;
    public Transform targetRotationMenu1;
    public Transform targetPositionMenu2;
    public Transform targetRotationMenu2;
    public Transform targetPositionMenu3;
    public Transform targetRotationMenu3;

    public float speedPOS;
    public float speedROT;
    public int NumeroPosicion;

    void Start()
    {

        NumeroPosicion = 1;

    }

    void Update()
    {

        float stepPOS = speedPOS * Time.deltaTime;
        float stepROT = speedROT * Time.deltaTime;

        if (NumeroPosicion == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPositionMenu1.position, stepPOS);
            Vector3 targetDir = targetRotationMenu1.position - transform.position;
            Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, stepROT, 0.0f);
            Debug.DrawRay(transform.position, newDir, Color.red);
            transform.rotation = Quaternion.LookRotation(newDir);
        }


        if (NumeroPosicion == 2)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPositionMenu2.position, stepPOS);
            Vector3 targetDir = targetRotationMenu2.position - transform.position;
            Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, stepROT, 0.0f);
            Debug.DrawRay(transform.position, newDir, Color.red);
            transform.rotation = Quaternion.LookRotation(newDir);
        }

        if (NumeroPosicion == 3)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPositionMenu1.position, stepPOS);
            Vector3 targetDir = targetRotationMenu1.position - transform.position;
            Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, stepROT, 0.0f);
            Debug.DrawRay(transform.position, newDir, Color.red);
            transform.rotation = Quaternion.LookRotation(newDir);
        }
        if (NumeroPosicion == 4)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPositionMenu3.position, stepPOS);
            Vector3 targetDir = targetRotationMenu3.position - transform.position;
            Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, stepROT, 0.0f);
            Debug.DrawRay(transform.position, newDir, Color.red);
            transform.rotation = Quaternion.LookRotation(newDir);
        }
        if (NumeroPosicion == 5)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPositionMenu1.position, stepPOS);
            Vector3 targetDir = targetRotationMenu1.position - transform.position;
            Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, stepROT, 0.0f);
            Debug.DrawRay(transform.position, newDir, Color.red);
            transform.rotation = Quaternion.LookRotation(newDir);
        }
    }
}
