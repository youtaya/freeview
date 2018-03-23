using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Validate {

    public class ValidatePlayer : MonoBehaviour {

        //Anchor transform
        Transform anchor;
        //camera transform
        public Transform mainCamera;

        // angle view
        public Text angleText;

	    // Use this for initialization
	    void Start () {
		
	    }
	
	    // Update is called once per frame
	    void Update () {
		
	    }

        private void AnotherGetAngle(Transform aPos, Transform bPos)
        {
            Vector3 targetDir = aPos.position - bPos.position; // 目标坐标与当前坐标差的向量

            Vector3.Angle(bPos.forward, targetDir); // 返回当前坐标与目标坐标的角度
        }

        private float GetAngle(Vector3 a, Vector3 b)
        {
            b.x -= a.x;
            b.z -= a.z;

            float deltaAngle = 0;
            if (b.x == 0 && b.z == 0)
            {
                return 0;
            }
            else if (b.x > 0 && b.z > 0)
            {
                deltaAngle = 0;
            }
            else if (b.x > 0 && b.z == 0)
            {
                return 90;
            }
            else if (b.x > 0 && b.z < 0)
            {
                deltaAngle = 180;
            }
            else if (b.x == 0 && b.z < 0)
            {
                return 180;
            }
            else if (b.x < 0 && b.z < 0)
            {
                deltaAngle = -180;
            }
            else if (b.x < 0 && b.z == 0)
            {
                return -90;
            }
            else if (b.x < 0 && b.z > 0)
            {
                deltaAngle = 0;
            }

            float angle = Mathf.Atan(b.x / b.z) * Mathf.Rad2Deg + deltaAngle;
            return angle;
        }
    }

}
