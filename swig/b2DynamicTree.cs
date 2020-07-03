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

public class b2DynamicTree : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2DynamicTree(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(b2DynamicTree obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2DynamicTree() {
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
          Box2DPINVOKE.delete_b2DynamicTree(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public b2DynamicTree() : this(Box2DPINVOKE.new_b2DynamicTree(), true) {
  }

  public int CreateProxy(b2AABB aabb, SWIGTYPE_p_void userData) {
    int ret = Box2DPINVOKE.b2DynamicTree_CreateProxy(swigCPtr, b2AABB.getCPtr(aabb), SWIGTYPE_p_void.getCPtr(userData));
    if (Box2DPINVOKE.SWIGPendingException.Pending) throw Box2DPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void DestroyProxy(int proxyId) {
    Box2DPINVOKE.b2DynamicTree_DestroyProxy(swigCPtr, proxyId);
  }

  public bool MoveProxy(int proxyId, b2AABB aabb1, b2Vec2 displacement) {
    bool ret = Box2DPINVOKE.b2DynamicTree_MoveProxy(swigCPtr, proxyId, b2AABB.getCPtr(aabb1), b2Vec2.getCPtr(displacement));
    if (Box2DPINVOKE.SWIGPendingException.Pending) throw Box2DPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_void GetUserData(int proxyId) {
    global::System.IntPtr cPtr = Box2DPINVOKE.b2DynamicTree_GetUserData(swigCPtr, proxyId);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public bool WasMoved(int proxyId) {
    bool ret = Box2DPINVOKE.b2DynamicTree_WasMoved(swigCPtr, proxyId);
    return ret;
  }

  public void ClearMoved(int proxyId) {
    Box2DPINVOKE.b2DynamicTree_ClearMoved(swigCPtr, proxyId);
  }

  public b2AABB GetFatAABB(int proxyId) {
    b2AABB ret = new b2AABB(Box2DPINVOKE.b2DynamicTree_GetFatAABB(swigCPtr, proxyId), false);
    return ret;
  }

  public void Validate() {
    Box2DPINVOKE.b2DynamicTree_Validate(swigCPtr);
  }

  public int GetHeight() {
    int ret = Box2DPINVOKE.b2DynamicTree_GetHeight(swigCPtr);
    return ret;
  }

  public int GetMaxBalance() {
    int ret = Box2DPINVOKE.b2DynamicTree_GetMaxBalance(swigCPtr);
    return ret;
  }

  public float GetAreaRatio() {
    float ret = Box2DPINVOKE.b2DynamicTree_GetAreaRatio(swigCPtr);
    return ret;
  }

  public void RebuildBottomUp() {
    Box2DPINVOKE.b2DynamicTree_RebuildBottomUp(swigCPtr);
  }

  public void ShiftOrigin(b2Vec2 newOrigin) {
    Box2DPINVOKE.b2DynamicTree_ShiftOrigin(swigCPtr, b2Vec2.getCPtr(newOrigin));
    if (Box2DPINVOKE.SWIGPendingException.Pending) throw Box2DPINVOKE.SWIGPendingException.Retrieve();
  }

}

}