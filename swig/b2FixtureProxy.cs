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

public class b2FixtureProxy : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2FixtureProxy(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(b2FixtureProxy obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2FixtureProxy() {
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
          Box2DPINVOKE.delete_b2FixtureProxy(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public b2AABB aabb {
    set {
      Box2DPINVOKE.b2FixtureProxy_aabb_set(swigCPtr, b2AABB.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = Box2DPINVOKE.b2FixtureProxy_aabb_get(swigCPtr);
      b2AABB ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2AABB(cPtr, false);
      return ret;
    } 
  }

  public b2Fixture fixture {
    set {
      Box2DPINVOKE.b2FixtureProxy_fixture_set(swigCPtr, b2Fixture.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = Box2DPINVOKE.b2FixtureProxy_fixture_get(swigCPtr);
      b2Fixture ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2Fixture(cPtr, false);
      return ret;
    } 
  }

  public int childIndex {
    set {
      Box2DPINVOKE.b2FixtureProxy_childIndex_set(swigCPtr, value);
    } 
    get {
      int ret = Box2DPINVOKE.b2FixtureProxy_childIndex_get(swigCPtr);
      return ret;
    } 
  }

  public int proxyId {
    set {
      Box2DPINVOKE.b2FixtureProxy_proxyId_set(swigCPtr, value);
    } 
    get {
      int ret = Box2DPINVOKE.b2FixtureProxy_proxyId_get(swigCPtr);
      return ret;
    } 
  }

  public b2FixtureProxy() : this(Box2DPINVOKE.new_b2FixtureProxy(), true) {
  }

}

}