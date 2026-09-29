using UnityEngine;

public class Camera_Movement : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 5, 10);
    public float lag = 0.1f;

    private Transform _player_pos;
    private Vector3 _vel = Vector3.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _player_pos = player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        if (_player_pos != null)
        {
            Vector3 targetPos = _player_pos.position + offset;
            transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref _vel, lag);
            transform.LookAt(_player_pos);
        }
    }
}
