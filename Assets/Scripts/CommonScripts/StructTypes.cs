using System;
using EnumTypes;
using UnityEngine;

namespace StructTypes
{
    [Serializable] public struct DirectionData
    {
        public DirectionTypes dirTypes;
    }

    [Serializable] public struct CharacterData
    {
        // Set character state
        public CharacterState characterState;

        // Set character position
        public Vector3 characterPos;
        
        //Set character rotation
        public Vector3 characterRot;

        // Set character hp
        private static int hp;
        public int Hp
        {
            get {return hp; }
            set
            {
                hp = value;
            }
        }

        // Set character speed
        private static float speed;
        public float Speed
        {
            get { return speed; }
            set
            {
                speed = value;
            }
        }
    }
}