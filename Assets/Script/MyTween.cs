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
    float timer = 0;

	// Update is called once per frame
	void Update() {
        if (que.delay <= timer) {
            var rate = (timer - que.delay) / que.time;
            switch(type) {
                case TweenType.MoveTo:

                    break;
                case TweenType.MoveBy:

                    break;
                case TweenType.RotateTo:

                    break;
                case TweenType.RotateBy:

                    break;
                case TweenType.ScaleTo:

                    break;
                case TweenType.ScaleBy:

                    break;
            }
        }
        timer += Time.deltaTime;
	}

    static void MoveTo(GameObject obj, TweenData data) {
        AddQue(obj, data, TweenType.MoveTo);
    }

    static void MoveBy(GameObject obj, TweenData data) {
        AddQue(obj, data, TweenType.MoveBy);
    }

    static void RotateTo(GameObject obj, TweenData data) {
        AddQue(obj, data, TweenType.RotateTo);
    }

    static void RotateBy(GameObject obj, TweenData data) {
        AddQue(obj, data, TweenType.RotateBy);
    }

    static void ScaleTo(GameObject obj, TweenData data) {
        AddQue(obj, data, TweenType.ScaleTo);
    }

    static void ScaleBy(GameObject obj, TweenData data) {
        AddQue(obj, data, TweenType.ScaleBy);
    }

    static void AddQue(GameObject obj, TweenData data, TweenType type) {
		var tween = obj.AddComponent<MyTween>();
		tween.que = data;
		tween.type = type;
	}
}

public class TweenData {

    public enum TweenMode {
        Liner,
        Sphere
    }

    public delegate void TweenCallback();

	Vector3 _value;
	public float time;
	public float delay = 0;
    public event TweenCallback callback;

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

}