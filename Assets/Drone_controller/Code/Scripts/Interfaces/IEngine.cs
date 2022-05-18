using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DroneProject{


    public interface IEngine
    {
        void InitEngine();
        void UpdateEngine(Rigidbody rb,Drone_Input input);
    }
}
