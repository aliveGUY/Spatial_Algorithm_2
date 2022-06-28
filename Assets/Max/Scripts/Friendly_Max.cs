using UnityEngine;
using System.Collections;

namespace SpatialPartitionPattern
{
    //The friendly sphere which is chasing the enemy cubes
    public class Friendly_Max : Soldier_Max
    {
        //init friendly
        public Friendly_Max(GameObject soldierObj, float mapWidth)
        {
            this.soldierTrans = soldierObj.transform;

            this.walkSpeed = 2f;
        }


        //Move towards the closest enemy - will always move within its grid
        public override void Move(Soldier_Max closestEnemy)
        {
            //Rotate towards the closest enemy
            soldierTrans.rotation = Quaternion.LookRotation(closestEnemy.soldierTrans.position - soldierTrans.position);
            //Move towards the closest enemy
            soldierTrans.Translate(Vector3.forward * Time.deltaTime * walkSpeed);
        }
    }
}