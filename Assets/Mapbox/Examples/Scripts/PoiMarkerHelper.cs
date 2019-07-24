﻿namespace Mapbox.Examples
{
	using UnityEngine;
	using Mapbox.Unity.MeshGeneration.Interfaces;
	using System.Collections.Generic;

	public class PoiMarkerHelper : MonoBehaviour, IFeaturePropertySettable
	{
		Dictionary<string, object> _props;

		public void Set(Dictionary<string, object> props)
		{
			_props = props;
            _props.TryGetValue("Name", out var value);
            Debug.Log(value);
		}

		void OnMouseUpAsButton()
		{
			foreach (var prop in _props)
			{
				Debug.Log(prop.Key + ":" + prop.Value);
			}
		}
	}
}