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

public class b2ContactFeature : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2ContactFeature(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(b2ContactFeature obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2ContactFeature() {
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
          Box2DPINVOKE.delete_b2ContactFeature(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public byte indexA {
    set {
      Box2DPINVOKE.b2ContactFeature_indexA_set(swigCPtr, value);
    } 
    get {
      byte ret = Box2DPINVOKE.b2ContactFeature_indexA_get(swigCPtr);
      return ret;
    } 
  }

  public byte indexB {
    set {
      Box2DPINVOKE.b2ContactFeature_indexB_set(swigCPtr, value);
    } 
    get {
      byte ret = Box2DPINVOKE.b2ContactFeature_indexB_get(swigCPtr);
      return ret;
    } 
  }

  public byte typeA {
    set {
      Box2DPINVOKE.b2ContactFeature_typeA_set(swigCPtr, value);
    } 
    get {
      byte ret = Box2DPINVOKE.b2ContactFeature_typeA_get(swigCPtr);
      return ret;
    } 
  }

  public byte typeB {
    set {
      Box2DPINVOKE.b2ContactFeature_typeB_set(swigCPtr, value);
    } 
    get {
      byte ret = Box2DPINVOKE.b2ContactFeature_typeB_get(swigCPtr);
      return ret;
    } 
  }

  public b2ContactFeature() : this(Box2DPINVOKE.new_b2ContactFeature(), true) {
  }

  public enum Type {
    e_vertex = 0,
    e_face = 1
  }

}

}
