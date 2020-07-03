//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Box2DCS {

public class b2WeldJoint : b2Joint {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal b2WeldJoint(global::System.IntPtr cPtr, bool cMemoryOwn) : base(Box2DPINVOKE.b2WeldJoint_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(b2WeldJoint obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Box2DPINVOKE.delete_b2WeldJoint(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public override b2Vec2 GetAnchorA() {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2WeldJoint_GetAnchorA(swigCPtr), true);
    return ret;
  }

  public override b2Vec2 GetAnchorB() {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2WeldJoint_GetAnchorB(swigCPtr), true);
    return ret;
  }

  public override b2Vec2 GetReactionForce(float inv_dt) {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2WeldJoint_GetReactionForce(swigCPtr, inv_dt), true);
    return ret;
  }

  public override float GetReactionTorque(float inv_dt) {
    float ret = Box2DPINVOKE.b2WeldJoint_GetReactionTorque(swigCPtr, inv_dt);
    return ret;
  }

  public b2Vec2 GetLocalAnchorA() {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2WeldJoint_GetLocalAnchorA(swigCPtr), false);
    return ret;
  }

  public b2Vec2 GetLocalAnchorB() {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2WeldJoint_GetLocalAnchorB(swigCPtr), false);
    return ret;
  }

  public float GetReferenceAngle() {
    float ret = Box2DPINVOKE.b2WeldJoint_GetReferenceAngle(swigCPtr);
    return ret;
  }

  public void SetFrequency(float hz) {
    Box2DPINVOKE.b2WeldJoint_SetFrequency(swigCPtr, hz);
  }

  public float GetFrequency() {
    float ret = Box2DPINVOKE.b2WeldJoint_GetFrequency(swigCPtr);
    return ret;
  }

  public void SetDampingRatio(float ratio) {
    Box2DPINVOKE.b2WeldJoint_SetDampingRatio(swigCPtr, ratio);
  }

  public float GetDampingRatio() {
    float ret = Box2DPINVOKE.b2WeldJoint_GetDampingRatio(swigCPtr);
    return ret;
  }

  public override void Dump() {
    Box2DPINVOKE.b2WeldJoint_Dump(swigCPtr);
  }

}

}
