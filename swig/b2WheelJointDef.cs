//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace b2Sharp {

public class b2WheelJointDef : b2JointDef {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal b2WheelJointDef(global::System.IntPtr cPtr, bool cMemoryOwn) : base(Box2DPINVOKE.b2WheelJointDef_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(b2WheelJointDef obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Box2DPINVOKE.delete_b2WheelJointDef(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public b2WheelJointDef() : this(Box2DPINVOKE.new_b2WheelJointDef(), true) {
  }

  public void Initialize(b2Body bodyA, b2Body bodyB, b2Vec2 anchor, b2Vec2 axis) {
    Box2DPINVOKE.b2WheelJointDef_Initialize(swigCPtr, b2Body.getCPtr(bodyA), b2Body.getCPtr(bodyB), b2Vec2.getCPtr(anchor), b2Vec2.getCPtr(axis));
    if (Box2DPINVOKE.SWIGPendingException.Pending) throw Box2DPINVOKE.SWIGPendingException.Retrieve();
  }

  public b2Vec2 localAnchorA {
    set {
      Box2DPINVOKE.b2WheelJointDef_localAnchorA_set(swigCPtr, b2Vec2.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = Box2DPINVOKE.b2WheelJointDef_localAnchorA_get(swigCPtr);
      b2Vec2 ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Vec2(cPtr, false);
      return ret;
    } 
  }

  public b2Vec2 localAnchorB {
    set {
      Box2DPINVOKE.b2WheelJointDef_localAnchorB_set(swigCPtr, b2Vec2.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = Box2DPINVOKE.b2WheelJointDef_localAnchorB_get(swigCPtr);
      b2Vec2 ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Vec2(cPtr, false);
      return ret;
    } 
  }

  public b2Vec2 localAxisA {
    set {
      Box2DPINVOKE.b2WheelJointDef_localAxisA_set(swigCPtr, b2Vec2.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = Box2DPINVOKE.b2WheelJointDef_localAxisA_get(swigCPtr);
      b2Vec2 ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Vec2(cPtr, false);
      return ret;
    } 
  }

  public bool enableLimit {
    set {
      Box2DPINVOKE.b2WheelJointDef_enableLimit_set(swigCPtr, value);
    } 
    get {
      bool ret = Box2DPINVOKE.b2WheelJointDef_enableLimit_get(swigCPtr);
      return ret;
    } 
  }

  public float lowerTranslation {
    set {
      Box2DPINVOKE.b2WheelJointDef_lowerTranslation_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2WheelJointDef_lowerTranslation_get(swigCPtr);
      return ret;
    } 
  }

  public float upperTranslation {
    set {
      Box2DPINVOKE.b2WheelJointDef_upperTranslation_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2WheelJointDef_upperTranslation_get(swigCPtr);
      return ret;
    } 
  }

  public bool enableMotor {
    set {
      Box2DPINVOKE.b2WheelJointDef_enableMotor_set(swigCPtr, value);
    } 
    get {
      bool ret = Box2DPINVOKE.b2WheelJointDef_enableMotor_get(swigCPtr);
      return ret;
    } 
  }

  public float maxMotorTorque {
    set {
      Box2DPINVOKE.b2WheelJointDef_maxMotorTorque_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2WheelJointDef_maxMotorTorque_get(swigCPtr);
      return ret;
    } 
  }

  public float motorSpeed {
    set {
      Box2DPINVOKE.b2WheelJointDef_motorSpeed_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2WheelJointDef_motorSpeed_get(swigCPtr);
      return ret;
    } 
  }

  public float stiffness {
    set {
      Box2DPINVOKE.b2WheelJointDef_stiffness_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2WheelJointDef_stiffness_get(swigCPtr);
      return ret;
    } 
  }

  public float damping {
    set {
      Box2DPINVOKE.b2WheelJointDef_damping_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2WheelJointDef_damping_get(swigCPtr);
      return ret;
    } 
  }

}

}
