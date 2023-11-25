using UnityEngine;
using System;

public class CarController : MonoBehaviour{
    public enum Axel{
        Front,
        Rear
    }

    [Serializable]
    public struct Wheel{
        public GameObject wheelModel;
        public WheelCollider wheelCollider;
        public Axel axel;
    }

    public float maxAcceleration = 30.0f;
    public float brakeAcceleration = 50.0f;

    public List<Wheel> wheels;

    float moveInput;
}