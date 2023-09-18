using System;
using UnityEngine;
using QFramework;
using Unity.Mathematics;

namespace DungeonDemo
{
	public partial class Player : ViewController
	{
		private const float speed = 3f;
		
		private void Update()
		{
			// 移动.
			float horizontal = Input.GetAxisRaw("Horizontal");
			float vertical = Input.GetAxisRaw("Vertical");
			Vector2 moveDir = new Vector2(horizontal, vertical).normalized;
			rb.velocity = moveDir * speed;

			// 旋转.
			Vector2 mouseDir = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position).normalized;
			float angle = Mathf.Atan2(mouseDir.y, mouseDir.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
		}
	}
}
