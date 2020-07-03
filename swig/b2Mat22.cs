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

public class b2Mat22 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2Mat22(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(b2Mat22 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2Mat22() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Box2DPINVOKE.delete_b2Mat22(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public b2Mat22() : this(Box2DPINVOKE.new_b2Mat22__SWIG_0(), true) {
  }

  public b2Mat22(b2Vec2 c1, b2Vec2 c2) : this(Box2DPINVOKE.new_b2Mat22__SWIG_1(b2Vec2.getCPtr(c1), b2Vec2.getCPtr(c2)), true) {
    if (Box2DPINVOKE.SWIGPendingException.Pending) throw Box2DPINVOKE.SWIGPendingException.Retrieve();
  }

  public b2Mat22(float a11, float a12, float a21, float a22) : this(Box2DPINVOKE.new_b2Mat22__SWIG_2(a11, a12, a21, a22), true) {
  }

  public void Set(b2Vec2 c1, b2Vec2 c2) {
    Box2DPINVOKE.b2Mat22_Set(swigCPtr, b2Vec2.getCPtr(c1), b2Vec2.getCPtr(c2));
    if (Box2DPINVOKE.SWIGPendingException.Pending) throw Box2DPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetIdentity() {
    Box2DPINVOKE.b2Mat22_SetIdentity(swigCPtr);
  }

  public void SetZero() {
    Box2DPINVOKE.b2Mat22_SetZero(swigCPtr);
  }

  public b2Mat22 GetInverse() {
    b2Mat22 ret = new b2Mat22(Box2DPINVOKE.b2Mat22_GetInverse(swigCPtr), true);
    return ret;
  }

  public b2Vec2 Solve(b2Vec2 b) {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2Mat22_Solve(swigCPtr, b2Vec2.getCPtr(b)), true);
    if (Box2DPINVOKE.SWIGPendingException.Pending) throw Box2DPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public b2Vec2 ex {
    set {
      Box2DPINVOKE.b2Mat22_ex_set(swigCPtr, b2Vec2.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = Box2DPINVOKE.b2Mat22_ex_get(swigCPtr);
      b2Vec2 ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Vec2(cPtr, false);
      return ret;
    } 
  }

  public b2Vec2 ey {
    set {
      Box2DPINVOKE.b2Mat22_ey_set(swigCPtr, b2Vec2.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = Box2DPINVOKE.b2Mat22_ey_get(swigCPtr);
      b2Vec2 ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Vec2(cPtr, false);
      return ret;
    } 
  }

}

}
