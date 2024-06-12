using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limitplayer : MonoBehaviour
{
     public float minX = -4.5f; // Tọa độ x tối thiểu
    public float maxX = 4.5f;  // Tọa độ x tối đa
    public float minZ = -10000f; // Tọa độ z tối thiểu
    public float maxZ = 10000f;  // Tọa độ z tối đa
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Lấy tọa độ hiện tại của player
        Vector3 currentPosition = transform.position;

        // Giới hạn tọa độ x
        currentPosition.x = Mathf.Clamp(currentPosition.x, minX, maxX);

        // Giới hạn tọa độ z
        currentPosition.z = Mathf.Clamp(currentPosition.z, minZ, maxZ);

        // Cập nhật tọa độ của player
        transform.position = currentPosition;
    }
}
