using UnityEngine;

public class ScoreAdd : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collision)
   {
	   Score.scoreValue++;
   }
}
