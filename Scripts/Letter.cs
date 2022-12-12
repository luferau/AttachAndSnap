using UnityEngine;
using UnityEngine.Events;

public class Letter : MonoBehaviour
{
    [SerializeField] private UnityEvent _onCollisionEnterWithLetter;
    [SerializeField] private UnityEvent _onCollisionEnterWithOtherObject;

    private Rigidbody _body;

    private void Start()
    {
        _body = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody?.GetComponent<Letter>() != null)
        {
            Debug.Log("Letter collision with Letter (" + collision.collider.name + ")");
            _onCollisionEnterWithLetter.Invoke();
        }
        else
        {
            Debug.Log("Letter collision with other");
            _onCollisionEnterWithOtherObject.Invoke();
        }
    }
}
