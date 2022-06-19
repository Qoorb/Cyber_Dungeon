using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform PlayerTransform;
    [SerializeField] private string PlayerTag;
    [SerializeField] private float movingspeed;

    private void Awake()
    {
        if (this.PlayerTransform == null)
        {
            if (this.PlayerTag == "")
            {
                this.PlayerTag = "Player";
            }
            this.PlayerTransform = GameObject.FindGameObjectWithTag(this.PlayerTag).transform;
        }

        this.transform.position = new Vector3()
        {
            x = this.PlayerTransform.position.x,
            y = this.PlayerTransform.position.y,
            z = this.PlayerTransform.position.z - 10,
        };
    }
    void Start()
    {

    }

    void Update()
    {
        if (this.PlayerTransform)
        {
            Vector3 target = new Vector3()
            {
                x = this.PlayerTransform.position.x,
                y = this.PlayerTransform.position.y,
                z = this.PlayerTransform.position.z - 10,
            };

            Vector3 pos = Vector3.Lerp(this.transform.position, target, this.movingspeed * Time.deltaTime);

            this.transform.position = pos;
        }
    }
}
