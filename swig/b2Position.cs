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

public class b2Position : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2Position(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(b2Position obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2Position() {
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
          Box2DPINVOKE.delete_b2Position(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public b2Vec2 c {
    set {
      Box2DPINVOKE.b2Position_c_set(swigCPtr, b2Vec2.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = Box2DPINVOKE.b2Position_c_get(swigCPtr);
      b2Vec2 ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Vec2(cPtr, false);
      return ret;
    } 
  }

  public float a {
    set {
      Box2DPINVOKE.b2Position_a_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2Position_a_get(swigCPtr);
      return ret;
    } 
  }

  public b2Position() : this(Box2DPINVOKE.new_b2Position(), true) {
  }

}

}
