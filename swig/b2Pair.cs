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

public class b2Pair : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2Pair(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(b2Pair obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2Pair() {
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
          Box2DPINVOKE.delete_b2Pair(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public int proxyIdA {
    set {
      Box2DPINVOKE.b2Pair_proxyIdA_set(swigCPtr, value);
    } 
    get {
      int ret = Box2DPINVOKE.b2Pair_proxyIdA_get(swigCPtr);
      return ret;
    } 
  }

  public int proxyIdB {
    set {
      Box2DPINVOKE.b2Pair_proxyIdB_set(swigCPtr, value);
    } 
    get {
      int ret = Box2DPINVOKE.b2Pair_proxyIdB_get(swigCPtr);
      return ret;
    } 
  }

  public b2Pair() : this(Box2DPINVOKE.new_b2Pair(), true) {
  }

}

}