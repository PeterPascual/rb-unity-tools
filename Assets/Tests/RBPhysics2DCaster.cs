﻿using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class RBPhysics2DCaster : MonoBehaviour {

	public CastType Cast;
	public enum CastType
	{
		OverlapCircle,
		OverlapArea,
	}

	public bool CastAll;
	public float Radius;
	public Vector2 CornerAOffset;
	public Vector2 CornerBOffset;
	public LayerMask castLayers;

	void OnGUI ()
	{
		switch (Cast) {
		case CastType.OverlapCircle : 
			if (CastAll) {
				RBPhysics2D.OverlapCircleAll (transform.position, Radius, castLayers.value);
			} else {
				RBPhysics2D.OverlapCircle (transform.position, Radius, castLayers.value);
			}
			break;
		case CastType.OverlapArea :
			Vector2 cornerA = (Vector2) transform.position + CornerAOffset;
			Vector2 cornerB = (Vector2) transform.position + CornerBOffset;
			if (CastAll) {
				RBPhysics2D.OverlapAreaAll (cornerA, cornerB, castLayers.value);
			} else {
				RBPhysics2D.OverlapArea (cornerA, cornerB, castLayers.value);
			}
			break;
		}
	}
}
