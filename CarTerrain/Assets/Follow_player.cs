using UnityEngine;

public class Follow_player : MonoBehaviour
{

    [SerializeField] public Transform player;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(0, 1, -10);
        
    }
}