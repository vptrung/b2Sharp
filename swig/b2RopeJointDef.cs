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

public class b2RopeJointDef : b2JointDef {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal b2RopeJointDef(global::System.IntPtr cPtr, bool cMemoryOwn) : base(Box2DPINVOKE.b2RopeJointDef_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(b2RopeJointDef obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Box2DPINVOKE.delete_b2RopeJointDef(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public b2RopeJointDef() : this(Box2DPINVOKE.new_b2RopeJointDef(), true) {
  }

  public b2Vec2 localAnchorA {
    set {
      Box2DPINVOKE.b2RopeJointDef_localAnchorA_set(swigCPtr, b2Vec2.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = Box2DPINVOKE.b2RopeJointDef_localAnchorA_get(swigCPtr);
      b2Vec2 ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Vec2(cPtr, false);
      return ret;
    } 
  }

  public b2Vec2 localAnchorB {
    set {
      Box2DPINVOKE.b2RopeJointDef_localAnchorB_set(swigCPtr, b2Vec2.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = Box2DPINVOKE.b2RopeJointDef_localAnchorB_get(swigCPtr);
      b2Vec2 ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Vec2(cPtr, false);
      return ret;
    } 
  }

  public float maxLength {
    set {
      Box2DPINVOKE.b2RopeJointDef_maxLength_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2RopeJointDef_maxLength_get(swigCPtr);
      return ret;
    } 
  }

}

}
