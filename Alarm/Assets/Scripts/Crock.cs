using System.Collections;
using UnityEngine;

public class Crock : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, _speed * Time.deltaTime * -1);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, _speed * Time.deltaTime);
        }
    }
}
