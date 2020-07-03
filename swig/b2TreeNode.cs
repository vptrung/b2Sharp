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

public class b2TreeNode : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2TreeNode(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(b2TreeNode obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2TreeNode() {
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
          Box2DPINVOKE.delete_b2TreeNode(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public bool IsLeaf() {
    bool ret = Box2DPINVOKE.b2TreeNode_IsLeaf(swigCPtr);
    return ret;
  }

  public b2AABB aabb {
    set {
      Box2DPINVOKE.b2TreeNode_aabb_set(swigCPtr, b2AABB.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = Box2DPINVOKE.b2TreeNode_aabb_get(swigCPtr);
      b2AABB ret = (cPtr == global::System.IntPtr.Zero) ? null : new b2AABB(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_void userData {
    set {
      Box2DPINVOKE.b2TreeNode_userData_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = Box2DPINVOKE.b2TreeNode_userData_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public int parent {
    set {
      Box2DPINVOKE.b2TreeNode_parent_set(swigCPtr, value);
    } 
    get {
      int ret = Box2DPINVOKE.b2TreeNode_parent_get(swigCPtr);
      return ret;
    } 
  }

  public int next {
    set {
      Box2DPINVOKE.b2TreeNode_next_set(swigCPtr, value);
    } 
    get {
      int ret = Box2DPINVOKE.b2TreeNode_next_get(swigCPtr);
      return ret;
    } 
  }

  public int child1 {
    set {
      Box2DPINVOKE.b2TreeNode_child1_set(swigCPtr, value);
    } 
    get {
      int ret = Box2DPINVOKE.b2TreeNode_child1_get(swigCPtr);
      return ret;
    } 
  }

  public int child2 {
    set {
      Box2DPINVOKE.b2TreeNode_child2_set(swigCPtr, value);
    } 
    get {
      int ret = Box2DPINVOKE.b2TreeNode_child2_get(swigCPtr);
      return ret;
    } 
  }

  public int height {
    set {
      Box2DPINVOKE.b2TreeNode_height_set(swigCPtr, value);
    } 
    get {
      int ret = Box2DPINVOKE.b2TreeNode_height_get(swigCPtr);
      return ret;
    } 
  }

  public bool moved {
    set {
      Box2DPINVOKE.b2TreeNode_moved_set(swigCPtr, value);
    } 
    get {
      bool ret = Box2DPINVOKE.b2TreeNode_moved_get(swigCPtr);
      return ret;
    } 
  }

  public b2TreeNode() : this(Box2DPINVOKE.new_b2TreeNode(), true) {
  }

}

}
