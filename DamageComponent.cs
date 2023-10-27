using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrew.Components
{
	public class DamageComponent : MonoBehaviour
	{
		[SerializeField] private int _damage;

		public void Modify(GameObject target)
		{
			var health = target.GetComponent<HealthComponent>();
			if(health!=null)
			{
				health.ApplyDamage(_damage);
			}
		}
	}
}
