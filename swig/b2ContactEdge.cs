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

public class b2ContactEdge : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2ContactEdge(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(b2ContactEdge obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2ContactEdge() {
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
          Box2DPINVOKE.delete_b2ContactEdge(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public b2Body other {
    set {
      Box2DPINVOKE.b2ContactEdge_other_set(swigCPtr, b2Body.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = Box2DPINVOKE.b2ContactEdge_other_get(swigCPtr);
      b2Body ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Body(cPtr, false);
      return ret;
    } 
  }

  public b2Contact contact {
    set {
      Box2DPINVOKE.b2ContactEdge_contact_set(swigCPtr, b2Contact.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = Box2DPINVOKE.b2ContactEdge_contact_get(swigCPtr);
      b2Contact ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Contact(cPtr, false);
      return ret;
    } 
  }

  public b2ContactEdge prev {
    set {
      Box2DPINVOKE.b2ContactEdge_prev_set(swigCPtr, b2ContactEdge.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = Box2DPINVOKE.b2ContactEdge_prev_get(swigCPtr);
      b2ContactEdge ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2ContactEdge(cPtr, false);
      return ret;
    } 
  }

  public b2ContactEdge next {
    set {
      Box2DPINVOKE.b2ContactEdge_next_set(swigCPtr, b2ContactEdge.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = Box2DPINVOKE.b2ContactEdge_next_get(swigCPtr);
      b2ContactEdge ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2ContactEdge(cPtr, false);
      return ret;
    } 
  }

  public b2ContactEdge() : this(Box2DPINVOKE.new_b2ContactEdge(), true) {
  }

}

}
