using UnityEngine;


namespace LevelUP.Dial
{
    public class Rotator : MonoBehaviour
    {
        public Transform linkedDial;

        [SerializeField] private int snapRotationAmout = 25;
        [SerializeField] private float angleTolerance;
        [SerializeField] private GameObject RightHand;
        [SerializeField] private GameObject LeftHand;

        private float startAngle;
        private bool requiresStartAngle = true;
        private bool shouldGetHandRotation = false;

        public void GrabbedBy()
        {

            shouldGetHandRotation = true;
            startAngle = 0f;

        }



        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject == RightHand)
            {
                Debug.Log(collision.gameObject);
            }
            if (collision.gameObject == LeftHand)
            {
                Debug.Log(collision.gameObject);
            }
        }
        void OnCollisionExit(Collision collision)
        {
            if (collision.gameObject == RightHand)
            {
                Debug.Log(collision.gameObject);
            }
            if (collision.gameObject == LeftHand)
            {
                Debug.Log(collision.gameObject);
            }
        }
        /*
        private void HandModelVisibility(bool visibilityState)
        {
            if(interactor.gameObject.GetComponent<XRController>().controllerNode == XRNode.RightHand)
            {
                RighthandModel.SetActive(visibilityState);
            }
            else
            {
                LefthandModel.SetActive(visibilityState);
            }
        }

        public void GrabEnd()
        {
            shouldGetHandRotation = false;
            requiresStartAngle = true;
        }

        void Update()
        {
            if (shouldGetHandRotation)
            {
                var rotationAngle = GetInteractorRotation(); //gets the current controller angle
                GetRotationDistance(rotationAngle);
            }
        }

        public float GetInteractorRotation()
        {
            var handRotation = interactor.GetComponent<Transform>().eulerAngles;
            return handRotation.z;
        }

        private void GetRotationDistance(float currentAngle)
        {
            if (!requiresStartAngle)
            {
                var angleDifference = Mathf.Abs(startAngle - currentAngle);

                if (angleDifference > angleTolerance)
                {
                    if (angleDifference > 270f) //checking to see if the user has gone from 0-360 - a very tiny movement but will trigger the angletolerance
                    {
                        float angleCheck;

                        if (startAngle < currentAngle) //going anticlockwise
                        {
                            angleCheck = CheckAngle(currentAngle, startAngle);

                            if (angleCheck < angleTolerance)
                            {
                                return;
                            }
                            else
                            {
                                RotateDialAntiClockwise();
                                startAngle = currentAngle;
                            }
                        }
                        else if (startAngle > currentAngle) //going clockwise;
                        {
                            angleCheck = CheckAngle(currentAngle, startAngle);

                            if (angleCheck < angleTolerance)
                            {
                                return;
                            }
                            else
                            {
                                RotateDialClockwise();
                                startAngle = currentAngle;
                            }
                        }
                    }
                    else
                    {
                        if (startAngle < currentAngle)//clockwise
                        {
                            RotateDialClockwise();
                            startAngle = currentAngle;
                        }
                        else if (startAngle > currentAngle)
                        {
                            RotateDialAntiClockwise();
                            startAngle = currentAngle;
                        }
                    }
                }
            }
            else
            {
                requiresStartAngle = false;
                startAngle = currentAngle;
            }
        }

        private float CheckAngle(float currentAngle, float startAngle)
        {
            var checkAngleTravelled = (360f - currentAngle) + startAngle;
            return (checkAngleTravelled);
        }

        private void RotateDialClockwise()
        {
            linkedDial.localEulerAngles = new Vector3(linkedDial.localEulerAngles.x, linkedDial.localEulerAngles.y - snapRotationAmout, linkedDial.localEulerAngles.z);
            GetComponent<IDial>().DialChanged(linkedDial.localEulerAngles.y);
        }

        private void RotateDialAntiClockwise()
        {
            linkedDial.localEulerAngles = new Vector3(linkedDial.localEulerAngles.x, linkedDial.localEulerAngles.y + snapRotationAmout, linkedDial.localEulerAngles.z);
            GetComponent<IDial>().DialChanged(linkedDial.localEulerAngles.y);
        }
    }*/
    }
}
