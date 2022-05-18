using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DroneProject
{
    [RequireComponent(typeof(PlayerInput))]
    public class Drone_Input : MonoBehaviour{
        public Vector2 cyclic;
        private float pedals;
        private float throttle;
        public Vector2 Cyclic{get => cyclic;}
        public float Pedals {get => pedals; }
        public float Throttle {get => throttle; }

        void update(){}
        public void OnCyclic(InputValue value){
            cyclic = value.Get<Vector2>();
        }
        public void OnPedals(InputValue value){
            pedals = value.Get<float>();
        }
        public void OnThrottle(InputValue value){
            throttle = value.Get<float>();
        }
      
      
  }
}

