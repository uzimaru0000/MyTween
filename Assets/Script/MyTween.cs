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

	Dictionary<TweenType, TweenData> que;

	// Update is called once per frame
	void Update() {

	}

	static void AddQue(GameObject obj, TweenData data, TweenType type) {
		var tween = obj.GetComponent<MyTween>();
		if (!tween) {
			tween = obj.AddComponent<MyTween>();
		}
		tween.que.Add(type, data);
	}
}

public class TweenData {

	Vector3 _value;
	public float time;
	public TweenMode mode;
	Action _updata;
	Action _callback;

	public Vector3 position {
		get {
			return _value;
		}
		set {
			_value = value;
		}
	}

	public Vector3 rotation {
		get {
			return _value;
		}
		set {
			_value = value;
		}
	}

	public Vector3 Scale {
		get {
			return _value;
		}
		set {
			_value = value;
		}
	}

	public float x {
		get {
			return _value.x;
		}
		set {
			_value.x = value;
		}
	}

	public float y {
		get {
			return _value.y;
		}
		set {
			_value.y = value;
		}
	}

	public float z {
		get {
			return _value.z;
		}
		set {
			_value.z = value;
		}
	}

	public Action update {
		get {
			if (_updata == null) _updata = () => { };
			return _updata;
		}
		set {
			_updata = value;
		}
	}

	public Action callback {
		get {
			if (_callback == null) _callback = () => { };
			return _callback;
		}
		set {
			_callback = value;
		}
	}

}

public enum TweenMode {
	Liner,
	Sphere
}