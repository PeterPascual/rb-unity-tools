﻿using UnityEngine;
using UnityEditor;
using System.Collections;

namespace RedBlueGames.Tools
{
	public static class SelectionUtilities
	{
		public static bool IsActiveObjectOfType<T> ()
		{
			if (Selection.activeObject == null) {
				return false;
			}

			return Selection.activeObject.GetType() == typeof(T);
		}
	}
}