using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : Character
{

    [SerializeField] private StructTypes.CharacterData playerData;

    private void Awake()
    {
        playerData.characterPos = transform.position;
        playerData.characterRot = transform.eulerAngles;
        playerData.Speed = 5.0f;
    }
    void Start()
    {
        Debug.Log(playerData.characterState);
    }

    void Update()
    {
        Move(playerData.characterPos);
    }

    public override void Move(Vector3 direction)
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        direction = new Vector3(h, 0.0f ,v) * playerData.Speed * Time.deltaTime;

        base.Move(direction);
    }
}
