using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Rigidbody feather_rb;
    private void OnCollisionEnter(Collision collision)
    {
        print("you'll find me in the club");
        feather_rb.GetComponent<Rigidbody>();
        feather_rb.linearVelocity = new Vector3(0f, 0f, 0f);
        feather_rb.useGravity = false;
    }
}
