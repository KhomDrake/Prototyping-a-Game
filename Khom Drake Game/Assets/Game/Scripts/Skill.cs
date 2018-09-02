using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Skill", menuName = "Player/Skill")]
public class Skill : ScriptableObject
{
    [System.Serializable]
        public class StopPlayer
        {
            [SerializeField] [Range(0, 100)] private float downTime;

            public float DownTime
            {
                get
                {
                    return this.downTime;
                }
            }

            public IEnumerator UnfreezePlayer()
            {
                //Player_Script.instance.G_CanMove = false;

                yield return new WaitForSeconds(downTime);

                //Player_Script.instance.G_CanMove = true;
            }
        }

        [System.Serializable]
        public class IsToHoldingPlayer
        {

            [SerializeField] [Range(0, 10)] private float timeToBeHolding;
            [SerializeField] private bool isHoldingEnough;
            [SerializeField] private bool wasReleased;
            private float timeWhenIsPressed, timeWhenItWasReleased, pressedTime;

            public float TimeToBeHolding
            {
                get
                {
                    return this.timeToBeHolding;
                }
            }

            public bool IsHoldingEnough
            {
                get
                {
                    return this.isHoldingEnough;
                }

                set
                {
                    this.isHoldingEnough = value;
                }
            }

            public bool WasReleased
            {
                get
                {
                    return this.wasReleased;
                }

                set
                {
                    this.wasReleased = value;
                }
            }

            public float TimeWhenIsPressed
            {
                get
                {
                    return this.timeWhenIsPressed;
                }

                set
                {
                    this.timeWhenIsPressed = value;
                }
            }

            public float TimeWhenItWasReleased
            {
                get
                {
                    return this.timeWhenItWasReleased;
                }

                set
                {
                    this.timeWhenItWasReleased = value;
                }
            }

            public float PressedTime
            {
                get
                {
                    return this.pressedTime;
                }

                set
                {
                    this.pressedTime = value;
                }
            }

        }

        [System.Serializable]
        public class HaveSecondPhasePlayer
        {
            [SerializeField] private GameObject secondPhaseObject;
            [SerializeField] private Skill secondPhaseSkill;
        }

        [SerializeField] private Skill_Object mySkill;
        [SerializeField] private string skillName;
        [SerializeField] [TextArea] private string description;
        [SerializeField] private bool isToStop, isToHolding, haveSecondPhase;
        [SerializeField] [Range(0, 100)] private float timeInScreen, countDown, damage;
        [SerializeField] [Range(-20, 20)] private float distanceXLeft, distanceY, distanceXRight;

        public IEnumerator TimeToSpendInScreen(GameObject my)
        {
            yield return new WaitForSeconds(timeInScreen);

            Destroy(my);
        }

		#region GetAndSet

        public Skill_Object MySkill
        {
            get
            {
                return this.mySkill;
            }
        }

        public float DistanceY
        {
            get
            {
                return this.distanceY;
            }
        }

        public float DistanceXRight
        {
            get
            {
                return this.distanceXRight;
            }
        }

        public float DistanceXLeft
        {
            get
            {
                return this.distanceXLeft;
            }
        }

        public float Damage
        {
            get
            {
                return this.damage;
            }
        }

        public float CountDown
        {
            get
            {
                return this.countDown;
            }
        }

        public float TimeInScreen
        {
            get
            {
                return this.timeInScreen;
            }
        }

        public bool HaveSecondPhase
        {
            get
            {
                return this.haveSecondPhase;
            }
        }

        public bool IsToHolding
        {
            get
            {
                return this.isToHolding;
            }
        }

        public bool IsToStop
        {
            get
            {
                return this.isToStop;
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }
        }

        public string SkillName
        {
            get
            {
                return this.skillName;
            }
        }

		#endregion
}