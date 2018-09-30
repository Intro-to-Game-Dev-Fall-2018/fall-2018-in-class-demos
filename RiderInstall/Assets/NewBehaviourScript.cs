using UnityEngine;

namespace RiderInstall
{
    public class NewBehaviourScript : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetAxis("Horizontal") >= Mathf.Epsilon)
            {
                // horizontal is moving "right"
            }
            else
            {
                // horizontal is moving "left"
                Input.get
            }
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.otherRigidbody.velocity.sqrMagnitude > 10)
            {
                // do something
            }
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("ScorePointTrigger"))
            {
                // score points
            }
        }
    }
}