using UnityEngine;
using UnityEngine.InputSystem;

namespace Entity.Behaviour
{
    public class Movement : MonoBehaviour
    {
        [SerializeField] private float speed = 25f;

        private void Update()
        {
            if (Keyboard.current.wKey.isPressed)
            {
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
        }
    }
}
