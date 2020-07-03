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

public class b2Sweep : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2Sweep(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(b2Sweep obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2Sweep() {
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
          Box2DPINVOKE.delete_b2Sweep(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public void GetTransform(b2Transform transform, float beta) {
    Box2DPINVOKE.b2Sweep_GetTransform(swigCPtr, b2Transform.getCPtr(transform), beta);
  }

  public void Advance(float alpha) {
    Box2DPINVOKE.b2Sweep_Advance(swigCPtr, alpha);
  }

  public void Normalize() {
    Box2DPINVOKE.b2Sweep_Normalize(swigCPtr);
  }

  public b2Vec2 localCenter {
    set {
      Box2DPINVOKE.b2Sweep_localCenter_set(swigCPtr, b2Vec2.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = Box2DPINVOKE.b2Sweep_localCenter_get(swigCPtr);
      b2Vec2 ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Vec2(cPtr, false);
      return ret;
    } 
  }

  public b2Vec2 c0 {
    set {
      Box2DPINVOKE.b2Sweep_c0_set(swigCPtr, b2Vec2.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = Box2DPINVOKE.b2Sweep_c0_get(swigCPtr);
      b2Vec2 ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Vec2(cPtr, false);
      return ret;
    } 
  }

  public b2Vec2 c {
    set {
      Box2DPINVOKE.b2Sweep_c_set(swigCPtr, b2Vec2.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = Box2DPINVOKE.b2Sweep_c_get(swigCPtr);
      b2Vec2 ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Vec2(cPtr, false);
      return ret;
    } 
  }

  public float a0 {
    set {
      Box2DPINVOKE.b2Sweep_a0_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2Sweep_a0_get(swigCPtr);
      return ret;
    } 
  }

  public float a {
    set {
      Box2DPINVOKE.b2Sweep_a_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2Sweep_a_get(swigCPtr);
      return ret;
    } 
  }

  public float alpha0 {
    set {
      Box2DPINVOKE.b2Sweep_alpha0_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2Sweep_alpha0_get(swigCPtr);
      return ret;
    } 
  }

  public b2Sweep() : this(Box2DPINVOKE.new_b2Sweep(), true) {
  }

}

}
