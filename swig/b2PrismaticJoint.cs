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

public class b2PrismaticJoint : b2Joint {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal b2PrismaticJoint(global::System.IntPtr cPtr, bool cMemoryOwn) : base(Box2DPINVOKE.b2PrismaticJoint_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(b2PrismaticJoint obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Box2DPINVOKE.delete_b2PrismaticJoint(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public override b2Vec2 GetAnchorA() {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2PrismaticJoint_GetAnchorA(swigCPtr), true);
    return ret;
  }

  public override b2Vec2 GetAnchorB() {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2PrismaticJoint_GetAnchorB(swigCPtr), true);
    return ret;
  }

  public override b2Vec2 GetReactionForce(float inv_dt) {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2PrismaticJoint_GetReactionForce(swigCPtr, inv_dt), true);
    return ret;
  }

  public override float GetReactionTorque(float inv_dt) {
    float ret = Box2DPINVOKE.b2PrismaticJoint_GetReactionTorque(swigCPtr, inv_dt);
    return ret;
  }

  public b2Vec2 GetLocalAnchorA() {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2PrismaticJoint_GetLocalAnchorA(swigCPtr), false);
    return ret;
  }

  public b2Vec2 GetLocalAnchorB() {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2PrismaticJoint_GetLocalAnchorB(swigCPtr), false);
    return ret;
  }

  public b2Vec2 GetLocalAxisA() {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2PrismaticJoint_GetLocalAxisA(swigCPtr), false);
    return ret;
  }

  public float GetReferenceAngle() {
    float ret = Box2DPINVOKE.b2PrismaticJoint_GetReferenceAngle(swigCPtr);
    return ret;
  }

  public float GetJointTranslation() {
    float ret = Box2DPINVOKE.b2PrismaticJoint_GetJointTranslation(swigCPtr);
    return ret;
  }

  public float GetJointSpeed() {
    float ret = Box2DPINVOKE.b2PrismaticJoint_GetJointSpeed(swigCPtr);
    return ret;
  }

  public bool IsLimitEnabled() {
    bool ret = Box2DPINVOKE.b2PrismaticJoint_IsLimitEnabled(swigCPtr);
    return ret;
  }

  public void EnableLimit(bool flag) {
    Box2DPINVOKE.b2PrismaticJoint_EnableLimit(swigCPtr, flag);
  }

  public float GetLowerLimit() {
    float ret = Box2DPINVOKE.b2PrismaticJoint_GetLowerLimit(swigCPtr);
    return ret;
  }

  public float GetUpperLimit() {
    float ret = Box2DPINVOKE.b2PrismaticJoint_GetUpperLimit(swigCPtr);
    return ret;
  }

  public void SetLimits(float lower, float upper) {
    Box2DPINVOKE.b2PrismaticJoint_SetLimits(swigCPtr, lower, upper);
  }

  public bool IsMotorEnabled() {
    bool ret = Box2DPINVOKE.b2PrismaticJoint_IsMotorEnabled(swigCPtr);
    return ret;
  }

  public void EnableMotor(bool flag) {
    Box2DPINVOKE.b2PrismaticJoint_EnableMotor(swigCPtr, flag);
  }

  public void SetMotorSpeed(float speed) {
    Box2DPINVOKE.b2PrismaticJoint_SetMotorSpeed(swigCPtr, speed);
  }

  public float GetMotorSpeed() {
    float ret = Box2DPINVOKE.b2PrismaticJoint_GetMotorSpeed(swigCPtr);
    return ret;
  }

  public void SetMaxMotorForce(float force) {
    Box2DPINVOKE.b2PrismaticJoint_SetMaxMotorForce(swigCPtr, force);
  }

  public float GetMaxMotorForce() {
    float ret = Box2DPINVOKE.b2PrismaticJoint_GetMaxMotorForce(swigCPtr);
    return ret;
  }

  public float GetMotorForce(float inv_dt) {
    float ret = Box2DPINVOKE.b2PrismaticJoint_GetMotorForce(swigCPtr, inv_dt);
    return ret;
  }

  public override void Dump() {
    Box2DPINVOKE.b2PrismaticJoint_Dump(swigCPtr);
  }

  public override void Draw(b2Draw draw) {
    Box2DPINVOKE.b2PrismaticJoint_Draw(swigCPtr, b2Draw.getCPtr(draw));
  }

}

}
