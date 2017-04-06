using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTween : MonoBehaviour {

	enum TweenType {
		MoveTo,
		MoveBy,
		RotateTo,
		RotateBy,
		ScaleTo,
		ScaleBy
	}

	TweenData que;
	TweenType type;

	// Update is called once per frame
	void Update() {
		
	}

	static void AddQue(GameObject obj, TweenData data, TweenType type) {
		var tween = obj.AddComponent<MyTween>();
		tween.que = data;
		tween.type = type;
	}

	public enum TweenMode {
		Liner,
		Sphere
	}	
}

public class TweenData {

	Vector3 _value;
	public float time;
	public float delay;
	Action _callback;

	public Vector3 position {
		get {
			return _value;
		}
		set {
			_value = value;
		}
	}

	public Vector3 scale {
		get {
			return _value;
		}
		set {
			_value = value;
		}
	}

	public Quaternion rotation {
		get {
			return Quaternion.Euler(_value);
		}
		set {
			_value = value.eulerAngles;
		}
	}

	public Action callback {
		get {
			if (_callback == null) {
				_callback = () => {};
			}
			return _callback;
		}
		set {
			_callback = value;
		}
	}

}