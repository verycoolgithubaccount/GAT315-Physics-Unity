using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject spawnee;
    [SerializeField] KeyCode keyCode;

    void Update()
    {
        if (Input.GetKeyDown(keyCode))
        {
            Instantiate(spawnee, gameObject.transform.position, gameObject.transform.rotation);
        }
    }
}
